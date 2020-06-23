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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDodajKupon = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.cmbPrikazTeretane = new System.Windows.Forms.ComboBox();
            this.dgvUplate = new System.Windows.Forms.DataGridView();
            this.ClanarinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClanString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipClanarineString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeretanaString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKupon
            // 
            this.btnDodajKupon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajKupon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKupon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajKupon.Location = new System.Drawing.Point(1021, 13);
            this.btnDodajKupon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKupon.Name = "btnDodajKupon";
            this.btnDodajKupon.Size = new System.Drawing.Size(150, 45);
            this.btnDodajKupon.TabIndex = 30;
            this.btnDodajKupon.Text = "Dodaj kupon";
            this.btnDodajKupon.UseVisualStyleBackColor = false;
            this.btnDodajKupon.Click += new System.EventHandler(this.btnDodajKupon_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.poruka);
            this.panelChildForm.Controls.Add(this.btnPDF);
            this.panelChildForm.Controls.Add(this.btnPrikaz);
            this.panelChildForm.Controls.Add(this.cmbPrikazTeretane);
            this.panelChildForm.Controls.Add(this.dgvUplate);
            this.panelChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelChildForm.Location = new System.Drawing.Point(0, 77);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1184, 502);
            this.panelChildForm.TabIndex = 29;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikaz.Location = new System.Drawing.Point(324, 10);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(78, 32);
            this.btnPrikaz.TabIndex = 47;
            this.btnPrikaz.Text = "Prikaz";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click_1);
            // 
            // cmbPrikazTeretane
            // 
            this.cmbPrikazTeretane.FormattingEnabled = true;
            this.cmbPrikazTeretane.Location = new System.Drawing.Point(12, 15);
            this.cmbPrikazTeretane.Name = "cmbPrikazTeretane";
            this.cmbPrikazTeretane.Size = new System.Drawing.Size(287, 25);
            this.cmbPrikazTeretane.TabIndex = 46;
            // 
            // dgvUplate
            // 
            this.dgvUplate.AllowUserToAddRows = false;
            this.dgvUplate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            this.dgvUplate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvUplate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUplate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanarinaId,
            this.ClanString,
            this.DatumUplate,
            this.DatumIsteka,
            this.TipClanarineString,
            this.TeretanaString,
            this.cijenaString});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUplate.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUplate.Location = new System.Drawing.Point(0, 69);
            this.dgvUplate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUplate.Name = "dgvUplate";
            this.dgvUplate.ReadOnly = true;
            this.dgvUplate.Size = new System.Drawing.Size(1184, 326);
            this.dgvUplate.TabIndex = 2;
            // 
            // ClanarinaId
            // 
            this.ClanarinaId.DataPropertyName = "ClanarinaId";
            this.ClanarinaId.HeaderText = "ClanarinaId";
            this.ClanarinaId.Name = "ClanarinaId";
            this.ClanarinaId.ReadOnly = true;
            this.ClanarinaId.Visible = false;
            // 
            // ClanString
            // 
            this.ClanString.DataPropertyName = "ClanString";
            this.ClanString.HeaderText = "Ime i prezime";
            this.ClanString.Name = "ClanString";
            this.ClanString.ReadOnly = true;
            // 
            // DatumUplate
            // 
            this.DatumUplate.DataPropertyName = "DatumUplate";
            this.DatumUplate.HeaderText = "Datum uplate";
            this.DatumUplate.Name = "DatumUplate";
            this.DatumUplate.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // TipClanarineString
            // 
            this.TipClanarineString.DataPropertyName = "TipClanarineString";
            this.TipClanarineString.HeaderText = "Tip članarine";
            this.TipClanarineString.Name = "TipClanarineString";
            this.TipClanarineString.ReadOnly = true;
            // 
            // TeretanaString
            // 
            this.TeretanaString.DataPropertyName = "TeretanaString";
            this.TeretanaString.HeaderText = "Teretana";
            this.TeretanaString.Name = "TeretanaString";
            this.TeretanaString.ReadOnly = true;
            // 
            // cijenaString
            // 
            this.cijenaString.DataPropertyName = "cijenaString";
            this.cijenaString.HeaderText = "Uplačeno";
            this.cijenaString.Name = "cijenaString";
            this.cijenaString.ReadOnly = true;
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
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPDF.Location = new System.Drawing.Point(1021, 444);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(150, 45);
            this.btnPDF.TabIndex = 48;
            this.btnPDF.Text = "Save PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poruka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poruka.Location = new System.Drawing.Point(762, 449);
            this.poruka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poruka.Name = "poruka";
            this.poruka.Padding = new System.Windows.Forms.Padding(8);
            this.poruka.Size = new System.Drawing.Size(256, 35);
            this.poruka.TabIndex = 49;
            this.poruka.Text = "Snimite izvještaj o uplatama:";
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUplate";
            this.Text = "frmUplate";
            this.Load += new System.EventHandler(this.frmUplate_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKupon;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUplate;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.ComboBox cmbPrikazTeretane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanarinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanString;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipClanarineString;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeretanaString;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaString;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label poruka;
    }
}