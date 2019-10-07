namespace Design370
{
    partial class Product_Types_View
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
            this.btnProductTypeOK = new System.Windows.Forms.Button();
            this.txtProductTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.lblProductTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 44;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnProductTypeOK
            // 
            this.btnProductTypeOK.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductTypeOK.Location = new System.Drawing.Point(142, 287);
            this.btnProductTypeOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductTypeOK.Name = "btnProductTypeOK";
            this.btnProductTypeOK.Size = new System.Drawing.Size(86, 28);
            this.btnProductTypeOK.TabIndex = 43;
            this.btnProductTypeOK.Text = "OK";
            this.btnProductTypeOK.UseVisualStyleBackColor = true;
            this.btnProductTypeOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtProductTypeDescription
            // 
            this.txtProductTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTypeDescription.Location = new System.Drawing.Point(30, 102);
            this.txtProductTypeDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProductTypeDescription.MaxLength = 100;
            this.txtProductTypeDescription.Multiline = true;
            this.txtProductTypeDescription.Name = "txtProductTypeDescription";
            this.txtProductTypeDescription.Size = new System.Drawing.Size(198, 162);
            this.txtProductTypeDescription.TabIndex = 42;
            this.txtProductTypeDescription.TextChanged += new System.EventHandler(this.TxtProductTypeDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description :";
            // 
            // txtProductTypeName
            // 
            this.txtProductTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTypeName.Location = new System.Drawing.Point(30, 45);
            this.txtProductTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProductTypeName.MaxLength = 25;
            this.txtProductTypeName.Name = "txtProductTypeName";
            this.txtProductTypeName.Size = new System.Drawing.Size(198, 26);
            this.txtProductTypeName.TabIndex = 40;
            this.txtProductTypeName.TextChanged += new System.EventHandler(this.TxtProductTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name :";
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblProductTypeName.Location = new System.Drawing.Point(236, 48);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblProductTypeName.TabIndex = 80;
            this.lblProductTypeName.Text = "✘";
            // 
            // lblProductTypeDescription
            // 
            this.lblProductTypeDescription.AutoSize = true;
            this.lblProductTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblProductTypeDescription.Location = new System.Drawing.Point(236, 105);
            this.lblProductTypeDescription.Name = "lblProductTypeDescription";
            this.lblProductTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblProductTypeDescription.TabIndex = 81;
            this.lblProductTypeDescription.Text = "✘";
            // 
            // Product_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 341);
            this.Controls.Add(this.lblProductTypeDescription);
            this.Controls.Add(this.lblProductTypeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProductTypeOK);
            this.Controls.Add(this.txtProductTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_Types_View";
            this.Text = "View Product Type";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Product_Types_View_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Product_Types_View_FormClosing);
            this.Load += new System.EventHandler(this.Product_Types_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProductTypeOK;
        private System.Windows.Forms.TextBox txtProductTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.Label lblProductTypeDescription;
    }
}