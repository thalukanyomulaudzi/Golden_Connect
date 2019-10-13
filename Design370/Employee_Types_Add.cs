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
    public partial class Employee_Types_Add : Form
    {
        public Employee_Types_Add()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddType_Click(object sender, EventArgs e)
        {
            if (!Validation.validate(txtTypeName.Text, "name") || !Validation.validate(txtTypeDescription.Text, "name") || cbxAccessLevel.SelectedIndex < 0)
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            addEmployeeType();
        }

        public void addEmployeeType()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "INSERT INTO employee_type(employee_type_name, employee_type_description, access_level)" +
                    " VALUES('" + txtTypeName.Text + "', '" + txtTypeDescription.Text + "', '" + cbxAccessLevel.Text + "')";
                var command = new MySqlCommand(query, dBCon.Connection);
                if (command.ExecuteNonQuery() < 0)
                {
                    MessageBox.Show("Employee type added");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            this.Close();
        }

        private void TxtType_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblTypeName, Validation.validate(txtTypeName.Text, "name"));
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblTypeDescription, Validation.validate(txtTypeDescription.Text, "name"));
        }

        private void Employee_Types_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Employee_Type";
            helpForm.ShowDialog();
        }
    }
}
