﻿namespace Design370
{
    partial class Employee_Add
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
            this.btnEmployeeCancel = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.cbxEmployeeType = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeGender = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeMarital = new System.Windows.Forms.ComboBox();
            this.cbxEmployeeTitle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnEmployeeTypeAdd = new System.Windows.Forms.Button();
            this.lblEmployeeFirst = new System.Windows.Forms.Label();
            this.lblEmployeeLast = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployeeCancel
            // 
            this.btnEmployeeCancel.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeCancel.Location = new System.Drawing.Point(351, 603);
            this.btnEmployeeCancel.Name = "btnEmployeeCancel";
            this.btnEmployeeCancel.Size = new System.Drawing.Size(116, 39);
            this.btnEmployeeCancel.TabIndex = 13;
            this.btnEmployeeCancel.Text = "Cancel";
            this.btnEmployeeCancel.UseVisualStyleBackColor = true;
            this.btnEmployeeCancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAdd.Location = new System.Drawing.Point(491, 603);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(115, 39);
            this.btnEmployeeAdd.TabIndex = 12;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.BtnEmpAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 463);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 18);
            this.label13.TabIndex = 65;
            this.label13.Text = "3. Business Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 348);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 18);
            this.label12.TabIndex = 64;
            this.label12.Text = "2. Contact Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "1. Personal Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "Address :";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeAddress.Location = new System.Drawing.Point(40, 228);
            this.txtEmployeeAddress.MaxLength = 100;
            this.txtEmployeeAddress.Multiline = true;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(243, 83);
            this.txtEmployeeAddress.TabIndex = 5;
            this.txtEmployeeAddress.TextChanged += new System.EventHandler(this.TxtEmployeeAddress_TextChanged);
            // 
            // cbxEmployeeType
            // 
            this.cbxEmployeeType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeType.FormattingEnabled = true;
            this.cbxEmployeeType.Location = new System.Drawing.Point(40, 523);
            this.cbxEmployeeType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeType.Name = "cbxEmployeeType";
            this.cbxEmployeeType.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeType.TabIndex = 10;
            this.cbxEmployeeType.SelectedIndexChanged += new System.EventHandler(this.CmEMTP_SelectedIndexChanged);
            // 
            // cbxEmployeeGender
            // 
            this.cbxEmployeeGender.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeGender.FormattingEnabled = true;
            this.cbxEmployeeGender.Location = new System.Drawing.Point(364, 161);
            this.cbxEmployeeGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeGender.Name = "cbxEmployeeGender";
            this.cbxEmployeeGender.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeGender.TabIndex = 4;
            // 
            // cbxEmployeeMarital
            // 
            this.cbxEmployeeMarital.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeMarital.FormattingEnabled = true;
            this.cbxEmployeeMarital.Location = new System.Drawing.Point(364, 228);
            this.cbxEmployeeMarital.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeMarital.Name = "cbxEmployeeMarital";
            this.cbxEmployeeMarital.Size = new System.Drawing.Size(243, 26);
            this.cbxEmployeeMarital.TabIndex = 6;
            this.cbxEmployeeMarital.SelectedIndexChanged += new System.EventHandler(this.CmMS_SelectedIndexChanged);
            // 
            // cbxEmployeeTitle
            // 
            this.cbxEmployeeTitle.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeeTitle.FormattingEnabled = true;
            this.cbxEmployeeTitle.Location = new System.Drawing.Point(364, 291);
            this.cbxEmployeeTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeTitle.Name = "cbxEmployeeTitle";
            this.cbxEmployeeTitle.Size = new System.Drawing.Size(127, 26);
            this.cbxEmployeeTitle.TabIndex = 7;
            this.cbxEmployeeTitle.SelectedIndexChanged += new System.EventHandler(this.CmTITLE_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 501);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "Employee Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "Marital status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Title :";
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.Location = new System.Drawing.Point(363, 405);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeEmail.MaxLength = 50;
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeEmail.TabIndex = 9;
            this.txtEmployeeEmail.TextChanged += new System.EventHandler(this.TxtEmpEmail_TextChanged);
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.Location = new System.Drawing.Point(40, 405);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeePhone.MaxLength = 15;
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeePhone.TabIndex = 8;
            this.txtEmployeePhone.TextChanged += new System.EventHandler(this.TxtEmployeePhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Email Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Phone Number :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(364, 93);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.MaxLength = 13;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeID.TabIndex = 3;
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
            this.label3.TabIndex = 46;
            this.label3.Text = "ID Number :";
            // 
            // txtEmployeeLast
            // 
            this.txtEmployeeLast.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLast.Location = new System.Drawing.Point(41, 161);
            this.txtEmployeeLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeLast.MaxLength = 25;
            this.txtEmployeeLast.Name = "txtEmployeeLast";
            this.txtEmployeeLast.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeLast.TabIndex = 2;
            this.txtEmployeeLast.TextChanged += new System.EventHandler(this.TxtEmployeeLast_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Last Name :";
            // 
            // txtEmployeeFirst
            // 
            this.txtEmployeeFirst.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFirst.Location = new System.Drawing.Point(41, 94);
            this.txtEmployeeFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeFirst.MaxLength = 25;
            this.txtEmployeeFirst.Name = "txtEmployeeFirst";
            this.txtEmployeeFirst.Size = new System.Drawing.Size(243, 26);
            this.txtEmployeeFirst.TabIndex = 1;
            this.txtEmployeeFirst.TextChanged += new System.EventHandler(this.TxtEmpFirst_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "First Name :";
            // 
            // btnEmployeeTypeAdd
            // 
            this.btnEmployeeTypeAdd.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeTypeAdd.Location = new System.Drawing.Point(363, 523);
            this.btnEmployeeTypeAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeTypeAdd.Name = "btnEmployeeTypeAdd";
            this.btnEmployeeTypeAdd.Size = new System.Drawing.Size(168, 29);
            this.btnEmployeeTypeAdd.TabIndex = 11;
            this.btnEmployeeTypeAdd.Text = "Add Employee Type";
            this.btnEmployeeTypeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeTypeAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEmployeeFirst
            // 
            this.lblEmployeeFirst.AutoSize = true;
            this.lblEmployeeFirst.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeFirst.Location = new System.Drawing.Point(291, 97);
            this.lblEmployeeFirst.Name = "lblEmployeeFirst";
            this.lblEmployeeFirst.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeFirst.TabIndex = 79;
            this.lblEmployeeFirst.Text = "✘";
            // 
            // lblEmployeeLast
            // 
            this.lblEmployeeLast.AutoSize = true;
            this.lblEmployeeLast.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeLast.Location = new System.Drawing.Point(291, 164);
            this.lblEmployeeLast.Name = "lblEmployeeLast";
            this.lblEmployeeLast.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeLast.TabIndex = 80;
            this.lblEmployeeLast.Text = "✘";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeID.Location = new System.Drawing.Point(614, 96);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeID.TabIndex = 81;
            this.lblEmployeeID.Text = "✘";
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeePhone.Location = new System.Drawing.Point(290, 408);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeePhone.TabIndex = 83;
            this.lblEmployeePhone.Text = "✘";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(610, 408);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(19, 18);
            this.lblEmployeeEmail.TabIndex = 84;
            this.lblEmployeeEmail.Text = "✘";
            // 
            // Employee_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(637, 672);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeePhone);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblEmployeeLast);
            this.Controls.Add(this.lblEmployeeFirst);
            this.Controls.Add(this.btnEmployeeTypeAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.cbxEmployeeType);
            this.Controls.Add(this.cbxEmployeeGender);
            this.Controls.Add(this.cbxEmployeeMarital);
            this.Controls.Add(this.cbxEmployeeTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.btnEmployeeCancel);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_Add_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeeCancel;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.ComboBox cbxEmployeeType;
        private System.Windows.Forms.ComboBox cbxEmployeeGender;
        private System.Windows.Forms.ComboBox cbxEmployeeMarital;
        private System.Windows.Forms.ComboBox cbxEmployeeTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnEmployeeTypeAdd;
        private System.Windows.Forms.Label lblEmployeeFirst;
        private System.Windows.Forms.Label lblEmployeeLast;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
    }
}