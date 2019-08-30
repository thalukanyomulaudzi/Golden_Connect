using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Customer_View : Form
    {
        public bool edit;
        public string customerID;
        public Customer_View()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Customer_View_Load(object sender, EventArgs e)
        {
            toggleBoxes();
            loadBoxes();
        }
        private void Customer_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtCustomerFirst.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            edit = true;
            toggleBoxes();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (edit)
                {
                    DBConnection dBCon = DBConnection.Instance();
                    string query = "UPDATE customer SET customer_first = '" + txtCustomerFirst.Text + "', customer_last = '" + txtCustomerLast.Text +
                        "', customer_email = '" + txtCustomerEmail.Text + "', customer_phone = '" + txtCustomerPhone.Text +
                        "', customer_id_number = '" + txtCustomerID.Text + "' " +
                        "WHERE customer_id = '" + customerID + "'";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    command.ExecuteNonQuery();
                }
                Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void toggleBoxes()
        {
            txtCustomerFirst.Enabled = edit;
            txtCustomerLast.Enabled = edit;
            txtCustomerID.Enabled = edit;
            txtCustomerPhone.Enabled = edit;
            txtCustomerEmail.Enabled = edit;
        }

        private void loadBoxes()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT customer_id, customer_first, customer_last, customer_id_number, customer_email, customer_phone FROM customer " +
                    "WHERE customer_id_number = '" + customerID + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                customerID = reader.GetString(0);
                txtCustomerFirst.Text = reader.GetString(1);
                txtCustomerLast.Text = reader.GetString(2);
                txtCustomerID.Text = reader.GetString(3);
                txtCustomerEmail.Text = reader.GetString(4);
                txtCustomerPhone.Text = reader.GetString(5);
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
