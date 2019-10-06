using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Customer_View : Form
    {
        public bool edit;
        public string customerID;
        public string GetCustomerRow { get; set; }
        public Customer_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtCustomerFirst, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtCustomerLast, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtCustomerEmail, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(txtCustomerPhone, "A maximum of 15 characters can be entered");
            toolTip1.SetToolTip(txtCustomerID, "A maximum of 13 characters can be entered");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Customer_View_Load(object sender, EventArgs e)
        {
            txtCustomerEmail.Enabled = edit;
            txtCustomerFirst.Enabled = edit;
            txtCustomerID.Enabled = edit;
            txtCustomerLast.Enabled = edit;
            txtCustomerPhone.Enabled = edit;
            button2.Enabled = !edit;
            if (edit)
            {
                Text = "Edit Customer";
                helpstring = "Edit_Customer";
            }
            else if (!edit)
            {
                Text = "View Customer";
                helpstring = "View_Customer";
            }

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM customer WHERE customer_id = '" + GetCustomerRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCustomerID.Text = reader.GetString(5);
                        txtCustomerFirst.Text = reader.GetString(1);
                        txtCustomerLast.Text = reader.GetString(2);
                        txtCustomerEmail.Text = reader.GetString(3);
                        txtCustomerPhone.Text = reader.GetString(4);
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void Customer_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            txtCustomerEmail.Enabled = true;
            txtCustomerFirst.Enabled = true;
            txtCustomerID.Enabled = true;
            txtCustomerLast.Enabled = true;
            txtCustomerPhone.Enabled = true;
            button2.Enabled = false;
            helpstring = "Edit_Customer";
            Text = "Edit Customer";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtCustomerFirst.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a first name");
                return;
            }
            else if (txtCustomerLast.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a last name");
                return;
            }
            else if (txtCustomerEmail.Text.Length <= 12)
            {
                MessageBox.Show("Please provide a valid id number");
                return;
            }
            else if (txtCustomerPhone.Text.Length <= 9)
            {
                MessageBox.Show("Please provide a valid phone number");
                return;
            }
            else if (txtCustomerEmail.Text.Length <= 8)
            {
                MessageBox.Show("Please provide a valid email address");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "UPDATE `customer` SET `customer_id` = '" + GetCustomerRow + "', `customer_first` = '" + txtCustomerFirst.Text + "', `customer_last` = '" + txtCustomerLast.Text +
                        "', `customer_email` = '" + txtCustomerEmail.Text.ToLower() + "', `customer_phone` = '" + txtCustomerPhone.Text + "', `customer_id_number` = '" + txtCustomerID.Text + "' WHERE " +
                        "customer_id = '" + GetCustomerRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            this.Close();
        }
    }
}
