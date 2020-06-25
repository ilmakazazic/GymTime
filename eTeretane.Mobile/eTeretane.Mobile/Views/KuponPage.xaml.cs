using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KuponPage : ContentPage
    {
        private readonly APIServices _kuponiService = new APIServices("Kupon");

        private KuponViewModel model = null;
        public KuponPage()
        {
            InitializeComponent();
            BindingContext = model = new KuponViewModel();

        }


        private async void Kuponi_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await model.PopuniKupone();
            }
            catch
            {
                DisplayAlert("Greška", "Niste unijeli sve podatke", "OK");
            }
        }
    }
}