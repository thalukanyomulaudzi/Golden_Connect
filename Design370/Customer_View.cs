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
            edit = false;
            toggleBoxes();
        }
        private void Customer_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Enabled)
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
            //save shit hier
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void toggleBoxes()
        {
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            textBox3.Enabled = edit;
            textBox4.Enabled = edit;
            textBox5.Enabled = edit;
        }

        private void loadBoxes()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
