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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.btnClose.Anchor = AnchorStyles.Left;
            this.btnMinimize.Anchor = AnchorStyles.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CreateRoundedCorners(this, this.Width, this.Height);
            }
            catch (Exception) { }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control) sender;
            control.BackColor = Color.Green;
        }

        private void label3_click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void new_reports_click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnReportsHistory_Click(object sender, EventArgs e)
        {
            new Form2(@"D:\X-ULTRA\data").Show();
        }

    }
}
