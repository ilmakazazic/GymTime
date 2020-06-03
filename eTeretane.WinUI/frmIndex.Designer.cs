namespace eTeretane.WinUI
{
    partial class frmIndex
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
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.txtDodajClana = new System.Windows.Forms.Button();
            this.txtDodajTrenera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navTeretane = new System.Windows.Forms.Button();
            this.navTermini = new System.Windows.Forms.Button();
            this.navUplate = new System.Windows.Forms.Button();
            this.navTreneri = new System.Windows.Forms.Button();
            this.navClanovi = new System.Windows.Forms.Button();
            this.navPocetna = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajTermin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTermin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajTermin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTermin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajTermin.Location = new System.Drawing.Point(96, 402);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(204, 80);
            this.btnDodajTermin.TabIndex = 0;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // txtDodajClana
            // 
            this.txtDodajClana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDodajClana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDodajClana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDodajClana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDodajClana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDodajClana.Location = new System.Drawing.Point(483, 402);
            this.txtDodajClana.Name = "txtDodajClana";
            this.txtDodajClana.Size = new System.Drawing.Size(204, 80);
            this.txtDodajClana.TabIndex = 1;
            this.txtDodajClana.Text = "Dodaj clana";
            this.txtDodajClana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtDodajClana.UseVisualStyleBackColor = false;
            // 
            // txtDodajTrenera
            // 
            this.txtDodajTrenera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDodajTrenera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDodajTrenera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDodajTrenera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDodajTrenera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDodajTrenera.Location = new System.Drawing.Point(865, 402);
            this.txtDodajTrenera.Name = "txtDodajTrenera";
            this.txtDodajTrenera.Size = new System.Drawing.Size(204, 80);
            this.txtDodajTrenera.TabIndex = 2;
            this.txtDodajTrenera.Text = "Dodaj trenera";
            this.txtDodajTrenera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtDodajTrenera.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(420, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOBRODOŠLI";
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(534, 171);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(100, 100);
            this.imgAvatar.TabIndex = 4;
            this.imgAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navTeretane);
            this.panel1.Controls.Add(this.navTermini);
            this.panel1.Controls.Add(this.navUplate);
            this.panel1.Controls.Add(this.navTreneri);
            this.panel1.Controls.Add(this.navClanovi);
            this.panel1.Controls.Add(this.navPocetna);
            this.panel1.Location = new System.Drawing.Point(317, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 58);
            this.panel1.TabIndex = 5;
            // 
            // navTeretane
            // 
            this.navTeretane.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navTeretane.FlatAppearance.BorderSize = 0;
            this.navTeretane.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navTeretane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navTeretane.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navTeretane.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navTeretane.Location = new System.Drawing.Point(328, 0);
            this.navTeretane.Name = "navTeretane";
            this.navTeretane.Size = new System.Drawing.Size(112, 57);
            this.navTeretane.TabIndex = 6;
            this.navTeretane.Text = "Teretane";
            this.navTeretane.UseVisualStyleBackColor = false;
            this.navTeretane.Click += new System.EventHandler(this.navTeretane_Click);
            // 
            // navTermini
            // 
            this.navTermini.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navTermini.FlatAppearance.BorderSize = 0;
            this.navTermini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navTermini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navTermini.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navTermini.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navTermini.Location = new System.Drawing.Point(438, 0);
            this.navTermini.Name = "navTermini";
            this.navTermini.Size = new System.Drawing.Size(112, 57);
            this.navTermini.TabIndex = 5;
            this.navTermini.Text = "Termini";
            this.navTermini.UseVisualStyleBackColor = false;
            this.navTermini.Click += new System.EventHandler(this.navTermini_Click);
            // 
            // navUplate
            // 
            this.navUplate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navUplate.FlatAppearance.BorderSize = 0;
            this.navUplate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navUplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navUplate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navUplate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navUplate.Location = new System.Drawing.Point(550, 0);
            this.navUplate.Name = "navUplate";
            this.navUplate.Size = new System.Drawing.Size(112, 57);
            this.navUplate.TabIndex = 4;
            this.navUplate.Text = "Uplate";
            this.navUplate.UseVisualStyleBackColor = false;
            this.navUplate.Click += new System.EventHandler(this.navUplate_Click);
            // 
            // navTreneri
            // 
            this.navTreneri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navTreneri.FlatAppearance.BorderSize = 0;
            this.navTreneri.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navTreneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navTreneri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navTreneri.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navTreneri.Location = new System.Drawing.Point(217, 0);
            this.navTreneri.Name = "navTreneri";
            this.navTreneri.Size = new System.Drawing.Size(112, 57);
            this.navTreneri.TabIndex = 2;
            this.navTreneri.Text = "Treneri";
            this.navTreneri.UseVisualStyleBackColor = false;
            this.navTreneri.Click += new System.EventHandler(this.navTreneri_Click);
            // 
            // navClanovi
            // 
            this.navClanovi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navClanovi.FlatAppearance.BorderSize = 0;
            this.navClanovi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navClanovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navClanovi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navClanovi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navClanovi.Location = new System.Drawing.Point(108, 0);
            this.navClanovi.Name = "navClanovi";
            this.navClanovi.Size = new System.Drawing.Size(112, 57);
            this.navClanovi.TabIndex = 1;
            this.navClanovi.Text = "Članovi";
            this.navClanovi.UseVisualStyleBackColor = false;
            // 
            // navPocetna
            // 
            this.navPocetna.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navPocetna.FlatAppearance.BorderSize = 0;
            this.navPocetna.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navPocetna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navPocetna.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.navPocetna.Location = new System.Drawing.Point(0, 0);
            this.navPocetna.Name = "navPocetna";
            this.navPocetna.Size = new System.Drawing.Size(112, 57);
            this.navPocetna.TabIndex = 0;
            this.navPocetna.Text = "Početna";
            this.navPocetna.UseVisualStyleBackColor = false;
            this.navPocetna.Click += new System.EventHandler(this.navPocetna_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.imgAvatar);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.txtDodajTrenera);
            this.panelChildForm.Controls.Add(this.txtDodajClana);
            this.panelChildForm.Controls.Add(this.btnDodajTermin);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(0, 102);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1184, 579);
            this.panelChildForm.TabIndex = 6;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "frmIndex";
            this.Text = "GymTime";
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Button txtDodajClana;
        private System.Windows.Forms.Button txtDodajTrenera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button navUplate;
        private System.Windows.Forms.Button navTreneri;
        private System.Windows.Forms.Button navClanovi;
        private System.Windows.Forms.Button navPocetna;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button navTermini;
        private System.Windows.Forms.Button navTeretane;
    }
}

