using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BitCalls.Forms.FrmReports
{
    public partial class RptViewer : Form
    {
        public ReportDocument rptRD1 { get; set; }
        public String rptTitle { get; set; }

        public RptViewer()
        {
            InitializeComponent();
        }

        private void RptViewer_Load(object sender, EventArgs e)
        {
            this.Text = rptTitle;

            crystalReportViewer1.ReportSource = rptRD1;
            this.Refresh();
        }
    }
}
