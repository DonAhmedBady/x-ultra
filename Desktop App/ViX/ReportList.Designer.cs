namespace ViX
{
    partial class ReportList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRiskLevel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDefendant = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelReportTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelSate = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelRID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.labelNo);
            this.panel1.Location = new System.Drawing.Point(823, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 59);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.ForeColor = System.Drawing.Color.White;
            this.labelNo.Location = new System.Drawing.Point(12, 24);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(29, 13);
            this.labelNo.TabIndex = 0;
            this.labelNo.Text = "الرقم";
            this.labelNo.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Location = new System.Drawing.Point(706, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(0, 23);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "التاريخ";
            this.labelDate.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.labelRiskLevel);
            this.panel3.Location = new System.Drawing.Point(599, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 59);
            this.panel3.TabIndex = 2;
            // 
            // labelRiskLevel
            // 
            this.labelRiskLevel.AutoSize = true;
            this.labelRiskLevel.ForeColor = System.Drawing.Color.White;
            this.labelRiskLevel.Location = new System.Drawing.Point(17, 23);
            this.labelRiskLevel.Name = "labelRiskLevel";
            this.labelRiskLevel.Size = new System.Drawing.Size(69, 13);
            this.labelRiskLevel.TabIndex = 8;
            this.labelRiskLevel.Text = "درجه الخطوره";
            this.labelRiskLevel.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.labelDefendant);
            this.panel4.Location = new System.Drawing.Point(396, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 59);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelDefendant
            // 
            this.labelDefendant.AutoSize = true;
            this.labelDefendant.ForeColor = System.Drawing.Color.White;
            this.labelDefendant.Location = new System.Drawing.Point(64, 23);
            this.labelDefendant.Name = "labelDefendant";
            this.labelDefendant.Size = new System.Drawing.Size(70, 13);
            this.labelDefendant.TabIndex = 9;
            this.labelDefendant.Text = "المشتكي عليه";
            this.labelDefendant.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.labelReportTitle);
            this.panel5.Location = new System.Drawing.Point(223, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 59);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelReportTitle
            // 
            this.labelReportTitle.AutoSize = true;
            this.labelReportTitle.ForeColor = System.Drawing.Color.White;
            this.labelReportTitle.Location = new System.Drawing.Point(43, 24);
            this.labelReportTitle.Name = "labelReportTitle";
            this.labelReportTitle.Size = new System.Drawing.Size(75, 13);
            this.labelReportTitle.TabIndex = 12;
            this.labelReportTitle.Text = "عنوان الشكوى";
            this.labelReportTitle.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel6.Controls.Add(this.labelSate);
            this.panel6.Location = new System.Drawing.Point(117, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 59);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelSate
            // 
            this.labelSate.AutoSize = true;
            this.labelSate.ForeColor = System.Drawing.Color.White;
            this.labelSate.Location = new System.Drawing.Point(16, 23);
            this.labelSate.Name = "labelSate";
            this.labelSate.Size = new System.Drawing.Size(68, 13);
            this.labelSate.TabIndex = 11;
            this.labelSate.Text = "لم تتم معالجته";
            this.labelSate.Click += new System.EventHandler(this.reportList_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel7.Controls.Add(this.labelRID);
            this.panel7.Location = new System.Drawing.Point(11, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(102, 59);
            this.panel7.TabIndex = 5;
            this.panel7.Click += new System.EventHandler(this.reportList_Click);
            // 
            // labelRID
            // 
            this.labelRID.AutoSize = true;
            this.labelRID.ForeColor = System.Drawing.Color.White;
            this.labelRID.Location = new System.Drawing.Point(26, 23);
            this.labelRID.Name = "labelRID";
            this.labelRID.Size = new System.Drawing.Size(50, 13);
            this.labelRID.TabIndex = 12;
            this.labelRID.Text = "رقم البلاغ";
            this.labelRID.Click += new System.EventHandler(this.reportList_Click);
            // 
            // ReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportList";
            this.Size = new System.Drawing.Size(881, 71);
            this.Click += new System.EventHandler(this.reportList_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRiskLevel;
        private System.Windows.Forms.Label labelDefendant;
        private System.Windows.Forms.Label labelReportTitle;
        private System.Windows.Forms.Label labelSate;
        private System.Windows.Forms.Label labelRID;
    }
}
