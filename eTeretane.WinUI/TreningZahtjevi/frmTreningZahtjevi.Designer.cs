namespace eTeretane.WinUI.TreningZahtjevi
{
    partial class frmTreningZahtjevi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvajZahtjev = new System.Windows.Forms.Button();
            this.btnSacuvajDodatni = new System.Windows.Forms.Button();
            this.dgvTreningZhatjev = new System.Windows.Forms.DataGridView();
            this.dgvTreningDodatni = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPretraziDodatni = new System.Windows.Forms.Button();
            this.txtPretraziZahtjev = new System.Windows.Forms.TextBox();
            this.txtPretraziDodatni = new System.Windows.Forms.TextBox();
            this.btnOdobreni = new System.Windows.Forms.Button();
            this.TreningZahtjevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeretanaIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClanIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakTreninga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClanIdZahtjev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeretanaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobren = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClanNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeretanaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvacen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningZhatjev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningDodatni)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(780, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Zahtjevi za veci broj rezervacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Zahtjevi za dodatni termin:";
            // 
            // btnSacuvajZahtjev
            // 
            this.btnSacuvajZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvajZahtjev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvajZahtjev.Location = new System.Drawing.Point(1012, 204);
            this.btnSacuvajZahtjev.Name = "btnSacuvajZahtjev";
            this.btnSacuvajZahtjev.Size = new System.Drawing.Size(122, 32);
            this.btnSacuvajZahtjev.TabIndex = 38;
            this.btnSacuvajZahtjev.Text = "Sacuvaj";
            this.btnSacuvajZahtjev.UseVisualStyleBackColor = false;
            this.btnSacuvajZahtjev.Click += new System.EventHandler(this.btnSacuvajZahtjev_Click);
            // 
            // btnSacuvajDodatni
            // 
            this.btnSacuvajDodatni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvajDodatni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvajDodatni.Location = new System.Drawing.Point(1012, 493);
            this.btnSacuvajDodatni.Name = "btnSacuvajDodatni";
            this.btnSacuvajDodatni.Size = new System.Drawing.Size(122, 32);
            this.btnSacuvajDodatni.TabIndex = 39;
            this.btnSacuvajDodatni.Text = "Sacuvaj";
            this.btnSacuvajDodatni.UseVisualStyleBackColor = false;
            this.btnSacuvajDodatni.Click += new System.EventHandler(this.btnSacuvajDodatni_Click);
            // 
            // dgvTreningZhatjev
            // 
            this.dgvTreningZhatjev.AllowUserToAddRows = false;
            this.dgvTreningZhatjev.AllowUserToDeleteRows = false;
            this.dgvTreningZhatjev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreningZhatjev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreningZhatjev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreningZhatjev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreningZhatjev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreningZahtjevId,
            this.TeretanaIme,
            this.ClanIme,
            this.PocetakTreninga,
            this.Kraj,
            this.Datum,
            this.Rezervacije,
            this.ClanIdZahtjev,
            this.TeretanaId,
            this.TreningId,
            this.Odobren});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreningZhatjev.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTreningZhatjev.Location = new System.Drawing.Point(12, 41);
            this.dgvTreningZhatjev.Name = "dgvTreningZhatjev";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTreningZhatjev.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTreningZhatjev.Size = new System.Drawing.Size(1122, 157);
            this.dgvTreningZhatjev.TabIndex = 41;
            // 
            // dgvTreningDodatni
            // 
            this.dgvTreningDodatni.AllowUserToAddRows = false;
            this.dgvTreningDodatni.AllowUserToDeleteRows = false;
            this.dgvTreningDodatni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreningDodatni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreningDodatni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTreningDodatni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreningDodatni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ClanNaziv,
            this.TeretanaNaziv,
            this.KorisnikIme,
            this.BrojRezervacija,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Prihvacen});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreningDodatni.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTreningDodatni.Location = new System.Drawing.Point(12, 287);
            this.dgvTreningDodatni.Name = "dgvTreningDodatni";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTreningDodatni.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTreningDodatni.Size = new System.Drawing.Size(1122, 200);
            this.dgvTreningDodatni.TabIndex = 42;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretrazi.Location = new System.Drawing.Point(303, 3);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(122, 32);
            this.btnPretrazi.TabIndex = 43;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPretraziDodatni
            // 
            this.btnPretraziDodatni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPretraziDodatni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretraziDodatni.Location = new System.Drawing.Point(303, 249);
            this.btnPretraziDodatni.Name = "btnPretraziDodatni";
            this.btnPretraziDodatni.Size = new System.Drawing.Size(122, 32);
            this.btnPretraziDodatni.TabIndex = 44;
            this.btnPretraziDodatni.Text = "Pretrazi";
            this.btnPretraziDodatni.UseVisualStyleBackColor = false;
            this.btnPretraziDodatni.Click += new System.EventHandler(this.btnPretraziDodatni_Click);
            // 
            // txtPretraziZahtjev
            // 
            this.txtPretraziZahtjev.Location = new System.Drawing.Point(12, 8);
            this.txtPretraziZahtjev.Name = "txtPretraziZahtjev";
            this.txtPretraziZahtjev.Size = new System.Drawing.Size(276, 23);
            this.txtPretraziZahtjev.TabIndex = 45;
            // 
            // txtPretraziDodatni
            // 
            this.txtPretraziDodatni.Location = new System.Drawing.Point(12, 254);
            this.txtPretraziDodatni.Name = "txtPretraziDodatni";
            this.txtPretraziDodatni.Size = new System.Drawing.Size(276, 23);
            this.txtPretraziDodatni.TabIndex = 46;
            // 
            // btnOdobreni
            // 
            this.btnOdobreni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdobreni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdobreni.Location = new System.Drawing.Point(912, 3);
            this.btnOdobreni.Name = "btnOdobreni";
            this.btnOdobreni.Size = new System.Drawing.Size(222, 32);
            this.btnOdobreni.TabIndex = 47;
            this.btnOdobreni.Text = "Prikazi odobrene";
            this.btnOdobreni.UseVisualStyleBackColor = false;
            this.btnOdobreni.Click += new System.EventHandler(this.btnOdobreni_Click);
            // 
            // TreningZahtjevId
            // 
            this.TreningZahtjevId.DataPropertyName = "TreningZahtjevId";
            this.TreningZahtjevId.HeaderText = "TreningZahtjevId";
            this.TreningZahtjevId.Name = "TreningZahtjevId";
            this.TreningZahtjevId.Visible = false;
            // 
            // TeretanaIme
            // 
            this.TeretanaIme.DataPropertyName = "TeretanaIme";
            this.TeretanaIme.HeaderText = "Teretana";
            this.TeretanaIme.Name = "TeretanaIme";
            this.TeretanaIme.ReadOnly = true;
            // 
            // ClanIme
            // 
            this.ClanIme.DataPropertyName = "ClanIme";
            this.ClanIme.HeaderText = "Clan";
            this.ClanIme.Name = "ClanIme";
            // 
            // PocetakTreninga
            // 
            this.PocetakTreninga.DataPropertyName = "TreningPocetak";
            this.PocetakTreninga.HeaderText = "Početak ";
            this.PocetakTreninga.Name = "PocetakTreninga";
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "TreningKraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "TreningDatum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Rezervacije
            // 
            this.Rezervacije.DataPropertyName = "TrenutnoRezervacija";
            this.Rezervacije.HeaderText = "Rezervacije";
            this.Rezervacije.Name = "Rezervacije";
            // 
            // ClanIdZahtjev
            // 
            this.ClanIdZahtjev.DataPropertyName = "ClanId";
            this.ClanIdZahtjev.HeaderText = "ClanId";
            this.ClanIdZahtjev.Name = "ClanIdZahtjev";
            this.ClanIdZahtjev.Visible = false;
            // 
            // TeretanaId
            // 
            this.TeretanaId.DataPropertyName = "TeretanaId";
            this.TeretanaId.HeaderText = "TeretanaId";
            this.TeretanaId.Name = "TeretanaId";
            this.TeretanaId.Visible = false;
            // 
            // TreningId
            // 
            this.TreningId.DataPropertyName = "TreningId";
            this.TreningId.HeaderText = "TreningId";
            this.TreningId.Name = "TreningId";
            this.TreningId.Visible = false;
            // 
            // Odobren
            // 
            this.Odobren.DataPropertyName = "Odobren";
            this.Odobren.FalseValue = "False";
            this.Odobren.HeaderText = "Odobren";
            this.Odobren.Name = "Odobren";
            this.Odobren.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Odobren.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Odobren.TrueValue = "True";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TreningDodatniId";
            this.dataGridViewTextBoxColumn2.HeaderText = "TreningDodatniId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PocetakTreninga";
            this.dataGridViewTextBoxColumn3.HeaderText = "Početak ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KrajTreninga";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kraj";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DatumOdrzavanja";
            this.dataGridViewTextBoxColumn5.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ClanNaziv
            // 
            this.ClanNaziv.DataPropertyName = "ClanIme";
            this.ClanNaziv.HeaderText = "Clan";
            this.ClanNaziv.Name = "ClanNaziv";
            // 
            // TeretanaNaziv
            // 
            this.TeretanaNaziv.DataPropertyName = "TeretanaNaziv";
            this.TeretanaNaziv.HeaderText = "Teretana";
            this.TeretanaNaziv.Name = "TeretanaNaziv";
            // 
            // KorisnikIme
            // 
            this.KorisnikIme.DataPropertyName = "KorisnikIme";
            this.KorisnikIme.HeaderText = "Trener";
            this.KorisnikIme.Name = "KorisnikIme";
            // 
            // BrojRezervacija
            // 
            this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija.HeaderText = "Broj rezervacija";
            this.BrojRezervacija.Name = "BrojRezervacija";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClanId";
            this.dataGridViewTextBoxColumn6.HeaderText = "ClanId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "KorisnikId";
            this.dataGridViewTextBoxColumn7.HeaderText = "KorisnikId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TeretanaId";
            this.dataGridViewTextBoxColumn8.HeaderText = "TeretanaId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // Prihvacen
            // 
            this.Prihvacen.DataPropertyName = "Prihvacen";
            this.Prihvacen.FalseValue = "False";
            this.Prihvacen.HeaderText = "Prihvacen";
            this.Prihvacen.Name = "Prihvacen";
            this.Prihvacen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prihvacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Prihvacen.TrueValue = "True";
            // 
            // frmTreningZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1146, 542);
            this.Controls.Add(this.btnOdobreni);
            this.Controls.Add(this.txtPretraziDodatni);
            this.Controls.Add(this.txtPretraziZahtjev);
            this.Controls.Add(this.btnPretraziDodatni);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTreningDodatni);
            this.Controls.Add(this.dgvTreningZhatjev);
            this.Controls.Add(this.btnSacuvajDodatni);
            this.Controls.Add(this.btnSacuvajZahtjev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTreningZahtjevi";
            this.Text = "frmTreningZahtjevi";
            this.Load += new System.EventHandler(this.frmTreningZahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningZhatjev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreningDodatni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvajZahtjev;
        private System.Windows.Forms.Button btnSacuvajDodatni;
        private System.Windows.Forms.DataGridView dgvTreningZhatjev;
        private System.Windows.Forms.DataGridView dgvTreningDodatni;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPretraziDodatni;
        private System.Windows.Forms.TextBox txtPretraziZahtjev;
        private System.Windows.Forms.TextBox txtPretraziDodatni;
        private System.Windows.Forms.Button btnOdobreni;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreningZahtjevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeretanaIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakTreninga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanIdZahtjev;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeretanaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreningId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobren;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeretanaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prihvacen;
    }
}