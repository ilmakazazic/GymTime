namespace eTeretane.WinUI.Licence
{
    partial class frmLicence
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
            this.cmbLicence = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.btnUrediLicence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLicence
            // 
            this.cmbLicence.FormattingEnabled = true;
            this.cmbLicence.Location = new System.Drawing.Point(0, 0);
            this.cmbLicence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLicence.Name = "cmbLicence";
            this.cmbLicence.Size = new System.Drawing.Size(141, 25);
            this.cmbLicence.TabIndex = 0;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(0, 50);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(141, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(3, 29);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(44, 17);
            this.Naziv.TabIndex = 32;
            this.Naziv.Text = "Naziv:";
            // 
            // btnUrediLicence
            // 
            this.btnUrediLicence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrediLicence.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediLicence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrediLicence.Location = new System.Drawing.Point(65, 80);
            this.btnUrediLicence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrediLicence.Name = "btnUrediLicence";
            this.btnUrediLicence.Size = new System.Drawing.Size(74, 31);
            this.btnUrediLicence.TabIndex = 33;
            this.btnUrediLicence.Text = "Snimi";
            this.btnUrediLicence.UseVisualStyleBackColor = false;
            this.btnUrediLicence.Click += new System.EventHandler(this.btnUrediLicence_Click);
            // 
            // frmLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 113);
            this.Controls.Add(this.btnUrediLicence);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbLicence);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLicence";
            this.Text = "frmLicence";
            this.Load += new System.EventHandler(this.frmLicence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLicence;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Button btnUrediLicence;
    }
}