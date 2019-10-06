namespace Design370
{
    partial class CustomerReportList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // customerReport
            // 
            this.customerReport.ActiveViewIndex = -1;
            this.customerReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerReport.Location = new System.Drawing.Point(0, 0);
            this.customerReport.Name = "customerReport";
            this.customerReport.Size = new System.Drawing.Size(800, 535);
            this.customerReport.TabIndex = 0;
            // 
            // CustomerReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.customerReport);
            this.Name = "CustomerReportList";
            this.Text = "CustomerReportList";
            this.Load += new System.EventHandler(this.CustomerReportList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer customerReport;
    }
}