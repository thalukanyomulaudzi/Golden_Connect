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
    public partial class Service_View : Form
    {
        public static bool edit;
        string serviceID = "";
        public string GetServiceRow { get; set; }
        public Service_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(comboBox1, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 100 characters can be entered");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void Service_View_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            textBox3.Enabled = edit;
            comboBox1.Enabled = edit;
            button3.Enabled = edit;
            button2.Enabled = !edit;

            try
            {
                DBConnection dbConnection = DBConnection.Instance();
                string serviceTypeID = "";
                string serviceTypeName = "";
                if (dbConnection.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM service_type", dbConnection.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        comboBox1.Items.Add(mysqlReader["service_type_name"].ToString());
                        comboBox1.ValueMember = (mysqlReader["service_type_id"].ToString());
                    }
                    mysqlReader.Close();
                    string query = "SELECT service_id, service_name, service_description, service_price, service_type_id FROM service WHERE service_id = '" + GetServiceRow + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        serviceID = mysqlReader.GetString(0);
                        textBox1.Text = mysqlReader.GetString(1);
                        textBox2.Text = mysqlReader.GetString(2);
                        textBox3.Text = mysqlReader.GetString(3);
                        serviceTypeID = mysqlReader.GetString(4);
                    }
                    mysqlReader.Close();
                    query = "SELECT service_type_name FROM service_type WHERE service_type_id = '" + serviceTypeID + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    mysqlReader.Read();
                    serviceTypeName = mysqlReader.GetString(0);
                    mysqlReader.Close();
                    comboBox1.SelectedIndex = comboBox1.FindStringExact(serviceTypeName);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Service_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5 || textBox3.Text.Length == 0)
            {
                MessageBox.Show("Invalid character length for name and/or description and/or price");
                return;
            }
            if (comboBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a service type");
                return;
            }
            try
            {
                DBConnection dbConnection = DBConnection.Instance();
                if (dbConnection.IsConnect())
                {
                    string serviceTypeID = "";
                    string query = "SELECT service_type_id FROM service_type WHERE service_type_name = '" + comboBox1.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    serviceTypeID = reader.GetString(0);
                    reader.Close();
                    query = "UPDATE `service` SET `service_name` = '" + textBox1.Text + "', `service_description` = '" +
                        "" + textBox2.Text + "', `service_price` = '" + textBox3.Text + "', `service_type_id` = '" +
                        "" + serviceTypeID + "' WHERE service_id = '" + serviceID + "'";
                    command = new MySqlCommand(query, dbConnection.Connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
