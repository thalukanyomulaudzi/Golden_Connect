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
    public partial class Employee_Add : Form
    {
        string titleID = " ";
        string maritalID = " ";
        string employee_type_ID = " ";
        string gender = " ";
        public Employee_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtEmpFirst, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmpLast, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmpID, "A maximum of 13 characters can be entered");
            toolTip1.SetToolTip(txtEmpPhone, "A maximum of 10 characters can be entered");
            toolTip1.SetToolTip(txtEmpAddress, "A maximum of 100 characters can be entered");
            toolTip1.SetToolTip(txtEmpEmail, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(cbxEmpGender, "Please select a gender");
            toolTip1.SetToolTip(cbxEmpMarital, "Please select a marital status");
            toolTip1.SetToolTip(cbxEmpTitle, "Please select a title");
            toolTip1.SetToolTip(cbxEmpType, "Please select an employee type");
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Employee_Types employee_Types = new Employee_Types();
            employee_Types.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Add_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            cbxEmpGender.Items.Add("Male");
            cbxEmpGender.Items.Add("Female");
            loadTitles();
            loadMaritalStatus();
            loadTypes();
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
                        cbxEmpTitle.Items.Add(reader.GetString(1));
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
                        cbxEmpType.Items.Add(reader.GetString(1));
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
                        cbxEmpMarital.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void CmMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void addEmployee()
        {
            if (cbxEmpTitle.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a title");
                return;
            }
            else if (txtEmpID.Text.Length <= 12)
            {
                MessageBox.Show("Please provide a valid id number");
                return;
            }
            else if (txtEmpFirst.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a first name");
                return;
            }
            else if (cbxEmpGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender");
                return;
            }
            else if (txtEmpLast.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a last name");
                return;
            }
            else if (cbxEmpMarital.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a marital status");
                return;
            }
            else if (txtEmpAddress.Text.Length <= 10)
            {
                MessageBox.Show("Please provide an address");
                return;
            }
            else if (txtEmpPhone.Text.Length <= 9)
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }
            else if (txtEmpEmail.Text.Length <= 5)
            {
                MessageBox.Show("Please provide a valid email address");
                return;
            }
            else if (cbxEmpType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee type");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT title_id FROM title WHERE title_name = '" + cbxEmpTitle.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        titleID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT marital_status_id FROM marital_status WHERE marital_status_name = '" + cbxEmpMarital.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        maritalID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT employee_type_id FROM employee_type WHERE employee_type_name = '" + cbxEmpType.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_type_ID = reader.GetString(0);
                    }
                    reader.Close();
                    gender = cbxEmpGender.SelectedItem.ToString().Substring(0, 1);
                    query = "INSERT INTO employee(employee_first, employee_last, employee_idnumber, employee_phone, " +
                    "employee_email, employee_address, employee_type, employee_gender, employee_marital, employee_title) " +
                    "VALUES('" + txtEmpFirst.Text + "', '" + txtEmpLast.Text + "', '" + txtEmpID.Text + "', '" + txtEmpPhone.Text + "', '" + txtEmpEmail.Text.ToLower() + "', '" + txtEmpAddress.Text + "', " +
                    "'" + employee_type_ID + "', '" + gender + "', '" + maritalID + "', '" + titleID + "')";
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

        private void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        private void CmEMTP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CmTITLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Types_Add employee_Types_Add = new Employee_Types_Add();
            employee_Types_Add.ShowDialog();
        }
    }
}
