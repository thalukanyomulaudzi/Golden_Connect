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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.AllowUserToDeleteRows = false;
            this.dgvDeliveries.ColumnHeadersHeight = 34;
            this.dgvDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveries.Location = new System.Drawing.Point(0, 45);
            this.dgvDeliveries.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly = true;
            this.dgvDeliveries.RowHeadersVisible = false;
            this.dgvDeliveries.RowTemplate.Height = 30;
            this.dgvDeliveries.Size = new System.Drawing.Size(665, 352);
            this.dgvDeliveries.TabIndex = 3;
            this.dgvDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDeliveries_CellContentClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Order Delivery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeliverOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 397);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeliverOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order for Delivery";
            this.Activated += new System.EventHandler(this.DeliverOrder_Activated);
            this.Load += new System.EventHandler(this.DeliverOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Label label1;
    }
}