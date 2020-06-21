using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTeretane.Model;
using eTeretane.Model.Requests;

namespace eTeretane.WinUI.TreningZahtjevi
{
    public partial class frmTreningZahtjevi : Form
    {
        private APIServices _treningZahtjevServices = new APIServices("TreningZahtjev");
        private APIServices _treningDodatniServices = new APIServices("TreningDodatni");
        private APIServices _treningServices = new APIServices("Trening");

        public frmTreningZahtjevi()
        {
            InitializeComponent();

        }

        private async void frmTreningZahtjevi_Load(object sender, EventArgs e)
        {
            await Loadfrm();
        }

        private async Task Loadfrm(bool? odobreni = false)
        {
            TreningZahtjevSearchRequest odobren = new TreningZahtjevSearchRequest();
            TreningDodatniSearchRequest prihvacen = new TreningDodatniSearchRequest();

            if (odobreni == true)
            {
                odobren = new TreningZahtjevSearchRequest()
                {
                    odobren = true
                };
                prihvacen = new TreningDodatniSearchRequest()
                {
                    Prihvacen = true
                };


            }

            var zahtjevi = await _treningZahtjevServices.Get<List<Model.TreningZahtjev>>(odobren);
            var dodatni = await _treningDodatniServices.Get<List<Model.TreningDodatni>>(prihvacen);

            dgvTreningZhatjev.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvTreningZhatjev.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvTreningZhatjev.Columns[3].DefaultCellStyle.Format = "HH:mm";

            for (int n = 0; n < dgvTreningZhatjev.ColumnCount - 1; n++)
            {
                dgvTreningZhatjev.Columns[n].ReadOnly = true;
            }

            dgvTreningZhatjev.AutoGenerateColumns = false;
            dgvTreningZhatjev.DataSource = zahtjevi;


            dgvTreningDodatni.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvTreningDodatni.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgvTreningDodatni.Columns[1].DefaultCellStyle.Format = "HH:mm";

            for (int i = 0; i < dgvTreningDodatni.ColumnCount - 1; i++)
            {
                dgvTreningDodatni.Columns[i].ReadOnly = true;
            }
            dgvTreningDodatni.Columns["brojRezervacija"].ReadOnly = false;

            dgvTreningDodatni.AutoGenerateColumns = false;
            dgvTreningDodatni.DataSource = dodatni;

        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = txtPretraziZahtjev.Text;
            await LoadZahtjevi(search);
        }

        private async Task LoadZahtjevi(string search)
        {
            var result = await _treningZahtjevServices.Get<List<Model.TreningZahtjev>>(new TreningZahtjevSearchRequest()
            {
                Naziv = search
            });

            dgvTreningZhatjev.AutoGenerateColumns = false;
            dgvTreningZhatjev.DataSource = result;

        }

        private async void btnPretraziDodatni_Click(object sender, EventArgs e)
        {
            var search = txtPretraziDodatni.Text;
            await LoadDodatni(search);

        }

        private async Task LoadDodatni(string search)
        {
            var result = await _treningDodatniServices.Get<List<Model.TreningDodatni>>(new TreningDodatniSearchRequest()
            {
                Naziv = search
            });

            dgvTreningDodatni.AutoGenerateColumns = false;
            dgvTreningDodatni.DataSource = result;

        }

        private async void btnSacuvajZahtjev_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvTreningZhatjev.Rows)
                {
                    DataGridViewCheckBoxCell cell =
                        row.Cells[dgvTreningZhatjev.ColumnCount - 1] as DataGridViewCheckBoxCell;

                    //Provjera da li je upisan broj rezervacija
                    if (cell.Value != null)
                    {
                        if (Convert.ToString(cell.Value) == (string) cell.TrueValue)
                        {
                            int _idZahtjev = (int) row.Cells[0].Value;
                            int _idTrening = (int) row.Cells["TreningId"].Value;

                            TreningZahtjevUpsertRequest noviZahtjev = new TreningZahtjevUpsertRequest()
                            {
                                ClanId = (int) row.Cells["ClanIdZahtjev"].Value,
                                TreningId = (int) row.Cells["TreningId"].Value,
                                Odobren = true
                            };

                            await _treningZahtjevServices.Update<TreningZahtjev>(_idZahtjev, noviZahtjev);

                            var trening = await _treningServices.GetById<Model.Trening>(_idTrening);

                            TreningUpsertRequest updateTrening = new TreningUpsertRequest()
                            {
                                BrojRezervacija = trening.BrojRezervacija + 1,
                                DatumOdrzavanja = trening.DatumOdrzavanja,
                                KorisnikId = trening.KorisnikId,
                                KrajTreninga = trening.KrajTreninga,
                                PocetakTreninga = trening.PocetakTreninga,
                                TeretanaId = trening.TeretanaId

                            };

                            await _treningServices.Update<Model.Trening>(_idTrening, updateTrening);

                            TreningDetaljiUpsertRequest noviTrDetalji = new TreningDetaljiUpsertRequest()
                            {
                                ClanId = noviZahtjev.ClanId,
                                Otkazan = false,
                                TreningId = _idTrening
                            };

                            MessageBox.Show("Uspješno ste prihvatili zahtjev");
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("Greška, pokušajte ponovo");
                throw;
            }

        }

        private async void btnOdobreni_Click(object sender, EventArgs e)
        {
            await Loadfrm(true);
        }

        private async void btnSacuvajDodatni_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTreningDodatni.Rows)
            {
                DataGridViewCheckBoxCell
                    cell = row.Cells[dgvTreningDodatni.ColumnCount - 1] as DataGridViewCheckBoxCell;

                //Provjera da li je upisan broj rezervacija
                if (cell.Value != null)
                {
                    if (Convert.ToString(cell.Value) == (string) cell.TrueValue)
                    {
                        if (row.Cells["brojRezervacija"].Value != null)
                        {
                            int _idDodatni = (int)row.Cells[0].Value;
                            var dodatniZahtjev = await _treningDodatniServices.GetById<TreningDodatni>(_idDodatni);

                            dodatniZahtjev.Prihvacen = true;

                            await _treningDodatniServices.Update<TreningDodatni>(_idDodatni, dodatniZahtjev);

                            TreningUpsertRequest noviTrening = new TreningUpsertRequest();

                            if (int.TryParse(row.Cells["brojRezervacija"].Value.ToString(), out int rezId))
                            {
                                noviTrening.BrojRezervacija = rezId;
                            }


                            noviTrening.DatumOdrzavanja = dodatniZahtjev.DatumOdrzavanja.Date;
                            noviTrening.PocetakTreninga = dodatniZahtjev.PocetakTreninga;
                            noviTrening.KrajTreninga = dodatniZahtjev.KrajTreninga;
                            noviTrening.TeretanaId = dodatniZahtjev.TeretanaId;
                            noviTrening.KorisnikId = dodatniZahtjev.KorisnikId;

                            await _treningServices.Insert<Model.Trening>(noviTrening);

                            MessageBox.Show("Novi trening je uspjesno dodan!");

                        }
                        else
                        {
                            MessageBox.Show("Unesite rezervacije!");
                        }
                       
                           
                     
                    }
                }
            }
        }
    }
}
