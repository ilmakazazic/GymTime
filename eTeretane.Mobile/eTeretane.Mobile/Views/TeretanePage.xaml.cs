using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeretanePage : ContentPage
    {
        private readonly APIServices _PlacanjeclanarineService = new APIServices("PlacanjeClanarine");

        private TeretaneViewModel model = null;
        public TeretanePage()
        {
            InitializeComponent();
            BindingContext = model = new TeretaneViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Teretana = e.SelectedItem as Teretane;
            var clanarina = await _PlacanjeclanarineService.Get<List<PlacanjeClanarine>>(null);

            foreach (var placene in clanarina)
            {
                if (placene.Clanarina.DatumIsteka < DateTime.Now)
                {
                    if (placene.Clanarina.TeretanaId == Teretana.TeretanaId && placene.Clanarina.ClanId== APIServices.ClanId)
                    {
                        await Navigation.PushAsync(new TreningPage(Teretana));
                        return;

                    }
                }
            }
            await Navigation.PushAsync(new PlacanjePage(Teretana));
        }

    }
}