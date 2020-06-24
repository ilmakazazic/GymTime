using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningPage : ContentPage
    {
        private readonly APIServices _treningDetaljiServices = new APIServices("TreningDetalji");
        private readonly APIServices _treningZahtjevServices = new APIServices("TreningZahtjev");

        private TreningViewModel model = null;
        public TreningPage(Teretane teretane)
        {
            InitializeComponent();
            BindingContext = model = new TreningViewModel()
            {
                Teretana = teretane
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);

            }
            catch
            {
                await Navigation.PushAsync(new TeretanePage());
            }

            await model.Init();
        }

        private async void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            await model.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Trening;
            TreningDetaljiSearchRequest search = new TreningDetaljiSearchRequest()
            {
                treningId = item.TreningId
            };

            var treninzi  = await _treningDetaljiServices.Get<List<TreningDetalji>>(search);

            if (treninzi.Count() >= item.BrojRezervacija)
            {
              var ans=await DisplayAlert("Broj mjesta popunjen", "Želite li poslati zahtjev za ovaj termin?", "Da", "Ne");
                if (ans == true)
                {
                    TreningZahtjevUpsertRequest unos = new TreningZahtjevUpsertRequest()
                    {
                        ClanId = APIServices.ClanId,
                        TreningId = item.TreningId,
                        Odobren = false
                    };
                   await  _treningZahtjevServices.Insert<Model.TreningZahtjev>(unos);
                    await DisplayAlert("Potvrda", "Uspješno ste poslali zahtjev!", "OK");
                }
            }
            else
            {
                var ans = await DisplayAlert("Potvrda", "Da li želite rezervisati trening?", "Da", "Ne");
                if (ans == true)
                {
                    TreningDetaljiUpsertRequest unos = new TreningDetaljiUpsertRequest()
                    {
                        ClanId = APIServices.ClanId,
                        Otkazan = false,
                        TreningId = item.TreningId
                    };
                    await _treningDetaljiServices.Insert<TreningDetalji>(unos);
                    await DisplayAlert("Obavijest", "Uspješno ste rezervisali trening!", "OK");
                }
            }
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TreningZahtjev(model.Teretana));

        }
    }
}