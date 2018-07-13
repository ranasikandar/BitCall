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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            GetDataTable("");
            clear();
            EnableSearch(false);
            //btCancel.Enabled = true;
            //btNew_Click_1(sender, e);
            btSave.Enabled = true;
            btNew.Enabled = false;
        }

        private void AssigntoControls(DataTable dt)
        {
            txtCategoryID.Text = dt.Rows[0]["CategoryID"].ToString();
            txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();

        }

        private void clear()
        {
            txtCategoryName.Text = "";
        }

        private void EnableSearch(bool Enable)
        {
            if (Enable)
            {
                this.panel1.Enabled = false;
                this.panel2.Enabled = true;
            }
            else
            {
                this.panel2.Enabled = false;
                this.panel1.Enabled = true;
            }
        }

        private void Save()
        {
            try
            {
                new Bll.Category().InsertCategory(this.txtCategoryName.Text);
                clear();
                EnableSearch(false);
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private void GetDataTable(string where)
        {
            try
            {
                gdvCategory.DataSource = new Bll.AddressBook().GetAllCatagories("");
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private bool validation()
        {
            if (txtCategoryName.Text != "" && txtCategoryName.Text.Length <= 30)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please Insert Valid Category Name. must be less then 30 char.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }

        private void Edit()
        {
            try
            {
                int selectedColumn = gdvCategory.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = gdvCategory.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Edit")
                {
                    int selectedrow = gdvCategory.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = gdvCategory.Rows[selectedrow];

                    //DataTable dt = null;
                    dt = new Bll.AddressBook().GetAllCatagories(" and CategoryID = " + selectRow.Cells["CategoryID"].Value.ToString() + "");

                    if (dt.Rows.Count > 0)
                    {
                        btSave.Text = "Update";
                        AssigntoControls(dt);
                        EnableSearch(true);
                        btNew.Enabled = false;
                    }
                    else
                    {
                        throw (new Exception("Unable To Load Doctor Info!"));
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
                int selectedColumn = gdvCategory.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = gdvCategory.Columns[selectedColumn];
                if (selectcolumn.HeaderText == "Delete")
                {
                    int selectedrow = gdvCategory.SelectedCells[0].RowIndex;
                    DataGridViewRow selectRow = gdvCategory.Rows[selectedrow];

                    new Bll.Category().Delete(selectRow.Cells["CategoryID"].Value.ToString());
                    GetDataTable("");
                }
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btSave.Text == "Save")
                {
                    if (validation())
                    {
                        Save();
                        clear();
                        EnableSearch(false);
                        GetDataTable("");
                    }
                    else
                    {
                        //MessageBox.Show("Please Insert Valid Category Name. must be less then 30 char.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (btSave.Text == "Update")
                {
                    if (validation())
                    {
                        UpdateFn();
                        clear();
                        EnableSearch(true);
                        GetDataTable("");
                    }
                    else
                    {
                        //MessageBox.Show("Please Insert Valid Category Name. must be less then 30 char.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Error While Saving\n" + Exception + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btNew_Click_1(sender, e);
        }

        private void UpdateFn()
        {
            try
            {
                new Bll.Category().UpdateCategory(this.txtCategoryName.Text,Convert.ToInt32(this.txtCategoryID.Text));
                clear();
                EnableSearch(false);
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                gdvCategory.DataSource = new Bll.AddressBook().GetAllCatagories(" and CategoryName like '%" + txtNameSearch.Text + "%'");
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        DataTable dt;

        private void gdvCategory_SelectionChanged_1(object sender, EventArgs e)
        {
            if (ActiveControl == null)
                return;
            else if (ActiveControl.Name != gdvCategory.Name)
                return;
            try
            {
                if (gdvCategory.Rows.Count > 0)
                {
                    int selectedrow = gdvCategory.CurrentCell.RowIndex;
                    DataGridViewRow selectRow = gdvCategory.Rows[gdvCategory.CurrentCell.RowIndex];

                    clear();
                    dt = null;
                    //dt = Biz_Doctors.getDataTable(" and DoctorID = " + selectRow.Cells["DoctorID"].Value.ToString());
                    dt = new Bll.AddressBook().GetAllCatagories(" and CategoryID = " + selectRow.Cells["CategoryID"].Value.ToString() + "");
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

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            clear();
            btSave.Text = "Save";
            btSave.Enabled = false;
            btNew.Enabled = true;
            EnableSearch(true);
            btCancel.Enabled = false;
            this.txtNameSearch.Focus();
        }

        private void gdvCategory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedColumn = gdvCategory.CurrentCell.ColumnIndex;
                DataGridViewColumn selectcolumn = gdvCategory.Columns[selectedColumn];

                if (this.gdvCategory.Rows.Count == 1)
                {
                    gdvCategory_SelectionChanged_1(sender, e);
                }

                if (selectcolumn.HeaderText == "Edit")
                {
                    btSave.Enabled = true;
                    btSave.Text = "Update";
                    Edit();
                    EnableSearch(false);
                    btCancel.Enabled = true;
                    txtCategoryName.Focus();
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

        private void btNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                clear();
                btSave.Text = "Save";
                btSave.Enabled = true;
                btNew.Enabled = false;
                EnableSearch(false);
                btCancel.Enabled = true;
                //MaxID();
            }
            catch (Exception Exception)
            {
                MessageBox.Show("SQL Error\n" + Exception + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.txtCategoryName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdvCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            var dataGridView = (sender as DataGridView);
            if (gdvCategory.Columns["Editor"].Index == e.ColumnIndex || gdvCategory.Columns["Delete"].Index == e.ColumnIndex)
            {
                dataGridView.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridView.Cursor = Cursors.Default;
            }
        }

        private void FrmCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
