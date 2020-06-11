namespace eTeretane.WinUI.Trening
{
    partial class frmTrening
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.TreningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakTreninga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbTeretane = new System.Windows.Forms.ComboBox();
            this.cmbTreneri = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numBrRezervacija = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrRezervacija)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teninzi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTreninzi);
            this.panel1.Location = new System.Drawing.Point(658, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 523);
            this.panel1.TabIndex = 7;
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreninzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreninzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreningId,
            this.PocetakTreninga,
            this.Kraj,
            this.Datum,
            this.BrojRezervacija});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreninzi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTreninzi.Location = new System.Drawing.Point(0, 0);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTreninzi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTreninzi.Size = new System.Drawing.Size(478, 523);
            this.dgvTreninzi.TabIndex = 0;
            this.dgvTreninzi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTreninzi_MouseDoubleClick);
            // 
            // TreningId
            // 
            this.TreningId.DataPropertyName = "TreningId";
            this.TreningId.HeaderText = "TreningId";
            this.TreningId.Name = "TreningId";
            this.TreningId.ReadOnly = true;
            this.TreningId.Visible = false;
            // 
            // PocetakTreninga
            // 
            this.PocetakTreninga.DataPropertyName = "PocetakTreninga";
            this.PocetakTreninga.HeaderText = "Početak ";
            this.PocetakTreninga.Name = "PocetakTreninga";
            this.PocetakTreninga.ReadOnly = true;
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "KrajTreninga";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumOdrzavanja";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // BrojRezervacija
            // 
            this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija.HeaderText = "Broj rezervacija";
            this.BrojRezervacija.Name = "BrojRezervacija";
            this.BrojRezervacija.ReadOnly = true;
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZahtjevi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZahtjevi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZahtjevi.Location = new System.Drawing.Point(376, 13);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(192, 32);
            this.btnZahtjevi.TabIndex = 43;
            this.btnZahtjevi.Text = "Zahtjevi";
            this.btnZahtjevi.UseVisualStyleBackColor = false;
            this.btnZahtjevi.Click += new System.EventHandler(this.btnZahtjevi_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(151, 120);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(417, 23);
            this.datePicker.TabIndex = 4;
            // 
            // cmbTeretane
            // 
            this.cmbTeretane.FormattingEnabled = true;
            this.cmbTeretane.Location = new System.Drawing.Point(151, 169);
            this.cmbTeretane.Name = "cmbTeretane";
            this.cmbTeretane.Size = new System.Drawing.Size(417, 25);
            this.cmbTeretane.TabIndex = 5;
            this.cmbTeretane.Text = "-- Teretane --";
            // 
            // cmbTreneri
            // 
            this.cmbTreneri.FormattingEnabled = true;
            this.cmbTreneri.Location = new System.Drawing.Point(151, 219);
            this.cmbTreneri.Name = "cmbTreneri";
            this.cmbTreneri.Size = new System.Drawing.Size(417, 25);
            this.cmbTreneri.TabIndex = 6;
            this.cmbTreneri.Text = "-- Treneri --";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikazi.Location = new System.Drawing.Point(468, 269);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 32);
            this.btnPrikazi.TabIndex = 30;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teretana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Trener:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Datum:";
            // 
            // dtpOD
            // 
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOD.Location = new System.Drawing.Point(151, 423);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.ShowUpDown = true;
            this.dtpOD.Size = new System.Drawing.Size(73, 23);
            this.dtpOD.TabIndex = 34;
            // 
            // dtpDO
            // 
            this.dtpDO.CustomFormat = "HH:mm";
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDO.Location = new System.Drawing.Point(302, 423);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.ShowUpDown = true;
            this.dtpDO.Size = new System.Drawing.Size(73, 23);
            this.dtpDO.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Do:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 28);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sačuvaj novi termin:";
            // 
            // numBrRezervacija
            // 
            this.numBrRezervacija.Location = new System.Drawing.Point(516, 423);
            this.numBrRezervacija.Name = "numBrRezervacija";
            this.numBrRezervacija.Size = new System.Drawing.Size(52, 23);
            this.numBrRezervacija.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Broj rezervacija:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(468, 485);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 32);
            this.btnSacuvaj.TabIndex = 41;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poruka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poruka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poruka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poruka.Location = new System.Drawing.Point(240, 480);
            this.poruka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poruka.Name = "poruka";
            this.poruka.Padding = new System.Windows.Forms.Padding(8);
            this.poruka.Size = new System.Drawing.Size(221, 37);
            this.poruka.TabIndex = 42;
            this.poruka.Text = "Trenutno unosite izmjene";
            this.poruka.Visible = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.btnZahtjevi);
            this.panelChildForm.Controls.Add(this.poruka);
            this.panelChildForm.Controls.Add(this.btnSacuvaj);
            this.panelChildForm.Controls.Add(this.label8);
            this.panelChildForm.Controls.Add(this.numBrRezervacija);
            this.panelChildForm.Controls.Add(this.label7);
            this.panelChildForm.Controls.Add(this.label5);
            this.panelChildForm.Controls.Add(this.label4);
            this.panelChildForm.Controls.Add(this.dtpDO);
            this.panelChildForm.Controls.Add(this.dtpOD);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.btnPrikazi);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.cmbTreneri);
            this.panelChildForm.Controls.Add(this.cmbTeretane);
            this.panelChildForm.Controls.Add(this.datePicker);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Location = new System.Drawing.Point(10, 8);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1146, 542);
            this.panelChildForm.TabIndex = 44;
            // 
            // frmTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 579);
            this.Controls.Add(this.panelChildForm);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrening";
            this.Text = "--Treneri--";
            this.Load += new System.EventHandler(this.frmTrening_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrRezervacija)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreningId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakTreninga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
        private System.Windows.Forms.Button btnZahtjevi;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox cmbTeretane;
        private System.Windows.Forms.ComboBox cmbTreneri;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBrRezervacija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label poruka;
        private System.Windows.Forms.Panel panelChildForm;
    }
}