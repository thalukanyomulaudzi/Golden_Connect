namespace Design370
{
    partial class inventory_Stock_On_Hand
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
            this.inventoryStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryStock
            // 
            this.inventoryStock.ActiveViewIndex = -1;
            this.inventoryStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.inventoryStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryStock.Location = new System.Drawing.Point(0, 0);
            this.inventoryStock.Name = "inventoryStock";
            this.inventoryStock.Size = new System.Drawing.Size(947, 537);
            this.inventoryStock.TabIndex = 0;
            // 
            // inventory_Stock_On_Hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 537);
            this.Controls.Add(this.inventoryStock);
            this.Name = "inventory_Stock_On_Hand";
            this.Text = "inventory_Stock_On_Hand";
            this.Load += new System.EventHandler(this.Inventory_Stock_On_Hand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer inventoryStock;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}