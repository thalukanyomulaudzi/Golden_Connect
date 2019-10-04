namespace Design370
{
    partial class Booking_Date
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvBookEvent = new System.Windows.Forms.DataGridView();
            this.dgvBookingEmployees = new System.Windows.Forms.DataGridView();
            this.bookingEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmployeeAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookingConfirmDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBookingDatePreviousWeek = new System.Windows.Forms.Label();
            this.lblBookingDateNextWeek = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 75);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 24);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dgvBookEvent
            // 
            this.dgvBookEvent.AllowUserToAddRows = false;
            this.dgvBookEvent.AllowUserToDeleteRows = false;
            this.dgvBookEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBookEvent.Location = new System.Drawing.Point(22, 153);
            this.dgvBookEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBookEvent.Name = "dgvBookEvent";
            this.dgvBookEvent.ReadOnly = true;
            this.dgvBookEvent.RowTemplate.Height = 24;
            this.dgvBookEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookEvent.Size = new System.Drawing.Size(1073, 322);
            this.dgvBookEvent.TabIndex = 17;
            this.dgvBookEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookEvent_CellContentClick);
            // 
            // dgvBookingEmployees
            // 
            this.dgvBookingEmployees.AllowUserToAddRows = false;
            this.dgvBookingEmployees.AllowUserToDeleteRows = false;
            this.dgvBookingEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookingEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingEmployeeName,
            this.bookingEmployeeAvailable,
            this.bookingEmployeeID});
            this.dgvBookingEmployees.Location = new System.Drawing.Point(1102, 153);
            this.dgvBookingEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookingEmployees.Name = "dgvBookingEmployees";
            this.dgvBookingEmployees.ReadOnly = true;
            this.dgvBookingEmployees.RowHeadersVisible = false;
            this.dgvBookingEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookingEmployees.Size = new System.Drawing.Size(384, 322);
            this.dgvBookingEmployees.TabIndex = 19;
            this.dgvBookingEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // bookingEmployeeName
            // 
            this.bookingEmployeeName.HeaderText = "Employee Name";
            this.bookingEmployeeName.Name = "bookingEmployeeName";
            this.bookingEmployeeName.ReadOnly = true;
            // 
            // bookingEmployeeAvailable
            // 
            this.bookingEmployeeAvailable.HeaderText = "Available";
            this.bookingEmployeeAvailable.Name = "bookingEmployeeAvailable";
            this.bookingEmployeeAvailable.ReadOnly = true;
            // 
            // bookingEmployeeID
            // 
            this.bookingEmployeeID.HeaderText = "ID";
            this.bookingEmployeeID.Name = "bookingEmployeeID";
            this.bookingEmployeeID.ReadOnly = true;
            // 
            // btnBookingConfirmDate
            // 
            this.btnBookingConfirmDate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookingConfirmDate.Location = new System.Drawing.Point(1297, 534);
            this.btnBookingConfirmDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookingConfirmDate.Name = "btnBookingConfirmDate";
            this.btnBookingConfirmDate.Size = new System.Drawing.Size(189, 34);
            this.btnBookingConfirmDate.TabIndex = 20;
            this.btnBookingConfirmDate.Text = "Proceed";
            this.btnBookingConfirmDate.UseVisualStyleBackColor = true;
            this.btnBookingConfirmDate.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Booking for customer:";
            // 
            // txtBookingCustomerName
            // 
            this.txtBookingCustomerName.Location = new System.Drawing.Point(179, 22);
            this.txtBookingCustomerName.Name = "txtBookingCustomerName";
            this.txtBookingCustomerName.Size = new System.Drawing.Size(228, 26);
            this.txtBookingCustomerName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Please select a timeslot that is available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1099, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Please select an employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lblBookingDatePreviousWeek
            // 
            this.lblBookingDatePreviousWeek.AutoSize = true;
            this.lblBookingDatePreviousWeek.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDatePreviousWeek.Location = new System.Drawing.Point(19, 123);
            this.lblBookingDatePreviousWeek.Name = "lblBookingDatePreviousWeek";
            this.lblBookingDatePreviousWeek.Size = new System.Drawing.Size(152, 18);
            this.lblBookingDatePreviousWeek.TabIndex = 26;
            this.lblBookingDatePreviousWeek.Text = "<----- Previous week";
            this.lblBookingDatePreviousWeek.Click += new System.EventHandler(this.LblBookingDatePreviousWeek_Click);
            this.lblBookingDatePreviousWeek.MouseEnter += new System.EventHandler(this.LblBookingDatePreviousWeek_MouseEnter);
            this.lblBookingDatePreviousWeek.MouseLeave += new System.EventHandler(this.LblBookingDatePreviousWeek_MouseLeave);
            // 
            // lblBookingDateNextWeek
            // 
            this.lblBookingDateNextWeek.AutoSize = true;
            this.lblBookingDateNextWeek.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDateNextWeek.Location = new System.Drawing.Point(977, 123);
            this.lblBookingDateNextWeek.Name = "lblBookingDateNextWeek";
            this.lblBookingDateNextWeek.Size = new System.Drawing.Size(118, 18);
            this.lblBookingDateNextWeek.TabIndex = 27;
            this.lblBookingDateNextWeek.Text = "Next week ---->";
            this.lblBookingDateNextWeek.Click += new System.EventHandler(this.LblBookingDateNextWeek_Click);
            this.lblBookingDateNextWeek.MouseEnter += new System.EventHandler(this.LblBookingDateNextWeek_MouseEnter);
            this.lblBookingDateNextWeek.MouseLeave += new System.EventHandler(this.LblBookingDateNextWeek_MouseLeave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Booking_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 586);
            this.Controls.Add(this.lblBookingDateNextWeek);
            this.Controls.Add(this.lblBookingDatePreviousWeek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBookingCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookingConfirmDate);
            this.Controls.Add(this.dgvBookingEmployees);
            this.Controls.Add(this.dgvBookEvent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking_Date";
            this.Text = "Choose date";
            this.Activated += new System.EventHandler(this.Booking_Date_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Book_Event_Date_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvBookEvent;
        private System.Windows.Forms.DataGridView dgvBookingEmployees;
        private System.Windows.Forms.Button btnBookingConfirmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookingCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBookingDatePreviousWeek;
        private System.Windows.Forms.Label lblBookingDateNextWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}