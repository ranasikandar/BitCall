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
    public partial class CallRecords : Form
    {
        public CallRecords()
        {
            InitializeComponent();
        }

        DataTable dtCatagories;

        private void CallRecords_Load(object sender, EventArgs e)
        {

            ///LOAD CBO CATAGORY
            //dtCatagories = new Bll.MainWindow().GetAllCatagories("");
            //DataRow rowCatagories = dtCatagories.NewRow();
            //rowCatagories["CategoryID"] = "0";
            //rowCatagories["CategoryName"] = "All";
            //dtCatagories.Rows.InsertAt(rowCatagories, 0);

            //DataView dv1 = new DataView(dtCatagories);
            this.cbxCategory.DataSource = new Bll.AddressBook().GetAllCatagories("");
            this.cbxCategory.SelectedIndex = 0;
            ///LOAD CBO CATAGORY


            ///LOAD GRID
            loadGrid();
            this.GridViewCallRecords.Columns["CallDateTime"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm:ss";
            ///LOAD GRID

            //load cbo of search
            //DataView dv2 = new DataView(dtCatagories);
            dtCatagories = new Bll.AddressBook().GetAllCatagories("");
            DataRow rowCatagories = dtCatagories.NewRow();
            rowCatagories["CategoryID"] = "0";
            rowCatagories["CategoryName"] = "All";
            dtCatagories.Rows.InsertAt(rowCatagories, 0);

            cbxCaegorySearch.DataSource = dtCatagories;

            this.cbxCaegorySearch.SelectedIndex = 0;
            //load cbo of search


            //load cbo for persones
            this.cbxContactPerson.DataSource = new Bll.CallRecords().GetPersons("");
            //load cbo for persones

            //load cbo of city
            DataTable dt = new Bll.AddressBook().GetCity(" and City is not null group by city");

            rowCatagories = dt.NewRow();
            rowCatagories["City"] = "Any/NA/All";
            dt.Rows.InsertAt(rowCatagories, 0);

            DataView dv1 = new DataView(dt);

            this.cboCity.DataSource = dv1;
            //load cbo of city

            //load cbo of city for search
            DataView dv2 = new DataView(dt);
            this.cboCitySearch.DataSource = dv2;
            //load cbo of city for search

            EnableSearch(false);

            this.cbxContactPerson.Text = string.Empty;
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
                this.dtCallRecord.Focus();
            }
        }

        private void loadGrid()
        {
            this.GridViewCallRecords.DataSource = new Bll.CallRecords().GetGrideData("");
            this.GridViewCallRecords.AutoGenerateColumns = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationOfCtrls())
            {
                if (this.btnSave.Text == "Save")
                {
                    try
                    {
                        new Bll.CallRecords().InsertCallRecords(assignToObj());
                        ctrlClear();
                        //this.btCancel_Click(sender, e);
                        btNew_Click(sender, e);
                        loadGrid();

                        //btNew.Enabled = false;
                        btCancel.Enabled = true;

                        CallRecords_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else if (this.btnSave.Text == "Update")
                {
                    try
                    {
                        new Bll.CallRecords().UpdateCallRecords(assignToObj());
                        ctrlClear();
                        //this.btCancel_Click(sender, e);
                        btNew_Click(sender, e);
                        loadGrid();

                        //btNew.Enabled = true;
                        btCancel.Enabled = true;

                        CallRecords_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

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

        private void ctrlClear()
        {
            this.dtCallRecord.Value = DateTime.Now;
            //cbxContactPerson.SelectedIndex = 0;
            cbxContactPerson.SelectedValue = 0;
            txtCompanyName.Text = "";
            txtMobileNo1.Text = "";
            cbxCategory.SelectedIndex = 0;
            txtCallDetails.Text = "";
            rdbIsOutGoing.Checked = true;
            cboCity.SelectedIndex = 0;
            cboCitySearch.SelectedIndex = 0;

            cbxCallStatus.SelectedIndex = 0;

        }

        private Obj.CallRecords assignToObj()
        {
            Obj.CallRecords obj = new Obj.CallRecords();
            obj.CallDateTime = this.dtCallRecord.Value;

            if (Convert.ToInt32(this.cbxContactPerson.SelectedValue) > 0)
            {
                obj.ContactID = Convert.ToInt32(cbxContactPerson.SelectedValue);
                obj.CallingPerson = cbxContactPerson.Text;
            }
            else
            {
                obj.ContactID = 0;
                obj.CallingPerson=cbxContactPerson.Text;
            }

            obj.CompanyName = this.txtCompanyName.Text;
            obj.CallingNo = this.txtMobileNo1.Text;
            obj.CategoryID = Convert.ToInt32(this.cbxCategory.SelectedValue);
            obj.CallDetail = this.txtCallDetails.Text;

            if (this.rdbIsOutGoing.Checked)
            {
                obj.IsOutgoing = true;
            }
            else
            {
                obj.IsOutgoing = false;
            }

            if (this.txtCallRecordIdHiden.Text == "")
            {
                obj.CallID = 0;
            }
            else
            {
                obj.CallID = Convert.ToInt32(this.txtCallRecordIdHiden.Text);
            }


            if (this.cbxContactPerson.SelectedValue==null||Convert.ToInt32(this.cbxContactPerson.SelectedValue) < 0)
            {
                DialogResult dr= MessageBox.Show("This Contact is not found in our database would you like to save this new contact", "New Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (this.btnSave.Text == "Save")
                    {
                        insertContact();
                    }
                    //else if(btnSave.Text=="Update")
                    //{
                    //    updateContact();
                    //}
                }
                //else
                //{

                //}

            }
            if (this.cboCity.SelectedIndex < 1)
            {
                obj.City = "";
            }
            else
            {
                obj.City = this.cboCity.Text;
            }

            obj.CallStaus = this.cbxCallStatus.Text;

            return obj;

        }

        private void updateContact()
        {
            throw new NotImplementedException();
        }

        private void insertContact()
        {
            Obj.AddressBook obj = new Obj.AddressBook();

            obj.txtPersonName = cbxContactPerson.Text;
            
            if (txtCompanyName.Text.Trim() == "")
            {
                obj.txtCompanyName = "na";
            }
            else
            {
                obj.txtCompanyName = txtCompanyName.Text;
            }

            obj.txtMobileNo1 = txtMobileNo1.Text;
            obj.cboCatagoryId = Convert.ToInt32(this.cbxCategory.SelectedValue);

            if (this.cboCity.SelectedIndex < 1)
            {
                obj.City = "";
            }
            else
            {
                obj.City = this.cboCity.Text;
            }

            new Bll.AddressBook().InsertContacts(obj);

            MessageBox.Show("This contact has been saved in contacts", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private bool validationOfCtrls()
        {
            //if (cbxContactPerson.SelectedIndex<1)

                if (this.cbxContactPerson.Text.Trim()!=string.Empty&&this.cbxContactPerson.Text.Length<=50)
                {
                    if (this.txtCompanyName.Text.Length < 50)
                    {
                        if (this.txtMobileNo1.Text.Trim() != string.Empty && this.txtMobileNo1.Text.Length <= 20)
                        {
                            if (txtCallDetails.Text.Trim() != string.Empty && txtCallDetails.Text.Length <= 200)
                            {
                                if (this.cbxCallStatus.SelectedIndex > 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    cbxCallStatus.Focus();
                                    MessageBox.Show("Please select a Status for this call", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                            else
                            {
                                txtCallDetails.Focus();
                                MessageBox.Show("Calling Details should not be empty or more then 200 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        else
                        {
                            this.txtMobileNo1.Focus();
                            MessageBox.Show("Calling Number should not be empty or more then 20 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        this.txtCompanyName.Focus();
                        MessageBox.Show("Company name should be more then 50 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    this.cbxContactPerson.Focus();
                    MessageBox.Show("Person name should not be empty and more then 50 char", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            if (txtNameSearch.Text.Trim()!="")
            {
                strWhere += " and car.CallingPerson like '%" + txtNameSearch.Text + "%'";
            } 
            if (txtCompanysearch.Text.Trim()!="")
            {
                strWhere += " and car.CompanyName like '%" + txtCompanysearch.Text + "%'";
            }
            if (txtMobile1Search.Text.Trim()!="")
            {
                strWhere += " and car.CallingNo like '%" + txtMobile1Search.Text + "%'";
            }
            if (cbxCaegorySearch.SelectedIndex>0)
            {
                strWhere += " and car.CategoryID =" + cbxCaegorySearch.SelectedValue + "";
            }

            if (this.cboCitySearch.SelectedIndex>0)
            {
                strWhere += " and car.City = '" + this.cboCitySearch.Text + "'";
            }

            if (this.cbxCallStatusSearch.SelectedIndex>0)
            {
                strWhere += " and CallStatus='"+this.cbxCallStatusSearch.Text+"'";
            }

            this.GridViewCallRecords.DataSource = new Bll.CallRecords().GetGrideData(strWhere);
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            EnableSearch(true);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            EnableSearch(false);
            ctrlClear();
            btnSave.Text = "Save";
        }

        private void GridViewCallRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (ActiveControl == null)
                return;
            else if (ActiveControl.Name != this.GridViewCallRecords.Name)
                return;
            try
            {
                if (GridViewCallRecords.Rows.Count > 0)
                {
                    int selectedrow = GridViewCallRecords.CurrentCell.RowIndex;

                    DataGridViewRow selectRow = GridViewCallRecords.Rows[GridViewCallRecords.CurrentCell.RowIndex];

                    ctrlClear();

                    DataTable dt = new DataTable();

                    dt = null;
                    dt = new Bll.CallRecords().GetGrideData(" and car.CallID =" + selectRow.Cells["CallID"].Value.ToString() + "");

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
            txtCallRecordIdHiden.Text = dt.Rows[0]["CallID"].ToString();
            dtCallRecord.Value = Convert.ToDateTime(dt.Rows[0]["CallDateTime"].ToString());

            if (Convert.ToInt32(dt.Rows[0]["ContactID"].ToString()) > 0)
            {
                this.cbxContactPerson.SelectedValue = dt.Rows[0]["ContactID"].ToString();
            }
            else
            {
                cbxContactPerson.Text = dt.Rows[0]["CallingPerson"].ToString();
            }

            txtCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
            txtMobileNo1.Text = dt.Rows[0]["CallingNo"].ToString();
            cbxCategory.SelectedValue = dt.Rows[0]["CategoryID"].ToString();
            txtCallDetails.Text=dt.Rows[0]["CallDetail"].ToString();

            if (Convert.ToBoolean(dt.Rows[0]["IsOutgoing"]))
            {
                this.rdbIsOutGoing.Checked = true;
                //this.rdbIsIncoming.Checked = false;
            }
            else
            {
                this.rdbIsIncoming.Checked = true;
            }

            if (dt.Rows[0]["City"].ToString() != "")
            {
                this.cboCity.SelectedValue = dt.Rows[0]["City"].ToString();
            }
            else
            {
                this.cboCity.SelectedIndex = 0;
            }

            if (dt.Rows[0]["CallStatus"].ToString() != "")
            {
                this.cbxCallStatus.Text = dt.Rows[0]["CallStatus"].ToString();
            }
        }

        private void GridViewCallRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedColumn = this.GridViewCallRecords.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewCallRecords.Columns[selectedColumn];

                if (this.GridViewCallRecords.Rows.Count == 1)
                {
                    GridViewCallRecords_SelectionChanged(sender, e);
                }

                if (selectcolumn.HeaderText == "Edit")
                {
                    this.btnSave.Enabled = true;
                    this.btnSave.Text = "Update";
                    Edit();
                    //GridViewContact.Enabled = false;
                    EnableSearch(false);
                    btCancel.Enabled = true;
                    btNew.Enabled = true;
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
                int selectedColumn = GridViewCallRecords.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewCallRecords.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Edit")
                {
                    int selectedrow = GridViewCallRecords.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = GridViewCallRecords.Rows[selectedrow];


                    DataTable dt = new DataTable();
                    //dt = new Bll.MainWindow().GetGrideData(" and con.ContactID=" + selectRow.Cells["ContactID"].Value.ToString() + "");
                    dt = new Bll.CallRecords().GetGrideData(" and car.CallID =" + selectRow.Cells["CallID"].Value.ToString() + "");

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
                int selectedColumn = GridViewCallRecords.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = GridViewCallRecords.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Delete")
                {
                    int selectedrow = GridViewCallRecords.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = GridViewCallRecords.Rows[selectedrow];
                    new Bll.CallRecords().Delete(selectRow.Cells["CallID"].Value.ToString());
                    loadGrid();
                }
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private void GridViewCallRecords_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            var dataGridView = (sender as DataGridView);
            if (GridViewCallRecords.Columns["Editor"].Index == e.ColumnIndex || GridViewCallRecords.Columns["Delete"].Index == e.ColumnIndex)
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

        private void CallRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
