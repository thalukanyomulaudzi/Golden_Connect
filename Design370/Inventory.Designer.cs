namespace Design370
{
    partial class Inventory
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
            this.inv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productstockquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsOnHandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOnHandBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inv
            // 
            this.inv.ActiveViewIndex = -1;
            this.inv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inv.Cursor = System.Windows.Forms.Cursors.Default;
            this.inv.Location = new System.Drawing.Point(1, 0);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(924, 536);
            this.inv.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productstockquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsOnHandBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(21, 16);
            this.dataGridView1.TabIndex = 1;
            // 
            // productstockquantityDataGridViewTextBoxColumn
            // 
            this.productstockquantityDataGridViewTextBoxColumn.DataPropertyName = "product_stock_quantity";
            this.productstockquantityDataGridViewTextBoxColumn.HeaderText = "product_stock_quantity";
            this.productstockquantityDataGridViewTextBoxColumn.Name = "productstockquantityDataGridViewTextBoxColumn";
            // 
            // productsOnHandBindingSource1
            // 
            this.productsOnHandBindingSource1.DataSource = typeof(Design370.ProductsOnHand);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inv);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsOnHandBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer inv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productstockquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsOnHandBindingSource1;
    }
}