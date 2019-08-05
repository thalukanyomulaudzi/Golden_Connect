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
            this.EmpTypeDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmpTypeEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmpTypeView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmpTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpTypeDelete
            // 
            this.EmpTypeDelete.HeaderText = "";
            this.EmpTypeDelete.Name = "EmpTypeDelete";
            // 
            // EmpTypeEdit
            // 
            this.EmpTypeEdit.HeaderText = "";
            this.EmpTypeEdit.Name = "EmpTypeEdit";
            // 
            // EmpTypeView
            // 
            this.EmpTypeView.HeaderText = "";
            this.EmpTypeView.Name = "EmpTypeView";
            this.EmpTypeView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpTypeView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmpTypeDescription
            // 
            this.EmpTypeDescription.HeaderText = "Description";
            this.EmpTypeDescription.Name = "EmpTypeDescription";
            // 
            // EmpTypeName
            // 
            this.EmpTypeName.HeaderText = "Name";
            this.EmpTypeName.Name = "EmpTypeName";
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpTypeName,
            this.EmpTypeDescription,
            this.EmpTypeView,
            this.EmpTypeEdit,
            this.EmpTypeDelete});
            this.dataGridView7.Location = new System.Drawing.Point(22, 73);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(754, 335);
            this.dataGridView7.TabIndex = 43;
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
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(82, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 26);
            this.textBox7.TabIndex = 45;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 47;
            this.label13.Text = "Sort by:";
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ItemHeight = 18;
            this.comboBox7.Location = new System.Drawing.Point(374, 24);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(136, 26);
            this.comboBox7.TabIndex = 48;
            // 
            // Employee_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 456);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dataGridView7);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Types";
            this.Text = "Employee Types";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeDelete;
        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeEdit;
        private System.Windows.Forms.DataGridViewButtonColumn EmpTypeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTypeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpTypeName;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}