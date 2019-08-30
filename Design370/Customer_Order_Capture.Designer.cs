namespace Design370
{
    partial class Customer_Order_Capture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.lblOID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID : ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Payment Amount : ";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(210, 293);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(154, 28);
            this.txtAmount.TabIndex = 3;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePayment.Location = new System.Drawing.Point(210, 336);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(154, 37);
            this.btnSavePayment.TabIndex = 4;
            this.btnSavePayment.Text = "Save Payment";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.BtnSavePayment_Click);
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOID.Location = new System.Drawing.Point(233, 94);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(39, 41);
            this.lblOID.TabIndex = 1;
            this.lblOID.Text = "id";
            this.lblOID.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount Due : ";
            this.label4.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(233, 145);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(78, 41);
            this.lblAmountDue.TabIndex = 1;
            this.lblAmountDue.Text = "R0.00";
            this.lblAmountDue.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Payment Type : ";
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Location = new System.Drawing.Point(210, 241);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(153, 27);
            this.cbxPaymentType.TabIndex = 5;
            this.cbxPaymentType.SelectedIndexChanged += new System.EventHandler(this.CbxPaymentType_SelectedIndexChanged);
            // 
            // Customer_Order_Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 398);
            this.Controls.Add(this.cbxPaymentType);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Customer_Order_Capture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Payment";
            this.Load += new System.EventHandler(this.CapturePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPaymentType;
    }
}