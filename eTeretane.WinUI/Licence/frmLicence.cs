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

namespace eTeretane.WinUI.Licence
{
    public partial class frmLicence : Form
    {
        private readonly APIServices _licenceService = new APIServices("Licence");
        public frmLicence()
        {
            InitializeComponent();
        }

        private async void frmLicence_Load(object sender, EventArgs e)
        {

            await LoadLicence();
        }

        private async Task LoadLicence()
        {
            var licence = await _licenceService.Get<List<Model.Licenca>>(null);

            licence.Insert(0, new Model.Licenca());
            cmbLicence.DisplayMember = "Tip";
            cmbLicence.ValueMember = "LicencaId";
            cmbLicence.DataSource = licence;

        }

        LicencaUpsertRequest request = new LicencaUpsertRequest();
        private async void btnUrediLicence_Click(object sender, EventArgs e)
        {
            request.Tip = txtNaziv.Text;

            var idLicenca = cmbLicence.SelectedValue;

            if (int.TryParse(idLicenca.ToString(), out int licencaId))
            {
                if(licencaId == 0)
                {
                    await _licenceService.Insert<Model.Licenca>(request);
                    MessageBox.Show("Uspješno ste dodali novu licencu!");

                }
                else
                {
                    await _licenceService.Update<Model.Licenca>(licencaId, request);
                    MessageBox.Show("Uspješno ste izmjenili postojucu licencu!");

                }
            }

            
           
        }
    }
}
