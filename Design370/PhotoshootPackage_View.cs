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
                    string query = "SELECT product_name, product_price FROM product WHERE product_type_id = '1';";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox4.Items.Add(reader.GetString(0) + ",  R" + reader.GetString(1) + " - Qty: " + 0);
                    }
                    reader.Close();
                    query = "SELECT service_name, service_price FROM service WHERE service_type_id = '1';";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox3.Items.Add(reader.GetString(0) + ",  R" + reader.GetString(1) + " - Qty: " + 0);
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
            int itemIndex, quantity = 0, i = 0;
            string itemString = " ";
            List<string> Items = new List<string>();
            foreach (var item in listBox3.Items)
            {
                Items.Add(item.ToString());
            }
            foreach (var item in listBox3.SelectedItems)
            {
                itemIndex = listBox3.Items.IndexOf(item);
                itemString = listBox3.Items[itemIndex].ToString();
                int pos = itemString.IndexOf(":");
                quantity = Convert.ToInt32(itemString.Substring(pos + 1)) + 1;
                if (quantity > 1)
                {
                    MessageBox.Show("You have selected one or more services with a quantity of 1, some of these may not have updated properly");
                    break;
                }
                itemString = itemString.Substring(0, pos);
                Items[itemIndex] = itemString + ": " + quantity;
            }
            listBox3.Items.Clear();
            listBox3.Items.AddRange(Items.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0, i = 0;
            string itemString = " ";
            List<string> Items = new List<string>();
            foreach (var item in listBox4.Items)
            {
                Items.Add(item.ToString());
            }
            foreach (var item in listBox4.SelectedItems)
            {
                itemIndex = listBox4.Items.IndexOf(item);
                itemString = listBox4.Items[itemIndex].ToString();
                int pos = itemString.IndexOf(":");
                quantity = Convert.ToInt32(itemString.Substring(pos + 1)) + 1;
                itemString = itemString.Substring(0, pos);
                Items[itemIndex] = itemString + ": " + quantity;
            }
            listBox4.Items.Clear();
            listBox4.Items.AddRange(Items.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0;
            string itemString = " ";
            List<string> Items = new List<string>();
            foreach (var item in listBox3.Items)
            {
                Items.Add(item.ToString());
            }
            foreach (var item in listBox3.SelectedItems)
            {
                itemIndex = listBox3.Items.IndexOf(item);
                itemString = listBox3.Items[itemIndex].ToString();
                int pos = itemString.IndexOf(":");
                quantity = Convert.ToInt32(itemString.Substring(pos + 1)) - 1;
                if (quantity < 0)
                {
                    MessageBox.Show("You have selected one or more services with a quantity of 0, some of these may not have updated properly");
                    break;
                }
                itemString = itemString.Substring(0, pos);
                Items[itemIndex] = itemString + ": " + quantity;
            }
            listBox3.Items.Clear();
            listBox3.Items.AddRange(Items.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0;
            string itemString = " ";
            List<string> Items = new List<string>();
            foreach (var item in listBox4.Items)
            {
                Items.Add(item.ToString());
            }
            foreach (var item in listBox4.SelectedItems)
            {
                itemIndex = listBox4.Items.IndexOf(item);
                itemString = listBox4.Items[itemIndex].ToString();
                int pos = itemString.IndexOf(":");
                quantity = Convert.ToInt32(itemString.Substring(pos + 1)) - 1;
                if (quantity < 0)
                {
                    MessageBox.Show("You have selected one or more products with a quantity of 0, some of these may not have updated properly");
                    break;
                }
                itemString = itemString.Substring(0, pos);
                Items[itemIndex] = itemString + ": " + quantity;
            }
            listBox4.Items.Clear();
            listBox4.Items.AddRange(Items.ToArray());
        }
    }
}
