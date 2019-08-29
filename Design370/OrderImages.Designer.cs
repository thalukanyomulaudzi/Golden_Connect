namespace Design370
{
    partial class OrderImages
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.custOrderProductList = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(2, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(336, 62);
            label3.TabIndex = 2;
            label3.Text = "Product Images";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(335, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(317, 62);
            label4.TabIndex = 2;
            label4.Text = "Product Details";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productImg
            // 
            this.productImg.BackColor = System.Drawing.Color.White;
            this.productImg.Location = new System.Drawing.Point(2, 125);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(336, 271);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImg.TabIndex = 1;
            this.productImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID : ";
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Location = new System.Drawing.Point(12, 414);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(103, 33);
            this.btnPrevImage.TabIndex = 3;
            this.btnPrevImage.Text = "Previous";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.BtnPrevImage_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.Location = new System.Drawing.Point(223, 414);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(102, 33);
            this.btnNextImg.TabIndex = 3;
            this.btnNextImg.Text = "Next";
            this.btnNextImg.UseVisualStyleBackColor = true;
            this.btnNextImg.Click += new System.EventHandler(this.BtnNextImg_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(437, 144);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(32, 29);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "ID";
            // 
            // custOrderProductList
            // 
            this.custOrderProductList.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custOrderProductList.Location = new System.Drawing.Point(345, 215);
            this.custOrderProductList.Name = "custOrderProductList";
            this.custOrderProductList.Size = new System.Drawing.Size(303, 241);
            this.custOrderProductList.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Products";
            // 
            // OrderImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 459);
            this.Controls.Add(this.custOrderProductList);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productImg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookshelf Symbol 7", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "OrderImages";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Products";
            this.Load += new System.EventHandler(this.OrderImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox productImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Button btnNextImg;
        public System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TreeView custOrderProductList;
        private System.Windows.Forms.Label label5;
    }
}