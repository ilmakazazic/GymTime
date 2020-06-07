using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningZahtjev : ContentPage
    {
        private TreningZahtjevViewModel model = null;
        private readonly APIServices _treningServices = new APIServices("Trening");
        private readonly APIServices _treningDodatniServices = new APIServices("TreningDodatni");

        public TreningZahtjev(Teretane teretane)
        {
            InitializeComponent();
            BindingContext = model = new TreningZahtjevViewModel()
            {
                Teretana = teretane
            };

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PopuniKorisnike();
        }

        private async void ZahtjevSlanje_OnClicked(object sender, EventArgs e)
        {
            var TreningList = await _treningServices.Get<List<Trening>>(null);

            try
            {
                var postoji = false;
                foreach (var trening in TreningList)
                {
                    if (trening.DatumOdrzavanja.Date.Equals(model.Datum.Date)
                        && trening.PocetakTreninga.Hour.Equals(model.PocetakTime.Hours)
                        && trening.PocetakTreninga.Minute.Equals(model.PocetakTime.Minutes)
                        && trening.KrajTreninga.Hour.Equals(model.KrajTime.Hours)
                        && trening.KrajTreninga.Minute.Equals(model.KrajTime.Minutes))

                    {

                        await DisplayAlert("Termin postoji", "Provjerite da li termin vec ima u ponudi", "OK");
                        postoji = true;
                    }
                    
                }
                if (postoji == false)
                {
                    var pocetak = model.PocetakTime.ToString();
                    var kraj = model.KrajTime.ToString();
                    TreningDodatniUpsertRequest input = new TreningDodatniUpsertRequest()
                    {
                        ClanId = APIServices.ClanId,
                        KorisnikId = model.Korisnik.KorisnikId,
                        TeretanaId = model.Teretana.TeretanaId,
                        DatumOdrzavanja = model.Datum.Date,
                        PocetakTreninga = DateTime.ParseExact(pocetak, "HH:mm:ss", null),
                        KrajTreninga = DateTime.ParseExact(kraj, "HH:mm:ss", null),
                        Prihvacen = false
                    };
                    await _treningDodatniServices.Insert<TreningDodatni>(input);
                    await DisplayAlert("Potvrda", "Poslali ste zahtjev za dodatni termin", "OK");
                }

            }
            catch
            {

                await DisplayAlert("Greška", "Došlo je do greške. Pokušajte ponovo", "OK");
            }

        }
    }
}