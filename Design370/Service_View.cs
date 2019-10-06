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
        string helpstring = " ";
        public Service_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(cbxServiceType, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtServiceName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtServiceDescription, "A maximum of 100 characters can be entered");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtServiceName.Enabled = true;
            txtServiceDescription.Enabled = true;
            txtServicePrice.Enabled = true;
            cbxServiceType.Enabled = true;
            btnServiceTypeAdd.Enabled = true;
            btnServiceEdit.Enabled = false;
            this.Text = "Edit Service";
            helpstring = "Edit_Service";
        }

        private void Service_View_Load(object sender, EventArgs e)
        {
            txtServiceName.Enabled = edit;
            txtServiceDescription.Enabled = edit;
            txtServicePrice.Enabled = edit;
            cbxServiceType.Enabled = edit;
            btnServiceTypeAdd.Enabled = edit;
            btnServiceEdit.Enabled = !edit;
            if (edit)
            {
                this.Text = "Edit Service";
                helpstring = "Edit_Service";
            }
            else if (!edit)
            {
                this.Text = "View Service";
                helpstring = "View_Service";
            }

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
                        cbxServiceType.Items.Add(mysqlReader["service_type_name"].ToString());
                        cbxServiceType.ValueMember = (mysqlReader["service_type_id"].ToString());
                    }
                    mysqlReader.Close();
                    string query = "SELECT service_id, service_name, service_description, service_price, service_type_id FROM service WHERE service_id = '" + GetServiceRow + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        serviceID = mysqlReader.GetString(0);
                        txtServiceName.Text = mysqlReader.GetString(1);
                        txtServiceDescription.Text = mysqlReader.GetString(2);
                        txtServicePrice.Text = mysqlReader.GetString(3);
                        serviceTypeID = mysqlReader.GetString(4);
                    }
                    mysqlReader.Close();
                    query = "SELECT service_type_name FROM service_type WHERE service_type_id = '" + serviceTypeID + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    mysqlReader.Read();
                    serviceTypeName = mysqlReader.GetString(0);
                    mysqlReader.Close();
                    cbxServiceType.SelectedIndex = cbxServiceType.FindStringExact(serviceTypeName);
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
            if (!Validation.validate(txtServiceName.Text, "name") || !Validation.validate(txtServiceDescription.Text, "name") || !Validation.validate(txtServicePrice.Text, "price"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            if (cbxServiceType.SelectedIndex <= -1)
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
                    string query = "SELECT service_type_id FROM service_type WHERE service_type_name = '" + cbxServiceType.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    serviceTypeID = reader.GetString(0);
                    reader.Close();
                    query = "UPDATE `service` SET `service_name` = '" + txtServiceName.Text + "', `service_description` = '" +
                        "" + txtServiceDescription.Text + "', `service_price` = '" + txtServicePrice.Text + "', `service_type_id` = '" +
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

        private void TxtServiceName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServiceName, Validation.validate(txtServiceName.Text, "name"));
        }

        private void TxtServicePrice_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServicePrice, Validation.validate(txtServicePrice.Text, "price"));
        }

        private void TxtServiceDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServiceDescription, Validation.validate(txtServiceDescription.Text, "name"));
        }

        private void Service_View_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = helpstring;
            helpForm.ShowDialog();
        }

        private void LblServiceDescription_Click(object sender, EventArgs e)
        {

        }

        private void LblServiceName_Click(object sender, EventArgs e)
        {

        }
    }
}
