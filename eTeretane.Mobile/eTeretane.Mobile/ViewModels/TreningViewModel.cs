using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Mobile.Views;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class TreningViewModel : BaseViewModel
    {
        private readonly APIServices _treningServices = new APIServices("Trening");
        private readonly APIServices _treningDetaljiServices = new APIServices("TreningDetalji");

        public TreningViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Trening> TreningList { get; set; } = new ObservableCollection<Trening>();

        public ICommand InitCommand { get; set; }
        public ICommand ZahtjeCommand { get; set; }

        public Teretane Teretana { get; set; }

        public DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }
        public int _korisnikId;
        public int KoriniskId
        {
            get { return _korisnikId; }
            set { SetProperty(ref _korisnikId, value); }
        }


  
        public async Task Init()
        {
            //KoriniskId = APIServices.NalogId;
            var date = _date.Date.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            var list = await _treningServices.GetByDateGym<IEnumerable<Trening>>(date, Teretana.TeretanaId, 0);
         

            var listDetalji = await _treningDetaljiServices.Get<IEnumerable<TreningDetalji>>(null);
            
            TreningList.Clear();
            foreach (var trening in list)
            {
                var i = 0;
                foreach (var detalji in listDetalji)
                {
                    if (trening.TreningId == detalji.TreningId)
                    {
                        i++;
                    }
                }
                
                trening.TrenutnoRezervisanih = i;
                TreningList.Add(trening);
            }
        }

      

    }
}
