using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
            toolTip1.SetToolTip(cbxServiceType, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtServiceName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtServiceDescription, "A maximum of 100 characters can be entered");
            toolTip1.SetToolTip(btnServiceAdd, "Add the service");
        }

        private void Service_Add_Activated(object sender, EventArgs e)
        {
            cbxServiceType.Items.Clear();
            try
            {
                var mysqlCmd = new MySqlCommand("SELECT * FROM service_type", dbCon.Connection);
                var mysqlReader = mysqlCmd.ExecuteReader();
                while (mysqlReader.Read())
                {
                    cbxServiceType.Items.Add(mysqlReader["service_type_name"].ToString());
                    cbxServiceType.ValueMember = (mysqlReader["service_type_id"].ToString());

                }
                mysqlReader.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void TxtServiceName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServiceName, Validation.validate(txtServiceName.Text, "name"));
        }

        private void BtnServiceAdd_Click(object sender, EventArgs e)
        {
            double price = txtServicePrice.Text.Contains("R") ? Convert.ToDouble(txtServicePrice.Text.Substring(1)) : Convert.ToDouble(txtServicePrice.Text);
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
                string bookingTypeID = "";
                string query = "SELECT service_type_id FROM service_type WHERE service_type_name = '" + cbxServiceType.SelectedItem.ToString() + "'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                bookingTypeID = reader.GetString(0);
                reader.Close();
                query = "INSERT INTO `service`(`service_name`, `service_description`, `service_price`, `service_type_id`) VALUES('" +
                            txtServiceName.Text + "', '" + txtServiceDescription.Text + "', '" + price + "', '" + bookingTypeID + "')";
                command = new MySqlCommand(query, dbCon.Connection);
                command.ExecuteNonQuery();
                this.Close();
                Main_Form.ActiveForm.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void BtnServiceType_Click(object sender, EventArgs e)
        {
            Service_Types_Add service_Types_add = new Service_Types_Add();
            service_Types_add.ShowDialog();
        }

        private void TxtServicePrice_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServicePrice, Validation.validate(txtServicePrice.Text, "price"));
        }

        private void TxtServiceDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblServiceDescription, Validation.validate(txtServiceDescription.Text, "name"));
        }

        private void Service_Add_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Service";
            helpForm.ShowDialog();
        }
    }
}
