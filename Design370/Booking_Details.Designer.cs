namespace Design370
{
    partial class Booking_Details
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
            this.cbxBookingAdditions = new System.Windows.Forms.CheckBox();
            this.btnBookingProceed = new System.Windows.Forms.Button();
            this.btnBookingCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBookingAdditionsServices = new System.Windows.Forms.ListBox();
            this.lstBookingAdditionsProducts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBookingServices = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBookingProducts = new System.Windows.Forms.ListBox();
            this.cmbBookingPackage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numBookingGuests = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookingCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmBookingDate = new System.Windows.Forms.DateTimePicker();
            this.btnBookingChangeCustomer = new System.Windows.Forms.Button();
            this.btnBookingChangeDateEmployee = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookingEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBookingAdditions
            // 
            this.cbxBookingAdditions.AutoSize = true;
            this.cbxBookingAdditions.Location = new System.Drawing.Point(42, 484);
            this.cbxBookingAdditions.Name = "cbxBookingAdditions";
            this.cbxBookingAdditions.Size = new System.Drawing.Size(127, 22);
            this.cbxBookingAdditions.TabIndex = 38;
            this.cbxBookingAdditions.Text = "Make additions";
            this.cbxBookingAdditions.UseVisualStyleBackColor = true;
            this.cbxBookingAdditions.CheckedChanged += new System.EventHandler(this.CbxBookingAdditions_CheckedChanged);
            // 
            // btnBookingProceed
            // 
            this.btnBookingProceed.Location = new System.Drawing.Point(369, 693);
            this.btnBookingProceed.Name = "btnBookingProceed";
            this.btnBookingProceed.Size = new System.Drawing.Size(83, 34);
            this.btnBookingProceed.TabIndex = 37;
            this.btnBookingProceed.Text = "Proceed";
            this.btnBookingProceed.UseVisualStyleBackColor = true;
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.Location = new System.Drawing.Point(42, 693);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(83, 34);
            this.btnBookingCancel.TabIndex = 36;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Services";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 523);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Products";
            // 
            // lstBookingAdditionsServices
            // 
            this.lstBookingAdditionsServices.FormattingEnabled = true;
            this.lstBookingAdditionsServices.ItemHeight = 18;
            this.lstBookingAdditionsServices.Items.AddRange(new object[] {
            "Photography 1 hour",
            "Photography 2 hours"});
            this.lstBookingAdditionsServices.Location = new System.Drawing.Point(254, 557);
            this.lstBookingAdditionsServices.Name = "lstBookingAdditionsServices";
            this.lstBookingAdditionsServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBookingAdditionsServices.Size = new System.Drawing.Size(198, 112);
            this.lstBookingAdditionsServices.TabIndex = 33;
            // 
            // lstBookingAdditionsProducts
            // 
            this.lstBookingAdditionsProducts.FormattingEnabled = true;
            this.lstBookingAdditionsProducts.ItemHeight = 18;
            this.lstBookingAdditionsProducts.Items.AddRange(new object[] {
            "10 Edited photos",
            "Canvas A4",
            "Canvas A3"});
            this.lstBookingAdditionsProducts.Location = new System.Drawing.Point(42, 557);
            this.lstBookingAdditionsProducts.Name = "lstBookingAdditionsProducts";
            this.lstBookingAdditionsProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBookingAdditionsProducts.Size = new System.Drawing.Size(198, 112);
            this.lstBookingAdditionsProducts.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Services in package";
            // 
            // lstBookingServices
            // 
            this.lstBookingServices.FormattingEnabled = true;
            this.lstBookingServices.ItemHeight = 18;
            this.lstBookingServices.Items.AddRange(new object[] {
            "Photography 1 hour",
            "Decor setup"});
            this.lstBookingServices.Location = new System.Drawing.Point(254, 359);
            this.lstBookingServices.Name = "lstBookingServices";
            this.lstBookingServices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBookingServices.Size = new System.Drawing.Size(198, 112);
            this.lstBookingServices.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Products in package";
            // 
            // lstBookingProducts
            // 
            this.lstBookingProducts.FormattingEnabled = true;
            this.lstBookingProducts.ItemHeight = 18;
            this.lstBookingProducts.Items.AddRange(new object[] {
            "10 Edited photos"});
            this.lstBookingProducts.Location = new System.Drawing.Point(42, 359);
            this.lstBookingProducts.Name = "lstBookingProducts";
            this.lstBookingProducts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBookingProducts.Size = new System.Drawing.Size(198, 112);
            this.lstBookingProducts.TabIndex = 27;
            // 
            // cmbBookingPackage
            // 
            this.cmbBookingPackage.FormattingEnabled = true;
            this.cmbBookingPackage.Items.AddRange(new object[] {
            "Basic package"});
            this.cmbBookingPackage.Location = new System.Drawing.Point(193, 289);
            this.cmbBookingPackage.Name = "cmbBookingPackage";
            this.cmbBookingPackage.Size = new System.Drawing.Size(259, 26);
            this.cmbBookingPackage.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select package";
            // 
            // numBookingGuests
            // 
            this.numBookingGuests.Location = new System.Drawing.Point(193, 253);
            this.numBookingGuests.Name = "numBookingGuests";
            this.numBookingGuests.Size = new System.Drawing.Size(259, 24);
            this.numBookingGuests.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "# of guests";
            // 
            // txtBookingLocation
            // 
            this.txtBookingLocation.Location = new System.Drawing.Point(193, 158);
            this.txtBookingLocation.Multiline = true;
            this.txtBookingLocation.Name = "txtBookingLocation";
            this.txtBookingLocation.Size = new System.Drawing.Size(259, 81);
            this.txtBookingLocation.TabIndex = 22;
            this.txtBookingLocation.Text = "10 Example Road\r\nBrooklyn\r\nPretoria\r\n0181";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Customer: ";
            // 
            // txtBookingCustomer
            // 
            this.txtBookingCustomer.Location = new System.Drawing.Point(193, 22);
            this.txtBookingCustomer.Name = "txtBookingCustomer";
            this.txtBookingCustomer.Size = new System.Drawing.Size(259, 24);
            this.txtBookingCustomer.TabIndex = 40;
            this.txtBookingCustomer.Text = "John Doe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date:";
            // 
            // dtmBookingDate
            // 
            this.dtmBookingDate.Location = new System.Drawing.Point(193, 56);
            this.dtmBookingDate.Name = "dtmBookingDate";
            this.dtmBookingDate.Size = new System.Drawing.Size(259, 24);
            this.dtmBookingDate.TabIndex = 42;
            // 
            // btnBookingChangeCustomer
            // 
            this.btnBookingChangeCustomer.Location = new System.Drawing.Point(464, 21);
            this.btnBookingChangeCustomer.Name = "btnBookingChangeCustomer";
            this.btnBookingChangeCustomer.Size = new System.Drawing.Size(68, 26);
            this.btnBookingChangeCustomer.TabIndex = 43;
            this.btnBookingChangeCustomer.Text = "Change";
            this.btnBookingChangeCustomer.UseVisualStyleBackColor = true;
            this.btnBookingChangeCustomer.Click += new System.EventHandler(this.BtnBookingChangeCustomer_Click);
            // 
            // btnBookingChangeDateEmployee
            // 
            this.btnBookingChangeDateEmployee.Location = new System.Drawing.Point(464, 54);
            this.btnBookingChangeDateEmployee.Name = "button1";
            this.btnBookingChangeDateEmployee.Size = new System.Drawing.Size(68, 60);
            this.btnBookingChangeDateEmployee.TabIndex = 44;
            this.btnBookingChangeDateEmployee.Text = "Change";
            this.btnBookingChangeDateEmployee.UseVisualStyleBackColor = true;
            this.btnBookingChangeDateEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Employee:";
            // 
            // txtBookingEmployee
            // 
            this.txtBookingEmployee.Location = new System.Drawing.Point(193, 90);
            this.txtBookingEmployee.Name = "txtBookingEmployee";
            this.txtBookingEmployee.Size = new System.Drawing.Size(259, 24);
            this.txtBookingEmployee.TabIndex = 46;
            this.txtBookingEmployee.Text = "John Doe";
            // 
            // Booking_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 795);
            this.Controls.Add(this.txtBookingEmployee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBookingChangeDateEmployee);
            this.Controls.Add(this.btnBookingChangeCustomer);
            this.Controls.Add(this.dtmBookingDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBookingCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxBookingAdditions);
            this.Controls.Add(this.btnBookingProceed);
            this.Controls.Add(this.btnBookingCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstBookingAdditionsServices);
            this.Controls.Add(this.lstBookingAdditionsProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstBookingServices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBookingProducts);
            this.Controls.Add(this.cmbBookingPackage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numBookingGuests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookingLocation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking_Details";
            this.Text = "Booking_Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Details_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxBookingAdditions;
        private System.Windows.Forms.Button btnBookingProceed;
        private System.Windows.Forms.Button btnBookingCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBookingAdditionsServices;
        private System.Windows.Forms.ListBox lstBookingAdditionsProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBookingServices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBookingProducts;
        private System.Windows.Forms.ComboBox cmbBookingPackage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBookingGuests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookingLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookingCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmBookingDate;
        private System.Windows.Forms.Button btnBookingChangeCustomer;
        private System.Windows.Forms.Button btnBookingChangeDateEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookingEmployee;
    }
}