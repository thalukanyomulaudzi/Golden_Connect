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
    public partial class Service_Add : Form
    {
        public Service_Add()
        {
            InitializeComponent();
            using (MysqlConnection.mysqlCon)
            {
                MySqlCommand mysqlCmd = new MySqlCommand("SELECT * FROM service_type", MysqlConnection.mysqlCon);

                MysqlConnection.mysqlCon.Open();
                MySqlDataReader mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                {
                    cbxServiceTypes.Items.Add(mysqlReader["service_type_name"].ToString());
                    cbxServiceTypes.ValueMember = (mysqlReader["service_type_id"].ToString());

                }

                mysqlReader.Close();

            }
        }

        private void Service_Add_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Service
            int selectedIndex = this.cbxServiceTypes.SelectedIndex + 1;

            string prodInsert = "INSERT INTO service(service_name, service_description, service_price, service_type_id) VALUES('" +
                                txtServiceName.Text + "', '" + txtServiceDescr.Text + "', '" + txtServiceDescr.Text + "', '" + selectedIndex.ToString() + "')";
            MysqlConnection.cmd = new MySqlCommand(prodInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Service already exits!");
                }
                else
                {
                    MessageBox.Show("New Service Inserted!");
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
