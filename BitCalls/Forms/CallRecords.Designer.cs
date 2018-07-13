namespace BitCalls
{
    partial class CallRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallRecords));
            this.dtCallRecord = new System.Windows.Forms.DateTimePicker();
            this.cbxContactPerson = new System.Windows.Forms.ComboBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobileNo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCallDetails = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbIsIncoming = new System.Windows.Forms.RadioButton();
            this.rdbIsOutGoing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCallRecordIdHiden = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCitySearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCaegorySearch = new System.Windows.Forms.ComboBox();
            this.GridViewCallRecords = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMobile1Search = new System.Windows.Forms.TextBox();
            this.txtCompanysearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxCallStatus = new System.Windows.Forms.ComboBox();
            this.CallID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallingPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOutgoing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EntryDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editor = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCallStatusSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCallRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCallRecord
            // 
            this.dtCallRecord.CustomFormat = "dd-MMM-yyyy   hh:mm:ss tt";
            this.dtCallRecord.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCallRecord.Location = new System.Drawing.Point(10, 33);
            this.dtCallRecord.Name = "dtCallRecord";
            this.dtCallRecord.Size = new System.Drawing.Size(171, 20);
            this.dtCallRecord.TabIndex = 1;
            // 
            // cbxContactPerson
            // 
            this.cbxContactPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxContactPerson.DisplayMember = "PersonName";
            this.cbxContactPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxContactPerson.FormattingEnabled = true;
            this.cbxContactPerson.Location = new System.Drawing.Point(187, 32);
            this.cbxContactPerson.Name = "cbxContactPerson";
            this.cbxContactPerson.Size = new System.Drawing.Size(192, 21);
            this.cbxContactPerson.TabIndex = 3;
            this.cbxContactPerson.ValueMember = "ContactID";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(385, 32);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(175, 20);
            this.txtCompanyName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company Name:";
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Location = new System.Drawing.Point(11, 84);
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(96, 20);
            this.txtMobileNo1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calling No:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "CategoryName";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(11, 122);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(135, 21);
            this.cbxCategory.TabIndex = 10;
            this.cbxCategory.ValueMember = "CategoryID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Call Details:";
            // 
            // txtCallDetails
            // 
            this.txtCallDetails.Location = new System.Drawing.Point(158, 83);
            this.txtCallDetails.Multiline = true;
            this.txtCallDetails.Name = "txtCallDetails";
            this.txtCallDetails.Size = new System.Drawing.Size(221, 60);
            this.txtCallDetails.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIsIncoming);
            this.groupBox1.Controls.Add(this.rdbIsOutGoing);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(428, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 36);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is Outgoing";
            // 
            // rdbIsIncoming
            // 
            this.rdbIsIncoming.AutoSize = true;
            this.rdbIsIncoming.Location = new System.Drawing.Point(58, 17);
            this.rdbIsIncoming.Name = "rdbIsIncoming";
            this.rdbIsIncoming.Size = new System.Drawing.Size(39, 17);
            this.rdbIsIncoming.TabIndex = 1;
            this.rdbIsIncoming.Text = "No";
            this.rdbIsIncoming.UseVisualStyleBackColor = true;
            // 
            // rdbIsOutGoing
            // 
            this.rdbIsOutGoing.AutoSize = true;
            this.rdbIsOutGoing.Checked = true;
            this.rdbIsOutGoing.Location = new System.Drawing.Point(7, 17);
            this.rdbIsOutGoing.Name = "rdbIsOutGoing";
            this.rdbIsOutGoing.Size = new System.Drawing.Size(43, 17);
            this.rdbIsOutGoing.TabIndex = 0;
            this.rdbIsOutGoing.TabStop = true;
            this.rdbIsOutGoing.Text = "Yes";
            this.rdbIsOutGoing.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Calling Person:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxCallStatus);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtCallRecordIdHiden);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtCallRecord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxContactPerson);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.txtCallDetails);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxCategory);
            this.panel1.Controls.Add(this.txtMobileNo1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 163);
            this.panel1.TabIndex = 0;
            // 
            // cboCity
            // 
            this.cboCity.DisplayMember = "City";
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(428, 107);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(132, 21);
            this.cboCity.TabIndex = 15;
            this.cboCity.ValueMember = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(392, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "City";
            // 
            // txtCallRecordIdHiden
            // 
            this.txtCallRecordIdHiden.Location = new System.Drawing.Point(482, 3);
            this.txtCallRecordIdHiden.Name = "txtCallRecordIdHiden";
            this.txtCallRecordIdHiden.Size = new System.Drawing.Size(15, 20);
            this.txtCallRecordIdHiden.TabIndex = 6;
            this.txtCallRecordIdHiden.Visible = false;
            // 
            // btNew
            // 
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(430, 172);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(69, 30);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "New";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(357, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(507, 172);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(69, 30);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(507, 521);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(69, 30);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxCallStatusSearch);
            this.panel2.Controls.Add(this.cboCitySearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxCaegorySearch);
            this.panel2.Controls.Add(this.GridViewCallRecords);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.txtNameSearch);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMobile1Search);
            this.panel2.Controls.Add(this.txtCompanysearch);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(4, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 306);
            this.panel2.TabIndex = 4;
            // 
            // cboCitySearch
            // 
            this.cboCitySearch.DisplayMember = "City";
            this.cboCitySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCitySearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCitySearch.FormattingEnabled = true;
            this.cboCitySearch.Location = new System.Drawing.Point(424, 18);
            this.cboCitySearch.Name = "cboCitySearch";
            this.cboCitySearch.Size = new System.Drawing.Size(84, 21);
            this.cboCitySearch.TabIndex = 17;
            this.cboCitySearch.ValueMember = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "City";
            // 
            // cbxCaegorySearch
            // 
            this.cbxCaegorySearch.DisplayMember = "CategoryName";
            this.cbxCaegorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaegorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCaegorySearch.FormattingEnabled = true;
            this.cbxCaegorySearch.Location = new System.Drawing.Point(314, 19);
            this.cbxCaegorySearch.Name = "cbxCaegorySearch";
            this.cbxCaegorySearch.Size = new System.Drawing.Size(104, 21);
            this.cbxCaegorySearch.TabIndex = 8;
            this.cbxCaegorySearch.ValueMember = "CategoryID";
            // 
            // GridViewCallRecords
            // 
            this.GridViewCallRecords.AllowUserToAddRows = false;
            this.GridViewCallRecords.AllowUserToDeleteRows = false;
            this.GridViewCallRecords.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridViewCallRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCallRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallID,
            this.CallDateTime,
            this.ContactID,
            this.CallingPerson,
            this.CompanyName,
            this.CallingNo,
            this.City,
            this.CallDetail,
            this.IsOutgoing,
            this.EntryDateTime,
            this.CategoryID,
            this.CategoryName,
            this.CallStatus,
            this.Editor,
            this.Delete});
            this.GridViewCallRecords.Location = new System.Drawing.Point(4, 72);
            this.GridViewCallRecords.MultiSelect = false;
            this.GridViewCallRecords.Name = "GridViewCallRecords";
            this.GridViewCallRecords.ReadOnly = true;
            this.GridViewCallRecords.RowHeadersVisible = false;
            this.GridViewCallRecords.RowHeadersWidth = 30;
            this.GridViewCallRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewCallRecords.Size = new System.Drawing.Size(565, 230);
            this.GridViewCallRecords.TabIndex = 0;
            this.GridViewCallRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCallRecords_CellClick);
            this.GridViewCallRecords.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCallRecords_CellMouseEnter);
            this.GridViewCallRecords.SelectionChanged += new System.EventHandler(this.GridViewCallRecords_SelectionChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Category";
            // 
            // btSearch
            // 
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(517, 14);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(49, 25);
            this.btSearch.TabIndex = 9;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(6, 19);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(101, 20);
            this.txtNameSearch.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mobile 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // txtMobile1Search
            // 
            this.txtMobile1Search.Location = new System.Drawing.Point(207, 19);
            this.txtMobile1Search.Name = "txtMobile1Search";
            this.txtMobile1Search.Size = new System.Drawing.Size(102, 20);
            this.txtMobile1Search.TabIndex = 6;
            // 
            // txtCompanysearch
            // 
            this.txtCompanysearch.Location = new System.Drawing.Point(117, 19);
            this.txtCompanysearch.Name = "txtCompanysearch";
            this.txtCompanysearch.Size = new System.Drawing.Size(80, 20);
            this.txtCompanysearch.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(114, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Company";
            // 
            // cbxCallStatus
            // 
            this.cbxCallStatus.DisplayMember = "City";
            this.cbxCallStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCallStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCallStatus.FormattingEnabled = true;
            this.cbxCallStatus.Items.AddRange(new object[] {
            " ",
            "Not Interested ",
            "Call Back Later",
            "Don’t call",
            "Interested"});
            this.cbxCallStatus.Location = new System.Drawing.Point(428, 134);
            this.cbxCallStatus.Name = "cbxCallStatus";
            this.cbxCallStatus.Size = new System.Drawing.Size(132, 21);
            this.cbxCallStatus.TabIndex = 16;
            this.cbxCallStatus.ValueMember = "City";
            // 
            // CallID
            // 
            this.CallID.DataPropertyName = "CallID";
            this.CallID.HeaderText = "CallID";
            this.CallID.Name = "CallID";
            this.CallID.ReadOnly = true;
            this.CallID.Visible = false;
            this.CallID.Width = 5;
            // 
            // CallDateTime
            // 
            this.CallDateTime.DataPropertyName = "CallDateTime";
            this.CallDateTime.HeaderText = "Call Date Time";
            this.CallDateTime.Name = "CallDateTime";
            this.CallDateTime.ReadOnly = true;
            this.CallDateTime.Width = 130;
            // 
            // ContactID
            // 
            this.ContactID.DataPropertyName = "ContactID";
            this.ContactID.HeaderText = "ContactID";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Visible = false;
            // 
            // CallingPerson
            // 
            this.CallingPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CallingPerson.DataPropertyName = "CallingPerson";
            this.CallingPerson.HeaderText = "Calling Person";
            this.CallingPerson.Name = "CallingPerson";
            this.CallingPerson.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 80;
            // 
            // CallingNo
            // 
            this.CallingNo.DataPropertyName = "CallingNo";
            this.CallingNo.HeaderText = "Calling No";
            this.CallingNo.Name = "CallingNo";
            this.CallingNo.ReadOnly = true;
            this.CallingNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CallingNo.Width = 50;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 50;
            // 
            // CallDetail
            // 
            this.CallDetail.DataPropertyName = "CallDetail";
            this.CallDetail.HeaderText = "Call Detail";
            this.CallDetail.Name = "CallDetail";
            this.CallDetail.ReadOnly = true;
            this.CallDetail.Visible = false;
            // 
            // IsOutgoing
            // 
            this.IsOutgoing.DataPropertyName = "IsOutgoing";
            this.IsOutgoing.HeaderText = "Outgoing";
            this.IsOutgoing.Name = "IsOutgoing";
            this.IsOutgoing.ReadOnly = true;
            this.IsOutgoing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsOutgoing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsOutgoing.Width = 40;
            // 
            // EntryDateTime
            // 
            this.EntryDateTime.DataPropertyName = "EntryDateTime";
            this.EntryDateTime.HeaderText = "Entry Date Time";
            this.EntryDateTime.Name = "EntryDateTime";
            this.EntryDateTime.ReadOnly = true;
            this.EntryDateTime.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Visible = false;
            // 
            // CallStatus
            // 
            this.CallStatus.DataPropertyName = "CallStatus";
            this.CallStatus.HeaderText = "CallStatus";
            this.CallStatus.Name = "CallStatus";
            this.CallStatus.ReadOnly = true;
            this.CallStatus.Visible = false;
            // 
            // Editor
            // 
            this.Editor.HeaderText = "Edit";
            this.Editor.Image = ((System.Drawing.Image)(resources.GetObject("Editor.Image")));
            this.Editor.Name = "Editor";
            this.Editor.ReadOnly = true;
            this.Editor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editor.Width = 45;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status";
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
            this.cbxCallStatusSearch.Location = new System.Drawing.Point(376, 45);
            this.cbxCallStatusSearch.Name = "cbxCallStatusSearch";
            this.cbxCallStatusSearch.Size = new System.Drawing.Size(132, 21);
            this.cbxCallStatusSearch.TabIndex = 18;
            this.cbxCallStatusSearch.ValueMember = "City";
            // 
            // CallRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CallRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Records";
            this.Load += new System.EventHandler(this.CallRecords_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CallRecords_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCallRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCallRecord;
        private System.Windows.Forms.ComboBox cbxContactPerson;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileNo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCallDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbIsIncoming;
        private System.Windows.Forms.RadioButton rdbIsOutGoing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxCaegorySearch;
        private System.Windows.Forms.DataGridView GridViewCallRecords;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMobile1Search;
        private System.Windows.Forms.TextBox txtCompanysearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCallRecordIdHiden;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCitySearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCallStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallingPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOutgoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallStatus;
        private System.Windows.Forms.DataGridViewImageColumn Editor;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCallStatusSearch;

    }
}