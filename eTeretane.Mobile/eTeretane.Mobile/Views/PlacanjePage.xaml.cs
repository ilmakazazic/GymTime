using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Mobile.ViewModels;
using eTeretane.Model;
using eTeretane.Model.Requests;
using Stripe;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTeretane.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class PlacanjePage : ContentPage
    {
        private readonly APIServices _clanService = new APIServices("Clan");
        private readonly APIServices _PlacanjeclanarineService = new APIServices("PlacanjeClanarine");
        private readonly APIServices _KuponService = new APIServices("Kupon");


        private ClanarinaViewModel model = null;
        public PlacanjePage(Teretane teretane)
        {
            InitializeComponent();
            BindingContext = model = new ClanarinaViewModel()
            {
                Teretana = teretane
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PopuniTipoveClanarina();
            await model.PopuniKupone();
        }

        private async void Plati_OnClicked(object sender, EventArgs e)
        {
            StripeConfiguration.SetApiKey("sk_test_51GwRr9KfuyQgAyDyOUzHiF1oewChAjkEf71ntZvZmSfXKnwnSkOX50nI8bhVLUVEpr7nkymSZ8WEoGy262QzyoR000aqsUZgkZ");

            Token stripeToken = null;

            try
            {
                var tokenOprions = new TokenCreateOptions()
                {
                    Card = new CreditCardOptions()
                    {
                        Number = CreditCardNumber.Text,
                        ExpMonth = Convert.ToInt64(CreditCardExpMonth.Text),
                        ExpYear = Convert.ToInt64(CreditCardExpYear.Text),
                        Cvc = CreditCardSecurityCode.Text
                    }
                };


                var tokenService = new TokenService();
                stripeToken = tokenService.Create(tokenOprions);

                var clan = await _clanService.GetById<Model.Clanovi>(APIServices.ClanId);

                var customer = new CustomerCreateOptions
                {
                    Description = "Naplata za kupca",
                    Name = clan.ImePrezime,  //ime kupca koji pravi naplatu, ja sam uzela logiranog, nemam pojma, sta god
                    Source = stripeToken.Id //pošto je ovdje sada isto kao dole source = bla bla
                };
                var customerService = new CustomerService();



                var customerResponse = customerService.Create(customer);

                //var M = model.TipClanarine.Cijena * (model.Kupon.Postotak/100);
                //var amount = model.TipClanarine.Cijena - M;


                // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
                var options = new ChargeCreateOptions
                {
                    Amount = (long)model.CijenaSaPopustom * 100, //5000, //ter.clanarinant * 100 zbog feninga ko kod tebe? yes
                    Currency = "bam",
                    //Source = stripeToken.Id, ukidas ga odavde, zato što token smiješ koristi samo jednom, ali umjesto toga, ovdje pišep
                    Customer = customerResponse.Id,
                    Description = "Nova uplata",
                };
                var service = new ChargeService();
                service.Create(options);


                //to je to haha
                //sada ovdje kad se sve to izvrši praviš narudžbu i sve ostalo, prazniš korpu itd.


                //ovdje ces da popunis PlacanjeClanarina tabelu i onda ces imati podatke koji ti trebaju
                //znaci prosla uplata i tek onda



                PlacanjeClanarineUpsertRequest input = new PlacanjeClanarineUpsertRequest();

                input.BrojKartice = CreditCardNumber.Text;
                input.ExpMonth = Convert.ToInt32(CreditCardExpMonth.Text);
                input.ExpYear = Convert.ToInt32(CreditCardExpYear.Text);
                input.SecurityCode = Convert.ToInt32(CreditCardSecurityCode.Text);
                input.ClanId = APIServices.ClanId;
                input.TeretanaId = model.Teretana.TeretanaId;
                input.TipClanarineId = model.TipClanarine.TipClanarineId;
                input.DatumUplate = DateTime.Now;


                if (model.TipClanarine.Tip == "Godisnja")
                {
                    input.DatumIsteka = input.DatumUplate.AddHours(24);
                }
                else if (model.TipClanarine.Tip == "Mjesecna")
                {
                    input.DatumIsteka = input.DatumUplate.AddDays(30);
                }
                else
                {
                    input.DatumIsteka = input.DatumUplate.AddHours(24);
                }


                await _PlacanjeclanarineService.Insert<PlacanjeClanarine>(input);
                await DisplayAlert("Obavijest", "Uspješno ste uplatili članarinu!", "OK");
                await Navigation.PushAsync(new TreningPage(model.Teretana));


            }
            catch 
            {
                await DisplayAlert("Greška!", "Niste unijeli tačne podatke", "OK");
            }
        }

        private async void TipClanarine_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as Picker;
            if(item == null)
                return;
            var selectedItem = item.SelectedItem as TipClanarine;
            if (selectedItem == null)
            {
               await Navigation.PushAsync(new TeretanePage());

            }
            else
            {
                await model.UpdateujCijenu(selectedItem.Cijena);

            }



            // DisplayAlert(selectedItem.Cijena.ToString(), "OK", "OK");
            //samo da vidim hoce li ga nahvatat


            //sad imas item clanarinu koja je izabrana i u njoj cijenu // ti poslije radi sa njom sta hoces, ne znam
            // kako ti ide sva logika oko toga
            //imas two-way binding izmedju viewmodela i pagea
            //cim promijenis u viewmodel onu cijenu sa popustom ona se updateuje na pageu 
        }

        private async void Kupon_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as Picker;
            if (item == null)
                return;
            var selectedItem = item.SelectedItem as KuponPopusti;

            await model.UpdateujCijenuPopust(selectedItem.Postotak);
        }
    }
}