using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViX
{
    public partial class ReportDetails : Form
    {
        WhistleBlowerReport whistleBlower;
        public ReportDetails(WhistleBlowerReport whistleBlower )
        {
            InitializeComponent();
            this.whistleBlower = whistleBlower;
            
        }

        private void ReportDetails_Load(object sender, EventArgs e)
        {
            Utils.CreateRoundedCorners(this, this.Width, this.Height);
            Task.Run(() =>
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.labelDate.Text = this.whistleBlower.date;
                            this.labelRiskLevel.Text = this.whistleBlower.riskLevel + "";
                            this.labelDefendant.Text = this.whistleBlower.defendant;
                            //this.labelState.Text = this.whistleBlower.state;
                            this.labelReportTitle.Text = this.whistleBlower.reporttitle;
                            this.labelRID.Text = this.whistleBlower.RID;
                            this.richTextBox1.Text = this.whistleBlower.report;
                            
                        });
                    }
                    catch (Exception ex) { }
                });

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
