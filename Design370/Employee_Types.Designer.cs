namespace Design370
{
    partial class Employee_Types
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
            this.dgvEmpType = new System.Windows.Forms.DataGridView();
            this.button14 = new System.Windows.Forms.Button();
            this.txtSearchEmpType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EmployeeTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTypeView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmpTypeEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmpTypeDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpType
            // 
            this.dgvEmpType.AllowUserToAddRows = false;
            this.dgvEmpType.AllowUserToDeleteRows = false;
            this.dgvEmpType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeTypeID,
            this.EmployeeTypeName,
            this.EmployeeTypeDescription,
            this.EmpTypeView,
            this.EmpTypeEdit,
            this.EmpTypeDelete});
            this.dgvEmpType.Location = new System.Drawing.Point(22, 73);
            this.dgvEmpType.Name = "dgvEmpType";
            this.dgvEmpType.ReadOnly = true;
            this.dgvEmpType.RowHeadersVisible = false;
            this.dgvEmpType.RowTemplate.Height = 24;
            this.dgvEmpType.Size = new System.Drawing.Size(755, 341);
            this.dgvEmpType.TabIndex = 43;
            this.dgvEmpType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpType_CellContentClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(619, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(158, 28);
            this.button14.TabIndex = 44;
            this.button14.Text = "Add Employee Type";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // txtSearchEmpType
            // 
            this.txtSearchEmpType.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmpType.Location = new System.Drawing.Point(82, 24);
            this.txtSearchEmpType.Name = "txtSearchEmpType";
            this.txtSearchEmpType.Size = new System.Drawing.Size(212, 26);
            this.txtSearchEmpType.TabIndex = 45;
            this.txtSearchEmpType.TextChanged += new System.EventHandler(this.TxtSearchEmpType_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 46;
            this.label14.Text = "Search:";
            // 
            // EmployeeTypeID
            // 
            this.EmployeeTypeID.HeaderText = "ID";
            this.EmployeeTypeID.Name = "EmployeeTypeID";
            this.EmployeeTypeID.ReadOnly = true;
            this.EmployeeTypeID.Visible = false;
            // 
            // EmployeeTypeName
            // 
            this.EmployeeTypeName.HeaderText = "Employee Type";
            this.EmployeeTypeName.Name = "EmployeeTypeName";
            this.EmployeeTypeName.ReadOnly = true;
            // 
            // EmployeeTypeDescription
            // 
            this.EmployeeTypeDescription.HeaderText = "Description";
            this.EmployeeTypeDescription.Name = "EmployeeTypeDescription";
            this.EmployeeTypeDescription.ReadOnly = true;
            // 
            // EmpTypeView
            // 
            this.EmpTypeView.HeaderText = "";
            this.EmpTypeView.Name = "EmpTypeView";
            this.EmpTypeView.ReadOnly = true;
            this.EmpTypeView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpTypeView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmpTypeView.Text = "View";
            this.EmpTypeView.UseColumnTextForButtonValue = true;
            // 
            // EmpTypeEdit
            // 
            this.EmpTypeEdit.HeaderText = "";
            this.EmpTypeEdit.Name = "EmpTypeEdit";
            this.EmpTypeEdit.ReadOnly = true;
            this.EmpTypeEdit.Text = "Edit";
            this.EmpTypeEdit.UseColumnTextForButtonValue = true;
            // 
            // EmpTypeDelete
            // 
            this.EmpTypeDelete.HeaderText = "";
            this.EmpTypeDelete.Name = "EmpTypeDelete";
            this.EmpTypeDelete.ReadOnly = true;
            this.EmpTypeDelete.Text = "Delete";
            this.EmpTypeDelete.UseColumnTextForButtonValue = true;
            // 
            // Employee_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSearchEmpType);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dgvEmpType);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Types";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Types";
            this.Activated += new System.EventHandler(this.Employee_Types_Activated);
            this.Load += new System.EventHandler(this.Employee_Types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpType;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtSearchEmpType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTypeDescription;
        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeView;
        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeEdit;
        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeDelete;
    }
}