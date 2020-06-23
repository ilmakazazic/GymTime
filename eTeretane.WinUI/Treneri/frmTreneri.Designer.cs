namespace eTeretane.WinUI.Treneri
{
    partial class frmTreneri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassConf = new System.Windows.Forms.TextBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.clbLicence = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnUrediLicence = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnNajposjecenijiTreneri = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreneriLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvKorisnici);
            this.panel1.Location = new System.Drawing.Point(12, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 241);
            this.panel1.TabIndex = 0;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            this.dgvKorisnici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.Ime,
            this.Email,
            this.Telefon,
            this.KorisnickoIme,
            this.TreneriLicence});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKorisnici.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(0, 0);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            this.dgvKorisnici.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKorisnici.Size = new System.Drawing.Size(1160, 241);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKorisnici_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treneri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(147, 101);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(321, 23);
            this.txtPrezime.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(147, 72);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(321, 23);
            this.txtIme.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(147, 159);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(321, 23);
            this.txtTel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(692, 132);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(321, 23);
            this.txtPass.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(692, 103);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(321, 23);
            this.txtKorisnickoIme.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password potvrda:";
            // 
            // txtPassConf
            // 
            this.txtPassConf.Location = new System.Drawing.Point(692, 161);
            this.txtPassConf.Name = "txtPassConf";
            this.txtPassConf.PasswordChar = '*';
            this.txtPassConf.Size = new System.Drawing.Size(321, 23);
            this.txtPassConf.TabIndex = 23;
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(692, 190);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(132, 40);
            this.clbUloge.TabIndex = 25;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(967, 205);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(99, 44);
            this.btnSacuvaj.TabIndex = 27;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_ClickAsync);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(21, 226);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(321, 23);
            this.txtPretrazi.TabIndex = 28;
            // 
            // clbLicence
            // 
            this.clbLicence.FormattingEnabled = true;
            this.clbLicence.Location = new System.Drawing.Point(692, 15);
            this.clbLicence.Name = "clbLicence";
            this.clbLicence.Size = new System.Drawing.Size(321, 76);
            this.clbLicence.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Licence:";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(1031, 71);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(141, 113);
            this.panelChildForm.TabIndex = 36;
            // 
            // btnUrediLicence
            // 
            this.btnUrediLicence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrediLicence.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediLicence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrediLicence.Location = new System.Drawing.Point(1054, 13);
            this.btnUrediLicence.Name = "btnUrediLicence";
            this.btnUrediLicence.Size = new System.Drawing.Size(118, 37);
            this.btnUrediLicence.TabIndex = 32;
            this.btnUrediLicence.Text = "Uredi licence";
            this.btnUrediLicence.UseVisualStyleBackColor = false;
            this.btnUrediLicence.Click += new System.EventHandler(this.btnUrediLicence_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretrazi.Location = new System.Drawing.Point(351, 221);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(78, 32);
            this.btnPretrazi.TabIndex = 29;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnNajposjecenijiTreneri
            // 
            this.btnNajposjecenijiTreneri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNajposjecenijiTreneri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNajposjecenijiTreneri.Location = new System.Drawing.Point(239, 517);
            this.btnNajposjecenijiTreneri.Name = "btnNajposjecenijiTreneri";
            this.btnNajposjecenijiTreneri.Size = new System.Drawing.Size(78, 32);
            this.btnNajposjecenijiTreneri.TabIndex = 37;
            this.btnNajposjecenijiTreneri.Text = "Pretrazi";
            this.btnNajposjecenijiTreneri.UseVisualStyleBackColor = false;
            this.btnNajposjecenijiTreneri.Click += new System.EventHandler(this.btnNajposjecenijiTreneri_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poruka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poruka.Location = new System.Drawing.Point(757, 517);
            this.poruka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poruka.Name = "poruka";
            this.poruka.Padding = new System.Windows.Forms.Padding(8);
            this.poruka.Size = new System.Drawing.Size(254, 35);
            this.poruka.TabIndex = 50;
            this.poruka.Text = "Snimite izvještaj o trenerima:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(71, 517);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8);
            this.label10.Size = new System.Drawing.Size(161, 32);
            this.label10.TabIndex = 51;
            this.label10.Text = "Najposječeniji treneri:";
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "ImePrezime";
            this.Ime.HeaderText = "Ime i prezime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // TreneriLicence
            // 
            this.TreneriLicence.DataPropertyName = "TreneriLicence";
            this.TreneriLicence.HeaderText = "Licenca";
            this.TreneriLicence.Name = "TreneriLicence";
            this.TreneriLicence.ReadOnly = true;
            this.TreneriLicence.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPDF.Location = new System.Drawing.Point(1021, 509);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(150, 45);
            this.btnPDF.TabIndex = 49;
            this.btnPDF.Text = "Save PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // frmTreneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 579);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.poruka);
            this.Controls.Add(this.btnNajposjecenijiTreneri);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.btnUrediLicence);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbLicence);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassConf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTreneri";
            this.Text = "frmTreneri";
            this.Load += new System.EventHandler(this.frmTreneri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassConf;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.CheckedListBox clbLicence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnUrediLicence;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnNajposjecenijiTreneri;
        private System.Windows.Forms.Label poruka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreneriLicence;
        private System.Windows.Forms.Button btnPDF;
    }
}