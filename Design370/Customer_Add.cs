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
            //It is working................
            //Try This
            //Again
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //It's workingyyyy
            //Stefan
            addCustomer();
        }

        private void Customer_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
            MessageBox.Show("New Customer Added Successfully!");
;        }

        public void addCustomer()
        {
            string custInsert = "INSERT INTO customer(customer_first, customer_last, customer_email, customer_phone) VALUES('"+txtFN.Text+"', '"+txtLN.Text+"', '"+txtEM.Text+"', '"+txtTEL.Text+"')";
            MysqlConnection.cmd = new MySqlCommand(custInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Customer already exits!");
                }
                else
                {
                    MessageBox.Show("New Customer Inserted!");
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
