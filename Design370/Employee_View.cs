using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class Employee_View : Form
    {
        public static bool edit;
        public string GetEmployeeRow { get; set; }
        string gender = " ";
        string marital_statusID = " ";
        string titleID = " ";
        string employee_typeID = " ";
        string title = " ";
        string employee_type = " ";
        string marital_status = " ";
        string helpstring = " ";
        public Employee_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtEmployeeFirst, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeLast, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeID, "A maximum of 13 characters can be entered");
            toolTip1.SetToolTip(txtEmployeePhone, "A maximum of 10 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeAddress, "A maximum of 100 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeEmail, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(cbxEmployeeGender, "Please select a gender");
            toolTip1.SetToolTip(cbxEmployeeStatus, "Please select a marital status");
            toolTip1.SetToolTip(cbxEmployeeTitle, "Please select a title");
            toolTip1.SetToolTip(cbxEmployeeType, "Please select an employee type");
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadTitles()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM title";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeTitle.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void loadTypes()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM employee_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeType.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void loadMaritalStatus()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM marital_status";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeStatus.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Employee_View_Load(object sender, EventArgs e)
        {
            txtEmployeeFirst.Enabled = edit;
            txtEmployeeLast.Enabled = edit;
            txtEmployeeID.Enabled = edit;
            txtEmployeePhone.Enabled = edit;
            txtEmployeeEmail.Enabled = edit;
            txtEmployeeAddress.Enabled = edit;
            btnEmployeeTypeAdd.Enabled = edit;
            cbxEmployeeTitle.Enabled = edit;
            cbxEmployeeStatus.Enabled = edit;
            cbxEmployeeGender.Enabled = edit;
            cbxEmployeeType.Enabled = edit;
            btnEmployeeEdit.Enabled = !edit;
            if (edit)
            {
                this.Text = "Edit Employee";
                helpstring = "Edit_Employee";
            }
            else if (!edit)
            {
                this.Text = "View Employee";
                helpstring = "View_Employee";
            }
            cbxEmployeeGender.Items.Add("Male");
            cbxEmployeeGender.Items.Add("Female");
            loadTitles();
            loadMaritalStatus();
            loadTypes();

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM employee WHERE employee_id = '" + GetEmployeeRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtEmployeeFirst.Text = reader.GetString(1);
                        txtEmployeeLast.Text = reader.GetString(2);
                        txtEmployeeID.Text = reader.GetString(3);
                        txtEmployeePhone.Text = reader.GetString(4);
                        txtEmployeeEmail.Text = reader.GetString(5);
                        txtEmployeeAddress.Text = reader.GetString(6);
                        employee_typeID = reader.GetString(7);
                        gender = reader.GetString(8);
                        marital_statusID = reader.GetString(9);
                        titleID = reader.GetString(10);
                    }
                    reader.Close();
                    if (gender == "M")
                    {
                        cbxEmployeeGender.SelectedIndex = cbxEmployeeGender.FindStringExact("Male");
                    }
                    else if (gender == "F")
                    {
                        cbxEmployeeGender.SelectedIndex = cbxEmployeeGender.FindStringExact("Female");
                    }
                    query = "SELECT title_name FROM title WHERE title_id = '" + titleID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        title = reader.GetString(0);
                    }
                    reader.Close();
                    cbxEmployeeTitle.SelectedIndex = cbxEmployeeTitle.FindStringExact(title);
                    query = "SELECT employee_type_name FROM employee_type WHERE employee_type_id = '" + employee_typeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_type = reader.GetString(0);
                    }
                    reader.Close();
                    cbxEmployeeType.SelectedIndex = cbxEmployeeType.FindStringExact(employee_type);
                    query = "SELECT marital_status_name FROM marital_status WHERE marital_status_id = '" + marital_statusID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        marital_status = reader.GetString(0);
                    }
                    reader.Close();
                    cbxEmployeeStatus.SelectedIndex = cbxEmployeeStatus.FindStringExact(marital_status);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            helpstring = "Edit_Employee";
            this.Text = "Edit Employee";
            txtEmployeeFirst.Enabled = true;
            txtEmployeeLast.Enabled = true;
            txtEmployeeID.Enabled = true;
            txtEmployeePhone.Enabled = true;
            txtEmployeeEmail.Enabled = true;
            txtEmployeeAddress.Enabled = true;
            cbxEmployeeTitle.Enabled = true;
            cbxEmployeeStatus.Enabled = true;
            cbxEmployeeGender.Enabled = true;
            cbxEmployeeType.Enabled = true;
            btnEmployeeTypeAdd.Enabled = true;
            btnEmployeeEdit.Enabled = false;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validation.validate(txtEmployeeFirst.Text, "name") || !Validation.validate(txtEmployeeLast.Text, "name") || !Validation.validate(txtEmployeeID.Text, "price")
                || !Validation.validate(txtEmployeeEmail.Text, "email") || !Validation.validate(txtEmployeePhone.Text, "phone"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            if (cbxEmployeeTitle.SelectedIndex < 0 || cbxEmployeeGender.SelectedIndex < 0 
                || cbxEmployeeStatus.SelectedIndex < 0 || cbxEmployeeType.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose values for all comboboxes");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string titleID = " ";
                    string maritalID = " ";
                    string employee_type_ID = " ";
                    string gender = " ";
                    string query = "SELECT title_id FROM title WHERE title_name = '" + cbxEmployeeTitle.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        titleID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT marital_status_id FROM marital_status WHERE marital_status_name = '" + cbxEmployeeStatus.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        maritalID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT employee_type_id FROM employee_type WHERE employee_type_name = '" + cbxEmployeeType.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_type_ID = reader.GetString(0);
                    }
                    reader.Close();
                    gender = cbxEmployeeGender.SelectedItem.ToString().Substring(0, 1);
                    query = "UPDATE `employee` SET `employee_id` = '" + GetEmployeeRow + "', `employee_first` = '" + txtEmployeeFirst.Text + "', `employee_last` = '" + txtEmployeeLast.Text +
                        "', `employee_idnumber` = '" + txtEmployeeID.Text + "', `employee_phone` = '" + txtEmployeePhone.Text + "', `employee_email` = '" + txtEmployeeEmail.Text.ToLower() + "', " +
                        "`employee_address` = '" + txtEmployeeAddress.Text + "', `employee_type` = '" + employee_type_ID + "', `employee_marital` = '" + maritalID + "', " +
                        "`employee_title` = '" + titleID + "' WHERE employee_id = '" + GetEmployeeRow + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            this.Close();
        }

        private void Employee_View_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Employee_Types_Add employee_Types_Add = new Employee_Types_Add();
            employee_Types_Add.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtEmployeeAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtEmployeeFirst_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeFirst, Validation.validate(txtEmployeeFirst.Text, "name"));
        }

        private void TxtEmployeeLast_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeLast, Validation.validate(txtEmployeeLast.Text, "name"));
        }

        private void TxtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeID, Validation.validate(txtEmployeeID.Text, "id"));
        }

        private void TxtEmployeePhone_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeePhone, Validation.validate(txtEmployeePhone.Text, "phone"));
        }

        private void TxtEmployeeEmail_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeEmail, Validation.validate(txtEmployeeEmail.Text, "email"));
        }

        private void Employee_View_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = helpstring;
            helpForm.ShowDialog();
        }
    }
}
