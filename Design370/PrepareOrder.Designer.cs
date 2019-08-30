namespace Design370
{
    partial class PrepareOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrepareCustomerOrder = new System.Windows.Forms.DataGridView();
            this.PrepareCustOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewProducts = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepareCustomerOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepare Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrepareCustomerOrder
            // 
            this.dgvPrepareCustomerOrder.ColumnHeadersHeight = 34;
            this.dgvPrepareCustomerOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrepareCustOrder,
            this.ViewProducts});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrepareCustomerOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrepareCustomerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrepareCustomerOrder.Location = new System.Drawing.Point(0, 65);
            this.dgvPrepareCustomerOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPrepareCustomerOrder.Name = "dgvPrepareCustomerOrder";
            this.dgvPrepareCustomerOrder.RowTemplate.Height = 30;
            this.dgvPrepareCustomerOrder.Size = new System.Drawing.Size(733, 393);
            this.dgvPrepareCustomerOrder.TabIndex = 1;
            this.dgvPrepareCustomerOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrepareCustomerOrder_CellContentClick);
            // 
            // PrepareCustOrder
            // 
            this.PrepareCustOrder.HeaderText = "";
            this.PrepareCustOrder.Name = "PrepareCustOrder";
            this.PrepareCustOrder.Text = "Prepare Order";
            this.PrepareCustOrder.UseColumnTextForButtonValue = true;
            this.PrepareCustOrder.Width = 125;
            // 
            // ViewProducts
            // 
            this.ViewProducts.HeaderText = "";
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.Text = "View Products";
            this.ViewProducts.UseColumnTextForButtonValue = true;
            this.ViewProducts.Width = 150;
            // 
            // PrepareOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 458);
            this.Controls.Add(this.dgvPrepareCustomerOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "PrepareOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrepareOrder";
            this.Load += new System.EventHandler(this.PrepareOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepareCustomerOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrepareCustomerOrder;
        private System.Windows.Forms.DataGridViewButtonColumn PrepareCustOrder;
        private System.Windows.Forms.DataGridViewButtonColumn ViewProducts;
    }
}