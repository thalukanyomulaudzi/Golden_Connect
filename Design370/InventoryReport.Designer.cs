namespace Design370
{
    partial class InventoryReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rChat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Design370.ProductsOnHand);
            // 
            // rChat
            // 
            this.rChat.ActiveViewIndex = -1;
            this.rChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.rChat.Location = new System.Drawing.Point(12, 12);
            this.rChat.Name = "rChat";
            this.rChat.Size = new System.Drawing.Size(832, 449);
            this.rChat.TabIndex = 1;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 528);
            this.Controls.Add(this.rChat);
            this.Controls.Add(this.button1);
            this.Name = "InventoryReport";
            this.Text = "InventoryReport";
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rChat;
    }
}