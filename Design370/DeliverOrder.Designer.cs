namespace Design370
{
    partial class DeliverOrder
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
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PrepareCustOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.ColumnHeadersHeight = 34;
            this.dgvDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrepareCustOrder});
            this.dgvDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveries.Location = new System.Drawing.Point(0, 65);
            this.dgvDeliveries.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowTemplate.Height = 30;
            this.dgvDeliveries.Size = new System.Drawing.Size(885, 434);
            this.dgvDeliveries.TabIndex = 3;
            this.dgvDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDeliveries_CellContentClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Order Delivery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrepareCustOrder
            // 
            this.PrepareCustOrder.HeaderText = "";
            this.PrepareCustOrder.Name = "PrepareCustOrder";
            this.PrepareCustOrder.Text = "Order Delivered";
            this.PrepareCustOrder.UseColumnTextForButtonValue = true;
            this.PrepareCustOrder.Width = 150;
            // 
            // DeliverOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 499);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookshelf Symbol 7", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "DeliverOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliverOrder";
            this.Load += new System.EventHandler(this.DeliverOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn PrepareCustOrder;
    }
}