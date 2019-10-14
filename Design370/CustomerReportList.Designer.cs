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
            this.components = new System.ComponentModel.Container();
            this.customerReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReport
            // 
            this.customerReport.ActiveViewIndex = -1;
            this.customerReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerReport.Location = new System.Drawing.Point(0, 59);
            this.customerReport.Name = "customerReport";
            this.customerReport.Size = new System.Drawing.Size(925, 547);
            this.customerReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Month : ";
            // 
            // cbxMonth
            // 
            this.cbxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbxMonth.Location = new System.Drawing.Point(119, 21);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(159, 24);
            this.cbxMonth.TabIndex = 2;
            this.cbxMonth.SelectedIndexChanged += new System.EventHandler(this.CbxMonth_SelectedIndexChanged);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateReport.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(284, 20);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(129, 26);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            // 
            // CustomerReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 606);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerReport);
            this.Name = "CustomerReportList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer ReportList";
            this.Load += new System.EventHandler(this.CustomerReportList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer customerReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Button btnGenerateReport;
        public System.Windows.Forms.BindingSource bindingSource1;
    }
}