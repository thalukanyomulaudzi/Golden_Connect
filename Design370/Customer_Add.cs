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
            toolTip1.SetToolTip(txtFN, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtLN, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEM, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(txtTEL, "A maximum of 10 characters can be entered");
            toolTip1.SetToolTip(textBox3, "A maximum of 13 characters can be entered");
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
            if (txtFN.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a first name");
                return;
            }
            else if (txtLN.Text.Length <= 0)
            {
                MessageBox.Show("Please provide a last name");
                return;
            }
            else if (textBox3.Text.Length <= 12)
            {
                MessageBox.Show("Please provide a valid id number");
                return;
            }
            else if (txtTEL.Text.Length <= 9)
            {
                MessageBox.Show("Please provide a valid phone number");
                return;
            }
            else if (txtEM.Text.Length <= 8)
            {
                MessageBox.Show("Please provide a valid email address");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "INSERT INTO customer(customer_first, customer_last, customer_email, customer_phone, customer_id_number) VALUES('" + txtFN.Text + "', " +
                        "'" + txtLN.Text + "', '" + txtEM.Text.ToLower() + "', '" + txtTEL.Text + "', '" + textBox3.Text + "')";
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
    }
}
