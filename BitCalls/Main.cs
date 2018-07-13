using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BitCalls
{
    public partial class Main : Form
    {
        MdiClient client;

        public Main()
        {
            InitializeComponent();

            IsMdiContainer = true;
            client = Controls.OfType<MdiClient>().First();
            client.GotFocus += (s, e) =>
            {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();
            };

        }

        public bool IsFormOpen(string FormName)
        {
            bool check = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType().Name == FormName)
                {
                    check = true;

                }
            }

            return check;
        }



        private void addressBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddressBook faddress = new FrmAddressBook();
            if (IsFormOpen("FrmAddressBook"))
            {
                Application.OpenForms["FrmAddressBook"].BringToFront();
            }
            else
            {
                faddress.MdiParent = this;
                client.BringToFront();
                faddress.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategory fcategory = new FrmCategory();
            if (IsFormOpen("FrmCategory"))
            {
                Application.OpenForms["FrmCategory"].BringToFront();
            }
            else
            {
                fcategory.MdiParent = this;
                client.BringToFront();
                fcategory.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CallRecords frmCallRecord = new CallRecords();
            if (IsFormOpen("CallRecords"))
            {
                Application.OpenForms["CallRecords"].BringToFront();
            }
            else
            {
                frmCallRecord.MdiParent = this;
                client.BringToFront();
                frmCallRecord.Show();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (IsFormOpen("FrmAddressBook"))
            {
                Application.OpenForms["FrmAddressBook"].Close();
            }
            if (IsFormOpen("FrmCategory"))
            {
                Application.OpenForms["FrmCategory"].Close();
            }
            if (IsFormOpen("CallRecords"))
            {
                Application.OpenForms["CallRecords"].Close();
            }
            if (IsFormOpen("FrmAddressBookReport"))
            {
                Application.OpenForms["FrmAddressBookReport"].Close();
            }
            if (IsFormOpen("FrmCallRecordsReport"))
            {
                Application.OpenForms["FrmCallRecordsReport"].Close();
            }
        }


        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Forms.FrmReports.FrmAddressBookReport fAddressrpt = new Forms.FrmReports.FrmAddressBookReport();

            if (IsFormOpen("FrmAddressBookReport"))
            {
                Application.OpenForms["FrmAddressBookReport"].BringToFront();
            }
            else
            {
                fAddressrpt.MdiParent = this;
                client.BringToFront();
                fAddressrpt.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Forms.FrmReports.FrmCallRecordsReport fcrRpt = new Forms.FrmReports.FrmCallRecordsReport();

            if (IsFormOpen("FrmCallRecordsReport"))
            {
                Application.OpenForms["FrmCallRecordsReport"].BringToFront();
            }
            else
            {
                fcrRpt.MdiParent = this;
                client.BringToFront();
                fcrRpt.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (new Bll.Database().ReadReg("BitCallsDBSN", "")=="")
            {
                Forms.FrmConnectionCheck fcon = new Forms.FrmConnectionCheck();
                fcon.ShowDialog();
            }
            else
            {
                
                try
                {
                    string connectionstring = "Server=" + new Bll.Global().ReadReg("BitCallsDBSN", "(Local)") + ";Uid=" + new Bll.Global().ReadReg("BitCallsUN", "sa") + ";Pwd=" + new Bll.Global().ReadReg("BitCallsPD", "") + ";Database=" + new Bll.Global().ReadReg("BitCallsDB", "") + ";";
                    SqlConnection cn = new SqlConnection(connectionstring);

                    Cursor.Current = Cursors.WaitCursor;
                    cn.Open();

                    if (cn.State == ConnectionState.Open)
                    {
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Forms.FrmConnectionCheck fcon = new Forms.FrmConnectionCheck();
                        fcon.ShowDialog();
                    }

                    cn.Close();
                    cn.Dispose();
                }
                catch (SqlException ex)
                {
                    Cursor.Current = Cursors.Default;
                    Forms.FrmConnectionCheck fcon = new Forms.FrmConnectionCheck();
                    fcon.ShowDialog();
                    //MessageBox.Show(ex.Message, "Error in Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
