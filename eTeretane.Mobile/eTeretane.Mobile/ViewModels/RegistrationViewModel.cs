using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Mobile.Views;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class RegistrationViewModel : BaseViewModel
    {

        private readonly APIServices _clanovi = new APIServices("Clan");
        private readonly APIServices _gradovi = new APIServices("Gradovi");


        public RegistrationViewModel()
        {
            Title = "Registracija";
            InitCommand = new Command(async () => await PopuniGradove());
        }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _confPassword = string.Empty;
        public string confPassword
        {
            get { return _confPassword; }
            set { SetProperty(ref _confPassword, value); }
        }

        Grad _grad = new Grad();
        public Grad Grad
        {
            get { return _grad; }
            set { SetProperty(ref _grad, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }



        string _imeError = string.Empty;
        string _prezimeError = string.Empty;
        string _usernameError = string.Empty;
        string _passError = string.Empty;
        string _confpassError = string.Empty;
        string _gradError = string.Empty;
        string _telefonError = string.Empty;



        public string ImeError
        {
            get { return _imeError; }
            set { SetProperty(ref _imeError, value); }
        }

        public string PrezimeError
        {
            get { return _prezimeError; }
            set { SetProperty(ref _prezimeError, value); }
        }

        public string GradError
        {
            get { return _gradError; }
            set { SetProperty(ref _gradError, value); }
        }

        public string UsernameError
        {
            get { return _usernameError; }
            set { SetProperty(ref _usernameError, value); }
        }
        public string PassError
        {
            get { return _passError; }
            set { SetProperty(ref _passError, value); }
        }
        public string confPassError
        {
            get { return _confpassError; }
            set { SetProperty(ref _confpassError, value); }
        }

        public string TelError
        {
            get { return _telefonError; }
            set { SetProperty(ref _telefonError, value); }
        }


        bool _visibleIme = false;
        bool _visiblePrezime = false;
        bool _visibleUsername = false;
        bool _visiblePass = false;
        bool _visibleconfPass = false;
        bool _visibleGrad = false;
        bool _visibleTelefon = false;


        public bool VisibleIme
        {
            get { return _visibleIme; }
            set { SetProperty(ref _visibleIme, value); }
        }
        public bool VisiblePrezime
        {
            get { return _visiblePrezime; }
            set { SetProperty(ref _visiblePrezime, value); }
        }
        public bool VisibleGrad
        {
            get { return _visibleGrad; }
            set { SetProperty(ref _visibleGrad, value); }
        }
        public bool VisibleUsername
        {
            get { return _visibleUsername; }
            set { SetProperty(ref _visibleUsername, value); }
        }
        public bool VisiblePass
        {
            get { return _visiblePass; }
            set { SetProperty(ref _visiblePass, value); }
        }
        public bool VisibleconfPass
        {
            get { return _visibleconfPass; }
            set { SetProperty(ref _visibleconfPass, value); }
        }
        public bool VisibleTel
        {
            get { return _visibleTelefon; }
            set { SetProperty(ref _visibleTelefon, value); }
        }

        public ICommand InitCommand { get; set; }


        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        public async Task PopuniGradove()
        {
            var list = await _gradovi.Get<IEnumerable<Grad>>(null);

            GradoviList.Clear();
            foreach (var item in list)
            {
                GradoviList.Add(item);
            }

        }


        public async Task<bool> Validacija()
        {

            if (Ime == string.Empty)
            {
                ImeError = "Ime je obavezno!";
                VisibleIme = true;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Ime.Length < 2)
            {
                ImeError = "Ime mora sadržavati barem 4 karaktera!";
                VisibleIme = true;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;


                return true;
            }
            else if (Ime.Any(char.IsDigit))
            {
                ImeError = "Ime ne smije sadržavati brojeve!";
                VisibleIme = true;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;


                return true;
            }

            else if (Prezime == string.Empty)
            {
                PrezimeError = "Prezime je obavezno!";
                VisibleIme = false;
                VisiblePrezime = true;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Prezime.Length < 4)
            {
                PrezimeError = "Prezime mora sadržavati barem 4 karaktera!";
                VisibleIme = false;
                VisiblePrezime = true;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Prezime.Any(char.IsDigit))
            {
                PrezimeError = "Prezime ne smije sadržavati brojeve!";
                VisibleIme = false;
                VisiblePrezime = true;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Grad == null)
            {
                GradError = "Grad je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = true;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Username == string.Empty)
            {
                UsernameError = "Korisničko ime je obavezno!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = true;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Username.Length < 4)
            {
                UsernameError = "Korisničko ime mora sadržavati barem 4 karaktera!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = true;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            if (Username.Length >= 4)
            {
                var lista = await _clanovi.Get<List<Model.Clanovi>>(null);
                foreach (var item in lista)
                {
                    if (Username == item.KorisnickoIme)
                    {
                        UsernameError = "Korisničko ime zauzeto, odaberite drugo!";
                        VisibleIme = false;
                        VisiblePrezime = false;
                        VisibleGrad = false;
                        VisibleUsername = true;
                        VisiblePass = false;
                        VisibleconfPass = false;
                        VisibleTel = false;

                        return true;
                    }
                }
            }

            if (Password == string.Empty)
            {
                PassError = "Lozinka je obavezna!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = true;
                VisibleconfPass = false;
                VisibleTel = false;

                return true;
            }
            else if (Password.Length < 6)
            {
                PassError = "Lozinka mora sadržavati barem 6 karatera!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = true;
                VisibleconfPass = false;
                VisibleTel = false;
                return true;
            }
            else if (confPassword == string.Empty)
            {
                confPassError = "Potvrda lozinke je obavezna!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = true;
                VisibleconfPass = true;
                VisibleTel = false;
                return true;
            }

            if (Telefon == string.Empty)
            {
                TelError = "Telefon je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = true;
                VisibleTel = true;
                return true;
            }
            else if (Telefon.Any(char.IsLetter))
            {
                TelError = "Telefon ne može sadržavati slova!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = true;
                return true;
            }
            else if (Telefon.Length < 9)
            {
                TelError = "Telefon mora sadržavati minimalno 9 brojeva!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = true;
                return true;
            }
            if (Telefon == string.Empty)
            {
                TelError = "Telefon je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = true;
                return true;
            }
            else if (Telefon.Any(char.IsLetter))
            {
                TelError = "Telefon ne može sadržavati slova!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = true;
                return true;
            }
            else if (Telefon.Length < 9)
            {
                TelError = "Telefon mora sadržavati minimalno 9 brojeva!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleGrad = false;
                VisibleUsername = false;
                VisiblePass = false;
                VisibleconfPass = false;
                VisibleTel = true;
                return true;
            }

            return false;
        }
    }
}
