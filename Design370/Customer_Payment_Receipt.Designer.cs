namespace Design370
{
    partial class Customer_Payment_Receipt
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
            this.customerOrderReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // customerOrderReceipt
            // 
            this.customerOrderReceipt.ActiveViewIndex = -1;
            this.customerOrderReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerOrderReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerOrderReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrderReceipt.Location = new System.Drawing.Point(0, 0);
            this.customerOrderReceipt.Name = "customerOrderReceipt";
            this.customerOrderReceipt.Size = new System.Drawing.Size(891, 578);
            this.customerOrderReceipt.TabIndex = 0;
            // 
            // Customer_Payment_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 578);
            this.Controls.Add(this.customerOrderReceipt);
            this.Name = "Customer_Payment_Receipt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Payment Receipt";
            this.Load += new System.EventHandler(this.Customer_Payment_Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer customerOrderReceipt;
    }
}