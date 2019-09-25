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

        public string emptype;
        private void Employee_Types_View_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    string loadEmployeeTypes = "SELECT * FROM `employee_type` WHERE `employee_type_name` = '"+emptype+"'";
                    var command = new MySqlCommand(loadEmployeeTypes, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        txtEmpTypeName.Text = reader[1].ToString();
                        txtEmpTypeDescription.Text = reader[2].ToString();
                    }
                    reader.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
