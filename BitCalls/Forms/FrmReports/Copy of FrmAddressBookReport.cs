using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BitCalls.Forms.FrmReports
{
    public partial class FrmAddressBookReport : Form
    {
        public FrmAddressBookReport()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void FrmAddressBookReport_Load(object sender, EventArgs e)
        {
            ///LOAD CBO CATAGORY
            /////////option 1
            dt = new Bll.AddressBook().GetAllCatagories("");
            DataRow rowCatagories = dt.NewRow();
            rowCatagories["CategoryID"] = "0";
            rowCatagories["CategoryName"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cbxCategory.DataSource = dt;

            this.cbxCategory.SelectedIndex = 0;
            ///LOAD CBO CATAGORY
          


            //load cbo of city
            dt = new Bll.AddressBook().GetCity(" and City is not null group by city");

            rowCatagories = dt.NewRow();
            rowCatagories["City"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cboCity.DataSource = dt;
            //load cbo of city

            //load compaies
            dt = new Bll.AddressBook().GetCompany(" and CompanyName is not null group by CompanyName");

            rowCatagories = dt.NewRow();
            rowCatagories["CompanyName"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cbxCompany.DataSource = dt;
            //load compaies

        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Application.StartupPath + "\\Reports\\rptAddressReport.rpt");


            string searchQury = @"select con.* ,cat.CategoryName from Contacts con inner join Category cat on con.CategoryID=cat.CategoryID where 1=1";

            if (this.cbxCompany.SelectedIndex>0)
            {
                searchQury += " and con.CompanyName='"+this.cbxCompany.Text+"'";
            }

            if (this.cboCity.SelectedIndex>0)
            {
                searchQury += " and con.City='"+this.cboCity.Text+"'";
            }

            if (this.cbxCategory.SelectedIndex > 0)
            {
                searchQury += " and cat.CategoryID=" + this.cbxCategory.SelectedValue + "";
            }

            rd.Database.Tables[0].SetDataSource(new Bll.AddressBook().GetGridSearch(searchQury));
            //rd.SetDataSource(new Bll.AddressBook().GetGridSearch(searchQury));
            
            /////////para
            var prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "Company Name: " + this.cbxCompany.Text + "";
            rd.ParameterFields["prmCompany"].CurrentValues.Clear();
            rd.ParameterFields["prmCompany"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "City: " + this.cboCity.Text + "";
            rd.ParameterFields["prmCity"].CurrentValues.Clear();
            rd.ParameterFields["prmCity"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "Category: " + this.cbxCategory.Text + "";
            rd.ParameterFields["prmCategory"].CurrentValues.Clear();
            rd.ParameterFields["prmCategory"].CurrentValues.Add(prmRpt);
            /////////para
            
            RptViewer rptv = new RptViewer();
            rptv.rptRD1 = rd;
            rptv.rptTitle = "Address Book";
            rptv.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddressBookReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
