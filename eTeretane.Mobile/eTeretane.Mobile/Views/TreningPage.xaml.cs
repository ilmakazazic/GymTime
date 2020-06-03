using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningPage : ContentPage
    {
        private TreningViewModel model = null;
        public TreningPage(Teretane teretane)
        {
            InitializeComponent();
            BindingContext = model = new TreningViewModel()
            {
                Teretana = teretane
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            await model.Init();
        }
    }
}