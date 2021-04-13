using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Model;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class TreningZahtjevViewModel : BaseViewModel
    {
        private readonly APIServices _korisnici = new APIServices("Korisnici");

        public TreningZahtjevViewModel()
        {
            InitCommand = new Command(async () => await PopuniKorisnike());

        }

        Teretane _teretane = new Teretane();
        public Teretane Teretana
        {
            get { return _teretane; }
            set { SetProperty(ref _teretane, value); }
        }

        Korisnici _korisnik = new Korisnici();
        public Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        DateTime _datum = DateTime.Now;
        public  DateTime Datum
        {
           get { return _datum; }
           set { SetProperty(ref _datum, value); }
        }

        private TimeSpan _timePocetak;
        public TimeSpan PocetakTime
        {
           get { return _timePocetak; }
           set { SetProperty(ref _timePocetak, value); }
        }

        private TimeSpan _timeKraj;
        public TimeSpan KrajTime
        {
            get { return _timeKraj; }
            set { SetProperty(ref _timeKraj, value); }
        }

        public ICommand InitCommand { get; set; }
        public ObservableCollection<Korisnici> KorisniciList { get; set; } = new ObservableCollection<Korisnici>();

        public async Task PopuniKorisnike()
        {
            var list = await _korisnici.Get<IEnumerable<Korisnici>>(null);
            KorisniciList.Clear();
            foreach (var item in list)
            {
                KorisniciList.Add(item);
            }
        }
    }
}
