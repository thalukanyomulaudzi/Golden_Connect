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
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBookingCreateEvent = new System.Windows.Forms.Button();
            this.dgvBookingEmployees = new System.Windows.Forms.DataGridView();
            this.btnBookingCreatePhotoshoot = new System.Windows.Forms.Button();
            this.bookingEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmployeeAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dgvBookEvent
            // 
            this.dgvBookEvent.AllowUserToAddRows = false;
            this.dgvBookEvent.AllowUserToDeleteRows = false;
            this.dgvBookEvent.AllowUserToOrderColumns = true;
            this.dgvBookEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBookEvent.Location = new System.Drawing.Point(27, 96);
            this.dgvBookEvent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookEvent.Name = "dgvBookEvent";
            this.dgvBookEvent.RowTemplate.Height = 24;
            this.dgvBookEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookEvent.Size = new System.Drawing.Size(805, 232);
            this.dgvBookEvent.TabIndex = 17;
            this.dgvBookEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookEvent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnBookingCreateEvent
            // 
            this.btnBookingCreateEvent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookingCreateEvent.Location = new System.Drawing.Point(848, 334);
            this.btnBookingCreateEvent.Name = "btnBookingCreateEvent";
            this.btnBookingCreateEvent.Size = new System.Drawing.Size(288, 24);
            this.btnBookingCreateEvent.TabIndex = 18;
            this.btnBookingCreateEvent.Text = "Create event booking";
            this.btnBookingCreateEvent.UseVisualStyleBackColor = true;
            this.btnBookingCreateEvent.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvBookingEmployees
            // 
            this.dgvBookingEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingEmployeeName,
            this.bookingEmployeeAvailable,
            this.bookingEmployeeID});
            this.dgvBookingEmployees.Location = new System.Drawing.Point(848, 96);
            this.dgvBookingEmployees.Name = "dgvBookingEmployees";
            this.dgvBookingEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBookingEmployees.Size = new System.Drawing.Size(288, 232);
            this.dgvBookingEmployees.TabIndex = 19;
            this.dgvBookingEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // btnBookingCreatePhotoshoot
            // 
            this.btnBookingCreatePhotoshoot.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookingCreatePhotoshoot.Location = new System.Drawing.Point(848, 364);
            this.btnBookingCreatePhotoshoot.Name = "btnBookingCreatePhotoshoot";
            this.btnBookingCreatePhotoshoot.Size = new System.Drawing.Size(288, 24);
            this.btnBookingCreatePhotoshoot.TabIndex = 20;
            this.btnBookingCreatePhotoshoot.Text = "Create photoshoot booking";
            this.btnBookingCreatePhotoshoot.UseVisualStyleBackColor = true;
            this.btnBookingCreatePhotoshoot.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bookingEmployeeName
            // 
            this.bookingEmployeeName.HeaderText = "Employee Name";
            this.bookingEmployeeName.Name = "bookingEmployeeName";
            // 
            // bookingEmployeeAvailable
            // 
            this.bookingEmployeeAvailable.HeaderText = "Available";
            this.bookingEmployeeAvailable.Name = "bookingEmployeeAvailable";
            // 
            // bookingEmployeeID
            // 
            this.bookingEmployeeID.HeaderText = "ID";
            this.bookingEmployeeID.Name = "bookingEmployeeID";
            this.bookingEmployeeID.Visible = false;
            // 
            // Booking_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 417);
            this.Controls.Add(this.btnBookingCreatePhotoshoot);
            this.Controls.Add(this.dgvBookingEmployees);
            this.Controls.Add(this.btnBookingCreateEvent);
            this.Controls.Add(this.dgvBookEvent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Booking_Date";
            this.Text = "Book_Event_Date";
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
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Button btnBookingCreateEvent;
        private System.Windows.Forms.DataGridView dgvBookingEmployees;
        private System.Windows.Forms.Button btnBookingCreatePhotoshoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEmployeeID;
    }
}