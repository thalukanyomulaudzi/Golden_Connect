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
        public Employee_View()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

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
                        comboBox4.Items.Add(reader.GetString(1));
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
                        comboBox2.Items.Add(reader.GetString(1));
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
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            textBox3.Enabled = edit;
            textBox4.Enabled = edit;
            textBox5.Enabled = edit;
            textBox7.Enabled = edit;
            button3.Enabled = edit;
            cbxEmpTitle.Enabled = edit;
            comboBox2.Enabled = edit;
            comboBox3.Enabled = edit;
            comboBox4.Enabled = edit;
            button2.Enabled = !edit;

            comboBox3.Items.Add("Male");
            comboBox3.Items.Add("Female");
            loadTitles();
            loadMaritalStatus();
            loadTypes();

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string gender = " ";
                    string marital_status = " ";
                    string title = " ";
                    string employee_type = " ";
                    string query = "SELECT * FROM employee WHERE employee_id = '" + GetEmployeeRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = reader.GetString(1);
                        textBox2.Text = reader.GetString(2);
                        textBox3.Text = reader.GetString(3);
                        textBox4.Text = reader.GetString(4);
                        textBox5.Text = reader.GetString(5);
                        textBox7.Text = reader.GetString(6);
                        employee_type = reader.GetString(7);
                        gender = reader.GetString(8);
                        marital_status = reader.GetString(9);
                        title = reader.GetString(10);
                    }
                    reader.Close();
                    if (gender == "M")
                    {
                        comboBox3.SelectedText = "Male";
                    }
                    else if (gender == "F")
                    {
                        comboBox3.SelectedText = "Female";
                    }
                    query = "SELECT title_name FROM title WHERE title_id = '" + title + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    cbxEmpTitle.SelectedText = reader.GetString(0);
                    reader.Close();
                    query = "SELECT employee_type_name FROM employee_type WHERE employee_type_id = '" + employee_type + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    comboBox4.SelectedText = reader.GetString(0);
                    reader.Close();
                    query = "SELECT marital_status_name FROM marital_status WHERE marital_status_id = '" + marital_status + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    comboBox2.SelectedText = reader.GetString(0);
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            cbxEmpTitle.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        public void addEmployee()
        {
            MessageBox.Show(cbxEmpTitle.SelectedText);
            if (cbxEmpTitle.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a title");
                return;
            }
            else if (textBox3.Text.Length <= 12)
            {
                MessageBox.Show("Please provide a valid id number");
                return;
            }
            else if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a first name");
                return;
            }
            else if (comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender");
                return;
            }
            else if (textBox2.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a last name");
                return;
            }
            else if (comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a marital status");
                return;
            }
            else if (textBox7.Text.Length <= 10)
            {
                MessageBox.Show("Please provide an address");
                return;
            }
            else if (textBox4.Text.Length <= 9)
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }
            else if (textBox5.Text.Length <= 5)
            {
                MessageBox.Show("Please provide a valid email address");
                return;
            }
            else if (comboBox4.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee type");
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
                    string query = "SELECT title_id FROM title WHERE title_name = '" + cbxEmpTitle.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        titleID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT marital_status_id FROM marital_status WHERE marital_status_name = '" + comboBox2.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        maritalID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT employee_type_id FROM employee_type WHERE employee_type_name = '" + comboBox4.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_type_ID = reader.GetString(0);
                    }
                    reader.Close();
                    gender = comboBox3.SelectedItem.ToString().Substring(0, 1);
                    query = "UPDATE `employee` SET `employee_id` = '" + GetEmployeeRow + "', `employee_first` = '" + textBox1.Text + "', `employee_last` = '" + textBox2.Text +
                        "', `employee_idnumber` = '" + textBox3.Text + "', `employee_phone` = '" + textBox4.Text + "', `employee_email` = '" + textBox5.Text + "', " +
                        "`employee_address` = '" + textBox7.Text + "', `employee_type` = '" + employee_type_ID + "', `employee_marital` = '" + maritalID + "', " +
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

        private void Button1_Click(object sender, EventArgs e)
        {
            addEmployee();
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
