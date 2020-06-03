using eTeretane.Model.Requests;
using eTeretane.WinUI.Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTeretane.WinUI.Treneri
{
    public partial class frmTreneri : Form
    {
        private APIServices _services = new APIServices("Korisnici");
        private APIServices _UlogeService = new APIServices("Uloge");
        private APIServices _LicenceService = new APIServices("Licence");

        private int? _id = null;
        public frmTreneri(int? KorisnikId = null)
        {
            InitializeComponent();
            _id = KorisnikId;
        }
        private async void frmTreneri_Load(object sender, EventArgs e)
        {

            await Loadfrm();

            var ulogeList = await _UlogeService.Get<List<Model.Uloge>>(null);
            var licenceList = await _LicenceService.Get<List<Model.Licence>>(null);

            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";

            clbLicence.DataSource = licenceList;
            clbLicence.DisplayMember = "Tip";

            if (_id.HasValue)
            {
                var korisnik = await _services.GetById<Model.Korisnici>(_id);

                txtEmail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTel.Text = korisnik.Telefon;

            }
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await Loadfrm();

        }
        private async Task Loadfrm()
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretrazi.Text

            };

            var korisnici = await _services.Get<List<Model.Korisnici>>(search);
     
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = korisnici;

        }
    
        private async void btnSacuvaj_ClickAsync(object sender, EventArgs e)
        {
            var uloge = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();
            var licence = clbLicence.CheckedItems.Cast<Model.Licence>().Select(x => x.LicencaId).ToList();

            var request = new KorisniciUpsertRequest()
            {
                Email = txtEmail.Text,
                Ime = txtIme.Text,
                Username = txtKorisnickoIme.Text,
                Password = txtPass.Text,
                PasswordConfirmation = txtPassConf.Text,
                Prezime = txtPrezime.Text,
                Telefon = txtTel.Text,
                Uloge = uloge,
                Licence = licence,
                 DatumPolaganja = dtpPolaganje.Value,
                 DatumIsteka = dtpIstek.Value,
                
            };

            if (_id.HasValue)
            {
                await _services.Update<Model.Korisnici>(_id, request);
            }
            else
            {
                await _services.Insert<Model.Korisnici>(request);
            }
            MessageBox.Show("Operacija uspjesna!");


        }    

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.CurrentRow.Cells[0].Value;
            _id = int.Parse(id.ToString());
            frmTreneri_Load(null, EventArgs.Empty);

        }


        private Form activForm = null;
        private void openChildForm(Form childForm)
        {
            if (activForm != null)
                activForm.Close();
            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUrediLicence_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLicence());
        }
    }



}
