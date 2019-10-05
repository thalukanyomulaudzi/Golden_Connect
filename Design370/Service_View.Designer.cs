namespace Design370
{
    partial class Service_View
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
            this.btnServiceEdit = new System.Windows.Forms.Button();
            this.btnServiceOK = new System.Windows.Forms.Button();
            this.btnServiceTypeAdd = new System.Windows.Forms.Button();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnServiceEdit
            // 
            this.btnServiceEdit.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceEdit.Location = new System.Drawing.Point(337, 357);
            this.btnServiceEdit.Name = "btnServiceEdit";
            this.btnServiceEdit.Size = new System.Drawing.Size(118, 38);
            this.btnServiceEdit.TabIndex = 7;
            this.btnServiceEdit.Text = "Edit";
            this.btnServiceEdit.UseVisualStyleBackColor = true;
            this.btnServiceEdit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnServiceOK
            // 
            this.btnServiceOK.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceOK.Location = new System.Drawing.Point(488, 357);
            this.btnServiceOK.Name = "btnServiceOK";
            this.btnServiceOK.Size = new System.Drawing.Size(118, 38);
            this.btnServiceOK.TabIndex = 6;
            this.btnServiceOK.Text = "OK";
            this.btnServiceOK.UseVisualStyleBackColor = true;
            this.btnServiceOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnServiceTypeAdd
            // 
            this.btnServiceTypeAdd.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceTypeAdd.Location = new System.Drawing.Point(337, 271);
            this.btnServiceTypeAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceTypeAdd.Name = "btnServiceTypeAdd";
            this.btnServiceTypeAdd.Size = new System.Drawing.Size(269, 29);
            this.btnServiceTypeAdd.TabIndex = 5;
            this.btnServiceTypeAdd.Text = "Add Service Type";
            this.btnServiceTypeAdd.UseVisualStyleBackColor = true;
            this.btnServiceTypeAdd.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cbxServiceType
            // 
            this.cbxServiceType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Location = new System.Drawing.Point(28, 273);
            this.cbxServiceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(247, 26);
            this.cbxServiceType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Service Type:";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicePrice.Location = new System.Drawing.Point(337, 41);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(269, 26);
            this.txtServicePrice.TabIndex = 3;
            this.txtServicePrice.TextChanged += new System.EventHandler(this.TxtServicePrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Service Price :";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceDescription.Location = new System.Drawing.Point(28, 113);
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(247, 112);
            this.txtServiceDescription.TabIndex = 2;
            this.txtServiceDescription.TextChanged += new System.EventHandler(this.TxtServiceDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Service Description :";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Service Name :";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.ForeColor = System.Drawing.Color.Red;
            this.lblServiceName.Location = new System.Drawing.Point(281, 44);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(19, 18);
            this.lblServiceName.TabIndex = 80;
            this.lblServiceName.Text = "✘";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.ForeColor = System.Drawing.Color.Red;
            this.lblServicePrice.Location = new System.Drawing.Point(612, 44);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(19, 18);
            this.lblServicePrice.TabIndex = 81;
            this.lblServicePrice.Text = "✘";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.ForeColor = System.Drawing.Color.Red;
            this.lblServiceDescription.Location = new System.Drawing.Point(281, 116);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(19, 18);
            this.lblServiceDescription.TabIndex = 82;
            this.lblServiceDescription.Text = "✘";
            // 
            // Service_View
            // 
            this.AcceptButton = this.btnServiceOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 424);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.btnServiceEdit);
            this.Controls.Add(this.btnServiceOK);
            this.Controls.Add(this.btnServiceTypeAdd);
            this.Controls.Add(this.cbxServiceType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Service_View";
            this.Text = "View Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Service_View_FormClosing);
            this.Load += new System.EventHandler(this.Service_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServiceEdit;
        private System.Windows.Forms.Button btnServiceOK;
        private System.Windows.Forms.Button btnServiceTypeAdd;
        private System.Windows.Forms.ComboBox cbxServiceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblServiceDescription;
    }
}