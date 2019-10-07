namespace Design370
{
    partial class Photoshoot_Type_Add
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
            this.txtPhotoshootTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhotoshootTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhotoshootTypeName = new System.Windows.Forms.Label();
            this.lblPhotoshootTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(40, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 50;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 49;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhotoshootTypeDescription
            // 
            this.txtPhotoshootTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotoshootTypeDescription.Location = new System.Drawing.Point(40, 134);
            this.txtPhotoshootTypeDescription.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPhotoshootTypeDescription.MaxLength = 200;
            this.txtPhotoshootTypeDescription.Multiline = true;
            this.txtPhotoshootTypeDescription.Name = "txtPhotoshootTypeDescription";
            this.txtPhotoshootTypeDescription.Size = new System.Drawing.Size(263, 223);
            this.txtPhotoshootTypeDescription.TabIndex = 48;
            this.txtPhotoshootTypeDescription.TextChanged += new System.EventHandler(this.TxtPhotoshootTypeDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Description :";
            // 
            // txtPhotoshootTypeName
            // 
            this.txtPhotoshootTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotoshootTypeName.Location = new System.Drawing.Point(40, 55);
            this.txtPhotoshootTypeName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPhotoshootTypeName.MaxLength = 25;
            this.txtPhotoshootTypeName.Name = "txtPhotoshootTypeName";
            this.txtPhotoshootTypeName.Size = new System.Drawing.Size(263, 26);
            this.txtPhotoshootTypeName.TabIndex = 46;
            this.txtPhotoshootTypeName.TextChanged += new System.EventHandler(this.TxtPhotoshootTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name :";
            // 
            // lblPhotoshootTypeName
            // 
            this.lblPhotoshootTypeName.AutoSize = true;
            this.lblPhotoshootTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblPhotoshootTypeName.Location = new System.Drawing.Point(313, 58);
            this.lblPhotoshootTypeName.Name = "lblPhotoshootTypeName";
            this.lblPhotoshootTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblPhotoshootTypeName.TabIndex = 82;
            this.lblPhotoshootTypeName.Text = "✘";
            // 
            // lblPhotoshootTypeDescription
            // 
            this.lblPhotoshootTypeDescription.AutoSize = true;
            this.lblPhotoshootTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblPhotoshootTypeDescription.Location = new System.Drawing.Point(313, 137);
            this.lblPhotoshootTypeDescription.Name = "lblPhotoshootTypeDescription";
            this.lblPhotoshootTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblPhotoshootTypeDescription.TabIndex = 83;
            this.lblPhotoshootTypeDescription.Text = "✘";
            // 
            // Photoshoot_Type_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 492);
            this.Controls.Add(this.lblPhotoshootTypeDescription);
            this.Controls.Add(this.lblPhotoshootTypeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPhotoshootTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhotoshootTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Photoshoot_Type_Add";
            this.Text = "Add Photoshoot Type";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Photoshoot_Type_Add_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Photoshoot_Type_Add_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhotoshootTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhotoshootTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhotoshootTypeName;
        private System.Windows.Forms.Label lblPhotoshootTypeDescription;
    }
}