namespace Design370
{
    partial class Employee_Types_View
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAccessLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEmpType = new System.Windows.Forms.Button();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbxAccessLevel
            // 
            this.cbxAccessLevel.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccessLevel.FormattingEnabled = true;
            this.cbxAccessLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbxAccessLevel.Location = new System.Drawing.Point(24, 296);
            this.cbxAccessLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAccessLevel.Name = "cbxAccessLevel";
            this.cbxAccessLevel.Size = new System.Drawing.Size(198, 26);
            this.cbxAccessLevel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Access Level :";
            // 
            // txtEmpTypeDescription
            // 
            this.txtEmpTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTypeDescription.Location = new System.Drawing.Point(24, 99);
            this.txtEmpTypeDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmpTypeDescription.Multiline = true;
            this.txtEmpTypeDescription.Name = "txtEmpTypeDescription";
            this.txtEmpTypeDescription.Size = new System.Drawing.Size(198, 162);
            this.txtEmpTypeDescription.TabIndex = 10;
            this.txtEmpTypeDescription.TextChanged += new System.EventHandler(this.TxtEmpTypeDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description :";
            // 
            // txtEmpTypeName
            // 
            this.txtEmpTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTypeName.Location = new System.Drawing.Point(24, 42);
            this.txtEmpTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmpTypeName.Name = "txtEmpTypeName";
            this.txtEmpTypeName.Size = new System.Drawing.Size(198, 26);
            this.txtEmpTypeName.TabIndex = 8;
            this.txtEmpTypeName.TextChanged += new System.EventHandler(this.TxtEmpTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // btnSaveEmpType
            // 
            this.btnSaveEmpType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmpType.Location = new System.Drawing.Point(24, 349);
            this.btnSaveEmpType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmpType.Name = "btnSaveEmpType";
            this.btnSaveEmpType.Size = new System.Drawing.Size(86, 28);
            this.btnSaveEmpType.TabIndex = 14;
            this.btnSaveEmpType.Text = "Edit";
            this.btnSaveEmpType.UseVisualStyleBackColor = true;
            this.btnSaveEmpType.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblTypeName.Location = new System.Drawing.Point(230, 45);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblTypeName.TabIndex = 81;
            this.lblTypeName.Text = "✘";
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.AutoSize = true;
            this.lblTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblTypeDescription.Location = new System.Drawing.Point(227, 102);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblTypeDescription.TabIndex = 82;
            this.lblTypeDescription.Text = "✘";
            // 
            // Employee_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 398);
            this.Controls.Add(this.lblTypeDescription);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.btnSaveEmpType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxAccessLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Types_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee Type";
            this.Load += new System.EventHandler(this.Employee_Types_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxAccessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEmpType;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblTypeDescription;
    }
}