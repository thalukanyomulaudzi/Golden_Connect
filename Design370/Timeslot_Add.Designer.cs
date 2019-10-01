namespace Design370
{
    partial class Timeslot_Add
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
            this.button20 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button20.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(52, 140);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(230, 28);
            this.button20.TabIndex = 66;
            this.button20.Text = "Add Timeslots up to date";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 26);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // Timeslot_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 424);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button20);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timeslot_Add";
            this.Text = "Timeslot_Add";
            this.Load += new System.EventHandler(this.Timeslot_Add_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}