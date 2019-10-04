namespace Design370
{
    partial class Event_Package_View
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPackage = new System.Windows.Forms.GroupBox();
            this.lblPackageDescription = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgvProductsInPackage = new System.Windows.Forms.DataGridView();
            this.PIPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIPAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PIPRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchSIP = new System.Windows.Forms.TextBox();
            this.dgvServicesInPackage = new System.Windows.Forms.DataGridView();
            this.SIPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIPRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServicesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.txtSearchServices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInPackage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(615, 638);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 35);
            this.button5.TabIndex = 74;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(739, 638);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 35);
            this.button6.TabIndex = 73;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDescription.Location = new System.Drawing.Point(18, 111);
            this.txtPackageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageDescription.Multiline = true;
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(207, 205);
            this.txtPackageDescription.TabIndex = 62;
            this.txtPackageDescription.TextChanged += new System.EventHandler(this.TxtPackageDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Description :";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(18, 57);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(207, 23);
            this.txtPackageName.TabIndex = 60;
            this.txtPackageName.TextChanged += new System.EventHandler(this.TxtPackageName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name :";
            // 
            // grbPackage
            // 
            this.grbPackage.Controls.Add(this.lblPackageDescription);
            this.grbPackage.Controls.Add(this.lblPackageName);
            this.grbPackage.Controls.Add(this.label11);
            this.grbPackage.Controls.Add(this.txtPackageDescription);
            this.grbPackage.Controls.Add(this.label2);
            this.grbPackage.Controls.Add(this.button5);
            this.grbPackage.Controls.Add(this.txtPackageName);
            this.grbPackage.Controls.Add(this.textBox3);
            this.grbPackage.Controls.Add(this.label1);
            this.grbPackage.Controls.Add(this.button6);
            this.grbPackage.Controls.Add(this.dgvProductsInPackage);
            this.grbPackage.Controls.Add(this.label5);
            this.grbPackage.Controls.Add(this.txtSearchPIP);
            this.grbPackage.Controls.Add(this.label8);
            this.grbPackage.Controls.Add(this.label7);
            this.grbPackage.Controls.Add(this.txtSearchSIP);
            this.grbPackage.Controls.Add(this.dgvServicesInPackage);
            this.grbPackage.Controls.Add(this.label13);
            this.grbPackage.Location = new System.Drawing.Point(14, 15);
            this.grbPackage.Margin = new System.Windows.Forms.Padding(4);
            this.grbPackage.Name = "grbPackage";
            this.grbPackage.Padding = new System.Windows.Forms.Padding(4);
            this.grbPackage.Size = new System.Drawing.Size(878, 689);
            this.grbPackage.TabIndex = 78;
            this.grbPackage.TabStop = false;
            this.grbPackage.Text = "Package Details";
            // 
            // lblPackageDescription
            // 
            this.lblPackageDescription.AutoSize = true;
            this.lblPackageDescription.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageDescription.ForeColor = System.Drawing.Color.Red;
            this.lblPackageDescription.Location = new System.Drawing.Point(230, 114);
            this.lblPackageDescription.Name = "lblPackageDescription";
            this.lblPackageDescription.Size = new System.Drawing.Size(15, 16);
            this.lblPackageDescription.TabIndex = 82;
            this.lblPackageDescription.Text = "✘";
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.Red;
            this.lblPackageName.Location = new System.Drawing.Point(230, 60);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(15, 16);
            this.lblPackageName.TabIndex = 81;
            this.lblPackageName.Text = "✘";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 327);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "Total Price :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(18, 347);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 25;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 23);
            this.textBox3.TabIndex = 60;
            this.textBox3.Text = "R0.00";
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
            this.dgvProductsInPackage.Location = new System.Drawing.Point(262, 372);
            this.dgvProductsInPackage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductsInPackage.Name = "dgvProductsInPackage";
            this.dgvProductsInPackage.ReadOnly = true;
            this.dgvProductsInPackage.RowHeadersVisible = false;
            this.dgvProductsInPackage.Size = new System.Drawing.Size(578, 245);
            this.dgvProductsInPackage.TabIndex = 47;
            this.dgvProductsInPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsInPackage_CellContentClick);
            this.dgvProductsInPackage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductsInPackage_CellPainting);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Products in Package :";
            // 
            // txtSearchPIP
            // 
            this.txtSearchPIP.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPIP.Location = new System.Drawing.Point(657, 332);
            this.txtSearchPIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPIP.Name = "txtSearchPIP";
            this.txtSearchPIP.Size = new System.Drawing.Size(182, 23);
            this.txtSearchPIP.TabIndex = 55;
            this.txtSearchPIP.TextChanged += new System.EventHandler(this.txtSearchPIP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Search :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Search :";
            // 
            // txtSearchSIP
            // 
            this.txtSearchSIP.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSIP.Location = new System.Drawing.Point(657, 33);
            this.txtSearchSIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSIP.Name = "txtSearchSIP";
            this.txtSearchSIP.Size = new System.Drawing.Size(182, 23);
            this.txtSearchSIP.TabIndex = 53;
            this.txtSearchSIP.TextChanged += new System.EventHandler(this.txtSearchSIP_TextChanged);
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
            this.dgvServicesInPackage.Location = new System.Drawing.Point(262, 71);
            this.dgvServicesInPackage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServicesInPackage.Name = "dgvServicesInPackage";
            this.dgvServicesInPackage.ReadOnly = true;
            this.dgvServicesInPackage.RowHeadersVisible = false;
            this.dgvServicesInPackage.Size = new System.Drawing.Size(578, 245);
            this.dgvServicesInPackage.TabIndex = 45;
            this.dgvServicesInPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicesInPackage_CellContentClick);
            this.dgvServicesInPackage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvServicesInPackage_CellPainting);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Services in Package :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgvServices);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchProducts);
            this.groupBox1.Controls.Add(this.txtSearchServices);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(899, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(564, 689);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Services and Products";
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
            this.dgvServices.Location = new System.Drawing.Point(35, 71);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.Size = new System.Drawing.Size(486, 245);
            this.dgvServices.TabIndex = 46;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            this.dgvServices.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvServices_CellPainting);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Services :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 336);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Search :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Search :";
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProducts.Location = new System.Drawing.Point(339, 332);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(182, 23);
            this.txtSearchProducts.TabIndex = 56;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.txtSearchProducts_TextChanged);
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchServices.Location = new System.Drawing.Point(339, 33);
            this.txtSearchServices.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(182, 23);
            this.txtSearchServices.TabIndex = 54;
            this.txtSearchServices.TextChanged += new System.EventHandler(this.txtSearchServices_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Products :";
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
            this.dgvProducts.Location = new System.Drawing.Point(35, 372);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(486, 245);
            this.dgvProducts.TabIndex = 48;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProducts_CellPainting);
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
            // Event_Package_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbPackage);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Event_Package_View";
            this.Text = "View Event Package";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventPackage_View_FormClosing);
            this.Load += new System.EventHandler(this.EventPackage_View_Load);
            this.grbPackage.ResumeLayout(false);
            this.grbPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInPackage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPackage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgvProductsInPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIPPrice;
        private System.Windows.Forms.DataGridViewButtonColumn PIPAdd;
        private System.Windows.Forms.DataGridViewButtonColumn PIPRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchSIP;
        private System.Windows.Forms.DataGridView dgvServicesInPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIPPrice;
        private System.Windows.Forms.DataGridViewButtonColumn SIPRemove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ServicesAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.TextBox txtSearchServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ProductAdd;
        private System.Windows.Forms.Label lblPackageDescription;
        private System.Windows.Forms.Label lblPackageName;
    }
}