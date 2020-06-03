namespace eTeretane.WinUI.Uplate
{
    partial class frmUplate
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
            this.btnDodajKupon = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajKupon
            // 
            this.btnDodajKupon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajKupon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKupon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajKupon.Location = new System.Drawing.Point(1021, 13);
            this.btnDodajKupon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajKupon.Name = "btnDodajKupon";
            this.btnDodajKupon.Size = new System.Drawing.Size(150, 45);
            this.btnDodajKupon.TabIndex = 30;
            this.btnDodajKupon.Text = "Dodaj kupon";
            this.btnDodajKupon.UseVisualStyleBackColor = false;
            this.btnDodajKupon.Click += new System.EventHandler(this.btnDodajKupon_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelChildForm.Location = new System.Drawing.Point(0, 77);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1184, 502);
            this.panelChildForm.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 31;
            this.label1.Text = "Uplate";
            // 
            // frmUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1184, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajKupon);
            this.Controls.Add(this.panelChildForm);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUplate";
            this.Text = "frmUplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKupon;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
    }
}