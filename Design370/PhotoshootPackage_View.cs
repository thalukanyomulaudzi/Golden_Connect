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
    public partial class PhotoshootPackage_View : Form
    {
        public static bool edit;
        public PhotoshootPackage_View()
        {
            InitializeComponent();
        }

        private void PhotoshootPackage_View_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            listBox1.Enabled = edit;
            listBox2.Enabled = edit;
            listBox3.Enabled = edit;
            listBox4.Enabled = edit;
            button1.Enabled = edit;
            button2.Enabled = edit;
            button3.Enabled = edit;
            button4.Enabled = edit;

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT booking_package_name FROM booking_package WHERE";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    query = "SELECT product_name FROM product WHERE product_type_id = '1';";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox4.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                    query = "SELECT service_name FROM service WHERE service_type_id = '1';";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox3.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            listBox3.Enabled = true;
            listBox4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void PhotoshootPackage_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox3.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox1.Items.Add(item);
            }
            while (listBox3.SelectedItems.Count > 0)
            {
                listBox3.Items.Remove(listBox3.SelectedItems[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox4.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox2.Items.Add(item);
            }
            while (listBox4.SelectedItems.Count > 0)
            {
                listBox4.Items.Remove(listBox4.SelectedItems[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox1.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox3.Items.Add(item);
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox2.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox4.Items.Add(item);
            }
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }
    }
}
