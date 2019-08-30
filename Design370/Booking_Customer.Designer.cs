namespace Design370
{
    partial class Booking_Customer
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
            this.dgvBookingCustomer = new System.Windows.Forms.DataGridView();
            this.CustFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingCustomer
            // 
            this.dgvBookingCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustFirst,
            this.CustLast,
            this.CustID,
            this.CustView,
            this.CustEdit,
            this.CustDelete});
            this.dgvBookingCustomer.Location = new System.Drawing.Point(25, 76);
            this.dgvBookingCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookingCustomer.Name = "dgvBookingCustomer";
            this.dgvBookingCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingCustomer.Size = new System.Drawing.Size(732, 310);
            this.dgvBookingCustomer.TabIndex = 65;
            this.dgvBookingCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookingAdd_CellContentClick);
            // 
            // CustFirst
            // 
            this.CustFirst.HeaderText = "First name";
            this.CustFirst.Name = "CustFirst";
            // 
            // CustLast
            // 
            this.CustLast.HeaderText = "Last name";
            this.CustLast.Name = "CustLast";
            // 
            // CustID
            // 
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            // 
            // CustView
            // 
            this.CustView.HeaderText = "";
            this.CustView.Name = "CustView";
            // 
            // CustEdit
            // 
            this.CustEdit.HeaderText = "";
            this.CustEdit.Name = "CustEdit";
            // 
            // CustDelete
            // 
            this.CustDelete.HeaderText = "";
            this.CustDelete.Name = "CustDelete";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 18);
            this.label18.TabIndex = 62;
            this.label18.Text = "Search:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(109, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(265, 25);
            this.textBox9.TabIndex = 61;
            this.textBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // button20
            // 
            this.button20.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button20.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(569, 416);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(188, 35);
            this.button20.TabIndex = 60;
            this.button20.Text = "Select customer";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Booking_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 490);
            this.Controls.Add(this.dgvBookingCustomer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button20);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking_Customer";
            this.Text = "Select customer";
            this.Activated += new System.EventHandler(this.Booking_Customer_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Customer_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingCustomer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewButtonColumn CustView;
        private System.Windows.Forms.DataGridViewButtonColumn CustEdit;
        private System.Windows.Forms.DataGridViewButtonColumn CustDelete;
    }
}