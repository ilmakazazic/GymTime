using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;
using TimePicker = Xamarin.Forms.PlatformConfiguration.iOSSpecific.TimePicker;

namespace eTeretane.Mobile.ViewModels
{
    class ClanarinaViewModel : BaseViewModel
    {
        private readonly APIServices _tipClanarineService = new APIServices("TipClanarine");
        private readonly APIServices _KuponService = new APIServices("Kupon");


        public ClanarinaViewModel()
        {

        }

        Teretane _teretane = new Teretane();
        public Teretane Teretana
        {
            get { return _teretane; }
            set { SetProperty(ref _teretane, value); }
        }

        TipClanarine _tipClanarine = new TipClanarine();
        public TipClanarine TipClanarine
        {
            get { return _tipClanarine; }
            set { SetProperty(ref _tipClanarine, value); }
        }

        private decimal? _cijenaSaPopustom = 0;

        public decimal? CijenaSaPopustom
        {
            get { return _cijenaSaPopustom; }
            set { SetProperty (ref _cijenaSaPopustom, value); }
        }
        KuponPopusti _kupon = new KuponPopusti();
        public KuponPopusti Kupon
        {
            get { return _kupon; }
            set { SetProperty(ref _kupon, value); }
        }

        public ObservableCollection<TipClanarine> TipoviClanarina { get; set; } = new ObservableCollection<TipClanarine>();
        public ObservableCollection<KuponPopusti> Kuponi { get; set; } = new ObservableCollection<KuponPopusti>();

        public async Task PopuniTipoveClanarina()
        {
            var list = await _tipClanarineService.Get<IEnumerable<TipClanarine>>(null);

            TipoviClanarina.Clear();
            foreach (var item in list)
            {
                TipoviClanarina.Add(item);
            }

            
        }

        public async Task PopuniKupone()
        {
            KuponSearchRequest search = new KuponSearchRequest()
            {
                TeretanaId = Teretana.TeretanaId
            };
            var list = await _KuponService.Get<IEnumerable<KuponPopusti>>(search);

            Kuponi.Clear();
            foreach (var item in list)
            {
                if (item.Aktivan == true && item.PocetakDatum < DateTime.Now && item.KrajDatum > DateTime.Now)
                {
                    Kuponi.Add(item);

                }
            }
        }


        public async Task UpdateujCijenu(double cijena)
        {
            CijenaSaPopustom =(decimal) cijena;
        }

        public async Task UpdateujCijenuPopust( int popust)
        {
            var temp =(decimal) TipClanarine.Cijena;
            var M = Math.Round((decimal)temp * (popust / 100m), 2, MidpointRounding.ToEven);
            CijenaSaPopustom = temp - M;
        }
    }
}
