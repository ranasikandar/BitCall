namespace BitCalls.Forms.FrmReports
{
    partial class FrmAddressBookReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddressBookReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btnPrivew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbxCompany);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbxCategory);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 63);
            this.panel1.TabIndex = 0;
            // 
            // cbxCompany
            // 
            this.cbxCompany.DisplayMember = "CompanyName";
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(6, 26);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(140, 21);
            this.cbxCompany.TabIndex = 1;
            this.cbxCompany.ValueMember = "CompanyName";
            // 
            // cboCity
            // 
            this.cboCity.DisplayMember = "City";
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(162, 26);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(158, 21);
            this.cboCity.TabIndex = 3;
            this.cboCity.ValueMember = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "City:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "CategoryName";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(336, 26);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(142, 21);
            this.cbxCategory.TabIndex = 5;
            this.cbxCategory.ValueMember = "CategoryID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name:";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(249, 77);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(69, 27);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnPrivew
            // 
            this.btnPrivew.Image = ((System.Drawing.Image)(resources.GetObject("btnPrivew.Image")));
            this.btnPrivew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivew.Location = new System.Drawing.Point(167, 77);
            this.btnPrivew.Name = "btnPrivew";
            this.btnPrivew.Size = new System.Drawing.Size(76, 27);
            this.btnPrivew.TabIndex = 1;
            this.btnPrivew.Text = "Priview";
            this.btnPrivew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrivew.UseVisualStyleBackColor = true;
            this.btnPrivew.Click += new System.EventHandler(this.btnPrivew_Click);
            // 
            // FrmAddressBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 116);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btnPrivew);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAddressBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book Report";
            this.Load += new System.EventHandler(this.FrmAddressBookReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddressBookReport_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnPrivew;
        private System.Windows.Forms.ComboBox cbxCompany;
    }
}