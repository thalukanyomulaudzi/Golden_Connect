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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxAccessLevel
            // 
            this.cbxAccessLevel.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccessLevel.FormattingEnabled = true;
            this.cbxAccessLevel.Location = new System.Drawing.Point(30, 294);
            this.cbxAccessLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAccessLevel.Name = "cbxAccessLevel";
            this.cbxAccessLevel.Size = new System.Drawing.Size(198, 24);
            this.cbxAccessLevel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Access Level :";
            // 
            // txtEmpTypeDescription
            // 
            this.txtEmpTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTypeDescription.Location = new System.Drawing.Point(30, 97);
            this.txtEmpTypeDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmpTypeDescription.Multiline = true;
            this.txtEmpTypeDescription.Name = "txtEmpTypeDescription";
            this.txtEmpTypeDescription.Size = new System.Drawing.Size(198, 162);
            this.txtEmpTypeDescription.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description :";
            // 
            // txtEmpTypeName
            // 
            this.txtEmpTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTypeName.Location = new System.Drawing.Point(30, 40);
            this.txtEmpTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmpTypeName.Name = "txtEmpTypeName";
            this.txtEmpTypeName.Size = new System.Drawing.Size(198, 21);
            this.txtEmpTypeName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            // 
            // btnSaveEmpType
            // 
            this.btnSaveEmpType.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmpType.Location = new System.Drawing.Point(30, 337);
            this.btnSaveEmpType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmpType.Name = "btnSaveEmpType";
            this.btnSaveEmpType.Size = new System.Drawing.Size(86, 28);
            this.btnSaveEmpType.TabIndex = 14;
            this.btnSaveEmpType.Text = "Edit";
            this.btnSaveEmpType.UseVisualStyleBackColor = true;
            this.btnSaveEmpType.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Employee_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 396);
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
    }
}