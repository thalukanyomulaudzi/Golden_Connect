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
            this.btnBookingProceed = new System.Windows.Forms.Button();
            this.btnBookingCancel = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnBookingProductAdd = new System.Windows.Forms.Button();
            this.btnBookingServiceAdd = new System.Windows.Forms.Button();
            this.numBookingProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnBookingProductRemove = new System.Windows.Forms.Button();
            this.btnBookingServiceRemove = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBookingTime = new System.Windows.Forms.TextBox();
            this.txtBookingTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxBookingPackage = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookingProductQuantity)).BeginInit();
            this.gbxBookingPackage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookingProceed
            // 
            this.btnBookingProceed.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookingProceed.Location = new System.Drawing.Point(910, 560);
            this.btnBookingProceed.Name = "btnBookingProceed";
            this.btnBookingProceed.Size = new System.Drawing.Size(104, 34);
            this.btnBookingProceed.TabIndex = 15;
            this.btnBookingProceed.Text = "Proceed";
            this.btnBookingProceed.UseVisualStyleBackColor = true;
            this.btnBookingProceed.Click += new System.EventHandler(this.BtnBookingProceed_Click);
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookingCancel.Location = new System.Drawing.Point(796, 560);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(104, 34);
            this.btnBookingCancel.TabIndex = 14;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 91);
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
            "Please select a package"});
            this.lstBookingServices.Location = new System.Drawing.Point(259, 122);
            this.lstBookingServices.Name = "lstBookingServices";
            this.lstBookingServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBookingServices.Size = new System.Drawing.Size(218, 184);
            this.lstBookingServices.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 91);
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
            "Please select a package"});
            this.lstBookingProducts.Location = new System.Drawing.Point(23, 122);
            this.lstBookingProducts.Name = "lstBookingProducts";
            this.lstBookingProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBookingProducts.Size = new System.Drawing.Size(218, 184);
            this.lstBookingProducts.TabIndex = 7;
            this.lstBookingProducts.SelectedIndexChanged += new System.EventHandler(this.LstBookingProducts_SelectedIndexChanged);
            // 
            // cmbBookingPackage
            // 
            this.cmbBookingPackage.FormattingEnabled = true;
            this.cmbBookingPackage.Location = new System.Drawing.Point(191, 42);
            this.cmbBookingPackage.Name = "cmbBookingPackage";
            this.cmbBookingPackage.Size = new System.Drawing.Size(286, 26);
            this.cmbBookingPackage.TabIndex = 6;
            this.cmbBookingPackage.SelectedIndexChanged += new System.EventHandler(this.CmbBookingPackage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select package";
            // 
            // numBookingGuests
            // 
            this.numBookingGuests.Location = new System.Drawing.Point(161, 318);
            this.numBookingGuests.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBookingGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBookingGuests.Name = "numBookingGuests";
            this.numBookingGuests.Size = new System.Drawing.Size(314, 24);
            this.numBookingGuests.TabIndex = 5;
            this.numBookingGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "# of guests";
            // 
            // txtBookingLocation
            // 
            this.txtBookingLocation.Location = new System.Drawing.Point(161, 214);
            this.txtBookingLocation.Multiline = true;
            this.txtBookingLocation.Name = "txtBookingLocation";
            this.txtBookingLocation.Size = new System.Drawing.Size(314, 81);
            this.txtBookingLocation.TabIndex = 4;
            this.txtBookingLocation.Text = "10 Example Road\r\nBrooklyn\r\n0181\r\nPretoria\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Customer: ";
            // 
            // txtBookingCustomer
            // 
            this.txtBookingCustomer.Enabled = false;
            this.txtBookingCustomer.Location = new System.Drawing.Point(161, 44);
            this.txtBookingCustomer.Name = "txtBookingCustomer";
            this.txtBookingCustomer.Size = new System.Drawing.Size(240, 24);
            this.txtBookingCustomer.TabIndex = 40;
            this.txtBookingCustomer.Text = "John Doe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date:";
            // 
            // dtmBookingDate
            // 
            this.dtmBookingDate.Enabled = false;
            this.dtmBookingDate.Location = new System.Drawing.Point(161, 128);
            this.dtmBookingDate.Name = "dtmBookingDate";
            this.dtmBookingDate.Size = new System.Drawing.Size(240, 24);
            this.dtmBookingDate.TabIndex = 42;
            // 
            // btnBookingChangeCustomer
            // 
            this.btnBookingChangeCustomer.Location = new System.Drawing.Point(407, 43);
            this.btnBookingChangeCustomer.Name = "btnBookingChangeCustomer";
            this.btnBookingChangeCustomer.Size = new System.Drawing.Size(68, 26);
            this.btnBookingChangeCustomer.TabIndex = 0;
            this.btnBookingChangeCustomer.Text = "Change";
            this.btnBookingChangeCustomer.UseVisualStyleBackColor = true;
            this.btnBookingChangeCustomer.Click += new System.EventHandler(this.BtnBookingChangeCustomer_Click);
            // 
            // btnBookingChangeDateEmployee
            // 
            this.btnBookingChangeDateEmployee.Location = new System.Drawing.Point(407, 88);
            this.btnBookingChangeDateEmployee.Name = "btnBookingChangeDateEmployee";
            this.btnBookingChangeDateEmployee.Size = new System.Drawing.Size(68, 104);
            this.btnBookingChangeDateEmployee.TabIndex = 1;
            this.btnBookingChangeDateEmployee.Text = "Change";
            this.btnBookingChangeDateEmployee.UseVisualStyleBackColor = true;
            this.btnBookingChangeDateEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Employee:";
            // 
            // txtBookingEmployee
            // 
            this.txtBookingEmployee.Enabled = false;
            this.txtBookingEmployee.Location = new System.Drawing.Point(161, 88);
            this.txtBookingEmployee.Name = "txtBookingEmployee";
            this.txtBookingEmployee.Size = new System.Drawing.Size(240, 24);
            this.txtBookingEmployee.TabIndex = 46;
            this.txtBookingEmployee.Text = "John Doe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Extras";
            // 
            // btnBookingProductAdd
            // 
            this.btnBookingProductAdd.Location = new System.Drawing.Point(98, 379);
            this.btnBookingProductAdd.Name = "btnBookingProductAdd";
            this.btnBookingProductAdd.Size = new System.Drawing.Size(143, 26);
            this.btnBookingProductAdd.TabIndex = 10;
            this.btnBookingProductAdd.Text = "Add Product";
            this.btnBookingProductAdd.UseVisualStyleBackColor = true;
            this.btnBookingProductAdd.Click += new System.EventHandler(this.BtnBookingProductAdd_Click);
            // 
            // btnBookingServiceAdd
            // 
            this.btnBookingServiceAdd.Location = new System.Drawing.Point(334, 379);
            this.btnBookingServiceAdd.Name = "btnBookingServiceAdd";
            this.btnBookingServiceAdd.Size = new System.Drawing.Size(143, 26);
            this.btnBookingServiceAdd.TabIndex = 12;
            this.btnBookingServiceAdd.Text = "Add Service";
            this.btnBookingServiceAdd.UseVisualStyleBackColor = true;
            this.btnBookingServiceAdd.Click += new System.EventHandler(this.BtnBookingServiceAdd_Click);
            // 
            // numBookingProductQuantity
            // 
            this.numBookingProductQuantity.Location = new System.Drawing.Point(23, 393);
            this.numBookingProductQuantity.Name = "numBookingProductQuantity";
            this.numBookingProductQuantity.Size = new System.Drawing.Size(46, 24);
            this.numBookingProductQuantity.TabIndex = 9;
            // 
            // btnBookingProductRemove
            // 
            this.btnBookingProductRemove.Location = new System.Drawing.Point(98, 411);
            this.btnBookingProductRemove.Name = "btnBookingProductRemove";
            this.btnBookingProductRemove.Size = new System.Drawing.Size(143, 26);
            this.btnBookingProductRemove.TabIndex = 11;
            this.btnBookingProductRemove.Text = "Remove Product";
            this.btnBookingProductRemove.UseVisualStyleBackColor = true;
            this.btnBookingProductRemove.Click += new System.EventHandler(this.BtnBookingProductRemove_Click);
            // 
            // btnBookingServiceRemove
            // 
            this.btnBookingServiceRemove.Location = new System.Drawing.Point(334, 411);
            this.btnBookingServiceRemove.Name = "btnBookingServiceRemove";
            this.btnBookingServiceRemove.Size = new System.Drawing.Size(143, 26);
            this.btnBookingServiceRemove.TabIndex = 13;
            this.btnBookingServiceRemove.Text = "Remove Service";
            this.btnBookingServiceRemove.UseVisualStyleBackColor = true;
            this.btnBookingServiceRemove.Click += new System.EventHandler(this.BtnBookingServiceRemove_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Time:";
            // 
            // txtBookingTime
            // 
            this.txtBookingTime.Enabled = false;
            this.txtBookingTime.Location = new System.Drawing.Point(161, 168);
            this.txtBookingTime.Name = "txtBookingTime";
            this.txtBookingTime.Size = new System.Drawing.Size(240, 24);
            this.txtBookingTime.TabIndex = 60;
            this.txtBookingTime.Text = "John Doe";
            // 
            // txtBookingTotal
            // 
            this.txtBookingTotal.Enabled = false;
            this.txtBookingTotal.Location = new System.Drawing.Point(659, 565);
            this.txtBookingTotal.Name = "txtBookingTotal";
            this.txtBookingTotal.Size = new System.Drawing.Size(119, 24);
            this.txtBookingTotal.TabIndex = 61;
            this.txtBookingTotal.Text = "John Doe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 568);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Booking total";
            // 
            // gbxBookingPackage
            // 
            this.gbxBookingPackage.Controls.Add(this.lstBookingServices);
            this.gbxBookingPackage.Controls.Add(this.label3);
            this.gbxBookingPackage.Controls.Add(this.cmbBookingPackage);
            this.gbxBookingPackage.Controls.Add(this.lstBookingProducts);
            this.gbxBookingPackage.Controls.Add(this.btnBookingServiceRemove);
            this.gbxBookingPackage.Controls.Add(this.label4);
            this.gbxBookingPackage.Controls.Add(this.btnBookingProductRemove);
            this.gbxBookingPackage.Controls.Add(this.label5);
            this.gbxBookingPackage.Controls.Add(this.numBookingProductQuantity);
            this.gbxBookingPackage.Controls.Add(this.btnBookingServiceAdd);
            this.gbxBookingPackage.Controls.Add(this.label6);
            this.gbxBookingPackage.Controls.Add(this.btnBookingProductAdd);
            this.gbxBookingPackage.Location = new System.Drawing.Point(537, 12);
            this.gbxBookingPackage.Name = "gbxBookingPackage";
            this.gbxBookingPackage.Size = new System.Drawing.Size(502, 513);
            this.gbxBookingPackage.TabIndex = 63;
            this.gbxBookingPackage.TabStop = false;
            this.gbxBookingPackage.Text = "Package";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBookingLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numBookingGuests);
            this.groupBox1.Controls.Add(this.txtBookingTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBookingCustomer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtmBookingDate);
            this.groupBox1.Controls.Add(this.btnBookingChangeCustomer);
            this.groupBox1.Controls.Add(this.btnBookingChangeDateEmployee);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBookingEmployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 513);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Booking_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 766);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBookingPackage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBookingProceed);
            this.Controls.Add(this.btnBookingCancel);
            this.Controls.Add(this.txtBookingTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking_Details";
            this.Text = "Booking_Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Details_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBookingProductQuantity)).EndInit();
            this.gbxBookingPackage.ResumeLayout(false);
            this.gbxBookingPackage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBookingProceed;
        private System.Windows.Forms.Button btnBookingCancel;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBookingProductAdd;
        private System.Windows.Forms.Button btnBookingServiceAdd;
        private System.Windows.Forms.NumericUpDown numBookingProductQuantity;
        private System.Windows.Forms.Button btnBookingProductRemove;
        private System.Windows.Forms.Button btnBookingServiceRemove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBookingTime;
        private System.Windows.Forms.TextBox txtBookingTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxBookingPackage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}