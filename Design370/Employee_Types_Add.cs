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
            addEmployeeType();
        }

        public void addEmployeeType()
        {
            MysqlConnection.mysqlCon.Open();
            string empType = "INSERT INTO employee_type(employee_type_name, employee_type_description)" +
                " VALUES('"+txtType.Text+"', '"+txtDescription.Text+"')";

            try
            {
                MysqlConnection.cmd = new MySqlCommand(empType, MysqlConnection.mysqlCon);
                MysqlConnection.cmd.ExecuteReader();
                MessageBox.Show("New Employee Type Inserted!");
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }
    }
}
