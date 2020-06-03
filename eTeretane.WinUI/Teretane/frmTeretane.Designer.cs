namespace eTeretane.WinUI.Teretane
{
    partial class frmTeretane
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
            this.dgvTeretanePrikaz = new System.Windows.Forms.DataGridView();
            this.TeretanaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVrijemeOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVrijemeDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnSlika = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.timePickerDO = new System.Windows.Forms.DateTimePicker();
            this.timePickerOD = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeretanePrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teretane";
            // 
            // dgvTeretanePrikaz
            // 
            this.dgvTeretanePrikaz.AllowUserToAddRows = false;
            this.dgvTeretanePrikaz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTeretanePrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeretanePrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeretanePrikaz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeretanePrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeretanePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeretanePrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeretanaId,
            this.Naziv,
            this.Adresa,
            this.RadnoVrijemeOD,
            this.RadnoVrijemeDO,
            this.Grad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeretanePrikaz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeretanePrikaz.Location = new System.Drawing.Point(13, 302);
            this.dgvTeretanePrikaz.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTeretanePrikaz.Name = "dgvTeretanePrikaz";
            this.dgvTeretanePrikaz.ReadOnly = true;
            this.dgvTeretanePrikaz.Size = new System.Drawing.Size(1158, 265);
            this.dgvTeretanePrikaz.TabIndex = 0;
            this.dgvTeretanePrikaz.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTeretanePrikaz_MouseDoubleClick);
            // 
            // TeretanaId
            // 
            this.TeretanaId.DataPropertyName = "TeretanaId";
            this.TeretanaId.HeaderText = "TeretanaId";
            this.TeretanaId.Name = "TeretanaId";
            this.TeretanaId.ReadOnly = true;
            this.TeretanaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // RadnoVrijemeOD
            // 
            this.RadnoVrijemeOD.DataPropertyName = "PocetakRadnoVrijeme";
            this.RadnoVrijemeOD.HeaderText = "Radno vrijeme od";
            this.RadnoVrijemeOD.Name = "RadnoVrijemeOD";
            this.RadnoVrijemeOD.ReadOnly = true;
            // 
            // RadnoVrijemeDO
            // 
            this.RadnoVrijemeDO.DataPropertyName = "KrajRadnoVrijeme";
            this.RadnoVrijemeDO.HeaderText = "Radno vrijeme do";
            this.RadnoVrijemeDO.Name = "RadnoVrijemeDO";
            this.RadnoVrijemeDO.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretraga.Location = new System.Drawing.Point(809, 249);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(270, 23);
            this.txtPretraga.TabIndex = 7;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretraga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPretraga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretraga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretraga.Location = new System.Drawing.Point(1085, 244);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(86, 33);
            this.btnPretraga.TabIndex = 8;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(544, 212);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(116, 65);
            this.btnSacuvaj.TabIndex = 26;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnSlika
            // 
            this.btnSlika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSlika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSlika.Location = new System.Drawing.Point(460, 244);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(78, 32);
            this.btnSlika.TabIndex = 27;
            this.btnSlika.Text = "Upload";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(818, 24);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(353, 183);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreview.TabIndex = 28;
            this.imgPreview.TabStop = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(217, 95);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(321, 23);
            this.txtNaziv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(217, 124);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(321, 23);
            this.txtAdresa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grad:";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(217, 216);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(321, 23);
            this.txtSlika.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Slika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Radno vrijeme od:";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(217, 185);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(135, 25);
            this.cmbGradovi.TabIndex = 22;
            // 
            // timePickerDO
            // 
            this.timePickerDO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerDO.Location = new System.Drawing.Point(411, 156);
            this.timePickerDO.Name = "timePickerDO";
            this.timePickerDO.ShowUpDown = true;
            this.timePickerDO.Size = new System.Drawing.Size(127, 23);
            this.timePickerDO.TabIndex = 24;
            // 
            // timePickerOD
            // 
            this.timePickerOD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerOD.Location = new System.Drawing.Point(217, 156);
            this.timePickerOD.Name = "timePickerOD";
            this.timePickerOD.ShowUpDown = true;
            this.timePickerOD.Size = new System.Drawing.Size(135, 23);
            this.timePickerOD.TabIndex = 25;
            // 
            // frmTeretane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 579);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.timePickerOD);
            this.Controls.Add(this.timePickerDO);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvTeretanePrikaz);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTeretane";
            this.Text = "frmTeretane";
            this.Load += new System.EventHandler(this.frmTeretane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeretanePrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeretanePrikaz;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeretanaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVrijemeOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVrijemeDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.DateTimePicker timePickerDO;
        private System.Windows.Forms.DateTimePicker timePickerOD;
    }
}