namespace Design370
{
    partial class Event_Types_View
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
            this.btnEventTypeEdit = new System.Windows.Forms.Button();
            this.btnEventTypeOK = new System.Windows.Forms.Button();
            this.txtEventTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEventTypeName = new System.Windows.Forms.Label();
            this.lblEventTypeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEventTypeEdit
            // 
            this.btnEventTypeEdit.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypeEdit.Location = new System.Drawing.Point(40, 397);
            this.btnEventTypeEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEventTypeEdit.Name = "btnEventTypeEdit";
            this.btnEventTypeEdit.Size = new System.Drawing.Size(115, 39);
            this.btnEventTypeEdit.TabIndex = 50;
            this.btnEventTypeEdit.Text = "Edit";
            this.btnEventTypeEdit.UseVisualStyleBackColor = true;
            this.btnEventTypeEdit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnEventTypeOK
            // 
            this.btnEventTypeOK.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypeOK.Location = new System.Drawing.Point(189, 397);
            this.btnEventTypeOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEventTypeOK.Name = "btnEventTypeOK";
            this.btnEventTypeOK.Size = new System.Drawing.Size(115, 39);
            this.btnEventTypeOK.TabIndex = 49;
            this.btnEventTypeOK.Text = "OK";
            this.btnEventTypeOK.UseVisualStyleBackColor = true;
            this.btnEventTypeOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtEventTypeDescription
            // 
            this.txtEventTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventTypeDescription.Location = new System.Drawing.Point(40, 134);
            this.txtEventTypeDescription.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEventTypeDescription.MaxLength = 200;
            this.txtEventTypeDescription.Multiline = true;
            this.txtEventTypeDescription.Name = "txtEventTypeDescription";
            this.txtEventTypeDescription.Size = new System.Drawing.Size(263, 223);
            this.txtEventTypeDescription.TabIndex = 48;
            this.txtEventTypeDescription.TextChanged += new System.EventHandler(this.TxtEventTypeDescription_TextChanged);
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
            // txtEventTypeName
            // 
            this.txtEventTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventTypeName.Location = new System.Drawing.Point(40, 55);
            this.txtEventTypeName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEventTypeName.MaxLength = 25;
            this.txtEventTypeName.Name = "txtEventTypeName";
            this.txtEventTypeName.Size = new System.Drawing.Size(263, 26);
            this.txtEventTypeName.TabIndex = 46;
            this.txtEventTypeName.TextChanged += new System.EventHandler(this.TxtEventTypeName_TextChanged);
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
            // lblEventTypeName
            // 
            this.lblEventTypeName.AutoSize = true;
            this.lblEventTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblEventTypeName.Location = new System.Drawing.Point(313, 58);
            this.lblEventTypeName.Name = "lblEventTypeName";
            this.lblEventTypeName.Size = new System.Drawing.Size(19, 18);
            this.lblEventTypeName.TabIndex = 81;
            this.lblEventTypeName.Text = "✘";
            // 
            // lblEventTypeDescription
            // 
            this.lblEventTypeDescription.AutoSize = true;
            this.lblEventTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblEventTypeDescription.Location = new System.Drawing.Point(313, 137);
            this.lblEventTypeDescription.Name = "lblEventTypeDescription";
            this.lblEventTypeDescription.Size = new System.Drawing.Size(19, 18);
            this.lblEventTypeDescription.TabIndex = 82;
            this.lblEventTypeDescription.Text = "✘";
            // 
            // Event_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 476);
            this.Controls.Add(this.lblEventTypeDescription);
            this.Controls.Add(this.lblEventTypeName);
            this.Controls.Add(this.btnEventTypeEdit);
            this.Controls.Add(this.btnEventTypeOK);
            this.Controls.Add(this.txtEventTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventTypeName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Event_Types_View";
            this.Text = "View Event Type";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Event_Types_View_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_Types_View_FormClosing);
            this.Load += new System.EventHandler(this.Event_Types_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventTypeEdit;
        private System.Windows.Forms.Button btnEventTypeOK;
        private System.Windows.Forms.TextBox txtEventTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEventTypeName;
        private System.Windows.Forms.Label lblEventTypeDescription;
    }
}