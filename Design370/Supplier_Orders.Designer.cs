namespace Design370
{
    partial class Supplier_Orders
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
            this.dgvSupplierOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReceiveSupplierOrder = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplierOrders
            // 
            this.dgvSupplierOrders.AllowUserToAddRows = false;
            this.dgvSupplierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dgvSupplierOrders.Location = new System.Drawing.Point(1, 57);
            this.dgvSupplierOrders.Name = "dgvSupplierOrders";
            this.dgvSupplierOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierOrders.Size = new System.Drawing.Size(571, 218);
            this.dgvSupplierOrders.TabIndex = 88;
            this.dgvSupplierOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierOrders_CellContentClick_2);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "supplier_order_id";
            this.Column1.HeaderText = "Order No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "supplier_name";
            this.Column4.HeaderText = "Supplier Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "supplier_order_date_placed";
            this.Column2.HeaderText = "Date Placed";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order Details";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Text = "View";
            this.Column3.UseColumnTextForButtonValue = true;
            this.Column3.Width = 120;
            // 
            // btnReceiveSupplierOrder
            // 
            this.btnReceiveSupplierOrder.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveSupplierOrder.Location = new System.Drawing.Point(623, 8);
            this.btnReceiveSupplierOrder.Name = "btnReceiveSupplierOrder";
            this.btnReceiveSupplierOrder.Size = new System.Drawing.Size(189, 28);
            this.btnReceiveSupplierOrder.TabIndex = 87;
            this.btnReceiveSupplierOrder.Text = "Received Supplier Orders";
            this.btnReceiveSupplierOrder.UseVisualStyleBackColor = true;
            this.btnReceiveSupplierOrder.Click += new System.EventHandler(this.btnReceiveSupplierOrder_Click_2);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 86;
            this.label14.Text = "Search:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(67, 10);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 26);
            this.textBox7.TabIndex = 85;
            this.textBox7.Text = " ";
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(818, 8);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(158, 28);
            this.button14.TabIndex = 84;
            this.button14.Text = "Place Supplier Order";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_2);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column5});
            this.dgvDisplay.Location = new System.Drawing.Point(578, 57);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(403, 218);
            this.dgvDisplay.TabIndex = 89;
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "supplier_order_line_quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Receive";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 70;
            // 
            // Supplier_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 311);
            this.Controls.Add(this.dgvSupplierOrders);
            this.Controls.Add(this.btnReceiveSupplierOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dgvDisplay);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier_Orders";
            this.Text = "Supplier Orders";
            this.Load += new System.EventHandler(this.Supplier_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplierOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Button btnReceiveSupplierOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}