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
    public partial class TeretanePage : ContentPage
    {
        private TeretaneViewModel model = null;
        public TeretanePage()
        {
            InitializeComponent();
            BindingContext = model = new TeretaneViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Teretane;
            await Navigation.PushAsync(new TreningPage(item));
        }
    }
}