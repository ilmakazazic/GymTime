using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private readonly APIServices _clanovi = new APIServices("Clan");
        private RegistrationViewModel model = null;
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistrationViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PopuniGradove();
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if (await model.Validacija())
            {
                await DisplayAlert("Greška", "Unesite tražena polja!", "OK");
            }
            else
            {
                ClanUpsertRequest vm = new ClanUpsertRequest();

                vm.PasswordConfirmation = model.confPassword;
                vm.Ime = model.Ime;
                vm.Prezime = model.Prezime;
                vm.GradId = model.Grad.GradId;
                vm.Username = model.Username;
                vm.Password = model.Password;
                vm.Telefon = model.Telefon;


                if (model.Password == model.confPassword)
                {
                    await _clanovi.Insert<Clanovi>(vm); 
                    await Application.Current.MainPage.DisplayAlert("Uspjesna registracija", "Uspjesno ste se registrovali ! Sada se logirajte sa vasim korisnickim informacijama.", "OK");
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Lozinke nisu iste!", "OK");
                }

            }
        }
    }
}