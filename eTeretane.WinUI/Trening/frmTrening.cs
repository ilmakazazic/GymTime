using eTeretane.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTeretane.WinUI.TreningZahtjevi;

namespace eTeretane.WinUI.Trening
{
    public partial class frmTrening : Form
    {

        private readonly APIServices _teretane = new APIServices("Teretana");
        private readonly APIServices _treneri = new APIServices("Korisnici");
        private readonly APIServices _trening = new APIServices("Trening");
        private int? _id = null;
        private string teretanacmb;
        private string trenercmb;
        public frmTrening()
        {
            InitializeComponent();
        }

        private async void frmTrening_Load(object sender, EventArgs e)
        {
            await TreneriLoad();
            await TeretaneLoad();
            if(_id.HasValue)
            {
                poruka.Visible = true;
                cmbTeretane.SelectedIndex = cmbTeretane.FindStringExact(teretanacmb);
                cmbTreneri.SelectedIndex = cmbTreneri.FindStringExact(trenercmb);
                
            }
        }

        private async Task frmLoad()
        {

        }

        private async Task TeretaneLoad()
        {
            var result = await _teretane.Get<List<Model.Teretane>>(null);

            result.Insert(0, new Model.Teretane());
            cmbTeretane.DisplayMember = "Naziv";
            cmbTeretane.ValueMember = "TeretanaId";
            cmbTeretane.DataSource = result;
        }

        private async Task TreneriLoad()
        {
            var result = await _treneri.Get<List<Model.Korisnici>>(null);

         

            result.Insert(0, new Model.Korisnici());
            cmbTreneri.DisplayMember = "ImePrezime";
            cmbTreneri.ValueMember = "KorisnikId";
            cmbTreneri.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var idTeretana = cmbTeretane.SelectedValue;
            var idTrener = cmbTreneri.SelectedValue;
            var datePick = datePicker.Value.Date.ToString("yyyy-MM-dd HH:mm:ss.fffffff");

            var result = await _trening.GetByDateGym<List<Model.Trening>>(datePick, idTeretana, idTrener);

            dgvTreninzi.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvTreninzi.Columns[1].DefaultCellStyle.Format = "HH:mm";
            dgvTreninzi.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvTreninzi.AutoGenerateColumns = false;
            dgvTreninzi.DataSource = result;




        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            TreningUpsertRequest request = new TreningUpsertRequest();

            var idBrRez = numBrRezervacija.Value;

            if (int.TryParse(idBrRez.ToString(), out int BrRezervacijaId))
            {
                request.BrojRezervacija = BrRezervacijaId;
            }

            var idTeretana = cmbTeretane.SelectedValue;
            if(int.TryParse(idTeretana.ToString(), out int TeretanaId))
            {
                request.TeretanaId = TeretanaId;
            }

            var idTrener = cmbTreneri.SelectedValue;
            if(int.TryParse(idTrener.ToString(), out int TrenerId))
            {
                request.KorisnikId = TrenerId;
            }

            

            request.DatumOdrzavanja = datePicker.Value.Date;
            request.PocetakTreninga = dtpOD.Value;
            request.KrajTreninga = dtpDO.Value;

            
            if(_id.HasValue)
            {
                await _trening.Update<Model.Trening>(_id, request);

            }
            else
            {
                await _trening.Insert<Model.Trening>(request);

            }

        }

        private void dgvTreninzi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTreninzi.CurrentRow.Cells[0].Value;
            _id = int.Parse(id.ToString());

            teretanacmb = cmbTeretane.Text;
            trenercmb = cmbTreneri.Text;
            frmTrening_Load(null, EventArgs.Empty);


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

        private void btnZahtjevi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTreningZahtjevi());
        }
    }
}
