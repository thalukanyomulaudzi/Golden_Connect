namespace Design370
{
    partial class Customer_Order_Payment
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
            this.dgvOrderPayment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderPayment
            // 
            this.dgvOrderPayment.AllowUserToAddRows = false;
            this.dgvOrderPayment.AllowUserToDeleteRows = false;
            this.dgvOrderPayment.ColumnHeadersHeight = 34;
            this.dgvOrderPayment.Location = new System.Drawing.Point(1, 59);
            this.dgvOrderPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderPayment.Name = "dgvOrderPayment";
            this.dgvOrderPayment.ReadOnly = true;
            this.dgvOrderPayment.RowHeadersVisible = false;
            this.dgvOrderPayment.Size = new System.Drawing.Size(732, 483);
            this.dgvOrderPayment.TabIndex = 0;
            this.dgvOrderPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderPayment_CellContentClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "ORDER ID : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(810, 107);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(86, 19);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "Select Order";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "ORDER TOTAL : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOT.Location = new System.Drawing.Point(841, 134);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(86, 19);
            this.lblOT.TabIndex = 2;
            this.lblOT.Text = "Select Order";
            this.lblOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "PAYMENT DATE : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDate.Location = new System.Drawing.Point(846, 161);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(86, 19);
            this.lblPayDate.TabIndex = 2;
            this.lblPayDate.Text = "Select Order";
            this.lblPayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(740, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "PAYMENT AMOUNT : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(870, 187);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(126, 26);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // Customer_Order_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 542);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.lblOT);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderPayment);
            this.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer_Order_Payment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Order Payment";
            this.Load += new System.EventHandler(this.Customer_Order_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
    }
}