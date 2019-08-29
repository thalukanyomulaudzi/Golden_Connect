namespace Design370
{
    partial class NewCustomerOrder
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
            this.customerOrderTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCusInfo = new System.Windows.Forms.Label();
            this.btnExitOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.ListBox();
            this.btnP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblOrders = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblImages = new System.Windows.Forms.Label();
            this.lblq = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOrderid = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkUpload = new System.Windows.Forms.LinkLabel();
            this.orderQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxPrTypes = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.customerOrderTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerOrderTab
            // 
            this.customerOrderTab.Controls.Add(this.tabPage1);
            this.customerOrderTab.Controls.Add(this.tabPage2);
            this.customerOrderTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrderTab.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrderTab.Location = new System.Drawing.Point(0, 0);
            this.customerOrderTab.Multiline = true;
            this.customerOrderTab.Name = "customerOrderTab";
            this.customerOrderTab.Padding = new System.Drawing.Point(8, 3);
            this.customerOrderTab.RightToLeftLayout = true;
            this.customerOrderTab.SelectedIndex = 0;
            this.customerOrderTab.Size = new System.Drawing.Size(1221, 636);
            this.customerOrderTab.TabIndex = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.btnExitOrder);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.customers);
            this.tabPage1.Controls.Add(this.btnP);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "         1";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTel);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblCusInfo);
            this.panel3.Location = new System.Drawing.Point(829, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 508);
            this.panel3.TabIndex = 78;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(-2, 287);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(363, 39);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "0731452365";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(-2, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(363, 39);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "hlamu.maluleka@gmail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-2, 184);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(360, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nhlamulo Maluleka";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCusInfo
            // 
            this.lblCusInfo.AutoSize = true;
            this.lblCusInfo.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusInfo.Location = new System.Drawing.Point(10, 13);
            this.lblCusInfo.Name = "lblCusInfo";
            this.lblCusInfo.Size = new System.Drawing.Size(342, 37);
            this.lblCusInfo.TabIndex = 0;
            this.lblCusInfo.Text = "Customer Information";
            // 
            // btnExitOrder
            // 
            this.btnExitOrder.BackColor = System.Drawing.Color.Red;
            this.btnExitOrder.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitOrder.Font = new System.Drawing.Font("Bookshelf Symbol 7", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExitOrder.Location = new System.Drawing.Point(463, 434);
            this.btnExitOrder.Name = "btnExitOrder";
            this.btnExitOrder.Size = new System.Drawing.Size(130, 33);
            this.btnExitOrder.TabIndex = 77;
            this.btnExitOrder.Text = "Cancel";
            this.btnExitOrder.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmSearchBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSeach);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(408, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 194);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmSearchBy
            // 
            this.cmSearchBy.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmSearchBy.FormattingEnabled = true;
            this.cmSearchBy.Items.AddRange(new object[] {
            "All",
            "Name",
            "Email Address",
            "Telephone"});
            this.cmSearchBy.Location = new System.Drawing.Point(130, 70);
            this.cmSearchBy.Name = "cmSearchBy";
            this.cmSearchBy.Size = new System.Drawing.Size(200, 27);
            this.cmSearchBy.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Search :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Search By :";
            // 
            // txtSeach
            // 
            this.txtSeach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.Location = new System.Drawing.Point(130, 121);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(200, 27);
            this.txtSeach.TabIndex = 67;
            this.txtSeach.TextChanged += new System.EventHandler(this.TxtSeach_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 79);
            this.panel1.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1207, 79);
            this.label3.TabIndex = 74;
            this.label3.Text = "Search Customer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customers
            // 
            this.customers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customers.ColumnWidth = 12;
            this.customers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.FormattingEnabled = true;
            this.customers.ItemHeight = 21;
            this.customers.Location = new System.Drawing.Point(5, 87);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(334, 506);
            this.customers.TabIndex = 72;
            this.customers.SelectedIndexChanged += new System.EventHandler(this.Customers_SelectedIndexChanged);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Blue;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.White;
            this.btnP.Location = new System.Drawing.Point(598, 434);
            this.btnP.Margin = new System.Windows.Forms.Padding(2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(130, 33);
            this.btnP.TabIndex = 66;
            this.btnP.Text = "Proceed";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "         2";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(521, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(689, 514);
            this.panel5.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblOrders);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.lblImages);
            this.panel7.Controls.Add(this.lblq);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lblPrice);
            this.panel7.Controls.Add(this.lblProductType);
            this.panel7.Controls.Add(this.lblOrderid);
            this.panel7.Controls.Add(this.lblProductPrice);
            this.panel7.Controls.Add(this.lblProduct);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(689, 442);
            this.panel7.TabIndex = 8;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(128, 292);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(20, 24);
            this.lblOrders.TabIndex = 16;
            this.lblOrders.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 24);
            this.label20.TabIndex = 17;
            this.label20.Text = "Saved Orders: ";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.lblD);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.lblTotal);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 320);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(689, 122);
            this.panel8.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Discount : ";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(172, 45);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(34, 24);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "0%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(120, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "VAT : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(172, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 24);
            this.label19.TabIndex = 10;
            this.label19.Text = "15%";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(170, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 32);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "R0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bookshelf Symbol 7", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "Order Total: ";
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImages.Location = new System.Drawing.Point(366, 202);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(28, 31);
            this.lblImages.TabIndex = 7;
            this.lblImages.Text = "0";
            // 
            // lblq
            // 
            this.lblq.AutoSize = true;
            this.lblq.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq.Location = new System.Drawing.Point(366, 170);
            this.lblq.Name = "lblq";
            this.lblq.Size = new System.Drawing.Size(28, 31);
            this.lblq.TabIndex = 8;
            this.lblq.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(231, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Images : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(364, 240);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 31);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "R0.00";
            // 
            // lblOrderid
            // 
            this.lblOrderid.AutoSize = true;
            this.lblOrderid.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderid.Location = new System.Drawing.Point(364, 29);
            this.lblOrderid.Name = "lblOrderid";
            this.lblOrderid.Size = new System.Drawing.Size(181, 31);
            this.lblOrderid.TabIndex = 11;
            this.lblOrderid.Text = "Select Product";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(364, 136);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(82, 31);
            this.lblProductPrice.TabIndex = 11;
            this.lblProductPrice.Text = "R0.00";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(364, 101);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(181, 31);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.Text = "Select Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 30);
            this.label10.TabIndex = 12;
            this.label10.Text = "Product Quantity : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "Order ID : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sub Total : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(151, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 30);
            this.label16.TabIndex = 14;
            this.label16.Text = "Product Price : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product Name : ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(689, 72);
            this.panel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(687, 70);
            this.label7.TabIndex = 4;
            this.label7.Text = "Product Details";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.btnAddP);
            this.panel4.Controls.Add(this.btnSaveOrder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 514);
            this.panel4.TabIndex = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.cbxPrTypes);
            this.groupBox2.Controls.Add(this.linkUpload);
            this.groupBox2.Controls.Add(this.orderQuantity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxProducts);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Products";
            // 
            // linkUpload
            // 
            this.linkUpload.AutoSize = true;
            this.linkUpload.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUpload.Location = new System.Drawing.Point(215, 250);
            this.linkUpload.Name = "linkUpload";
            this.linkUpload.Size = new System.Drawing.Size(129, 19);
            this.linkUpload.TabIndex = 18;
            this.linkUpload.TabStop = true;
            this.linkUpload.Text = "Upload Images";
            this.linkUpload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUpload_LinkClicked);
            // 
            // orderQuantity
            // 
            this.orderQuantity.Font = new System.Drawing.Font("Bahnschrift Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQuantity.Location = new System.Drawing.Point(178, 185);
            this.orderQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.orderQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(176, 28);
            this.orderQuantity.TabIndex = 2;
            this.orderQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.orderQuantity.ValueChanged += new System.EventHandler(this.OrderQuantity_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product : ";
            // 
            // cbxProducts
            // 
            this.cbxProducts.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(178, 136);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(176, 27);
            this.cbxProducts.TabIndex = 0;
            this.cbxProducts.SelectedIndexChanged += new System.EventHandler(this.CmOrderList_SelectedIndexChanged);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddP.Font = new System.Drawing.Font("Bookshelf Symbol 7", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.ForeColor = System.Drawing.Color.White;
            this.btnAddP.Location = new System.Drawing.Point(104, 392);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(127, 33);
            this.btnAddP.TabIndex = 3;
            this.btnAddP.Text = "Add Product";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.BtnAddP_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.Blue;
            this.btnSaveOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Bookshelf Symbol 7", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaveOrder.Location = new System.Drawing.Point(243, 391);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(129, 35);
            this.btnSaveOrder.TabIndex = 3;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 79);
            this.panel2.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1207, 79);
            this.label4.TabIndex = 74;
            this.label4.Text = "Place Customer Order";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "Product Type: ";
            // 
            // cbxPrTypes
            // 
            this.cbxPrTypes.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrTypes.FormattingEnabled = true;
            this.cbxPrTypes.Location = new System.Drawing.Point(178, 85);
            this.cbxPrTypes.Name = "cbxPrTypes";
            this.cbxPrTypes.Size = new System.Drawing.Size(176, 27);
            this.cbxPrTypes.TabIndex = 19;
            this.cbxPrTypes.SelectedIndexChanged += new System.EventHandler(this.CbxPrTypes_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(158, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 30);
            this.label18.TabIndex = 14;
            this.label18.Text = "Product Type : ";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Bookshelf Symbol 7", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(366, 65);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(148, 31);
            this.lblProductType.TabIndex = 11;
            this.lblProductType.Text = "Select Type";
            // 
            // NewCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 636);
            this.Controls.Add(this.customerOrderTab);
            this.Name = "NewCustomerOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Customer Order";
            this.Load += new System.EventHandler(this.NewCustomerOrder_Load);
            this.customerOrderTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl customerOrderTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCusInfo;
        private System.Windows.Forms.Button btnExitOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox customers;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Label lblq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOrderid;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkUpload;
        private System.Windows.Forms.NumericUpDown orderQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxPrTypes;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label label18;
    }
}