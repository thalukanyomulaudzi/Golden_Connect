namespace Design370
{
    partial class Product_Type_Add
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
            this.txtProductTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutTypeDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblProductTypeName = new System.Windows.Forms.Label();
            this.lblProductTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name :";
            // 
            // txtProductTypeName
            // 
            this.txtProductTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTypeName.Location = new System.Drawing.Point(30, 47);
            this.txtProductTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProductTypeName.MaxLength = 25;
            this.txtProductTypeName.Name = "txtProductTypeName";
            this.txtProductTypeName.Size = new System.Drawing.Size(198, 26);
            this.txtProductTypeName.TabIndex = 34;
            this.txtProductTypeName.TextChanged += new System.EventHandler(this.TxtProdTypeName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description :";
            // 
            // txtProdutTypeDesc
            // 
            this.txtProdutTypeDesc.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutTypeDesc.Location = new System.Drawing.Point(30, 109);
            this.txtProdutTypeDesc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProdutTypeDesc.MaxLength = 100;
            this.txtProdutTypeDesc.Multiline = true;
            this.txtProdutTypeDesc.Name = "txtProdutTypeDesc";
            this.txtProdutTypeDesc.Size = new System.Drawing.Size(198, 162);
            this.txtProdutTypeDesc.TabIndex = 36;
            this.txtProdutTypeDesc.TextChanged += new System.EventHandler(this.TxtProdTypeDesc_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 293);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblProductTypeName
            // 
            this.lblProductTypeName.AutoSize = true;
            this.lblProductTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblProductTypeName.Location = new System.Drawing.Point(236, 50);
            this.lblProductTypeName.Name = "lblProductTypeName";
            this.lblProductTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblProductTypeName.TabIndex = 79;
            this.lblProductTypeName.Text = "✘";
            // 
            // lblProductTypeDescription
            // 
            this.lblProductTypeDescription.AutoSize = true;
            this.lblProductTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblProductTypeDescription.Location = new System.Drawing.Point(236, 112);
            this.lblProductTypeDescription.Name = "lblProductTypeDescription";
            this.lblProductTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblProductTypeDescription.TabIndex = 80;
            this.lblProductTypeDescription.Text = "✘";
            // 
            // Product_Type_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 350);
            this.Controls.Add(this.lblProductTypeDescription);
            this.Controls.Add(this.lblProductTypeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProdutTypeDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_Type_Add";
            this.Text = "Add Product Type";
            this.Load += new System.EventHandler(this.Product_Type_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdutTypeDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblProductTypeName;
        private System.Windows.Forms.Label lblProductTypeDescription;
    }
}