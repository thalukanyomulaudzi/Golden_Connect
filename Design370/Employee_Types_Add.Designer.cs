namespace Design370
{
    partial class Employee_Types_Add
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
            this.cbxAccessLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddType = new System.Windows.Forms.Button();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cbxAccessLevel.Location = new System.Drawing.Point(30, 332);
            this.cbxAccessLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAccessLevel.Name = "cbxAccessLevel";
            this.cbxAccessLevel.Size = new System.Drawing.Size(198, 26);
            this.cbxAccessLevel.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Access Level :";
            // 
            // txtTypeDescription
            // 
            this.txtTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeDescription.Location = new System.Drawing.Point(30, 122);
            this.txtTypeDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTypeDescription.Multiline = true;
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(198, 162);
            this.txtTypeDescription.TabIndex = 20;
            this.txtTypeDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Description :";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.Location = new System.Drawing.Point(30, 45);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(198, 26);
            this.txtTypeName.TabIndex = 18;
            this.txtTypeName.TextChanged += new System.EventHandler(this.TxtType_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(30, 390);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 28);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_AddType
            // 
            this.btn_AddType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddType.Location = new System.Drawing.Point(142, 390);
            this.btn_AddType.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddType.Name = "btn_AddType";
            this.btn_AddType.Size = new System.Drawing.Size(86, 28);
            this.btn_AddType.TabIndex = 23;
            this.btn_AddType.Text = "Add";
            this.btn_AddType.UseVisualStyleBackColor = true;
            this.btn_AddType.Click += new System.EventHandler(this.Btn_AddType_Click);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblTypeName.Location = new System.Drawing.Point(236, 48);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblTypeName.TabIndex = 80;
            this.lblTypeName.Text = "✘";
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.AutoSize = true;
            this.lblTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblTypeDescription.Location = new System.Drawing.Point(236, 125);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblTypeDescription.TabIndex = 81;
            this.lblTypeDescription.Text = "✘";
            // 
            // Employee_Types_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 452);
            this.Controls.Add(this.lblTypeDescription);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddType);
            this.Controls.Add(this.cbxAccessLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_Types_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Type";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Employee_Types_Add_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAccessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_AddType;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblTypeDescription;
    }
}