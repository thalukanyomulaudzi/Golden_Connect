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
            this.SuspendLayout();
            // 
            // btnEventTypeEdit
            // 
            this.btnEventTypeEdit.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypeEdit.Location = new System.Drawing.Point(30, 287);
            this.btnEventTypeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventTypeEdit.Name = "btnEventTypeEdit";
            this.btnEventTypeEdit.Size = new System.Drawing.Size(86, 28);
            this.btnEventTypeEdit.TabIndex = 50;
            this.btnEventTypeEdit.Text = "Edit";
            this.btnEventTypeEdit.UseVisualStyleBackColor = true;
            this.btnEventTypeEdit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnEventTypeOK
            // 
            this.btnEventTypeOK.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypeOK.Location = new System.Drawing.Point(142, 287);
            this.btnEventTypeOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventTypeOK.Name = "btnEventTypeOK";
            this.btnEventTypeOK.Size = new System.Drawing.Size(86, 28);
            this.btnEventTypeOK.TabIndex = 49;
            this.btnEventTypeOK.Text = "OK";
            this.btnEventTypeOK.UseVisualStyleBackColor = true;
            this.btnEventTypeOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtEventTypeDescription
            // 
            this.txtEventTypeDescription.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventTypeDescription.Location = new System.Drawing.Point(30, 97);
            this.txtEventTypeDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEventTypeDescription.MaxLength = 200;
            this.txtEventTypeDescription.Multiline = true;
            this.txtEventTypeDescription.Name = "txtEventTypeDescription";
            this.txtEventTypeDescription.Size = new System.Drawing.Size(198, 162);
            this.txtEventTypeDescription.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Description :";
            // 
            // txtEventTypeName
            // 
            this.txtEventTypeName.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventTypeName.Location = new System.Drawing.Point(30, 40);
            this.txtEventTypeName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEventTypeName.MaxLength = 25;
            this.txtEventTypeName.Name = "txtEventTypeName";
            this.txtEventTypeName.Size = new System.Drawing.Size(198, 21);
            this.txtEventTypeName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name :";
            // 
            // Event_Types_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 344);
            this.Controls.Add(this.btnEventTypeEdit);
            this.Controls.Add(this.btnEventTypeOK);
            this.Controls.Add(this.txtEventTypeDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventTypeName);
            this.Controls.Add(this.label1);
            this.Name = "Event_Types_View";
            this.Text = "View Event Type";
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
    }
}