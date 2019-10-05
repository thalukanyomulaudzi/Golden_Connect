namespace Design370
{
    partial class Service_Add
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
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.btnServiceCancel = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.btnServiceType = new System.Windows.Forms.Button();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.ForeColor = System.Drawing.Color.Red;
            this.lblServiceDescription.Location = new System.Drawing.Point(281, 116);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(19, 18);
            this.lblServiceDescription.TabIndex = 101;
            this.lblServiceDescription.Text = "✘";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.ForeColor = System.Drawing.Color.Red;
            this.lblServicePrice.Location = new System.Drawing.Point(612, 44);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(19, 18);
            this.lblServicePrice.TabIndex = 100;
            this.lblServicePrice.Text = "✘";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.ForeColor = System.Drawing.Color.Red;
            this.lblServiceName.Location = new System.Drawing.Point(281, 44);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(19, 18);
            this.lblServiceName.TabIndex = 99;
            this.lblServiceName.Text = "✘";
            // 
            // btnServiceCancel
            // 
            this.btnServiceCancel.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceCancel.Location = new System.Drawing.Point(337, 357);
            this.btnServiceCancel.Name = "btnServiceCancel";
            this.btnServiceCancel.Size = new System.Drawing.Size(118, 38);
            this.btnServiceCancel.TabIndex = 94;
            this.btnServiceCancel.Text = "Edit";
            this.btnServiceCancel.UseVisualStyleBackColor = true;
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAdd.Location = new System.Drawing.Point(488, 357);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(118, 38);
            this.btnServiceAdd.TabIndex = 93;
            this.btnServiceAdd.Text = "OK";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.BtnServiceAdd_Click);
            // 
            // btnServiceType
            // 
            this.btnServiceType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceType.Location = new System.Drawing.Point(337, 271);
            this.btnServiceType.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(269, 29);
            this.btnServiceType.TabIndex = 92;
            this.btnServiceType.Text = "Add Service Type";
            this.btnServiceType.UseVisualStyleBackColor = true;
            this.btnServiceType.Click += new System.EventHandler(this.BtnServiceType_Click);
            // 
            // cbxServiceType
            // 
            this.cbxServiceType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Location = new System.Drawing.Point(28, 273);
            this.cbxServiceType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(247, 26);
            this.cbxServiceType.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Service Type:";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicePrice.Location = new System.Drawing.Point(337, 41);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(269, 26);
            this.txtServicePrice.TabIndex = 90;
            this.txtServicePrice.TextChanged += new System.EventHandler(this.TxtServicePrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Service Price :";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceDescription.Location = new System.Drawing.Point(28, 113);
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(247, 112);
            this.txtServiceDescription.TabIndex = 89;
            this.txtServiceDescription.TextChanged += new System.EventHandler(this.TxtServiceDescription_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 96;
            this.label7.Text = "Service Description :";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(28, 41);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(247, 26);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.TextChanged += new System.EventHandler(this.TxtServiceName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 95;
            this.label8.Text = "Service Name :";
            // 
            // Service_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.btnServiceCancel);
            this.Controls.Add(this.btnServiceAdd);
            this.Controls.Add(this.btnServiceType);
            this.Controls.Add(this.cbxServiceType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Service_Add";
            this.Text = "Add Service";
            this.Activated += new System.EventHandler(this.Service_Add_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Button btnServiceCancel;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Button btnServiceType;
        private System.Windows.Forms.ComboBox cbxServiceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label8;
    }
}