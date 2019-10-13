namespace Design370
{
    partial class supplierOrderReport
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
            this.supplierOrderRep = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // supplierOrderRep
            // 
            this.supplierOrderRep.ActiveViewIndex = -1;
            this.supplierOrderRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierOrderRep.Cursor = System.Windows.Forms.Cursors.Default;
            this.supplierOrderRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierOrderRep.Location = new System.Drawing.Point(0, 0);
            this.supplierOrderRep.Name = "supplierOrderRep";
            this.supplierOrderRep.Size = new System.Drawing.Size(868, 517);
            this.supplierOrderRep.TabIndex = 0;
            // 
            // supplierOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 517);
            this.Controls.Add(this.supplierOrderRep);
            this.Name = "supplierOrderReport";
            this.Text = "supplierOrderReport";
            this.Load += new System.EventHandler(this.SupplierOrderReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer supplierOrderRep;
    }
}