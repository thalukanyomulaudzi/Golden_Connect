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
    public partial class Employee_Types_View : Form
    {
        int id = -1;
        public static bool edit;
        string helpstring = " ";
        public static string emptype;

        public Employee_Types_View()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    string editEmpTypes = "UPDATE `employee_type` SET `employee_type_name` = @Name, `employee_type_description` = @Descr " +
                        "WHERE `employee_type_name` = @ID";
                    var command = new MySqlCommand(editEmpTypes, dbCon.Connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Name", txtEmpTypeName.Text);
                    command.Parameters.AddWithValue("@Descr", txtEmpTypeDescription.Text);
                    command.Parameters.AddWithValue("@ID", txtEmpTypeName.Text);
                    command.ExecuteReader();
                    //if (done > 0)
                    MessageBox.Show("Employee Type Updated Successfully", "Update Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.Close();
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Employee_Types_View_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                string query = "SELECT employee_type_id, employee_type_name, employee_type_description, access_level FROM `employee_type` WHERE `employee_type_name` = '" + emptype + "'";
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
        }
    }
}
