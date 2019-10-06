namespace Design370
{
    partial class Employee_View
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
            this.btnEmployeeEdit = new System.Windows.Forms.Button();
            this.btnEmployeeOK = new System.Windows.Forms.Button();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEmployeeTitle = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeGender = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEmployeeTypeAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEmployeeFirst = new System.Windows.Forms.Label();
            this.lblEmployeeLast = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployeeEdit
            // 
            this.btnEmployeeEdit.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeEdit.Location = new System.Drawing.Point(363, 623);
            this.btnEmployeeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeEdit.Name = "btnEmployeeEdit";
            this.btnEmployeeEdit.Size = new System.Drawing.Size(117, 39);
            this.btnEmployeeEdit.TabIndex = 23;
            this.btnEmployeeEdit.Text = "Edit";
            this.btnEmployeeEdit.UseVisualStyleBackColor = true;
            this.btnEmployeeEdit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnEmployeeOK
            // 
            this.btnEmployeeOK.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeOK.Location = new System.Drawing.Point(490, 623);
            this.btnEmployeeOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeOK.Name = "btnEmployeeOK";
            this.btnEmployeeOK.Size = new System.Drawing.Size(117, 39);
            this.btnEmployeeOK.TabIndex = 22;
            this.btnEmployeeOK.Text = "OK";
            this.btnEmployeeOK.UseVisualStyleBackColor = true;
            this.btnEmployeeOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.Location = new System.Drawing.Point(363, 404);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeEmail.TabIndex = 21;
            this.txtEmployeeEmail.TextChanged += new System.EventHandler(this.TxtEmployeeEmail_TextChanged);
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.Location = new System.Drawing.Point(40, 404);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeePhone.TabIndex = 20;
            this.txtEmployeePhone.TextChanged += new System.EventHandler(this.TxtEmployeePhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(364, 93);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeID.TabIndex = 17;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.TxtEmployeeID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Number :";
            // 
            // txtEmployeeLast
            // 
            this.txtEmployeeLast.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLast.Location = new System.Drawing.Point(41, 160);
            this.txtEmployeeLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeLast.Name = "txtEmployeeLast";
            this.txtEmployeeLast.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeLast.TabIndex = 15;
            this.txtEmployeeLast.TextChanged += new System.EventHandler(this.TxtEmployeeLast_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name :";
            // 
            // txtEmployeeFirst
            // 
            this.txtEmployeeFirst.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFirst.Location = new System.Drawing.Point(41, 93);
            this.txtEmployeeFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeFirst.Name = "txtEmployeeFirst";
            this.txtEmployeeFirst.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeFirst.TabIndex = 13;
            this.txtEmployeeFirst.TextChanged += new System.EventHandler(this.TxtEmployeeFirst_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Title :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Marital status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Employee Type :";
            // 
            // cbxEmployeeTitle
            // 
            this.cbxEmployeeTitle.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeTitle.FormattingEnabled = true;
            this.cbxEmployeeTitle.Location = new System.Drawing.Point(364, 292);
            this.cbxEmployeeTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeTitle.Name = "cbxEmployeeTitle";
            this.cbxEmployeeTitle.Size = new System.Drawing.Size(127, 26);
            this.cbxEmployeeTitle.TabIndex = 32;
            // 
            // cbxEmployeeStatus
            // 
            this.cbxEmployeeStatus.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeStatus.FormattingEnabled = true;
            this.cbxEmployeeStatus.Location = new System.Drawing.Point(364, 228);
            this.cbxEmployeeStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeStatus.Name = "cbxEmployeeStatus";
            this.cbxEmployeeStatus.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeStatus.TabIndex = 33;
            // 
            // cbxEmployeeGender
            // 
            this.cbxEmployeeGender.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeGender.FormattingEnabled = true;
            this.cbxEmployeeGender.Location = new System.Drawing.Point(364, 161);
            this.cbxEmployeeGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeGender.Name = "cbxEmployeeGender";
            this.cbxEmployeeGender.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeGender.TabIndex = 34;
            // 
            // cbxEmployeeType
            // 
            this.cbxEmployeeType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeType.FormattingEnabled = true;
            this.cbxEmployeeType.Location = new System.Drawing.Point(40, 522);
            this.cbxEmployeeType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeType.Name = "cbxEmployeeType";
            this.cbxEmployeeType.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeType.TabIndex = 35;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeAddress.Location = new System.Drawing.Point(40, 227);
            this.txtEmployeeAddress.Multiline = true;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(243, 83);
            this.txtEmployeeAddress.TabIndex = 36;
            this.txtEmployeeAddress.TextChanged += new System.EventHandler(this.TxtEmployeeAddress_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "Address :";
            // 
            // btnEmployeeTypeAdd
            // 
            this.btnEmployeeTypeAdd.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeTypeAdd.Location = new System.Drawing.Point(363, 522);
            this.btnEmployeeTypeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeTypeAdd.Name = "btnEmployeeTypeAdd";
            this.btnEmployeeTypeAdd.Size = new System.Drawing.Size(168, 29);
            this.btnEmployeeTypeAdd.TabIndex = 38;
            this.btnEmployeeTypeAdd.Text = "Add Employee Type";
            this.btnEmployeeTypeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeTypeAdd.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "1. Personal Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 347);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "2. Contact Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 462);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "3. Business Information";
            // 
            // lblEmployeeFirst
            // 
            this.lblEmployeeFirst.AutoSize = true;
            this.lblEmployeeFirst.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeFirst.Location = new System.Drawing.Point(291, 96);
            this.lblEmployeeFirst.Name = "lblEmployeeFirst";
            this.lblEmployeeFirst.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeFirst.TabIndex = 80;
            this.lblEmployeeFirst.Text = "✘";
            // 
            // lblEmployeeLast
            // 
            this.lblEmployeeLast.AutoSize = true;
            this.lblEmployeeLast.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeLast.Location = new System.Drawing.Point(291, 164);
            this.lblEmployeeLast.Name = "lblEmployeeLast";
            this.lblEmployeeLast.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeLast.TabIndex = 81;
            this.lblEmployeeLast.Text = "✘";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeID.Location = new System.Drawing.Point(614, 96);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeID.TabIndex = 84;
            this.lblEmployeeID.Text = "✘";
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeePhone.Location = new System.Drawing.Point(290, 407);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeePhone.TabIndex = 85;
            this.lblEmployeePhone.Text = "✘";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(613, 407);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeEmail.TabIndex = 86;
            this.lblEmployeeEmail.Text = "✘";
            // 
            // Employee_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 694);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeePhone);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblEmployeeLast);
            this.Controls.Add(this.lblEmployeeFirst);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEmployeeTypeAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.cbxEmployeeType);
            this.Controls.Add(this.cbxEmployeeGender);
            this.Controls.Add(this.cbxEmployeeStatus);
            this.Controls.Add(this.cbxEmployeeTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEmployeeEdit);
            this.Controls.Add(this.btnEmployeeOK);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeFirst);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_View";
            this.Text = "View Employee";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Employee_View_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_View_FormClosing);
            this.Load += new System.EventHandler(this.Employee_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeEdit;
        private System.Windows.Forms.Button btnEmployeeOK;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEmployeeTitle;
        private System.Windows.Forms.ComboBox cbxEmployeeStatus;
        private System.Windows.Forms.ComboBox cbxEmployeeGender;
        private System.Windows.Forms.ComboBox cbxEmployeeType;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEmployeeTypeAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEmployeeFirst;
        private System.Windows.Forms.Label lblEmployeeLast;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
    }
}