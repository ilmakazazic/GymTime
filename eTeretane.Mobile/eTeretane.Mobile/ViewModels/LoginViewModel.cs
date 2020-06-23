using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Mobile.Views;
using eTeretane.Model;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class LoginViewModel : BaseViewModel
    {

        string _username = string.Empty;
        string _password = string.Empty;
        string _userError = string.Empty;
        string _passError = string.Empty;
        bool _visible = false;
        bool _visiblePass = false;


        private readonly APIServices _clanServices = new APIServices("Clan");
        private readonly APIServices _korisnickiNalog = new APIServices("KorisnickiNalog");

        public LoginViewModel()
        {

            LoginCommand = new Command(async () => await Login());

        }


        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public string UserError
        {
            get { return _userError; }
            set { SetProperty(ref _userError, value); }
        }
        public string PassError
        {
            get { return _passError; }
            set { SetProperty(ref _passError, value); }
        }

        public bool VisibleKors
        {
            get { return _visible; }
            set { SetProperty(ref _visible, value); }
        }
        public bool VisiblePass
        {
            get { return _visiblePass; }
            set { SetProperty(ref _visiblePass, value); }
        }
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            if (await Validacija())
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite tražena polja!", "OK");
            }
            else
            {
                IsBusy = true;
                APIServices.Username = Username;
                APIServices.Password = Password;

                try
                {
                    var allUsers = await _clanServices.Get<List<Model.Clanovi>>(null);
                    foreach (var u in allUsers)
                    {

                        if (u.KorisnickiNalog.Username == Username)
                        {

                            APIServices.NalogId = u.KorisnickiNalogId;
                            APIServices.ClanId = u.ClanId;
                        }
                    }

                    Application.Current.MainPage = new MainPage();
                }
                catch
                {

                    await Application.Current.MainPage.DisplayAlert("Greška!", "Niste unijeli tacnu lozinku ili username", "OK");
                }


            }

        }

        public async Task<bool> Validacija()
        {
            if (Username == string.Empty)
            {
                UserError = "Unesite korisnicko ime!";
                VisibleKors = true;
                VisiblePass = false;
                return true;
            }
            else if (Password == string.Empty)
            {
                PassError = "Unesite password!";
                VisiblePass = true;
                VisibleKors = false;
                return true;
            }

            return false;
        }
    }
}
