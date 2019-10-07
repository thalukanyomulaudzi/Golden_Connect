using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Employee_Update : Form
    {
        public static bool edit;
        public static string employeeID;
        int ms, et;
        int msID, emtID;
        public Employee_Update()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtEmpFirst.Enabled = edit;
            txtEmpLast.Enabled = edit;
            txtEmpPhone.Enabled = edit;
            txtEmpEmail.Enabled = edit;
            txtEmpAddress.Enabled = edit;
            cbxEmpMarital.Enabled = edit;
            cbxEmpType.Enabled = edit;
            loadAllEmployeesForEdit();


            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `employee` WHERE `employee_idnumber` = '" + employeeID + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtEmpFirst.Text = reader.GetString("employee_first");
                    txtEmpLast.Text = reader.GetString("employee_last");
                    txtEmpPhone.Text = reader.GetString("employee_phone");
                    txtEmpEmail.Text = reader.GetString("employee_email");
                    txtEmpAddress.Text = reader.GetString("employee_address");
                    ms = reader.GetInt32("employee_marital");
                    et = reader.GetInt32("employee_type");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            load_EMPType(et);
            load_MS(ms);
        }

        private void loadAllEmployeesForEdit()
        {
            load_EMPTypes();
            load_MaritalStatus();
        }

        public void load_EMPTypes()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `employee_type`";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxEmpType.Items.Add(reader.GetString(1));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void load_EMPType(int i)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `employee_type` WHERE `employee_type_id` = '" + i + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxEmpType.Text = reader.GetString("employee_type_name");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void load_MaritalStatus()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `marital_status`";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                cbxEmpMarital.Items.Clear();
                while (reader.Read())
                {
                    cbxEmpMarital.Items.Add(reader.GetString(1));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BtnSaveEmpEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT `marital_status_id`, `employee_type_id` FROM `marital_status`, `employee_type` " +
                    "WHERE `marital_status_name` = '" + cbxEmpMarital.SelectedItem.ToString() + "' AND `employee_type_name` = '" + cbxEmpType.SelectedItem.ToString() + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                cbxEmpMarital.Items.Clear();
                while (reader.Read())
                {
                    msID = reader.GetInt32("marital_status_id");
                    emtID = reader.GetInt32("employee_type_id");
                }
                reader.Close();


                query = "UPDATE employee SET (employee_first, employee_last, employee_marital, employee_email, employee_phone, employee_type, employee_address) " +
                    "VALUES ('" + txtEmpFirst.Text + "', '" + txtEmpLast.Text + "','" + msID + "','" + txtEmpEmail.Text + "','" + txtEmpPhone.Text + "','" + emtID + "','" + txtEmpAddress.Text + "') " +
                    "WHERE employee_id = '" + employeeID + "'";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee updated");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void load_MS(int i)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `marital_status` WHERE `marital_status_id` = '" + i + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxEmpMarital.Text = reader.GetString("marital_status_name");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
