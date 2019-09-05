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

        DBConnection dbCon = DBConnection.Instance();
        public Service_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(cbxServiceTypes, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtServiceName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtServiceDescr, "A maximum of 100 characters can be entered");

        }

        private void Service_Add_Load(object sender, EventArgs e)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM service_type", dbCon.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        cbxServiceTypes.Items.Add(mysqlReader["service_type_name"].ToString());
                        cbxServiceTypes.ValueMember = (mysqlReader["service_type_id"].ToString());

                    }
                    mysqlReader.Close();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Length <= 2 || txtServiceDescr.Text.Length <= 5 || txtServicePrice.Text.Length == 0)
            {
                MessageBox.Show("Invalid character length for name and/or description and/or price");
                return;
            }
            if (cbxServiceTypes.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a service type");
                return;
            }
            try
            {
                if (dbCon.IsConnect())
                {
                    string bookingTypeID = "";
                    string query = "SELECT service_type_id FROM service_type WHERE service_type_name = '" + cbxServiceTypes.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    bookingTypeID = reader.GetString(0);
                    reader.Close();
                    query = "INSERT INTO `service`(`service_name`, `service_description`, `service_price`, `service_type_id`) VALUES('" +
                                txtServiceName.Text + "', '" + txtServiceDescr.Text + "', '" + txtServicePrice.Text + "', '"  + bookingTypeID + "')";
                    command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtServicePrice_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtServicePrice_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
