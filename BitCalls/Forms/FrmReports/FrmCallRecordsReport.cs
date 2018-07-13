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
    public partial class FrmCallRecordsReport : Form
    {
        public FrmCallRecordsReport()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void FrmCallRecordsReport_Load(object sender, EventArgs e)
        {   
            //load cbo for persones
            dt = new Bll.CallRecords().GetPersons("");
            DataRow rowCatagories = dt.NewRow();
            rowCatagories["PersonName"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);
            cbxContactPerson.DataSource = dt;
            cbxContactPerson.SelectedIndex = 0;
            //load cbo for persones

            ////load compaies
            //dt = new Bll.AddressBook().GetCompany(" and CompanyName is not null group by CompanyName");

            //rowCatagories = dt.NewRow();
            //rowCatagories["CompanyName"] = "All";
            //dt.Rows.InsertAt(rowCatagories, 0);

            //this.cbxCompany.DataSource = dt;
            //cbxCompany.SelectedIndex = 0;
            ////load compaies

            //load cbo of city
            dt = new Bll.AddressBook().GetCity(" and City is not null group by city");

            rowCatagories = dt.NewRow();
            rowCatagories["City"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cbxCity.DataSource = dt;
            cbxCity.SelectedIndex = 0;
            //load cbo of city

            ///LOAD CBO CATAGORY
            dt = new Bll.AddressBook().GetAllCatagories("");
            rowCatagories = dt.NewRow();
            rowCatagories["CategoryID"] = "0";
            rowCatagories["CategoryName"] = "All";
            dt.Rows.InsertAt(rowCatagories, 0);

            this.cbxCategory.DataSource = dt;
            this.cbxCategory.SelectedIndex = 0;
            ///LOAD CBO CATAGORY

            this.cbxCallStatusSearch.SelectedIndex = 0;
            this.CbxOutgoing.SelectedIndex = 0;
                        
            this.dtFromDateTime.Value = DateTime.Today.AddHours(00.00);
            this.dtToDateTime.Value = DateTime.Today.AddHours(23.59);
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            //string strWherex =this.dtFromDateTime.Value.ToString();

            ReportDocument rd = new ReportDocument();
            rd.Load(Application.StartupPath + "\\Reports\\rptCallRecordsReport.rpt");

            string strWhere = "";
            if (cbxContactPerson.SelectedIndex>0)
            {
                strWhere += " and car.CallingPerson='"+this.cbxContactPerson.Text+"'";
            }

            strWhere += " and CONVERT(datetime,'" + this.dtFromDateTime.Value.ToString() + "')<=car.CallDateTime";
            strWhere += " and CONVERT(datetime,'"+this.dtToDateTime.Value.ToString()+"')>=car.CallDateTime";

            //if (this.chbxIsOutgoing.Checked)
            //{
            //    if (this.rdbIsOutGoing.Checked)
            //    {
            //        strWhere += " and IsOutgoing=1";
            //    }
            //    else
            //    {
            //        strWhere += " and IsOutgoing=0";
            //    }
            //}

            if (this.CbxOutgoing.SelectedIndex>0)
            {
                if (CbxOutgoing.Text=="OutGoing")
                {
                    strWhere += " and IsOutgoing=1";
                }
                else
                {
                    strWhere += " and IsOutgoing=0";
                }
            }

            //if (this.cbxCompany.SelectedIndex>0)
            //{
            //    strWhere += " and CompanyName='"+this.cbxCompany.Text+"'";
            //}

            if (this.cbxCity.SelectedIndex>0)
            {
                strWhere += " and City='"+this.cbxCity.Text+"'";
            }

            if (this.cbxCategory.SelectedIndex>0)
            {
                strWhere += " and car.CategoryID="+cbxCategory.SelectedValue+"";
            }
            
            if (this.cbxCallStatusSearch.SelectedIndex > 0)
            {
                strWhere += " and CallStatus='" + this.cbxCallStatusSearch.Text + "'";
            }

            //DataTable dt = new Bll.CallRecords().GetGrideData(strWhere);

            rd.Database.Tables[0].SetDataSource(new Bll.CallRecords().GetGrideData(strWhere));
            
            ///////////para
            var prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "Calling Person: " + this.cbxContactPerson.Text + "";
            rd.ParameterFields["CallingPerson"].CurrentValues.Clear();
            rd.ParameterFields["CallingPerson"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "From DateTime: " + this.dtFromDateTime.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") + "";
            rd.ParameterFields["FromDateTime"].CurrentValues.Clear();
            rd.ParameterFields["FromDateTime"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "To DateTime: " + this.dtToDateTime.Value.ToString("dd-MMM-yyyy hh:mm:ss tt") + "";
            rd.ParameterFields["ToDateTime"].CurrentValues.Clear();
            rd.ParameterFields["ToDateTime"].CurrentValues.Add(prmRpt);

            
                prmRpt = new ParameterDiscreteValue();
                //if (this.chbxIsOutgoing.Checked)
                //{
                //    if (this.rdbIsOutGoing.Checked)
                //    {
                //        prmRpt.Value = "Is Outgoing:";
                //    }
                //    else
                //    {
                //        prmRpt.Value = "Is Incoming:";
                //    }
                //}
                //else
                //{
                //    prmRpt.Value = "Outgoing & Incoming:";
                //}
                if (this.CbxOutgoing.SelectedIndex > 0)
                {
                    if (this.CbxOutgoing.Text == "OutGoing")
                    {
                        prmRpt.Value = "Is Outgoing:";
                    }
                    else
                    {
                        prmRpt.Value = "Is Incoming:";
                    }
                }
                else
                {
                    prmRpt.Value = "Outgoing & Incoming:";
                }

                rd.ParameterFields["IsOutgoing"].CurrentValues.Clear();
                rd.ParameterFields["IsOutgoing"].CurrentValues.Add(prmRpt);


                //prmRpt = new ParameterDiscreteValue();
                //prmRpt.Value = "Company Name: " + this.cbxCompany.Text + "";
                //rd.ParameterFields["CompanyName"].CurrentValues.Clear();
                //rd.ParameterFields["CompanyName"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "City: " + this.cbxCity.Text + "";
            rd.ParameterFields["City"].CurrentValues.Clear();
            rd.ParameterFields["City"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "Category: " + this.cbxCategory.Text + "";
            rd.ParameterFields["Category"].CurrentValues.Clear();
            rd.ParameterFields["Category"].CurrentValues.Add(prmRpt);

            prmRpt = new ParameterDiscreteValue();
            prmRpt.Value = "Status: " + this.cbxCallStatusSearch.Text + "";
            rd.ParameterFields["Status"].CurrentValues.Clear();
            rd.ParameterFields["Status"].CurrentValues.Add(prmRpt);

            ///////////para

            RptViewer rptv = new RptViewer();
            rptv.rptRD1 = rd;
            rptv.rptTitle = "Address Book";
            rptv.ShowDialog();

        }

        private void chbxIsOutgoing_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.chbxIsOutgoing.Checked)
            //{
            //    this.groupBox1.Enabled = true;
            //}
            //else
            //{
            //    this.groupBox1.Enabled = false;
            //}
        }

        private void FrmCallRecordsReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


    }
}
