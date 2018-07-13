using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace BitCalls.Forms
{
    public partial class FrmConnectionCheck : Form
    {
        public FrmConnectionCheck()
        {
            InitializeComponent();
        }

        private void FrmConnectionCheck_Load(object sender, EventArgs e)
        {
            if (new Bll.Database().ReadReg("BitCallsDBSN", "") != "")
            {
                TxtDBServer.Text = new Bll.Database().ReadReg("BitCallsDBSN", "(Local)");
                TxtDB.Text = new Bll.Database().ReadReg("BitCallsDB", "LabSys");
                TxtUser.Text = new Bll.Database().ReadReg("BitCallsUN", "sa");
                TxtPwd.Text = new Bll.Database().ReadReg("BitCallsPD", "");
            }
            else
            {
                MessageBox.Show("Welcome! Please enter database settings.\nor Contact with your adminstrator.", "Welcome to BitCalls", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            funTestConnection();
        }

        private void funTestConnection()
        {

            try
            {
                string connectionstring = "Server=" + TxtDBServer.Text + ";Uid=" + TxtUser.Text + ";Pwd=" + TxtPwd.Text + ";Database=" + TxtDB.Text + ";";
                SqlConnection cn = new SqlConnection(connectionstring);

                Cursor.Current = Cursors.WaitCursor;
                cn.Open();

                if (cn.State == ConnectionState.Open)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Connection Test Successfull. Please save settings and Restart BitCalls to Take Effect.", "Successfull Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //WriteReg("BitCallsDBSN", TxtDBServer.Text);
                    //WriteReg("BitCallsDB", TxtDB.Text);
                    //WriteReg("BitCallsUN", TxtUser.Text);
                    //WriteReg("BitCallsPD", TxtPwd.Text);
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Connection Failed", "Error in Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cn.Close();
                cn.Dispose();

            }
            catch (SqlException exception)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(exception.Message, "Error in Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string ReadReg(string KeyName, string DefaultValue)
        {
            RegistryKey regKey1 = Registry.CurrentUser;
            regKey1 = regKey1.CreateSubKey("BitCalls");

            try
            {
                return (string)regKey1.GetValue(KeyName, DefaultValue);
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }

        public void WriteReg(string KeyName, string KeyValue)
        {
            RegistryKey regKey1 = Registry.CurrentUser;
            regKey1 = regKey1.CreateSubKey("BitCalls");

            try
            {
                regKey1.SetValue(KeyName, KeyValue);
            }
            catch (Exception e)
            {
                //
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            WriteReg("BitCallsDBSN", TxtDBServer.Text);
            WriteReg("BitCallsDB", TxtDB.Text);
            WriteReg("BitCallsUN", TxtUser.Text);
            WriteReg("BitCallsPD", TxtPwd.Text);
            MessageBox.Show("Settings has been saved successfully. you may restart BitCalls.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Restart();
        }
    }
}
