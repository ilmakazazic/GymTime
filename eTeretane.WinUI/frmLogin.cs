﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTeretane.Model;

namespace eTeretane.WinUI
{
    public partial class frmLogin : Form
    {
        APIServices _service = new APIServices("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIServices.Username = txtUsername.Text;
                APIServices.Password = txtPass.Text;

                var list = await _service.Get<List<Korisnici>>(null);
                foreach (var korisnici in list)
                {
                    if (korisnici.KorisnickiNalog.Username == APIServices.Username)
                    {
                        APIServices.KorisnikId = korisnici.KorisnikId;
                    }
                }

                if (APIServices.KorisnikId == 0)
                {
                    MessageBox.Show("Pogrešan username ili password!", "Greška!", MessageBoxButtons.OK);

                }
                else
                {
                    this.Hide();
                    frmIndex frm = new frmIndex();
                    frm.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
