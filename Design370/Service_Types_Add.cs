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
    public partial class Service_Types_Add : Form
    {
        public Service_Types_Add()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServiceTypeInsert = "INSERT INTO service_type(service_type_name, service_type_description) VALUES('" +
                                    txtServTypeName.Text + "', '" + txtServTypeDesc.Text + "')";
            MysqlConnection.cmd = new MySqlCommand(ServiceTypeInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Service Type already exits!");
                }
                else
                {
                    MessageBox.Show("New Service Type Inserted!");
                    MysqlConnection.mysqlCon.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
            }
        }
    }
}
