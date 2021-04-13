using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class PrisustvaViewModel : BaseViewModel
    {
        private readonly APIServices _treningDetaljiServices = new APIServices("TreningDetalji");
        private readonly APIServices _treningServices = new APIServices("Trening");
        public PrisustvaViewModel()
        {
            InitCommand = new Command(async ()=>await Init());
        }

        public ObservableCollection<Trening> TreningDetaljiList { get; set; } = new ObservableCollection<Trening>();
        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            TreningDetaljiSearchRequest search = new TreningDetaljiSearchRequest();
            search.clanId = APIServices.ClanId;
            var TreningDetalji = await _treningDetaljiServices.Get<IEnumerable<TreningDetalji>>(search);
            TreningDetaljiList.Clear();
            foreach (var trening in TreningDetalji)
            {
                var tr = await _treningServices.GetById<Trening>(trening.TreningId);
                TreningDetaljiList.Add(tr);
            }
        }
    }
}
