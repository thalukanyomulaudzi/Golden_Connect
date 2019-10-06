namespace Design370
{
    partial class Service_Types_Add
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtServTypeDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServTypeDesc
            // 
            this.txtServTypeDesc.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServTypeDesc.Location = new System.Drawing.Point(30, 102);
            this.txtServTypeDesc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServTypeDesc.MaxLength = 100;
            this.txtServTypeDesc.Multiline = true;
            this.txtServTypeDesc.Name = "txtServTypeDesc";
            this.txtServTypeDesc.Size = new System.Drawing.Size(198, 162);
            this.txtServTypeDesc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Description :";
            // 
            // txtServTypeName
            // 
            this.txtServTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServTypeName.Location = new System.Drawing.Point(30, 45);
            this.txtServTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServTypeName.MaxLength = 25;
            this.txtServTypeName.Name = "txtServTypeName";
            this.txtServTypeName.Size = new System.Drawing.Size(198, 26);
            this.txtServTypeName.TabIndex = 26;
            this.txtServTypeName.TextChanged += new System.EventHandler(this.TxtServTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name :";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.ForeColor = System.Drawing.Color.Red;
            this.lblServiceName.Location = new System.Drawing.Point(236, 48);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(19, 18);
            this.lblServiceName.TabIndex = 100;
            this.lblServiceName.Text = "✘";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.ForeColor = System.Drawing.Color.Red;
            this.lblServiceDescription.Location = new System.Drawing.Point(236, 105);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(19, 18);
            this.lblServiceDescription.TabIndex = 102;
            this.lblServiceDescription.Text = "✘";
            // 
            // Service_Types_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 350);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtServTypeDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Service_Types_Add";
            this.Text = "Add Service Type";
            this.Load += new System.EventHandler(this.Service_Types_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServTypeDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceDescription;
    }
}