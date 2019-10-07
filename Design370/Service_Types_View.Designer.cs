namespace Design370
{
    partial class Service_Types_View
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
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
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
            this.button2.TabIndex = 38;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceDescription.Location = new System.Drawing.Point(30, 102);
            this.txtServiceDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServiceDescription.MaxLength = 100;
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(198, 162);
            this.txtServiceDescription.TabIndex = 36;
            this.txtServiceDescription.TextChanged += new System.EventHandler(this.TxtServiceDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description :";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(30, 46);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServiceName.MaxLength = 25;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(198, 26);
            this.txtServiceName.TabIndex = 34;
            this.txtServiceName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.ForeColor = System.Drawing.Color.Red;
            this.lblServiceName.Location = new System.Drawing.Point(236, 49);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(19, 18);
            this.lblServiceName.TabIndex = 101;
            this.lblServiceName.Text = "✘";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.ForeColor = System.Drawing.Color.Red;
            this.lblServiceDescription.Location = new System.Drawing.Point(236, 105);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(19, 18);
            this.lblServiceDescription.TabIndex = 103;
            this.lblServiceDescription.Text = "✘";
            // 
            // Service_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 343);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Service_Types_View";
            this.Text = "View Service Type";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Service_Types_View_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Service_Types_View_FormClosing);
            this.Load += new System.EventHandler(this.Service_Types_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceDescription;
    }
}