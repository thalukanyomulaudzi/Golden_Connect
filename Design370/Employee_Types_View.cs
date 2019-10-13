using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Design370
{
    public partial class Employee_Types_View : Form
    {
        int id = -1;
        public static bool edit;
        string helpstring = " ";
        public string emptype;

        public Employee_Types_View()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            btnSaveEmpType.Enabled = false;
            txtEmpTypeName.Enabled = true;
            txtEmpTypeDescription.Enabled = true;
            cbxAccessLevel.Enabled = true;
            helpstring = "Edit_Employee_Type";
        }
        private void Employee_Types_View_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                this.Text = "Edit Employee Type";
                helpstring = "Edit_Employee_Type";
            }
            else if (!edit)
            {
                this.Text = "View Employee Type";
                helpstring = "View_Employee_Type";
            }
            txtEmpTypeName.Enabled = edit;
            txtEmpTypeDescription.Enabled = edit;
            cbxAccessLevel.Enabled = edit;
            btnSaveEmpType.Enabled = !edit;
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                string query = "SELECT * FROM `employee_type` WHERE `employee_type_name` = '" + emptype + "'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    txtEmpTypeName.Text = reader.GetString(1);
                    txtEmpTypeDescription.Text = reader.GetString(2);
                    cbxAccessLevel.SelectedIndex = cbxAccessLevel.FindStringExact(reader.GetString(3));
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
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "UPDATE `employee_type` SET `employee_type_name` = '" + txtEmpTypeName.Text + "', `employee_type_description` = '" + txtEmpTypeDescription.Text + "', " +
                    "`access_level` = '" + cbxAccessLevel.SelectedItem.ToString() + "' WHERE employee_type_id = '" + id + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Employee_Types_View_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = helpstring;
            helpForm.ShowDialog();
        }
    }
}
