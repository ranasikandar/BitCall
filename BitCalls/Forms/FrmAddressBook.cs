using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitCalls
{
    public partial class FrmAddressBook : Form
    {
        public FrmAddressBook()
        {
            InitializeComponent();
        }

        DataTable dtCatagories;

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {
            ///LOAD CBO CATAGORY
            /////////option 1
            dtCatagories = new Bll.AddressBook().GetAllCatagories("");
            DataRow rowCatagories = dtCatagories.NewRow();
            rowCatagories["CategoryID"] = "0";
            rowCatagories["CategoryName"] = "All";
            dtCatagories.Rows.InsertAt(rowCatagories, 0);

            //DataView dv1 = new DataView(dtCatagories);
            
            this.cbxCategory.DataSource = dtCatagories;
            /////////option 2
            //this.cbxCategory.DataSource = new Bll.MainWindow().GetAllCatagories();
            /////////

            //this.cbxCategory.ValueMember = "CategoryID";
            //this.cbxCategory.DisplayMember = "CategoryName";
            this.cbxCategory.SelectedIndex = 0;
            ///LOAD CBO CATAGORY

            ///LOAD GRID
            loadGrid();
            ///LOAD GRID

            //load cbo of search
            //DataView dv2 = new DataView(dtCatagories);
            //this.cboCaegorySearch.DataSource = dv2;
            //this.cboCaegorySearch.ValueMember = "CategoryID";
            //this.cboCaegorySearch.DisplayMember = "CategoryName";
            //this.cboCaegorySearch.SelectedIndex = 0;

            dtCatagories = new Bll.AddressBook().GetAllCatagories("");
            rowCatagories = dtCatagories.NewRow();
            rowCatagories["CategoryID"] = "0";
            rowCatagories["CategoryName"] = "All";
            dtCatagories.Rows.InsertAt(rowCatagories, 0);

            cbxCaegorySearch.DataSource = dtCatagories;

            this.cbxCaegorySearch.SelectedIndex = 0;
            //load cbo of search

            //load cbo of city
            DataTable dt = new Bll.AddressBook().GetCity(" and City is not null group by city");

            rowCatagories = dt.NewRow();
            rowCatagories["City"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cboCity.DataSource = dt;
            //this.cboCity.DataSource = new Bll.AddressBook().GetCity("");
            //load cbo of city

            EnableSearch(true);
        }

        private void loadGrid()
        {
            this.GridViewContact.DataSource = new Bll.AddressBook().GetGrideData("");
            this.GridViewContact.AutoGenerateColumns = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationOfCtrls())
            {
                if (this.btnSave.Text == "Save")
                {
                    try
                    {
                        new Bll.AddressBook().InsertContacts(assignToObj());
                        //ctrlClear();
                        this.btCancel_Click(sender, e);
                        loadGrid();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else if (this.btnSave.Text=="Update")
                {
                    try
                    {
                        new Bll.AddressBook().UpdateContacts(assignToObj());
                        //ctrlClear();
                        this.btCancel_Click(sender, e);
                        loadGrid();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }


        }

        //if (validationOfCtrls())
        //    {
        //        if (this.btnSave.Text == "Save")
        //        {
        //            try
        //            {
        //                new Bll.MainWindow().InsertContacts(assignToObj());
        //                ctrlctrlClear();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //        }
        //        else if (this.btnSave.Text=="Update")
        //        {
                    
        //        }
        //    }

        
        private Obj.AddressBook assignToObj()
        {
            Obj.AddressBook obj = new Obj.AddressBook();

            if (this.txtContactIdHiden.Text!=string.Empty)
            {
                obj.txtContactId = Convert.ToInt32(this.txtContactIdHiden.Text);
            }
            else
            {
                obj.txtContactId = 0;
            }

            obj.cboCatagoryId = Convert.ToInt32(this.cbxCategory.SelectedValue);
            obj.txtPersonName = this.txtPersonName.Text;
            obj.txtCompanyName = this.txtCompanyName.Text;
            obj.txtMobileNo1 = this.txtMobileNo1.Text;
            obj.txtMobileNo2 = this.txtMobileNo2.Text;
            obj.txtLandlineNo1 = this.txtLandlineNo1.Text;
            obj.txtLandlineNo2 = this.txtLandlineNo2.Text;
            obj.txtHomeAddress = this.txtHomeAddress.Text;
            obj.txtOfficeAddress = this.txtOfficeAddress.Text;

            if (this.txtCity.Text.Trim() != "")
            {
                obj.City = this.txtCity.Text;
            }
            else
            {
                obj.City = "";
            }
            

            return obj;
        }

        private bool validationOfCtrls()
        {
            if (this.txtPersonName.Text.Trim() != string.Empty && this.txtPersonName.Text.Length <= 50)
            {
                if (this.txtCompanyName.Text.Trim() != string.Empty && this.txtCompanyName.Text.Length <= 50)
                {
                    if (this.txtMobileNo1.Text.Trim() != string.Empty && this.txtMobileNo1.Text.Length <= 20)
                    {
                        if (this.txtMobileNo2.Text.Length <= 20)
                        {
                            if (this.txtLandlineNo1.Text.Length<=20)
                            {
                                if (this.txtLandlineNo2.Text.Length<=20)
                                {
                                    if (this.txtHomeAddress.Text.Length <= 200)
                                    {
                                        if (this.txtOfficeAddress.Text.Length <= 200)
                                        {
                                            if (Convert.ToInt32(this.cbxCategory.SelectedValue) > 0)
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                this.cbxCategory.Focus();
                                                MessageBox.Show("Please Select A Valid Catogory", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                            }
                                        }
                                        else
                                        {
                                            this.txtHomeAddress.Focus();
                                            MessageBox.Show("Should not exceed more then 200 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                    }
                                    else
                                    {
                                        this.txtHomeAddress.Focus();
                                        MessageBox.Show("Should not exceed more then 200 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                }
                                else
                                {
                                    this.txtLandlineNo2.Focus();
                                    MessageBox.Show("Should not exceed more then 20 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                            else
                            {
                                this.txtLandlineNo1.Focus();
                                MessageBox.Show("Should not exceed more then 20 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        else
                        {
                            this.txtMobileNo2.Focus();
                            MessageBox.Show("Should not exceed more then 20 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        this.txtMobileNo1.Focus();
                        MessageBox.Show("Should not empty and less then 20 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    this.txtCompanyName.Focus();
                    MessageBox.Show("Should not empty and less then 50 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                this.txtPersonName.Focus();
                MessageBox.Show("Should not empty and less then 50 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchQury = @"select con.* ,cat.CategoryName from Contacts con inner join Category cat on con.CategoryID=cat.CategoryID where 1=1";

            if (this.cbxCaegorySearch.SelectedIndex>0)
            {
                searchQury += " and cat.CategoryID="+this.cbxCaegorySearch.SelectedValue+"";
            }

            if (this.txtNameSearch.Text!=string.Empty)
            {
                searchQury += " and con.PersonName like '%"+this.txtNameSearch.Text+"%'";
            }
            if (this.txtCompanysearch.Text!=string.Empty)
            {
                searchQury += " and con.CompanyName like '%" + this.txtCompanysearch.Text + "%'";
            }
            if (this.txtMobile1Search.Text != string.Empty)
            {
                searchQury += " and con.MobileNo1 like '%" + this.txtMobile1Search.Text + "%'";
            }
            if (this.cboCity.Text!="All")
            {
                searchQury += " and con.City = '" + this.cboCity.Text + "'";
            }

            this.GridViewContact.DataSource = new Bll.AddressBook().GetGridSearch(searchQury);
            
        }

        private void GridViewContact_SelectionChanged(object sender, EventArgs e)
        {
            if (ActiveControl == null)
                return;
            else if (ActiveControl.Name != this.GridViewContact.Name)
                return;
            try
            {
                if (GridViewContact.Rows.Count > 0)
                {
                    int selectedrow = GridViewContact.CurrentCell.RowIndex;

                    DataGridViewRow selectRow = GridViewContact.Rows[GridViewContact.CurrentCell.RowIndex];

                    ctrlClear();

                    DataTable dt = new DataTable();

                    dt = null;
                    //dt = Biz_Doctors.getDataTable(" and DoctorID = " + selectRow.Cells["DoctorID"].Value.ToString());

                    dt = new Bll.AddressBook().GetGrideData(" and con.ContactID=" + selectRow.Cells["ContactID"].Value.ToString() + "");

                    if (dt.Rows.Count > 0)
                    {
                        AssigntoControls(dt);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("GridViewSearch_SelectionChanged Error\n" + Exception + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssigntoControls(DataTable dt)
        {
            this.txtContactIdHiden.Text = dt.Rows[0]["ContactID"].ToString();
            this.cbxCategory.SelectedValue = dt.Rows[0]["CategoryID"].ToString();
            this.txtPersonName.Text = dt.Rows[0]["PersonName"].ToString();
            this.txtCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
            this.txtMobileNo1.Text = dt.Rows[0]["MobileNo1"].ToString();
            this.txtMobileNo2.Text = dt.Rows[0]["MobileNo2"].ToString();
            this.txtLandlineNo1.Text = dt.Rows[0]["LandlineNo1"].ToString();
            this.txtLandlineNo2.Text = dt.Rows[0]["LandlineNo2"].ToString();
            this.txtHomeAddress.Text = dt.Rows[0]["HomeAddress"].ToString();
            this.txtOfficeAddress.Text = dt.Rows[0]["OfficeAddress"].ToString();

            this.txtCity.Text = dt.Rows[0]["City"].ToString();
           
        }

        private void ctrlClear()
        {
            this.cbxCategory.SelectedValue = 0;
            this.txtPersonName.Text = "";
            this.txtCompanyName.Text = "";
            this.txtMobileNo1.Text = "";
            this.txtMobileNo2.Text = "";
            this.txtLandlineNo1.Text = "";
            this.txtLandlineNo2.Text = "";
            this.txtHomeAddress.Text = "";
            this.txtOfficeAddress.Text = "";
            this.txtCity.Text = "";
            cboCity.SelectedIndex = 0;
        }

        private void GridViewContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedColumn = this.GridViewContact.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewContact.Columns[selectedColumn];

                if (this.GridViewContact.Rows.Count == 1)
                {
                    GridViewContact_SelectionChanged(sender, e);
                }

                if (selectcolumn.HeaderText == "Edit")
                {
                    this.btnSave.Enabled = true;
                    this.btnSave.Text = "Update";
                    Edit();
                    //GridViewContact.Enabled = false;
                    EnableSearch(false);
                    btCancel.Enabled = true;
                    cbxCategory.Focus();
                }
                else if (selectcolumn.HeaderText == "Delete")
                {
                    DialogResult dr = MessageBox.Show("Confirm to Delete !!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        DeleteRecord();
                    }
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("SQL Error\n" + Exception + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit()
        {
            try
            {
                int selectedColumn = GridViewContact.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewContact.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Edit")
                {
                    int selectedrow = GridViewContact.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = GridViewContact.Rows[selectedrow];


                    DataTable dt = new DataTable();
                    dt = new Bll.AddressBook().GetGrideData(" and con.ContactID=" + selectRow.Cells["ContactID"].Value.ToString() + "");

                    if (dt.Rows.Count > 0)
                    {
                        this.btnSave.Text = "Update";
                        AssigntoControls(dt);
                        EnableSearch(false);
                        btNew.Enabled = false;
                    }
                    else
                    {
                        throw (new Exception("Unable To Load Info!"));
                    }
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void DeleteRecord()
        {
            try
            {
                int selectedColumn = GridViewContact.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewContact.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Delete")
                {
                    int selectedrow = GridViewContact.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = GridViewContact.Rows[selectedrow];
                    new Bll.AddressBook().Delete(selectRow.Cells["ContactID"].Value.ToString());
                    loadGrid();
                }
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private void EnableSearch(bool Enable)
        {
            if (Enable)
            {
                this.panel1.Enabled = false;
                this.panel2.Enabled = true;
                this.txtNameSearch.Focus();
            }
            else
            {
                this.panel2.Enabled = false;
                panel1.Enabled = true;
                this.txtPersonName.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ctrlClear();
            this.btnSave.Text = "Save";
            btnSave.Enabled = false;
            btNew.Enabled = true;
            EnableSearch(true);
            btCancel.Enabled = false;
            this.txtNameSearch.Focus();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            try
            {
                clearSearchCtrls();

                ctrlClear();
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                btNew.Enabled = false;
                EnableSearch(false);
                btCancel.Enabled = true;
            }
            catch (Exception Exception)
            {
                MessageBox.Show("SQL Error\n" + Exception + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cbxCategory.Focus();
        }

        private void clearSearchCtrls()
        {
            this.txtNameSearch.Text = "";
            this.txtCompanysearch.Text = "";
            this.txtMobile1Search.Text = "";
            this.cbxCaegorySearch.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
//            BitCalls.FrmCategory frm = new BitCalls.FrmCategory();
            FrmCategory fc = new FrmCategory();
            fc.Show();
            
        }

        private void btnCustomerRefresh_Click(object sender, EventArgs e)
        {
            FrmMainWindow_Load(sender, e);
        }

        private void btnCallRecord_Click(object sender, EventArgs e)
        {
            CallRecords callrec = new CallRecords();
            callrec.Show();
        }

        private void GridViewContact_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            var dataGridView = (sender as DataGridView);
            if (GridViewContact.Columns["Editor"].Index == e.ColumnIndex || GridViewContact.Columns["Delete"].Index == e.ColumnIndex)
            {
                dataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridView.Cursor = Cursors.Default;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmAddressBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


        
    }
}

