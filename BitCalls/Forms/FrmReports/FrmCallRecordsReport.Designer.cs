namespace BitCalls.Forms.FrmReports
{
    partial class FrmCallRecordsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCallRecordsReport));
            this.btClose = new System.Windows.Forms.Button();
            this.btnPrivew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxOutgoing = new System.Windows.Forms.ComboBox();
            this.cbxCallStatusSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContactPerson = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtToDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(259, 138);
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
            this.btnPrivew.Location = new System.Drawing.Point(177, 138);
            this.btnPrivew.Name = "btnPrivew";
            this.btnPrivew.Size = new System.Drawing.Size(76, 27);
            this.btnPrivew.TabIndex = 1;
            this.btnPrivew.Text = "Priview";
            this.btnPrivew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrivew.UseVisualStyleBackColor = true;
            this.btnPrivew.Click += new System.EventHandler(this.btnPrivew_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CbxOutgoing);
            this.panel1.Controls.Add(this.cbxCallStatusSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxContactPerson);
            this.panel1.Controls.Add(this.cbxCategory);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxCity);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtToDateTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFromDateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 117);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "OutGoing/Incoming";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // CbxOutgoing
            // 
            this.CbxOutgoing.DisplayMember = "City";
            this.CbxOutgoing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxOutgoing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxOutgoing.FormattingEnabled = true;
            this.CbxOutgoing.Items.AddRange(new object[] {
            "All",
            "OutGoing",
            "Incoming"});
            this.CbxOutgoing.Location = new System.Drawing.Point(15, 80);
            this.CbxOutgoing.Name = "CbxOutgoing";
            this.CbxOutgoing.Size = new System.Drawing.Size(116, 21);
            this.CbxOutgoing.TabIndex = 7;
            this.CbxOutgoing.ValueMember = "City";
            // 
            // cbxCallStatusSearch
            // 
            this.cbxCallStatusSearch.DisplayMember = "City";
            this.cbxCallStatusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCallStatusSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCallStatusSearch.FormattingEnabled = true;
            this.cbxCallStatusSearch.Items.AddRange(new object[] {
            "All",
            "Not Interested ",
            "Call Back Later",
            "Don’t call",
            "Interested"});
            this.cbxCallStatusSearch.Location = new System.Drawing.Point(395, 80);
            this.cbxCallStatusSearch.Name = "cbxCallStatusSearch";
            this.cbxCallStatusSearch.Size = new System.Drawing.Size(104, 21);
            this.cbxCallStatusSearch.TabIndex = 13;
            this.cbxCallStatusSearch.ValueMember = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calling Person:";
            // 
            // cbxContactPerson
            // 
            this.cbxContactPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxContactPerson.DisplayMember = "PersonName";
            this.cbxContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxContactPerson.FormattingEnabled = true;
            this.cbxContactPerson.Location = new System.Drawing.Point(15, 30);
            this.cbxContactPerson.Name = "cbxContactPerson";
            this.cbxContactPerson.Size = new System.Drawing.Size(130, 21);
            this.cbxContactPerson.TabIndex = 1;
            this.cbxContactPerson.ValueMember = "ContactID";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "CategoryName";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(267, 80);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(122, 21);
            this.cbxCategory.TabIndex = 11;
            this.cbxCategory.ValueMember = "CategoryID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Category:";
            // 
            // cbxCity
            // 
            this.cbxCity.DisplayMember = "City";
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(137, 80);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(124, 21);
            this.cbxCity.TabIndex = 9;
            this.cbxCity.ValueMember = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "City:";
            // 
            // dtToDateTime
            // 
            this.dtToDateTime.CustomFormat = "dd-MMM-yyyy   hh:mm:ss tt";
            this.dtToDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDateTime.Location = new System.Drawing.Point(328, 31);
            this.dtToDateTime.Name = "dtToDateTime";
            this.dtToDateTime.Size = new System.Drawing.Size(171, 20);
            this.dtToDateTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To Date Time:";
            // 
            // dtFromDateTime
            // 
            this.dtFromDateTime.CustomFormat = "dd-MMM-yyyy   hh:mm:ss tt";
            this.dtFromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDateTime.Location = new System.Drawing.Point(151, 31);
            this.dtFromDateTime.Name = "dtFromDateTime";
            this.dtFromDateTime.Size = new System.Drawing.Size(171, 20);
            this.dtFromDateTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date Time:";
            // 
            // FrmCallRecordsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 179);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btnPrivew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCallRecordsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Records Report";
            this.Load += new System.EventHandler(this.FrmCallRecordsReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCallRecordsReport_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnPrivew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtToDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFromDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxContactPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCallStatusSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxOutgoing;
    }
}