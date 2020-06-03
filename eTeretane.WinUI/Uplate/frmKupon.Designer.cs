namespace eTeretane.WinUI.Uplate
{
    partial class frmKupon
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
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.cmbDodajTeretane = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKuponKod = new System.Windows.Forms.TextBox();
            this.numPostotak = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBrKoristenja = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKuponiPrikaz = new System.Windows.Forms.DataGridView();
            this.KuponPopustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KuponKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postotak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrajDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_Koristenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPrikazTeretane = new System.Windows.Forms.ComboBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPostotak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrKoristenja)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponiPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPocetak.Location = new System.Drawing.Point(586, 18);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(106, 23);
            this.dtpPocetak.TabIndex = 37;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKraj.Location = new System.Drawing.Point(886, 18);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(106, 23);
            this.dtpKraj.TabIndex = 36;
            // 
            // cmbDodajTeretane
            // 
            this.cmbDodajTeretane.FormattingEnabled = true;
            this.cmbDodajTeretane.Location = new System.Drawing.Point(171, 18);
            this.cmbDodajTeretane.Name = "cmbDodajTeretane";
            this.cmbDodajTeretane.Size = new System.Drawing.Size(231, 25);
            this.cmbDodajTeretane.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Početak:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teretana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kraj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Postotak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kupon kod:";
            // 
            // txtKuponKod
            // 
            this.txtKuponKod.Location = new System.Drawing.Point(171, 49);
            this.txtKuponKod.Name = "txtKuponKod";
            this.txtKuponKod.Size = new System.Drawing.Size(231, 23);
            this.txtKuponKod.TabIndex = 26;
            // 
            // numPostotak
            // 
            this.numPostotak.Location = new System.Drawing.Point(586, 49);
            this.numPostotak.Name = "numPostotak";
            this.numPostotak.Size = new System.Drawing.Size(47, 23);
            this.numPostotak.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "%";
            // 
            // numBrKoristenja
            // 
            this.numBrKoristenja.Location = new System.Drawing.Point(886, 50);
            this.numBrKoristenja.Name = "numBrKoristenja";
            this.numBrKoristenja.Size = new System.Drawing.Size(46, 23);
            this.numBrKoristenja.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Broj korištenja:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvKuponiPrikaz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 343);
            this.panel1.TabIndex = 42;
            // 
            // dgvKuponiPrikaz
            // 
            this.dgvKuponiPrikaz.AllowUserToAddRows = false;
            this.dgvKuponiPrikaz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvKuponiPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKuponiPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKuponiPrikaz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKuponiPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKuponiPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuponiPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KuponPopustId,
            this.KuponKod,
            this.Postotak,
            this.PocetakDatum,
            this.KrajDatum,
            this.Broj_Koristenja});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKuponiPrikaz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKuponiPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKuponiPrikaz.Location = new System.Drawing.Point(0, 0);
            this.dgvKuponiPrikaz.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKuponiPrikaz.Name = "dgvKuponiPrikaz";
            this.dgvKuponiPrikaz.ReadOnly = true;
            this.dgvKuponiPrikaz.Size = new System.Drawing.Size(1184, 343);
            this.dgvKuponiPrikaz.TabIndex = 1;
            this.dgvKuponiPrikaz.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKuponiPrikaz_MouseDoubleClick);
            // 
            // KuponPopustId
            // 
            this.KuponPopustId.DataPropertyName = "KuponPopustId";
            this.KuponPopustId.HeaderText = "KuponPopustId";
            this.KuponPopustId.Name = "KuponPopustId";
            this.KuponPopustId.ReadOnly = true;
            this.KuponPopustId.Visible = false;
            // 
            // KuponKod
            // 
            this.KuponKod.DataPropertyName = "KuponKod";
            this.KuponKod.HeaderText = "Kupon Kod";
            this.KuponKod.Name = "KuponKod";
            this.KuponKod.ReadOnly = true;
            // 
            // Postotak
            // 
            this.Postotak.DataPropertyName = "Postotak";
            this.Postotak.HeaderText = "Postotak";
            this.Postotak.Name = "Postotak";
            this.Postotak.ReadOnly = true;
            // 
            // PocetakDatum
            // 
            this.PocetakDatum.DataPropertyName = "PocetakDatum";
            this.PocetakDatum.HeaderText = "Početak";
            this.PocetakDatum.Name = "PocetakDatum";
            this.PocetakDatum.ReadOnly = true;
            // 
            // KrajDatum
            // 
            this.KrajDatum.DataPropertyName = "KrajDatum";
            this.KrajDatum.HeaderText = "Kraj";
            this.KrajDatum.Name = "KrajDatum";
            this.KrajDatum.ReadOnly = true;
            // 
            // Broj_Koristenja
            // 
            this.Broj_Koristenja.DataPropertyName = "Broj_Koristenja";
            this.Broj_Koristenja.HeaderText = "Broj korištenja";
            this.Broj_Koristenja.Name = "Broj_Koristenja";
            this.Broj_Koristenja.ReadOnly = true;
            // 
            // cmbPrikazTeretane
            // 
            this.cmbPrikazTeretane.FormattingEnabled = true;
            this.cmbPrikazTeretane.Location = new System.Drawing.Point(12, 112);
            this.cmbPrikazTeretane.Name = "cmbPrikazTeretane";
            this.cmbPrikazTeretane.Size = new System.Drawing.Size(287, 25);
            this.cmbPrikazTeretane.TabIndex = 44;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikaz.Location = new System.Drawing.Point(324, 107);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(78, 32);
            this.btnPrikaz.TabIndex = 45;
            this.btnPrikaz.Text = "Prikaz";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(1039, 18);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(104, 54);
            this.btnSacuvaj.TabIndex = 46;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // frmKupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 502);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.cmbPrikazTeretane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numBrKoristenja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPostotak);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.cmbDodajTeretane);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKuponKod);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKupon";
            this.Text = "frmKupon";
            this.Load += new System.EventHandler(this.frmKupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPostotak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrKoristenja)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponiPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.ComboBox cmbDodajTeretane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKuponKod;
        private System.Windows.Forms.NumericUpDown numPostotak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBrKoristenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKuponiPrikaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn KuponPopustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KuponKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postotak;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrajDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_Koristenja;
        private System.Windows.Forms.ComboBox cmbPrikazTeretane;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}