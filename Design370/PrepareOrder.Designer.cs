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
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepareCustomerOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepare Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrepareCustomerOrder
            // 
            this.dgvPrepareCustomerOrder.AllowUserToAddRows = false;
            this.dgvPrepareCustomerOrder.AllowUserToDeleteRows = false;
            this.dgvPrepareCustomerOrder.ColumnHeadersHeight = 34;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrepareCustomerOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrepareCustomerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrepareCustomerOrder.Location = new System.Drawing.Point(0, 62);
            this.dgvPrepareCustomerOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrepareCustomerOrder.Name = "dgvPrepareCustomerOrder";
            this.dgvPrepareCustomerOrder.ReadOnly = true;
            this.dgvPrepareCustomerOrder.RowHeadersVisible = false;
            this.dgvPrepareCustomerOrder.RowTemplate.Height = 30;
            this.dgvPrepareCustomerOrder.Size = new System.Drawing.Size(807, 419);
            this.dgvPrepareCustomerOrder.TabIndex = 1;
            this.dgvPrepareCustomerOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrepareCustomerOrder_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(6, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 33);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Orders";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // PrepareOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 481);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvPrepareCustomerOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "PrepareOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare Order";
            this.Activated += new System.EventHandler(this.PrepareOrder_Activated);
            this.Load += new System.EventHandler(this.PrepareOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepareCustomerOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrepareCustomerOrder;
        private System.Windows.Forms.Button btnExport;
    }
}