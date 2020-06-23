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
using eTeretane.Model.Requests;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace eTeretane.WinUI.Uplate
{
    public partial class frmUplate : Form
    {
        private readonly APIServices _teretaneService = new APIServices("Teretana");
        private readonly APIServices _PlacanjeClanarinaService = new APIServices("PlacanjeClanarine");


        public frmUplate()
        {
            InitializeComponent();
        }

        private void btnDodajKupon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKupon());
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

        private async void frmUplate_Load(object sender, EventArgs e)
        {
            await LoadTeretane();
            var result = await _PlacanjeClanarinaService.Get<List<Model.PlacanjeClanarine>>(null);
            dgvUplate.AutoGenerateColumns = false;
            dgvUplate.DataSource = result;

        }

        public async Task LoadTeretane()
        {
            var result = await _teretaneService.Get<List<Model.Teretane>>(null);

            result.Insert(0, new Model.Teretane());
            cmbPrikazTeretane.DisplayMember = "Naziv";
            cmbPrikazTeretane.ValueMember = "TeretanaId";
            cmbPrikazTeretane.DataSource = result;

        }

        PlacanjeClanarineSearchRequest request = new PlacanjeClanarineSearchRequest();
     

        private async void btnPrikaz_Click_1(object sender, EventArgs e)
        {
            var idTeretana = cmbPrikazTeretane.SelectedValue;

            if (int.TryParse(idTeretana.ToString(), out int teretanaID))
            {
                request.TeretanaId = teretanaID;
            }

            var result = await _PlacanjeClanarinaService.Get<List<Model.PlacanjeClanarine>>(request);
            dgvUplate.AutoGenerateColumns = false;
            dgvUplate.DataSource = result;

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
            exportGridToPdf(dgvUplate, "izvjestajUplate");
        }
    }
}
