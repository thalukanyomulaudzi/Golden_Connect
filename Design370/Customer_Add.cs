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
    public partial class Customer_Add : Form
    {
        public Customer_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtCustomerFirst, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtCustomerLast, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtCustomerEmail, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(txtCustomerPhone, "A maximum of 10 characters can be entered");
            toolTip1.SetToolTip(txtCustomerID, "A maximum of 13 characters can be entered");
        }

        private void Customer_Add_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (!Validation.validate(txtCustomerFirst.Text, "name") || !Validation.validate(txtCustomerLast.Text, "name") || !Validation.validate(txtCustomerID.Text, "id") 
                || !Validation.validate(txtCustomerPhone.Text, "phone") || !Validation.validate(txtCustomerEmail.Text, "email"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "INSERT INTO customer(customer_first, customer_last, customer_email, customer_phone, customer_id_number) VALUES('" + txtCustomerFirst.Text + "', " +
                        "'" + txtCustomerLast.Text + "', '" + txtCustomerEmail.Text.ToLower() + "', '" + txtCustomerPhone.Text + "', '" + txtCustomerID.Text + "')";
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

        private void Customer_Add_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TxtFN_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblCustomerFirst, Validation.validate(txtCustomerFirst.Text, "name"));
        }

        private void TxtCustomerID_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblCustomerID, Validation.validate(txtCustomerID.Text, "id"));
        }

        private void TxtCustomerLast_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblCustomerLast, Validation.validate(txtCustomerLast.Text, "name"));
        }

        private void TxtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblCustomerPhone, Validation.validate(txtCustomerPhone.Text, "phone"));
        }

        private void TxtCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblCustomerEmail, Validation.validate(txtCustomerEmail.Text, "email"));
        }

        private void Customer_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
