namespace Design370
{
    partial class Customer_Order_New
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
            this.components = new System.ComponentModel.Container();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomerNames = new System.Windows.Forms.Label();
            this.lboxProductTypes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pBoxPrintPhoto = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rBtnCollected = new System.Windows.Forms.RadioButton();
            this.rBtnDelivered = new System.Windows.Forms.RadioButton();
            this.pnlDeliveryAddress = new System.Windows.Forms.Panel();
            this.txtDelAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrintPhoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            this.panel3.SuspendLayout();
            this.controls.SuspendLayout();
            this.pnlDeliveryAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(550, 121);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.Size = new System.Drawing.Size(610, 422);
            this.dgvOrderList.TabIndex = 0;
            this.dgvOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Order For : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.lblCustomerNames);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 50);
            this.panel1.TabIndex = 2;
            // 
            // lblCustomerNames
            // 
            this.lblCustomerNames.AutoSize = true;
            this.lblCustomerNames.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerNames.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCustomerNames.Location = new System.Drawing.Point(225, 5);
            this.lblCustomerNames.Name = "lblCustomerNames";
            this.lblCustomerNames.Size = new System.Drawing.Size(251, 39);
            this.lblCustomerNames.TabIndex = 1;
            this.lblCustomerNames.Text = "Mr Nhlamulo Maluleka";
            this.lblCustomerNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lboxProductTypes
            // 
            this.lboxProductTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxProductTypes.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxProductTypes.FormattingEnabled = true;
            this.lboxProductTypes.ItemHeight = 19;
            this.lboxProductTypes.Items.AddRange(new object[] {
            "Phone Cover",
            "Key Holder",
            "Mugs",
            "Canvas"});
            this.lboxProductTypes.Location = new System.Drawing.Point(40, 152);
            this.lboxProductTypes.Name = "lboxProductTypes";
            this.lboxProductTypes.Size = new System.Drawing.Size(215, 152);
            this.lboxProductTypes.TabIndex = 3;
            this.lboxProductTypes.SelectedIndexChanged += new System.EventHandler(this.lbox_ProductTypes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1021, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Location = new System.Drawing.Point(285, 306);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(244, 31);
            this.btnUploadPhoto.TabIndex = 4;
            this.btnUploadPhoto.Text = "Upload Print Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 42);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order ID : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderID
            // 
            this.lblOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(256, 67);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(110, 34);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "5165165";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBoxPrintPhoto
            // 
            this.pBoxPrintPhoto.Location = new System.Drawing.Point(286, 337);
            this.pBoxPrintPhoto.Name = "pBoxPrintPhoto";
            this.pBoxPrintPhoto.Size = new System.Drawing.Size(242, 175);
            this.pBoxPrintPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPrintPhoto.TabIndex = 5;
            this.pBoxPrintPhoto.TabStop = false;
            this.pBoxPrintPhoto.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(285, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Product Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nQty);
            this.panel2.Location = new System.Drawing.Point(286, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 132);
            this.panel2.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(119, 21);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 24);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "R0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Price : ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(118, 95);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(21, 24);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock :   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity : ";
            // 
            // nQty
            // 
            this.nQty.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nQty.Location = new System.Drawing.Point(123, 56);
            this.nQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.Name = "nQty";
            this.nQty.ReadOnly = true;
            this.nQty.Size = new System.Drawing.Size(76, 28);
            this.nQty.TabIndex = 0;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.ValueChanged += new System.EventHandler(this.NQty_ValueChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Silver;
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(408, 551);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(121, 27);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.Silver;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveOrder.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOrder.Location = new System.Drawing.Point(38, 590);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(124, 31);
            this.btnSaveOrder.TabIndex = 4;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblOTotal);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(550, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 104);
            this.panel3.TabIndex = 7;
            // 
            // lblOTotal
            // 
            this.lblOTotal.AutoSize = true;
            this.lblOTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTotal.Location = new System.Drawing.Point(366, 33);
            this.lblOTotal.Name = "lblOTotal";
            this.lblOTotal.Size = new System.Drawing.Size(113, 39);
            this.lblOTotal.TabIndex = 0;
            this.lblOTotal.Text = "R0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Order Total : ";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.Silver;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrder.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelOrder.Location = new System.Drawing.Point(168, 590);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(124, 31);
            this.btnCancelOrder.TabIndex = 4;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // controls
            // 
            this.controls.Controls.Add(this.btnNext);
            this.controls.Controls.Add(this.btnPrev);
            this.controls.Controls.Add(this.lblPhoto);
            this.controls.Location = new System.Drawing.Point(286, 514);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(243, 35);
            this.controls.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(209, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrev.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(31, 28);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(37, 3);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(166, 31);
            this.lblPhoto.TabIndex = 0;
            this.lblPhoto.Text = "1  |  3";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBtnCollected
            // 
            this.rBtnCollected.AutoSize = true;
            this.rBtnCollected.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnCollected.Location = new System.Drawing.Point(47, 374);
            this.rBtnCollected.Name = "rBtnCollected";
            this.rBtnCollected.Size = new System.Drawing.Size(96, 23);
            this.rBtnCollected.TabIndex = 9;
            this.rBtnCollected.TabStop = true;
            this.rBtnCollected.Text = "Collected";
            this.rBtnCollected.UseVisualStyleBackColor = true;
            this.rBtnCollected.CheckedChanged += new System.EventHandler(this.RBtnCollected_CheckedChanged);
            // 
            // rBtnDelivered
            // 
            this.rBtnDelivered.AutoSize = true;
            this.rBtnDelivered.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDelivered.Location = new System.Drawing.Point(47, 348);
            this.rBtnDelivered.Name = "rBtnDelivered";
            this.rBtnDelivered.Size = new System.Drawing.Size(98, 23);
            this.rBtnDelivered.TabIndex = 9;
            this.rBtnDelivered.TabStop = true;
            this.rBtnDelivered.Text = "Delivered";
            this.rBtnDelivered.UseVisualStyleBackColor = true;
            this.rBtnDelivered.CheckedChanged += new System.EventHandler(this.rBtnDelivered_CheckedChanged);
            // 
            // pnlDeliveryAddress
            // 
            this.pnlDeliveryAddress.Controls.Add(this.txtDelAddress);
            this.pnlDeliveryAddress.Controls.Add(this.label5);
            this.pnlDeliveryAddress.Location = new System.Drawing.Point(40, 406);
            this.pnlDeliveryAddress.Name = "pnlDeliveryAddress";
            this.pnlDeliveryAddress.Size = new System.Drawing.Size(213, 143);
            this.pnlDeliveryAddress.TabIndex = 10;
            this.pnlDeliveryAddress.Visible = false;
            // 
            // txtDelAddress
            // 
            this.txtDelAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelAddress.Location = new System.Drawing.Point(0, 25);
            this.txtDelAddress.Name = "txtDelAddress";
            this.txtDelAddress.Size = new System.Drawing.Size(213, 117);
            this.txtDelAddress.TabIndex = 12;
            this.txtDelAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delivery Address";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(40, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Collection Method";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Customer_Order_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 656);
            this.Controls.Add(this.rBtnDelivered);
            this.Controls.Add(this.rBtnCollected);
            this.Controls.Add(this.pnlDeliveryAddress);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBoxPrintPhoto);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxProductTypes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "Customer_Order_New";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Customer Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Order_New_FormClosing);
            this.Load += new System.EventHandler(this.NewCustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrintPhoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.controls.ResumeLayout(false);
            this.pnlDeliveryAddress.ResumeLayout(false);
            this.pnlDeliveryAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomerNames;
        private System.Windows.Forms.ListBox lboxProductTypes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.PictureBox pBoxPrintPhoto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnCollected;
        private System.Windows.Forms.RadioButton rBtnDelivered;
        private System.Windows.Forms.Panel pnlDeliveryAddress;
        private System.Windows.Forms.RichTextBox txtDelAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}