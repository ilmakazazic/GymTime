using eTeretane.Model.Requests;
using eTeretane.WinUI.Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTeretane.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace eTeretane.WinUI.Treneri
{
    public partial class frmTreneri : Form
    {
        private APIServices _services = new APIServices("Korisnici");
        private APIServices _UlogeService = new APIServices("Uloge");
        private APIServices _LicenceService = new APIServices("Licence");
        private APIServices _treningService = new APIServices("Trening");


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
            var licenceList = await _LicenceService.Get<List<Model.Licenca>>(null);

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
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
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
            var licence = clbLicence.CheckedItems.Cast<Model.Licenca>().Select(x => x.LicencaId).ToList();

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
                
            };

            if (_id.HasValue)
            {
                await _services.Update<Model.Korisnici>(_id, request);
                MessageBox.Show("Uspješno ste izmjenili korisnika!");

            }
            else
            {
                await _services.Insert<Model.Korisnici>(request);
                MessageBox.Show("Uspješno ste dodali korisnika!");

            }


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

        private async void btnNajposjecenijiTreneri_Click(object sender, EventArgs e)
        {
            var treninzi = await _treningService.Get<List<Model.Trening>>(null);
            var treneri = await _services.Get<List<Korisnici>>(null);
            var brojac = 0;

            List<IzvjestajNajposjecenijiTreneri> lista = new List<IzvjestajNajposjecenijiTreneri>();

            foreach (var trener in treneri)
            {
                foreach (var trening in treninzi)
                {
                    if (trening.KorisnikId == trener.KorisnikId)
                    {
                        brojac++;
                    }
                }
                lista.Add(new IzvjestajNajposjecenijiTreneri(){brojRezervacija = brojac, Email = trener.Email, ImePrezime = trener.ImePrezime, KorisnickoIme = trener.KorisnickoIme, Telefon = trener.Telefon});
            }

            lista.OrderBy(c => c.brojRezervacija);

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = lista;

        }


        public void exportGridToPdf(DataGridView dgw, string fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfptable = new PdfPTable(dgw.Columns.Count);

            pdfptable.DefaultCell.Padding = 3;
            pdfptable.WidthPercentage = 100;
            pdfptable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfptable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfptable.AddCell(cell);
            }


            //datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfptable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = fileName;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfptable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }


        private void btnPDF_Click(object sender, EventArgs e)
        {
            exportGridToPdf(dgvKorisnici, "IzvjestajTreneri");

        }
    }



}
