using eTeretane.WinUI.Teretane;
using eTeretane.WinUI.Treneri;
using eTeretane.WinUI.Trening;
using eTeretane.WinUI.Uplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTeretane.WinUI
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {

        }

        private void navTeretane_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTeretane());

        }

        private void navPocetna_Click(object sender, EventArgs e)
        {
            if (activForm != null)
                activForm.Close();
        }

        private void navTermini_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTrening());

        }

        private void navTreneri_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTreneri());

        }

        private void navUplate_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUplate());

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

    
    }
}
