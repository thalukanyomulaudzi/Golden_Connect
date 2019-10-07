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
            this.label12 = new System.Windows.Forms.Label();
            this.txtBookingTime = new System.Windows.Forms.TextBox();
            this.txtBookingTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxBookingPackage = new System.Windows.Forms.GroupBox();
            this.gbxBookingDetails = new System.Windows.Forms.GroupBox();
            this.dgvProductsInPackage = new System.Windows.Forms.DataGridView();
            this.PIPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PIPRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvServicesInPackage = new System.Windows.Forms.DataGridView();
            this.SIPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServicesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).BeginInit();
            this.gbxBookingPackage.SuspendLayout();
            this.gbxBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookingProceed
            // 
            this.btnBookingProceed.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookingProceed.Location = new System.Drawing.Point(856, 692);
            this.btnBookingProceed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBookingProceed.Name = "btnBookingProceed";
            this.btnBookingProceed.Size = new System.Drawing.Size(81, 30);
            this.btnBookingProceed.TabIndex = 15;
            this.btnBookingProceed.Text = "Proceed";
            this.btnBookingProceed.UseVisualStyleBackColor = true;
            this.btnBookingProceed.Click += new System.EventHandler(this.BtnBookingProceed_Click);
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookingCancel.Location = new System.Drawing.Point(767, 692);
            this.btnBookingCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(81, 30);
            this.btnBookingCancel.TabIndex = 14;
            this.btnBookingCancel.Text = "Cancel";
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            // 
            // cmbBookingPackage
            // 
            this.cmbBookingPackage.FormattingEnabled = true;
            this.cmbBookingPackage.Location = new System.Drawing.Point(244, 27);
            this.cmbBookingPackage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbBookingPackage.Name = "cmbBookingPackage";
            this.cmbBookingPackage.Size = new System.Drawing.Size(223, 24);
            this.cmbBookingPackage.TabIndex = 6;
            this.cmbBookingPackage.SelectedIndexChanged += new System.EventHandler(this.CmbBookingPackage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select package";
            // 
            // numBookingGuests
            // 
            this.numBookingGuests.Location = new System.Drawing.Point(121, 155);
            this.numBookingGuests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.numBookingGuests.Size = new System.Drawing.Size(248, 23);
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
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "# of guests";
            // 
            // txtBookingLocation
            // 
            this.txtBookingLocation.Location = new System.Drawing.Point(121, 74);
            this.txtBookingLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookingLocation.Multiline = true;
            this.txtBookingLocation.Name = "txtBookingLocation";
            this.txtBookingLocation.Size = new System.Drawing.Size(248, 72);
            this.txtBookingLocation.TabIndex = 4;
            this.txtBookingLocation.Text = "10 Example Road\r\nBrooklyn\r\n0181\r\nPretoria\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Customer: ";
            // 
            // txtBookingCustomer
            // 
            this.txtBookingCustomer.Enabled = false;
            this.txtBookingCustomer.Location = new System.Drawing.Point(121, 39);
            this.txtBookingCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookingCustomer.Name = "txtBookingCustomer";
            this.txtBookingCustomer.Size = new System.Drawing.Size(164, 23);
            this.txtBookingCustomer.TabIndex = 40;
            this.txtBookingCustomer.Text = "John Doe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date:";
            // 
            // dtmBookingDate
            // 
            this.dtmBookingDate.Enabled = false;
            this.dtmBookingDate.Location = new System.Drawing.Point(561, 75);
            this.dtmBookingDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtmBookingDate.Name = "dtmBookingDate";
            this.dtmBookingDate.Size = new System.Drawing.Size(188, 23);
            this.dtmBookingDate.TabIndex = 42;
            // 
            // btnBookingChangeCustomer
            // 
            this.btnBookingChangeCustomer.Location = new System.Drawing.Point(289, 38);
            this.btnBookingChangeCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBookingChangeCustomer.Name = "btnBookingChangeCustomer";
            this.btnBookingChangeCustomer.Size = new System.Drawing.Size(80, 23);
            this.btnBookingChangeCustomer.TabIndex = 0;
            this.btnBookingChangeCustomer.Text = "Change";
            this.btnBookingChangeCustomer.UseVisualStyleBackColor = true;
            this.btnBookingChangeCustomer.Click += new System.EventHandler(this.BtnBookingChangeCustomer_Click);
            // 
            // btnBookingChangeDateEmployee
            // 
            this.btnBookingChangeDateEmployee.Location = new System.Drawing.Point(752, 39);
            this.btnBookingChangeDateEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBookingChangeDateEmployee.Name = "btnBookingChangeDateEmployee";
            this.btnBookingChangeDateEmployee.Size = new System.Drawing.Size(65, 94);
            this.btnBookingChangeDateEmployee.TabIndex = 1;
            this.btnBookingChangeDateEmployee.Text = "Change";
            this.btnBookingChangeDateEmployee.UseVisualStyleBackColor = true;
            this.btnBookingChangeDateEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Employee:";
            // 
            // txtBookingEmployee
            // 
            this.txtBookingEmployee.Enabled = false;
            this.txtBookingEmployee.Location = new System.Drawing.Point(561, 39);
            this.txtBookingEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookingEmployee.Name = "txtBookingEmployee";
            this.txtBookingEmployee.Size = new System.Drawing.Size(188, 23);
            this.txtBookingEmployee.TabIndex = 46;
            this.txtBookingEmployee.Text = "John Doe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Time:";
            // 
            // txtBookingTime
            // 
            this.txtBookingTime.Enabled = false;
            this.txtBookingTime.Location = new System.Drawing.Point(561, 110);
            this.txtBookingTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookingTime.Name = "txtBookingTime";
            this.txtBookingTime.Size = new System.Drawing.Size(188, 23);
            this.txtBookingTime.TabIndex = 60;
            this.txtBookingTime.Text = "John Doe";
            // 
            // txtBookingTotal
            // 
            this.txtBookingTotal.Enabled = false;
            this.txtBookingTotal.Location = new System.Drawing.Point(120, 696);
            this.txtBookingTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookingTotal.Name = "txtBookingTotal";
            this.txtBookingTotal.Size = new System.Drawing.Size(93, 23);
            this.txtBookingTotal.TabIndex = 61;
            this.txtBookingTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Booking total";
            // 
            // gbxBookingPackage
            // 
            this.gbxBookingPackage.Controls.Add(this.label17);
            this.gbxBookingPackage.Controls.Add(this.dgvServices);
            this.gbxBookingPackage.Controls.Add(this.dgvProducts);
            this.gbxBookingPackage.Controls.Add(this.label13);
            this.gbxBookingPackage.Controls.Add(this.dgvServicesInPackage);
            this.gbxBookingPackage.Controls.Add(this.label15);
            this.gbxBookingPackage.Controls.Add(this.label11);
            this.gbxBookingPackage.Controls.Add(this.dgvProductsInPackage);
            this.gbxBookingPackage.Controls.Add(this.cmbBookingPackage);
            this.gbxBookingPackage.Controls.Add(this.label3);
            this.gbxBookingPackage.Location = new System.Drawing.Point(9, 208);
            this.gbxBookingPackage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxBookingPackage.Name = "gbxBookingPackage";
            this.gbxBookingPackage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxBookingPackage.Size = new System.Drawing.Size(928, 465);
            this.gbxBookingPackage.TabIndex = 63;
            this.gbxBookingPackage.TabStop = false;
            this.gbxBookingPackage.Text = "Package Details";
            // 
            // gbxBookingDetails
            // 
            this.gbxBookingDetails.Controls.Add(this.txtBookingLocation);
            this.gbxBookingDetails.Controls.Add(this.label1);
            this.gbxBookingDetails.Controls.Add(this.label2);
            this.gbxBookingDetails.Controls.Add(this.numBookingGuests);
            this.gbxBookingDetails.Controls.Add(this.txtBookingTime);
            this.gbxBookingDetails.Controls.Add(this.label7);
            this.gbxBookingDetails.Controls.Add(this.label12);
            this.gbxBookingDetails.Controls.Add(this.txtBookingCustomer);
            this.gbxBookingDetails.Controls.Add(this.label9);
            this.gbxBookingDetails.Controls.Add(this.dtmBookingDate);
            this.gbxBookingDetails.Controls.Add(this.btnBookingChangeCustomer);
            this.gbxBookingDetails.Controls.Add(this.btnBookingChangeDateEmployee);
            this.gbxBookingDetails.Controls.Add(this.label10);
            this.gbxBookingDetails.Controls.Add(this.txtBookingEmployee);
            this.gbxBookingDetails.Location = new System.Drawing.Point(9, 11);
            this.gbxBookingDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxBookingDetails.Name = "gbxBookingDetails";
            this.gbxBookingDetails.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxBookingDetails.Size = new System.Drawing.Size(928, 191);
            this.gbxBookingDetails.TabIndex = 64;
            this.gbxBookingDetails.TabStop = false;
            this.gbxBookingDetails.Text = "Booking Details";
            // 
            // dgvProductsInPackage
            // 
            this.dgvProductsInPackage.AllowUserToAddRows = false;
            this.dgvProductsInPackage.AllowUserToDeleteRows = false;
            this.dgvProductsInPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsInPackage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductsInPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIPID,
            this.PIPName,
            this.PIPQuantity,
            this.PIPPrice,
            this.PIPAdd,
            this.PIPRemove});
            this.dgvProductsInPackage.Location = new System.Drawing.Point(17, 290);
            this.dgvProductsInPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductsInPackage.Name = "dgvProductsInPackage";
            this.dgvProductsInPackage.ReadOnly = true;
            this.dgvProductsInPackage.RowHeadersVisible = false;
            this.dgvProductsInPackage.Size = new System.Drawing.Size(450, 158);
            this.dgvProductsInPackage.TabIndex = 86;
            this.dgvProductsInPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductsInPackage_CellContentClick);
            // 
            // PIPID
            // 
            this.PIPID.HeaderText = "ID";
            this.PIPID.Name = "PIPID";
            this.PIPID.ReadOnly = true;
            this.PIPID.Visible = false;
            // 
            // PIPName
            // 
            this.PIPName.HeaderText = "Product Name";
            this.PIPName.Name = "PIPName";
            this.PIPName.ReadOnly = true;
            // 
            // PIPQuantity
            // 
            this.PIPQuantity.HeaderText = "Quantity";
            this.PIPQuantity.Name = "PIPQuantity";
            this.PIPQuantity.ReadOnly = true;
            // 
            // PIPPrice
            // 
            this.PIPPrice.HeaderText = "Price";
            this.PIPPrice.Name = "PIPPrice";
            this.PIPPrice.ReadOnly = true;
            // 
            // PIPAdd
            // 
            this.PIPAdd.HeaderText = "";
            this.PIPAdd.Name = "PIPAdd";
            this.PIPAdd.ReadOnly = true;
            // 
            // PIPRemove
            // 
            this.PIPRemove.HeaderText = "";
            this.PIPRemove.Name = "PIPRemove";
            this.PIPRemove.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 88;
            this.label11.Text = "Products in Package :";
            // 
            // dgvServicesInPackage
            // 
            this.dgvServicesInPackage.AllowUserToAddRows = false;
            this.dgvServicesInPackage.AllowUserToDeleteRows = false;
            this.dgvServicesInPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicesInPackage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicesInPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicesInPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIPID,
            this.SIPName,
            this.SIPPrice,
            this.SIPRemove});
            this.dgvServicesInPackage.Location = new System.Drawing.Point(17, 82);
            this.dgvServicesInPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvServicesInPackage.Name = "dgvServicesInPackage";
            this.dgvServicesInPackage.ReadOnly = true;
            this.dgvServicesInPackage.RowHeadersVisible = false;
            this.dgvServicesInPackage.Size = new System.Drawing.Size(450, 158);
            this.dgvServicesInPackage.TabIndex = 85;
            this.dgvServicesInPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvServicesInPackage_CellContentClick);
            // 
            // SIPID
            // 
            this.SIPID.HeaderText = "ID";
            this.SIPID.Name = "SIPID";
            this.SIPID.ReadOnly = true;
            this.SIPID.Visible = false;
            // 
            // SIPName
            // 
            this.SIPName.HeaderText = "Service Name";
            this.SIPName.Name = "SIPName";
            this.SIPName.ReadOnly = true;
            // 
            // SIPPrice
            // 
            this.SIPPrice.HeaderText = "Price";
            this.SIPPrice.Name = "SIPPrice";
            this.SIPPrice.ReadOnly = true;
            // 
            // SIPRemove
            // 
            this.SIPRemove.HeaderText = "";
            this.SIPRemove.Name = "SIPRemove";
            this.SIPRemove.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 16);
            this.label15.TabIndex = 87;
            this.label15.Text = "Services in Package :";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServicesID,
            this.ServicesName,
            this.ServicesPrice,
            this.ServicesAdd});
            this.dgvServices.Location = new System.Drawing.Point(506, 82);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.Size = new System.Drawing.Size(411, 158);
            this.dgvServices.TabIndex = 65;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvServices_CellContentClick);
            // 
            // ServicesID
            // 
            this.ServicesID.HeaderText = "ID";
            this.ServicesID.Name = "ServicesID";
            this.ServicesID.ReadOnly = true;
            this.ServicesID.Visible = false;
            // 
            // ServicesName
            // 
            this.ServicesName.HeaderText = "Service Name";
            this.ServicesName.Name = "ServicesName";
            this.ServicesName.ReadOnly = true;
            // 
            // ServicesPrice
            // 
            this.ServicesPrice.HeaderText = "Price";
            this.ServicesPrice.Name = "ServicesPrice";
            this.ServicesPrice.ReadOnly = true;
            // 
            // ServicesAdd
            // 
            this.ServicesAdd.HeaderText = "";
            this.ServicesAdd.Name = "ServicesAdd";
            this.ServicesAdd.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 16);
            this.label13.TabIndex = 67;
            this.label13.Text = "Additional Services :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(503, 270);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 16);
            this.label17.TabIndex = 68;
            this.label17.Text = "Additional Products :";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsID,
            this.ProductsName,
            this.ProductPrice,
            this.ProductAdd});
            this.dgvProducts.Location = new System.Drawing.Point(506, 290);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(411, 158);
            this.dgvProducts.TabIndex = 66;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellContentClick);
            // 
            // ProductsID
            // 
            this.ProductsID.HeaderText = "ID";
            this.ProductsID.Name = "ProductsID";
            this.ProductsID.ReadOnly = true;
            this.ProductsID.Visible = false;
            // 
            // ProductsName
            // 
            this.ProductsName.HeaderText = "Product Name";
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductAdd
            // 
            this.ProductAdd.HeaderText = "";
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.ReadOnly = true;
            // 
            // Booking_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 801);
            this.Controls.Add(this.gbxBookingDetails);
            this.Controls.Add(this.gbxBookingPackage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBookingProceed);
            this.Controls.Add(this.txtBookingTotal);
            this.Controls.Add(this.btnBookingCancel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Booking_Details";
            this.Text = "Booking_Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Details_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBookingGuests)).EndInit();
            this.gbxBookingPackage.ResumeLayout(false);
            this.gbxBookingPackage.PerformLayout();
            this.gbxBookingDetails.ResumeLayout(false);
            this.gbxBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBookingProceed;
        private System.Windows.Forms.Button btnBookingCancel;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBookingTime;
        private System.Windows.Forms.TextBox txtBookingTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxBookingPackage;
        private System.Windows.Forms.GroupBox gbxBookingDetails;
        private System.Windows.Forms.DataGridView dgvServicesInPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPPrice;
        private System.Windows.Forms.DataGridViewButtonColumn SIPRemove;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProductsInPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPPrice;
        private System.Windows.Forms.DataGridViewButtonColumn PIPAdd;
        private System.Windows.Forms.DataGridViewButtonColumn PIPRemove;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ServicesAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ProductAdd;
    }
}