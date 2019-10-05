using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Employee_Types_View : Form
    {
        int id = -1;


        public Employee_Types_View()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "UPDATE employee_type SET (employee_type_name, employee_type_description) " +
                    "VALUES ('" + txtEmpTypeName.Text + "', '" + txtEmpTypeDescription.Text + "') " +
                    "WHERE employee_type_id = '" + id + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee type updated");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public string emptype;
        private void Employee_Types_View_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                string query = "SELECT * FROM `employee_type` WHERE `employee_type_name` = '" + emptype + "'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    txtEmpTypeName.Text = reader.GetString(1);
                    txtEmpTypeDescription.Text = reader.GetString(2);
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtEmpTypeName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblTypeName, Validation.validate(txtEmpTypeName.Text, "name"));
        }

        private void TxtEmpTypeDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblTypeDescription, Validation.validate(txtEmpTypeDescription.Text, "name"));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Validation.validate(txtEmpTypeName.Text, "name") || !Validation.validate(txtEmpTypeDescription.Text, "name"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
        }
    }
}
