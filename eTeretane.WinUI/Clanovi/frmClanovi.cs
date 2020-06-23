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
using eTeretane.Model.Requests;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace eTeretane.WinUI.Clanovi
{
    public partial class frmClanovi : Form
    {
        private APIServices _clanService = new APIServices("Clan");
        private readonly APIServices _gradovi = new APIServices("Gradovi");
        private readonly APIServices _TreningDetalji = new APIServices("TreningDetalji");


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

        private async void btnNajposjecenijiTreneri_Click(object sender, EventArgs e)
        {
            var treninzi = await _TreningDetalji.Get<List<Model.TreningDetalji>>(null);
            var clanovi = await _clanService.Get<List<Model.Clanovi>>(null);
            var brojac = 0;

            List<IzvjestajNajlojalnijiClanovi> lista = new List<IzvjestajNajlojalnijiClanovi>();

            foreach (var clan in clanovi)
            {
                foreach (var trening in treninzi)
                {
                    if (trening.ClanId == clan.ClanId)
                    {
                        brojac++;
                    }
                }
                lista.Add(new IzvjestajNajlojalnijiClanovi() { Ime = clan.Ime, Email = clan.Email, KorisnickoIme = clan.KorisnickoIme, Prezime = clan.Prezime, brojRezervacija = brojac});
            }

            lista.OrderBy(c => c.brojRezervacija);

            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = lista;


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
            exportGridToPdf(dgvClanovi, "IzvjestajClanovi");

        }
    }
}
