﻿using System;
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
        }


        private void Button3_Click_1(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedIndex = this.cbxServiceTypes.SelectedIndex + 1;

            string ServiceInsert = "INSERT INTO service(service_name, service_description, service_price, service_type_id) VALUES('" +
                                txtServiceName.Text + "', '" + txtServiceDescr.Text + "', '" + txtServicePrice.Text + "', '" + selectedIndex.ToString() + "')";
            MysqlConnection.cmd = new MySqlCommand(ServiceInsert, MysqlConnection.mysqlCon);
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
