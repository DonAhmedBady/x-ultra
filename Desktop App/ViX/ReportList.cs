using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViX
{
    public partial class ReportList : UserControl
    {
        WhistleBlowerReport whistleBlower;
        public ReportList(WhistleBlowerReport whistleBlower , int reportsCount)
        {
            InitializeComponent();
            this.whistleBlower = whistleBlower;
            this.labelNo.Text = reportsCount + "";
            this.labelDate.Text = whistleBlower.date;
            this.labelRiskLevel.Text = whistleBlower.riskLevel + "";
            this.labelDefendant.Text = whistleBlower.defendant;
            this.labelReportTitle.Text = whistleBlower.reporttitle;
            labelRID.Text = whistleBlower.RID;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reportList_Click(object sender, EventArgs e)
        {
            new ReportDetails(this.whistleBlower).Show();
        }
    }
}
