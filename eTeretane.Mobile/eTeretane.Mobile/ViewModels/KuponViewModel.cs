using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Model;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    public class KuponViewModel : BaseViewModel
    {
        private readonly APIServices _kuponiService = new APIServices("Kupon");

        public KuponViewModel()
        {
            InitCommand = new Command(async () => await PopuniKupone());

        }

        DateTime _datumOD = DateTime.Now;
        public DateTime DatumOD
        {
            get { return _datumOD; }
            set { SetProperty(ref _datumOD, value); }
        }


        DateTime _datumDO = DateTime.Now;
        public DateTime DatumDO
        {
            get { return _datumDO; }
            set { SetProperty(ref _datumDO, value); }
        }

        private decimal? _ukupno = 0;

        public decimal? Ukupno
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

        public ICommand InitCommand { get; set; }

        public ObservableCollection<KuponPopusti> NovaLista { get; set; } = new ObservableCollection<KuponPopusti>();

        public async Task PopuniKupone()
        {
            var kuponi = await _kuponiService.Get<IEnumerable<KuponPopusti>>(null);

            NovaLista.Clear();
            foreach (var item in kuponi)
            {
                if (item.PocetakDatum >= DatumOD && item.KrajDatum <= DatumDO)
                {
                    NovaLista.Add(item);
                    Ukupno = Ukupno + item.Postotak;

                }

            }

        }


    }
}
