using System;
using System.Windows.Forms;

namespace Design370
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lblCustomerSort = new System.Windows.Forms.Label();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIDNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTimeslots = new System.Windows.Forms.Label();
            this.btnTimeslotAdd = new System.Windows.Forms.Button();
            this.dgvTimeslots = new System.Windows.Forms.DataGridView();
            this.timeslotDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnServiceType = new System.Windows.Forms.Button();
            this.lblServiceSearch = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ServiceEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ServiceDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnPhotoshootPackageAdd = new System.Windows.Forms.Button();
            this.lblPhotoshootPackageSearch = new System.Windows.Forms.Label();
            this.txtPhotoshootPackageSearch = new System.Windows.Forms.TextBox();
            this.dgvPhotoshootPackage = new System.Windows.Forms.DataGridView();
            this.PhotoshootPackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoshootPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoshootPackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoshootPackageView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PhotoshootPackageEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PhotoshootPackageDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPhotoshootTypes = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnEventTypes = new System.Windows.Forms.Button();
            this.lblEventPackageSearch = new System.Windows.Forms.Label();
            this.txtEventPackageSearch = new System.Windows.Forms.TextBox();
            this.btnEventPackageAdd = new System.Windows.Forms.Button();
            this.dgvEventPackages = new System.Windows.Forms.DataGridView();
            this.EventPackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesEvents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsEvents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventPackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventPackageView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventPackageEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventPackageDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ViewOrderProducts = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerOrderPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btnBookingAdd = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.bookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookingEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookingDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblBookingSearch = new System.Windows.Forms.Label();
            this.txtBookingSearch = new System.Windows.Forms.TextBox();
            this.btnBookingCapture = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SupplierEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SupplierDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button22 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoshootPackage)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventPackages)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 616);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cmb);
            this.tabPage1.Controls.Add(this.lblCustomerSort);
            this.tabPage1.Controls.Add(this.lblCustomerSearch);
            this.tabPage1.Controls.Add(this.txtCustomerSearch);
            this.tabPage1.Controls.Add(this.btnCustomerAdd);
            this.tabPage1.Controls.Add(this.dgvCustomers);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1104, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.ItemHeight = 17;
            this.cmb.Location = new System.Drawing.Point(339, 11);
            this.cmb.Margin = new System.Windows.Forms.Padding(2);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(103, 25);
            this.cmb.TabIndex = 8;
            // 
            // lblCustomerSort
            // 
            this.lblCustomerSort.AutoSize = true;
            this.lblCustomerSort.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSort.Location = new System.Drawing.Point(281, 15);
            this.lblCustomerSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerSort.Name = "lblCustomerSort";
            this.lblCustomerSort.Size = new System.Drawing.Size(56, 18);
            this.lblCustomerSort.TabIndex = 7;
            this.lblCustomerSort.Text = "Sort by:";
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSearch.Location = new System.Drawing.Point(8, 16);
            this.lblCustomerSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(57, 18);
            this.lblCustomerSearch.TabIndex = 5;
            this.lblCustomerSearch.Text = "Search:";
            this.lblCustomerSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(71, 13);
            this.txtCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(200, 25);
            this.txtCustomerSearch.TabIndex = 4;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(623, 11);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(151, 28);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.Text = "Add Customer";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustFirst,
            this.CustLast,
            this.CustID,
            this.CustView,
            this.CustEdit,
            this.CustDelete});
            this.dgvCustomers.Location = new System.Drawing.Point(11, 59);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(763, 349);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustFirst
            // 
            this.CustFirst.HeaderText = "First Name";
            this.CustFirst.Name = "CustFirst";
            // 
            // CustLast
            // 
            this.CustLast.HeaderText = "Last Name";
            this.CustLast.Name = "CustLast";
            // 
            // CustID
            // 
            this.CustID.HeaderText = "ID Number";
            this.CustID.Name = "CustID";
            // 
            // CustView
            // 
            this.CustView.HeaderText = "";
            this.CustView.Name = "CustView";
            this.CustView.Text = "View";
            this.CustView.ToolTipText = "View";
            this.CustView.UseColumnTextForButtonValue = true;
            // 
            // CustEdit
            // 
            this.CustEdit.HeaderText = "";
            this.CustEdit.Name = "CustEdit";
            this.CustEdit.Text = "Edit";
            this.CustEdit.ToolTipText = "Edit Row";
            this.CustEdit.UseColumnTextForButtonValue = true;
            // 
            // CustDelete
            // 
            this.CustDelete.HeaderText = "";
            this.CustDelete.Name = "CustDelete";
            this.CustDelete.Text = "Delete";
            this.CustDelete.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.empGrid);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1104, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(936, 428);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 28);
            this.button7.TabIndex = 16;
            this.button7.Text = "Employee Types";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(71, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(936, 16);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 28);
            this.button8.TabIndex = 10;
            this.button8.Text = "Add Employee";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // empGrid
            // 
            this.empGrid.AllowUserToAddRows = false;
            this.empGrid.AllowUserToDeleteRows = false;
            this.empGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeIDNum,
            this.EmployeeName,
            this.EmployeePhone,
            this.EmployeeEmail,
            this.EmployeeType,
            this.View,
            this.Edit,
            this.Delete});
            this.empGrid.Location = new System.Drawing.Point(11, 58);
            this.empGrid.Margin = new System.Windows.Forms.Padding(2);
            this.empGrid.Name = "empGrid";
            this.empGrid.ReadOnly = true;
            this.empGrid.RowHeadersVisible = false;
            this.empGrid.RowTemplate.Height = 24;
            this.empGrid.Size = new System.Drawing.Size(1076, 355);
            this.empGrid.TabIndex = 9;
            this.empGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView4_CellContentClick);
            this.empGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.empGrid_CellPainting);
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            // 
            // EmployeeIDNum
            // 
            this.EmployeeIDNum.HeaderText = "ID Number";
            this.EmployeeIDNum.Name = "EmployeeIDNum";
            this.EmployeeIDNum.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.HeaderText = "Phone Number";
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.ReadOnly = true;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.HeaderText = "Email Address";
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.ReadOnly = true;
            // 
            // EmployeeType
            // 
            this.EmployeeType.HeaderText = "Employee Type";
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "View";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTimeslots);
            this.tabPage3.Controls.Add(this.btnTimeslotAdd);
            this.tabPage3.Controls.Add(this.dgvTimeslots);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1104, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timeslot";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // lblTimeslots
            // 
            this.lblTimeslots.AutoSize = true;
            this.lblTimeslots.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeslots.Location = new System.Drawing.Point(8, 21);
            this.lblTimeslots.Name = "lblTimeslots";
            this.lblTimeslots.Size = new System.Drawing.Size(202, 23);
            this.lblTimeslots.TabIndex = 18;
            this.lblTimeslots.Text = "Timeslots for this week";
            // 
            // btnTimeslotAdd
            // 
            this.btnTimeslotAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeslotAdd.Location = new System.Drawing.Point(623, 16);
            this.btnTimeslotAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeslotAdd.Name = "btnTimeslotAdd";
            this.btnTimeslotAdd.Size = new System.Drawing.Size(151, 28);
            this.btnTimeslotAdd.TabIndex = 17;
            this.btnTimeslotAdd.Text = "Add Timeslots";
            this.btnTimeslotAdd.UseVisualStyleBackColor = true;
            this.btnTimeslotAdd.Click += new System.EventHandler(this.BtnTimeslotAdd_Click);
            // 
            // dgvTimeslots
            // 
            this.dgvTimeslots.AllowUserToAddRows = false;
            this.dgvTimeslots.AllowUserToDeleteRows = false;
            this.dgvTimeslots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeslots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimeslots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeslots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeslotDay1,
            this.timeslotDay2,
            this.timeslotDay3,
            this.timeslotDay4,
            this.timeslotDay5,
            this.timeslotDay6,
            this.timeslotDay7});
            this.dgvTimeslots.Location = new System.Drawing.Point(11, 59);
            this.dgvTimeslots.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTimeslots.Name = "dgvTimeslots";
            this.dgvTimeslots.ReadOnly = true;
            this.dgvTimeslots.RowTemplate.Height = 24;
            this.dgvTimeslots.Size = new System.Drawing.Size(763, 356);
            this.dgvTimeslots.TabIndex = 16;
            // 
            // timeslotDay1
            // 
            this.timeslotDay1.HeaderText = "Day1";
            this.timeslotDay1.Name = "timeslotDay1";
            this.timeslotDay1.ReadOnly = true;
            // 
            // timeslotDay2
            // 
            this.timeslotDay2.HeaderText = "Day2";
            this.timeslotDay2.Name = "timeslotDay2";
            this.timeslotDay2.ReadOnly = true;
            // 
            // timeslotDay3
            // 
            this.timeslotDay3.HeaderText = "Day3";
            this.timeslotDay3.Name = "timeslotDay3";
            this.timeslotDay3.ReadOnly = true;
            // 
            // timeslotDay4
            // 
            this.timeslotDay4.HeaderText = "Day4";
            this.timeslotDay4.Name = "timeslotDay4";
            this.timeslotDay4.ReadOnly = true;
            // 
            // timeslotDay5
            // 
            this.timeslotDay5.HeaderText = "Day5";
            this.timeslotDay5.Name = "timeslotDay5";
            this.timeslotDay5.ReadOnly = true;
            // 
            // timeslotDay6
            // 
            this.timeslotDay6.HeaderText = "Day6";
            this.timeslotDay6.Name = "timeslotDay6";
            this.timeslotDay6.ReadOnly = true;
            // 
            // timeslotDay7
            // 
            this.timeslotDay7.HeaderText = "Day7";
            this.timeslotDay7.Name = "timeslotDay7";
            this.timeslotDay7.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnServiceType);
            this.tabPage4.Controls.Add(this.lblServiceSearch);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.btnServiceAdd);
            this.tabPage4.Controls.Add(this.dgvServices);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1104, 608);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Services";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnServiceType
            // 
            this.btnServiceType.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceType.Location = new System.Drawing.Point(623, 427);
            this.btnServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(151, 28);
            this.btnServiceType.TabIndex = 38;
            this.btnServiceType.Text = "Service Types";
            this.btnServiceType.UseVisualStyleBackColor = true;
            this.btnServiceType.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblServiceSearch
            // 
            this.lblServiceSearch.AutoSize = true;
            this.lblServiceSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceSearch.Location = new System.Drawing.Point(8, 16);
            this.lblServiceSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceSearch.Name = "lblServiceSearch";
            this.lblServiceSearch.Size = new System.Drawing.Size(57, 18);
            this.lblServiceSearch.TabIndex = 13;
            this.lblServiceSearch.Text = "Search:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(71, 13);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAdd.Location = new System.Drawing.Point(623, 11);
            this.btnServiceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(151, 28);
            this.btnServiceAdd.TabIndex = 10;
            this.btnServiceAdd.Text = "Add Service";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.ServiceType,
            this.ServicePrice,
            this.ServiceView,
            this.ServiceEdit,
            this.ServiceDelete});
            this.dgvServices.Location = new System.Drawing.Point(11, 59);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(2);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(763, 349);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            this.dgvServices.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvServices_CellPainting);
            // 
            // ServiceID
            // 
            this.ServiceID.HeaderText = "ID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            // 
            // ServicePrice
            // 
            this.ServicePrice.HeaderText = "Price";
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            // 
            // ServiceView
            // 
            this.ServiceView.HeaderText = "";
            this.ServiceView.Name = "ServiceView";
            this.ServiceView.ReadOnly = true;
            // 
            // ServiceEdit
            // 
            this.ServiceEdit.HeaderText = "";
            this.ServiceEdit.Name = "ServiceEdit";
            this.ServiceEdit.ReadOnly = true;
            // 
            // ServiceDelete
            // 
            this.ServiceDelete.HeaderText = "";
            this.ServiceDelete.Name = "ServiceDelete";
            this.ServiceDelete.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.lblProductSearch);
            this.tabPage5.Controls.Add(this.txtProductSearch);
            this.tabPage5.Controls.Add(this.btnProductAdd);
            this.tabPage5.Controls.Add(this.dgvProducts);
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1104, 608);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Products";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(623, 427);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 28);
            this.button5.TabIndex = 38;
            this.button5.Text = "Product Types";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(8, 16);
            this.lblProductSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(57, 18);
            this.lblProductSearch.TabIndex = 20;
            this.lblProductSearch.Text = "Search:";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(71, 13);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(200, 25);
            this.txtProductSearch.TabIndex = 19;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Location = new System.Drawing.Point(623, 11);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(151, 28);
            this.btnProductAdd.TabIndex = 17;
            this.btnProductAdd.Text = "Add Product";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.Button6_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductType,
            this.ProductPrice,
            this.ProductView,
            this.ProductEdit,
            this.ProductDelete});
            this.dgvProducts.Location = new System.Drawing.Point(11, 59);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(763, 349);
            this.dgvProducts.TabIndex = 16;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            this.dgvProducts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProducts_CellPainting);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "product_name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "product_type_name";
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "product_price";
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductView
            // 
            this.ProductView.HeaderText = "";
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            // 
            // ProductEdit
            // 
            this.ProductEdit.HeaderText = "";
            this.ProductEdit.Name = "ProductEdit";
            this.ProductEdit.ReadOnly = true;
            // 
            // ProductDelete
            // 
            this.ProductDelete.HeaderText = "";
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnPhotoshootPackageAdd);
            this.tabPage6.Controls.Add(this.lblPhotoshootPackageSearch);
            this.tabPage6.Controls.Add(this.txtPhotoshootPackageSearch);
            this.tabPage6.Controls.Add(this.dgvPhotoshootPackage);
            this.tabPage6.Controls.Add(this.btnPhotoshootTypes);
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1104, 608);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Photoshoots";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            this.tabPage6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabPage6_MouseClick);
            // 
            // btnPhotoshootPackageAdd
            // 
            this.btnPhotoshootPackageAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoshootPackageAdd.Location = new System.Drawing.Point(586, 11);
            this.btnPhotoshootPackageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhotoshootPackageAdd.Name = "btnPhotoshootPackageAdd";
            this.btnPhotoshootPackageAdd.Size = new System.Drawing.Size(188, 28);
            this.btnPhotoshootPackageAdd.TabIndex = 32;
            this.btnPhotoshootPackageAdd.Text = "Add Photoshoot Package";
            this.btnPhotoshootPackageAdd.UseVisualStyleBackColor = true;
            this.btnPhotoshootPackageAdd.Click += new System.EventHandler(this.BtnPhotoshootPackageAdd_Click);
            // 
            // lblPhotoshootPackageSearch
            // 
            this.lblPhotoshootPackageSearch.AutoSize = true;
            this.lblPhotoshootPackageSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoshootPackageSearch.Location = new System.Drawing.Point(8, 16);
            this.lblPhotoshootPackageSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhotoshootPackageSearch.Name = "lblPhotoshootPackageSearch";
            this.lblPhotoshootPackageSearch.Size = new System.Drawing.Size(57, 18);
            this.lblPhotoshootPackageSearch.TabIndex = 27;
            this.lblPhotoshootPackageSearch.Text = "Search:";
            // 
            // txtPhotoshootPackageSearch
            // 
            this.txtPhotoshootPackageSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhotoshootPackageSearch.Location = new System.Drawing.Point(71, 13);
            this.txtPhotoshootPackageSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhotoshootPackageSearch.Name = "txtPhotoshootPackageSearch";
            this.txtPhotoshootPackageSearch.Size = new System.Drawing.Size(200, 25);
            this.txtPhotoshootPackageSearch.TabIndex = 26;
            this.txtPhotoshootPackageSearch.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dgvPhotoshootPackage
            // 
            this.dgvPhotoshootPackage.AllowUserToAddRows = false;
            this.dgvPhotoshootPackage.AllowUserToDeleteRows = false;
            this.dgvPhotoshootPackage.AllowUserToResizeColumns = false;
            this.dgvPhotoshootPackage.AllowUserToResizeRows = false;
            this.dgvPhotoshootPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhotoshootPackage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhotoshootPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhotoshootPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhotoshootPackageID,
            this.PhotoshootPackageName,
            this.Services,
            this.Products,
            this.PhotoshootPackagePrice,
            this.PhotoshootPackageView,
            this.PhotoshootPackageEdit,
            this.PhotoshootPackageDelete});
            this.dgvPhotoshootPackage.Location = new System.Drawing.Point(11, 59);
            this.dgvPhotoshootPackage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhotoshootPackage.Name = "dgvPhotoshootPackage";
            this.dgvPhotoshootPackage.ReadOnly = true;
            this.dgvPhotoshootPackage.RowHeadersVisible = false;
            this.dgvPhotoshootPackage.RowTemplate.Height = 24;
            this.dgvPhotoshootPackage.Size = new System.Drawing.Size(763, 349);
            this.dgvPhotoshootPackage.TabIndex = 23;
            this.dgvPhotoshootPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView6_CellContentClick);
            this.dgvPhotoshootPackage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPhotoshootPackage_CellPainting);
            // 
            // PhotoshootPackageID
            // 
            this.PhotoshootPackageID.HeaderText = "ID";
            this.PhotoshootPackageID.Name = "PhotoshootPackageID";
            this.PhotoshootPackageID.ReadOnly = true;
            this.PhotoshootPackageID.Visible = false;
            // 
            // PhotoshootPackageName
            // 
            this.PhotoshootPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhotoshootPackageName.HeaderText = "Package Name";
            this.PhotoshootPackageName.Name = "PhotoshootPackageName";
            this.PhotoshootPackageName.ReadOnly = true;
            this.PhotoshootPackageName.Width = 132;
            // 
            // Services
            // 
            this.Services.HeaderText = "Services";
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            // 
            // PhotoshootPackagePrice
            // 
            this.PhotoshootPackagePrice.HeaderText = "Price";
            this.PhotoshootPackagePrice.Name = "PhotoshootPackagePrice";
            this.PhotoshootPackagePrice.ReadOnly = true;
            // 
            // PhotoshootPackageView
            // 
            this.PhotoshootPackageView.HeaderText = "";
            this.PhotoshootPackageView.Name = "PhotoshootPackageView";
            this.PhotoshootPackageView.ReadOnly = true;
            // 
            // PhotoshootPackageEdit
            // 
            this.PhotoshootPackageEdit.HeaderText = "";
            this.PhotoshootPackageEdit.Name = "PhotoshootPackageEdit";
            this.PhotoshootPackageEdit.ReadOnly = true;
            // 
            // PhotoshootPackageDelete
            // 
            this.PhotoshootPackageDelete.HeaderText = "";
            this.PhotoshootPackageDelete.Name = "PhotoshootPackageDelete";
            this.PhotoshootPackageDelete.ReadOnly = true;
            // 
            // btnPhotoshootTypes
            // 
            this.btnPhotoshootTypes.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoshootTypes.Location = new System.Drawing.Point(586, 427);
            this.btnPhotoshootTypes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhotoshootTypes.Name = "btnPhotoshootTypes";
            this.btnPhotoshootTypes.Size = new System.Drawing.Size(188, 29);
            this.btnPhotoshootTypes.TabIndex = 0;
            this.btnPhotoshootTypes.Text = "Photoshoot Types";
            this.btnPhotoshootTypes.UseVisualStyleBackColor = true;
            this.btnPhotoshootTypes.Click += new System.EventHandler(this.btnPhotoshootTypes_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnEventTypes);
            this.tabPage7.Controls.Add(this.lblEventPackageSearch);
            this.tabPage7.Controls.Add(this.txtEventPackageSearch);
            this.tabPage7.Controls.Add(this.btnEventPackageAdd);
            this.tabPage7.Controls.Add(this.dgvEventPackages);
            this.tabPage7.Location = new System.Drawing.Point(154, 4);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1104, 608);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Events";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnEventTypes
            // 
            this.btnEventTypes.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypes.Location = new System.Drawing.Point(623, 427);
            this.btnEventTypes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventTypes.Name = "btnEventTypes";
            this.btnEventTypes.Size = new System.Drawing.Size(151, 28);
            this.btnEventTypes.TabIndex = 37;
            this.btnEventTypes.Text = "Event Types";
            this.btnEventTypes.UseVisualStyleBackColor = true;
            this.btnEventTypes.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEventPackageSearch
            // 
            this.lblEventPackageSearch.AutoSize = true;
            this.lblEventPackageSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventPackageSearch.Location = new System.Drawing.Point(8, 16);
            this.lblEventPackageSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventPackageSearch.Name = "lblEventPackageSearch";
            this.lblEventPackageSearch.Size = new System.Drawing.Size(57, 18);
            this.lblEventPackageSearch.TabIndex = 34;
            this.lblEventPackageSearch.Text = "Search:";
            // 
            // txtEventPackageSearch
            // 
            this.txtEventPackageSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventPackageSearch.Location = new System.Drawing.Point(71, 13);
            this.txtEventPackageSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventPackageSearch.Name = "txtEventPackageSearch";
            this.txtEventPackageSearch.Size = new System.Drawing.Size(200, 25);
            this.txtEventPackageSearch.TabIndex = 33;
            this.txtEventPackageSearch.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnEventPackageAdd
            // 
            this.btnEventPackageAdd.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventPackageAdd.Location = new System.Drawing.Point(623, 11);
            this.btnEventPackageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventPackageAdd.Name = "btnEventPackageAdd";
            this.btnEventPackageAdd.Size = new System.Drawing.Size(151, 28);
            this.btnEventPackageAdd.TabIndex = 31;
            this.btnEventPackageAdd.Text = "Add Event Package";
            this.btnEventPackageAdd.UseVisualStyleBackColor = true;
            this.btnEventPackageAdd.Click += new System.EventHandler(this.button14_Click);
            // 
            // dgvEventPackages
            // 
            this.dgvEventPackages.AllowUserToAddRows = false;
            this.dgvEventPackages.AllowUserToDeleteRows = false;
            this.dgvEventPackages.AllowUserToResizeColumns = false;
            this.dgvEventPackages.AllowUserToResizeRows = false;
            this.dgvEventPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventPackages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventPackageID,
            this.EventPackageName,
            this.ServicesEvents,
            this.ProductsEvents,
            this.EventPackagePrice,
            this.EventPackageView,
            this.EventPackageEdit,
            this.EventPackageDelete});
            this.dgvEventPackages.Location = new System.Drawing.Point(11, 59);
            this.dgvEventPackages.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventPackages.Name = "dgvEventPackages";
            this.dgvEventPackages.ReadOnly = true;
            this.dgvEventPackages.RowHeadersVisible = false;
            this.dgvEventPackages.RowTemplate.Height = 24;
            this.dgvEventPackages.Size = new System.Drawing.Size(763, 349);
            this.dgvEventPackages.TabIndex = 30;
            this.dgvEventPackages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView7_CellContentClick);
            this.dgvEventPackages.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvEventPackages_CellPainting);
            // 
            // EventPackageID
            // 
            this.EventPackageID.HeaderText = "ID";
            this.EventPackageID.Name = "EventPackageID";
            this.EventPackageID.ReadOnly = true;
            this.EventPackageID.Visible = false;
            // 
            // EventPackageName
            // 
            this.EventPackageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventPackageName.HeaderText = "Package Name";
            this.EventPackageName.Name = "EventPackageName";
            this.EventPackageName.ReadOnly = true;
            this.EventPackageName.Width = 132;
            // 
            // ServicesEvents
            // 
            this.ServicesEvents.HeaderText = "Services";
            this.ServicesEvents.Name = "ServicesEvents";
            this.ServicesEvents.ReadOnly = true;
            // 
            // ProductsEvents
            // 
            this.ProductsEvents.HeaderText = "Products";
            this.ProductsEvents.Name = "ProductsEvents";
            this.ProductsEvents.ReadOnly = true;
            // 
            // EventPackagePrice
            // 
            this.EventPackagePrice.HeaderText = "Price";
            this.EventPackagePrice.Name = "EventPackagePrice";
            this.EventPackagePrice.ReadOnly = true;
            // 
            // EventPackageView
            // 
            this.EventPackageView.HeaderText = "";
            this.EventPackageView.Name = "EventPackageView";
            this.EventPackageView.ReadOnly = true;
            // 
            // EventPackageEdit
            // 
            this.EventPackageEdit.HeaderText = "";
            this.EventPackageEdit.Name = "EventPackageEdit";
            this.EventPackageEdit.ReadOnly = true;
            // 
            // EventPackageDelete
            // 
            this.EventPackageDelete.HeaderText = "";
            this.EventPackageDelete.Name = "EventPackageDelete";
            this.EventPackageDelete.ReadOnly = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dgvOrders);
            this.tabPage8.Controls.Add(this.button18);
            this.tabPage8.Controls.Add(this.button17);
            this.tabPage8.Controls.Add(this.comboBox8);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.textBox8);
            this.tabPage8.Controls.Add(this.button16);
            this.tabPage8.Location = new System.Drawing.Point(154, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1104, 608);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Customer Orders";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewOrderProducts,
            this.CustomerOrderPayment});
            this.dgvOrders.Location = new System.Drawing.Point(2, 59);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1100, 547);
            this.dgvOrders.TabIndex = 46;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrders_CellContentClick);
            // 
            // ViewOrderProducts
            // 
            this.ViewOrderProducts.HeaderText = "";
            this.ViewOrderProducts.Name = "ViewOrderProducts";
            this.ViewOrderProducts.Text = "View Products";
            this.ViewOrderProducts.UseColumnTextForButtonValue = true;
            this.ViewOrderProducts.Width = 140;
            // 
            // CustomerOrderPayment
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.CustomerOrderPayment.DefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerOrderPayment.HeaderText = "";
            this.CustomerOrderPayment.Name = "CustomerOrderPayment";
            this.CustomerOrderPayment.Text = "Capture Payment";
            this.CustomerOrderPayment.UseColumnTextForButtonValue = true;
            this.CustomerOrderPayment.Width = 130;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(979, 11);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(112, 28);
            this.button18.TabIndex = 45;
            this.button18.Text = "Deliver Order";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18_Click);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(859, 11);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(116, 28);
            this.button17.TabIndex = 44;
            this.button17.Text = "Prepare Order";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.ItemHeight = 17;
            this.comboBox8.Location = new System.Drawing.Point(339, 11);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(103, 25);
            this.comboBox8.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(281, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "Sort by:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Search:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(71, 13);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 25);
            this.textBox8.TabIndex = 40;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(727, 11);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(128, 28);
            this.button16.TabIndex = 38;
            this.button16.Text = "Place Order";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btnBookingAdd);
            this.tabPage9.Controls.Add(this.dgvBookings);
            this.tabPage9.Controls.Add(this.lblBookingSearch);
            this.tabPage9.Controls.Add(this.txtBookingSearch);
            this.tabPage9.Controls.Add(this.btnBookingCapture);
            this.tabPage9.Location = new System.Drawing.Point(154, 4);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1104, 608);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Bookings";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btnBookingAdd
            // 
            this.btnBookingAdd.Location = new System.Drawing.Point(585, 13);
            this.btnBookingAdd.Name = "btnBookingAdd";
            this.btnBookingAdd.Size = new System.Drawing.Size(189, 29);
            this.btnBookingAdd.TabIndex = 54;
            this.btnBookingAdd.Text = "Add Booking";
            this.btnBookingAdd.UseVisualStyleBackColor = true;
            this.btnBookingAdd.Click += new System.EventHandler(this.BtnBookingAdd_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingID,
            this.bookingDate,
            this.BookingCustName,
            this.bookingStatus,
            this.bookingView,
            this.BookingEdit,
            this.BookingDelete});
            this.dgvBookings.Location = new System.Drawing.Point(11, 59);
            this.dgvBookings.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(763, 349);
            this.dgvBookings.TabIndex = 53;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookings_CellContentClick);
            // 
            // bookingID
            // 
            this.bookingID.HeaderText = "ID";
            this.bookingID.Name = "bookingID";
            this.bookingID.ReadOnly = true;
            // 
            // bookingDate
            // 
            this.bookingDate.HeaderText = "Booking Date";
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.ReadOnly = true;
            // 
            // BookingCustName
            // 
            this.BookingCustName.HeaderText = "Customer Name";
            this.BookingCustName.Name = "BookingCustName";
            this.BookingCustName.ReadOnly = true;
            // 
            // bookingStatus
            // 
            this.bookingStatus.HeaderText = "Booking Status";
            this.bookingStatus.Name = "bookingStatus";
            this.bookingStatus.ReadOnly = true;
            // 
            // bookingView
            // 
            this.bookingView.HeaderText = "";
            this.bookingView.Name = "bookingView";
            this.bookingView.ReadOnly = true;
            this.bookingView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BookingEdit
            // 
            this.BookingEdit.HeaderText = "";
            this.BookingEdit.Name = "BookingEdit";
            this.BookingEdit.ReadOnly = true;
            // 
            // BookingDelete
            // 
            this.BookingDelete.HeaderText = "";
            this.BookingDelete.Name = "BookingDelete";
            this.BookingDelete.ReadOnly = true;
            // 
            // lblBookingSearch
            // 
            this.lblBookingSearch.AutoSize = true;
            this.lblBookingSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingSearch.Location = new System.Drawing.Point(8, 16);
            this.lblBookingSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingSearch.Name = "lblBookingSearch";
            this.lblBookingSearch.Size = new System.Drawing.Size(54, 18);
            this.lblBookingSearch.TabIndex = 50;
            this.lblBookingSearch.Text = "Search";
            // 
            // txtBookingSearch
            // 
            this.txtBookingSearch.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingSearch.Location = new System.Drawing.Point(66, 13);
            this.txtBookingSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingSearch.Name = "txtBookingSearch";
            this.txtBookingSearch.Size = new System.Drawing.Size(238, 25);
            this.txtBookingSearch.TabIndex = 49;
            this.txtBookingSearch.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // btnBookingCapture
            // 
            this.btnBookingCapture.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingCapture.Location = new System.Drawing.Point(11, 425);
            this.btnBookingCapture.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookingCapture.Name = "btnBookingCapture";
            this.btnBookingCapture.Size = new System.Drawing.Size(151, 29);
            this.btnBookingCapture.TabIndex = 48;
            this.btnBookingCapture.Text = "Capture Payment";
            this.btnBookingCapture.UseVisualStyleBackColor = true;
            this.btnBookingCapture.Click += new System.EventHandler(this.BtnBookingCapture_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.dataGridView10);
            this.tabPage10.Controls.Add(this.button22);
            this.tabPage10.Controls.Add(this.label20);
            this.tabPage10.Controls.Add(this.textBox10);
            this.tabPage10.Controls.Add(this.button24);
            this.tabPage10.Location = new System.Drawing.Point(154, 4);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1104, 608);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Supplier";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AllowUserToAddRows = false;
            this.dataGridView10.AllowUserToDeleteRows = false;
            this.dataGridView10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView10.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.Column1,
            this.Column2,
            this.SupplierType,
            this.SupplierView,
            this.SupplierEdit,
            this.SupplierDelete});
            this.dataGridView10.Location = new System.Drawing.Point(11, 59);
            this.dataGridView10.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.RowHeadersVisible = false;
            this.dataGridView10.RowTemplate.Height = 24;
            this.dataGridView10.Size = new System.Drawing.Size(763, 349);
            this.dataGridView10.TabIndex = 55;
            this.dataGridView10.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView10_CellContentClick);
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "supplier_name";
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "supplier_email_address";
            this.Column1.HeaderText = "Supplier Email Address";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "supplier_phone";
            this.Column2.HeaderText = "Supplier Telephone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // SupplierType
            // 
            this.SupplierType.DataPropertyName = "supplier_type_name";
            this.SupplierType.HeaderText = "Supplier Type";
            this.SupplierType.Name = "SupplierType";
            this.SupplierType.ReadOnly = true;
            // 
            // SupplierView
            // 
            this.SupplierView.HeaderText = "";
            this.SupplierView.Name = "SupplierView";
            this.SupplierView.ReadOnly = true;
            // 
            // SupplierEdit
            // 
            this.SupplierEdit.HeaderText = "";
            this.SupplierEdit.Name = "SupplierEdit";
            this.SupplierEdit.ReadOnly = true;
            // 
            // SupplierDelete
            // 
            this.SupplierDelete.HeaderText = "";
            this.SupplierDelete.Name = "SupplierDelete";
            this.SupplierDelete.ReadOnly = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(623, 427);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(151, 28);
            this.button22.TabIndex = 53;
            this.button22.Text = "Supplier Orders";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button22_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 16);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 18);
            this.label20.TabIndex = 50;
            this.label20.Text = "Search:";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(71, 13);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 25);
            this.textBox10.TabIndex = 49;
            this.textBox10.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(623, 11);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(151, 28);
            this.button24.TabIndex = 47;
            this.button24.Text = "Add Supplier";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Button24_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.button13);
            this.tabPage11.Controls.Add(this.button11);
            this.tabPage11.Controls.Add(this.button9);
            this.tabPage11.Controls.Add(this.button25);
            this.tabPage11.Controls.Add(this.button26);
            this.tabPage11.Location = new System.Drawing.Point(154, 4);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1104, 608);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Reports";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(37, 324);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(227, 43);
            this.button13.TabIndex = 60;
            this.button13.Text = "Generate Audit Trail Report";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(37, 251);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(227, 43);
            this.button11.TabIndex = 59;
            this.button11.Text = "Generate Inventory Report";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(37, 178);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(227, 43);
            this.button9.TabIndex = 58;
            this.button9.Text = "Generate Supplier Order Report";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(37, 105);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(227, 43);
            this.button25.TabIndex = 57;
            this.button25.Text = "Generate Booking Report";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(37, 32);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(227, 43);
            this.button26.TabIndex = 56;
            this.button26.Text = "Generate Customer Report";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(154, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1104, 608);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Help";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1262, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golden Connect";
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeslots)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoshootPackage)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventPackages)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Label lblTimeslots;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lblCustomerSort;
        private System.Windows.Forms.Label lblCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblServiceSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button8;
        private DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnTimeslotAdd;
        private System.Windows.Forms.DataGridView dgvTimeslots;
        private DataGridViewTextBoxColumn timeslotDay1;
        private DataGridViewTextBoxColumn timeslotDay2;
        private DataGridViewTextBoxColumn timeslotDay3;
        private DataGridViewTextBoxColumn timeslotDay4;
        private DataGridViewTextBoxColumn timeslotDay5;
        private DataGridViewTextBoxColumn timeslotDay6;
        private DataGridViewTextBoxColumn timeslotDay7;
        private System.Windows.Forms.Label lblPhotoshootPackageSearch;
        private System.Windows.Forms.TextBox txtPhotoshootPackageSearch;
        private System.Windows.Forms.Button btnPhotoshootTypes;
        private System.Windows.Forms.DataGridView dgvPhotoshootPackage;
        private System.Windows.Forms.Label lblEventPackageSearch;
        private System.Windows.Forms.TextBox txtEventPackageSearch;
        private System.Windows.Forms.Button btnEventPackageAdd;
        private System.Windows.Forms.DataGridView dgvEventPackages;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label lblBookingSearch;
        private System.Windows.Forms.TextBox txtBookingSearch;
        private System.Windows.Forms.Button btnBookingCapture;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEventTypes;
        private System.Windows.Forms.Button btnServiceType;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewButtonColumn CustView;
        private System.Windows.Forms.DataGridViewButtonColumn CustEdit;
        private System.Windows.Forms.DataGridViewButtonColumn CustDelete;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage tabPage12;
        private DataGridView dgvService;
        public System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierType;
        private System.Windows.Forms.DataGridViewButtonColumn SupplierView;
        private System.Windows.Forms.DataGridViewButtonColumn SupplierEdit;
        private System.Windows.Forms.DataGridViewButtonColumn SupplierDelete;
        private Button btnPhotoshootPackageAdd;
        private Button btnBookingAdd;
        private Button button1;
        private DataGridViewButtonColumn ViewOrderProducts;
        private DataGridViewButtonColumn CustomerOrderPayment;
        private DataGridViewTextBoxColumn bookingID;
        private DataGridViewTextBoxColumn bookingDate;
        private DataGridViewTextBoxColumn BookingCustName;
        private DataGridViewTextBoxColumn bookingStatus;
        private DataGridViewButtonColumn bookingView;
        private DataGridViewButtonColumn BookingEdit;
        private DataGridViewButtonColumn BookingDelete;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn ServiceType;
        private DataGridViewTextBoxColumn ServicePrice;
        private DataGridViewButtonColumn ServiceView;
        private DataGridViewButtonColumn ServiceEdit;
        private DataGridViewButtonColumn ServiceDelete;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewButtonColumn ProductView;
        private DataGridViewButtonColumn ProductEdit;
        private DataGridViewButtonColumn ProductDelete;
        private DataGridViewTextBoxColumn PhotoshootPackageID;
        private DataGridViewTextBoxColumn PhotoshootPackageName;
        private DataGridViewTextBoxColumn Services;
        private DataGridViewTextBoxColumn Products;
        private DataGridViewTextBoxColumn PhotoshootPackagePrice;
        private DataGridViewButtonColumn PhotoshootPackageView;
        private DataGridViewButtonColumn PhotoshootPackageEdit;
        private DataGridViewButtonColumn PhotoshootPackageDelete;
        private DataGridViewTextBoxColumn EventPackageID;
        private DataGridViewTextBoxColumn EventPackageName;
        private DataGridViewTextBoxColumn ServicesEvents;
        private DataGridViewTextBoxColumn ProductsEvents;
        private DataGridViewTextBoxColumn EventPackagePrice;
        private DataGridViewButtonColumn EventPackageView;
        private DataGridViewButtonColumn EventPackageEdit;
        private DataGridViewButtonColumn EventPackageDelete;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeIDNum;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeePhone;
        private DataGridViewTextBoxColumn EmployeeEmail;
        private DataGridViewTextBoxColumn EmployeeType;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}

