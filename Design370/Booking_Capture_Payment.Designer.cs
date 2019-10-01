namespace Design370
{
    partial class Booking_Capture_Payment
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
            this.btnBookingPaymentCapture = new System.Windows.Forms.Button();
            this.dgvBookingPayments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBookingAmountAfterPayment = new System.Windows.Forms.TextBox();
            this.txtBookingOutstandingTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingPaymentAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookingPaymentCapture
            // 
            this.btnBookingPaymentCapture.Location = new System.Drawing.Point(252, 422);
            this.btnBookingPaymentCapture.Name = "btnBookingPaymentCapture";
            this.btnBookingPaymentCapture.Size = new System.Drawing.Size(163, 34);
            this.btnBookingPaymentCapture.TabIndex = 0;
            this.btnBookingPaymentCapture.Text = "Capture Payment";
            this.btnBookingPaymentCapture.UseVisualStyleBackColor = true;
            // 
            // dgvBookingPayments
            // 
            this.dgvBookingPayments.AllowUserToAddRows = false;
            this.dgvBookingPayments.AllowUserToDeleteRows = false;
            this.dgvBookingPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookingPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentCustomer,
            this.paymentAmount,
            this.paymentDate});
            this.dgvBookingPayments.Location = new System.Drawing.Point(33, 77);
            this.dgvBookingPayments.Name = "dgvBookingPayments";
            this.dgvBookingPayments.ReadOnly = true;
            this.dgvBookingPayments.RowHeadersVisible = false;
            this.dgvBookingPayments.Size = new System.Drawing.Size(382, 190);
            this.dgvBookingPayments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Past payments toward booking";
            // 
            // PaymentCustomer
            // 
            this.PaymentCustomer.HeaderText = "Customer Name";
            this.PaymentCustomer.Name = "PaymentCustomer";
            this.PaymentCustomer.ReadOnly = true;
            // 
            // paymentAmount
            // 
            this.paymentAmount.HeaderText = "Amount";
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.ReadOnly = true;
            // 
            // paymentDate
            // 
            this.paymentDate.HeaderText = "Payment Date";
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.ReadOnly = true;
            // 
            // txtBookingAmountAfterPayment
            // 
            this.txtBookingAmountAfterPayment.Enabled = false;
            this.txtBookingAmountAfterPayment.Location = new System.Drawing.Point(225, 373);
            this.txtBookingAmountAfterPayment.Name = "txtBookingAmountAfterPayment";
            this.txtBookingAmountAfterPayment.Size = new System.Drawing.Size(190, 24);
            this.txtBookingAmountAfterPayment.TabIndex = 3;
            // 
            // txtBookingOutstandingTotal
            // 
            this.txtBookingOutstandingTotal.Enabled = false;
            this.txtBookingOutstandingTotal.Location = new System.Drawing.Point(225, 297);
            this.txtBookingOutstandingTotal.Name = "txtBookingOutstandingTotal";
            this.txtBookingOutstandingTotal.Size = new System.Drawing.Size(190, 24);
            this.txtBookingOutstandingTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total outstanding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total after this payment";
            // 
            // txtBookingPaymentAmount
            // 
            this.txtBookingPaymentAmount.Location = new System.Drawing.Point(225, 335);
            this.txtBookingPaymentAmount.Name = "txtBookingPaymentAmount";
            this.txtBookingPaymentAmount.Size = new System.Drawing.Size(190, 24);
            this.txtBookingPaymentAmount.TabIndex = 7;
            this.txtBookingPaymentAmount.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "This payment";
            // 
            // Booking_Capture_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookingPaymentAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookingOutstandingTotal);
            this.Controls.Add(this.txtBookingAmountAfterPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBookingPayments);
            this.Controls.Add(this.btnBookingPaymentCapture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Booking_Capture_Payment";
            this.Text = "Booking_Capture_Payment";
            this.Load += new System.EventHandler(this.Booking_Capture_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookingPaymentCapture;
        private System.Windows.Forms.DataGridView dgvBookingPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDate;
        private System.Windows.Forms.TextBox txtBookingAmountAfterPayment;
        private System.Windows.Forms.TextBox txtBookingOutstandingTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingPaymentAmount;
        private System.Windows.Forms.Label label4;
    }
}