namespace BitCalls.Forms
{
    partial class FrmConnectionCheck
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.TxtDBServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(168, 179);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(59, 23);
            this.BtnExit.TabIndex = 66;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(15, 179);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(94, 23);
            this.BtnTest.TabIndex = 64;
            this.BtnTest.Text = "Test Connecion";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(109, 179);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(59, 23);
            this.BtnSave.TabIndex = 65;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "User ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "DB Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "DB Server Name";
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(15, 147);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(210, 20);
            this.TxtPwd.TabIndex = 59;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(15, 108);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(210, 20);
            this.TxtUser.TabIndex = 58;
            // 
            // TxtDB
            // 
            this.TxtDB.Location = new System.Drawing.Point(15, 68);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(210, 20);
            this.TxtDB.TabIndex = 57;
            this.TxtDB.Text = "DB";
            // 
            // TxtDBServer
            // 
            this.TxtDBServer.Location = new System.Drawing.Point(15, 29);
            this.TxtDBServer.Name = "TxtDBServer";
            this.TxtDBServer.Size = new System.Drawing.Size(210, 20);
            this.TxtDBServer.TabIndex = 56;
            this.TxtDBServer.Text = "(Local)";
            // 
            // FrmConnectionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 227);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.TxtDBServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConnectionCheck";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BitCalls Connection Check";
            this.Load += new System.EventHandler(this.FrmConnectionCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtDB;
        private System.Windows.Forms.TextBox TxtDBServer;
    }
}