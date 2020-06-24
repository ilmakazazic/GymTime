using eTeretane.Model.Requests;
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
using eTeretane.WinUI.Helper;
using System.Configuration;

namespace eTeretane.WinUI.Teretane
{
    public partial class frmTeretane : Form
    {
        private readonly APIServices _teretane = new APIServices("Teretana");
        private readonly APIServices _gradovi = new APIServices("Gradovi");
        private int? _id = null;
        public frmTeretane(int? TeretanaId = null)
        {
            InitializeComponent();
            _id = TeretanaId;
        }

        private async void frmTeretane_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
               await Loadfrm(_id);
            }
            else
            {
                await Loadfrm();
            }
        }

        private async Task Loadfrm(int? id=null)
        {
            await LoadGradovi();

            var result = await _teretane.Get<List<Model.Teretane>>(null);
            dgvTeretanePrikaz.AutoGenerateColumns = false;
            dgvTeretanePrikaz.Columns[3].DefaultCellStyle.Format = "HH:mm";
            dgvTeretanePrikaz.Columns[4].DefaultCellStyle.Format = "HH:mm";

            dgvTeretanePrikaz.DataSource = result;

            if (id.HasValue)
            {
                var teretana = await _teretane.GetById<Model.Teretane>(_id);

                txtNaziv.Text = teretana.Naziv;
                txtAdresa.Text = teretana.Adresa;
                timePickerOD.Value = teretana.PocetakRadnoVrijeme;
                timePickerDO.Value = teretana.KrajRadnoVrijeme;
                cmbGradovi.SelectedItem = teretana.GradId;

            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = txtPretraga.Text;
            await LoadTeretane(search);
        }

        private async Task LoadTeretane(string naziv)
        {
            var result = await _teretane.Get<List<Model.Teretane>>(new TeretanaSearchRequest()
            {
                Naziv = naziv
            });

            dgvTeretanePrikaz.AutoGenerateColumns = false;
            dgvTeretanePrikaz.DataSource = result;
        }

        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);

            result.Insert(0, new Model.Grad());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;

        }

        TeretanaUpsertRequest request = new TeretanaUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var idGrad = cmbGradovi.SelectedValue;

            if(int.TryParse(idGrad.ToString(), out int gradId))
            {
                request.GradId = gradId;
            }

            //DateTime dtOD = timePickerOD.Value;
            //DateTime dtDO = timePickerDO.Value;
            //TimeSpan OD = new TimeSpan(dtOD.Hour, dtOD.Minute, dtOD.Second);
            //TimeSpan DO = new TimeSpan(dtDO.Hour, dtDO.Minute, dtDO.Second);

            request.Naziv = txtNaziv.Text;
            request.Adresa = txtAdresa.Text;
            request.PocetakRadnoVrijeme = timePickerOD.Value;
            request.KrajRadnoVrijeme = timePickerDO.Value;
            

            if(_id.HasValue)
            {
                await _teretane.Update<Model.Teretane>(_id, request);
                MessageBox.Show("Uspješno ste izmjenili teretanu!");

            }
            else
            {
                await _teretane.Insert<Model.Teretane>(request);
                MessageBox.Show("Uspješno ste dodali teretanu!");

            }
        }

   
        private void btnSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var FileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(FileName);
                txtSlika.Text = file.ToString();
                request.Slika = file;
                txtSlika.Text = FileName;

                Image imagePreview = Image.FromFile(FileName);
                imgPreview.Image = imagePreview;


                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (imagePreview.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(imagePreview, new Size(resizedImgWidth, resizedImgHeight));
                    Image croppedImg = resizedImg;

                    if (resizedImg.Width >= croppedImgWidth && resizedImg.Height >= croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;


                        croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));


                        ImageConverter imgCon = new ImageConverter();
                        request.SlikaThumb = (byte[])imgCon.ConvertTo(croppedImg, typeof(byte[]));

                    }
                }

            }
        }

  
        private void dgvTeretanePrikaz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTeretanePrikaz.CurrentRow.Cells[0].Value;
            _id = int.Parse(id.ToString());
            frmTeretane_Load(null, EventArgs.Empty);

        }
    }
}
