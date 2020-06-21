using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTeretane.Model.Requests;

namespace eTeretane.WinUI.Clanovi
{
    public partial class frmClanovi : Form
    {
        private APIServices _clanService = new APIServices("Clan");
        private readonly APIServices _gradovi = new APIServices("Gradovi");

        private int? _id = null;

        public frmClanovi(int? ClanId = null)
        {
            InitializeComponent();
            _id = ClanId;
        }

        private async void frmClanovi_Load(object sender, EventArgs e)
        {
            await Loadfrm();
            await LoadGradovi();

            if (_id.HasValue)
            {
                var clan = await _clanService.GetById<Model.Clanovi>(_id);

                txtEmail.Text = clan.Email;
                txtIme.Text = clan.Ime;
                txtPrezime.Text = clan.Prezime;
                txtEmail.Text = clan.Email;
                txtKorisnickoIme.Text = clan.KorisnickoIme;
            }

        }

        private async Task Loadfrm()
        {
            var search = new ClanSearchRequest()
            {
                Ime = txtPretrazi.Text

            };

            var clanovi = await _clanService.Get<List<Model.Clanovi>>(search);
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = clanovi;



        }

        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);

            result.Insert(0, new Model.Grad());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;

        }



        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await Loadfrm();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
           

            var request = new ClanUpsertRequest()
            {
                Email = txtEmail.Text,
                Ime = txtIme.Text,
                Username = txtKorisnickoIme.Text,
                Password = txtPass.Text,
                PasswordConfirmation = txtPassConf.Text,
                Prezime = txtPrezime.Text


            };


            var idGrad = cmbGradovi.SelectedValue;

            if (int.TryParse(idGrad.ToString(), out int gradId))
            {
                request.GradId = gradId;
            }


            if (_id.HasValue)
            {
                await _clanService.Update<Model.Clanovi>(_id, request);
                MessageBox.Show("Uspješno ste izmjenili člana!");

            }
            else
            {
                await _clanService.Insert<Model.Clanovi>(request);
                MessageBox.Show("Uspješno ste dodali člana!");

            }

        }

        private void dgvClanovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvClanovi.CurrentRow.Cells[0].Value;
            _id = int.Parse(id.ToString());
            frmClanovi_Load(null, EventArgs.Empty);
        }
    }
}
