using eTeretane.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTeretane.WinUI.Uplate
{
    public partial class frmKupon : Form
    {
        private readonly APIServices _teretaneService = new APIServices("Teretana");
        private readonly APIServices _kuponService = new APIServices("Kupon");

        private int? _id = null;
        public frmKupon()
        {
            InitializeComponent();
        }

        private async void frmKupon_Load(object sender, EventArgs e)
        {
            await LoadTeretane();

            if(_id.HasValue)
            {
                var kupon = await _kuponService.GetById<Model.KuponPopusti>(_id);

                txtKuponKod.Text = kupon.KuponKod;
                numBrKoristenja.Value = (decimal)kupon.Broj_Koristenja;
                numPostotak.Value = (decimal)kupon.Postotak;
                dtpPocetak.Value = kupon.PocetakDatum;
                dtpKraj.Value = kupon.KrajDatum;
                cmbDodajTeretane.SelectedItem = kupon.TeretanaId;

            }
        }

        public async Task LoadTeretane()
        {
            var result = await _teretaneService.Get<List<Model.Teretane>>(null);

            result.Insert(0, new Model.Teretane());
            cmbPrikazTeretane.DisplayMember = "Naziv";
            cmbPrikazTeretane.ValueMember = "TeretanaId";
            cmbPrikazTeretane.DataSource = result;
            

            cmbDodajTeretane.DisplayMember = "Naziv";
            cmbDodajTeretane.ValueMember = "TeretanaId";
            cmbDodajTeretane.DataSource = result;
        }

        KuponSearchRequest request = new KuponSearchRequest();
        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            var idTeretana = cmbPrikazTeretane.SelectedValue;

            if(int.TryParse(idTeretana.ToString(), out int teretanaID))
            {
                request.TeretanaId = teretanaID;
            }

            var result = await _kuponService.Get<List<Model.KuponPopusti>>(request);
            dgvKuponiPrikaz.AutoGenerateColumns = false;
            dgvKuponiPrikaz.DataSource = result;
        }

        KuponUpsertRequest saveRequst = new KuponUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var idTeretana = cmbDodajTeretane.SelectedValue;

            if (int.TryParse(idTeretana.ToString(), out int teretanaID))
            {
                saveRequst.TeretanaId = teretanaID;
            }

            saveRequst.Aktivan = true;
            saveRequst.Broj_Koristenja =(int)numBrKoristenja.Value;
            saveRequst.Postotak = (int)numPostotak.Value;
            saveRequst.PocetakDatum = dtpPocetak.Value.Date;
            saveRequst.KrajDatum = dtpKraj.Value.Date;
        
            saveRequst.KuponKod = txtKuponKod.Text.ToUpper();

            if(_id.HasValue)
            {
                await _kuponService.Update<Model.KuponPopusti>(_id, saveRequst);
                MessageBox.Show("Uspješno ste dodali kupon!");
            }
            else
            {
                await _kuponService.Insert<Model.KuponPopusti>(saveRequst);
                MessageBox.Show("Uspješno ste izmjenili kupon!");
            }

        }

        private void dgvKuponiPrikaz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKuponiPrikaz.CurrentRow.Cells[0].Value;
            _id = int.Parse(id.ToString());
            frmKupon_Load(null, EventArgs.Empty);

        }
    }
}
