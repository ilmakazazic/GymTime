using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Xamarin.Forms;

namespace eTeretane.Mobile.ViewModels
{
    class TeretaneViewModel : BaseViewModel
    {

        private readonly APIServices _teretanaServices = new APIServices("Teretana");
        private readonly APIServices _clanService = new APIServices("Clan");

        public TeretaneViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Teretane> TeretaneList { get; set; } = new ObservableCollection<Teretane>();
        public ICommand InitCommand { get; set; }

        string _search = string.Empty;
        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }

        public async Task Init()
        {
            TeretanaSearchRequest search = new TeretanaSearchRequest();
            IEnumerable<Teretane> list;
            var clan = await _clanService.GetById<Clanovi>(APIServices.ClanId);
            search.GradId = clan.GradId;
            if (Search != String.Empty)
            {
                search.Naziv = Search;
                list = await _teretanaServices.Get<IEnumerable<Teretane>>(search);
            }
            else
            {
                list = await _teretanaServices.Get<IEnumerable<Teretane>>(search);

            }
            TeretaneList.Clear();
            foreach (var teretane in list)
            {
                TeretaneList.Add(teretane);
            }


        }
    }
}
