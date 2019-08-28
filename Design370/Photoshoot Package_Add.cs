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
    public partial class Photoshoot_Package_Add : Form
    {

        List<string> Products;
        List<string> Services;
        public Photoshoot_Package_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(listBox3, "Multiple items can be selected");
            toolTip1.SetToolTip(listBox4, "Multiple items can be selected");
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 200 characters can be entered");
        }

        private void Photoshoot_Package_Add_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    int typeID = 0;
                    string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot';";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    typeID = reader.GetInt32(0);
                    reader.Close();
                    query = "SELECT product_name, product_price FROM product WHERE booking_type_id = '" + typeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox4.Items.Add(reader.GetString(0) + ";  R" + reader.GetString(1) + " - Qty: " + 0);
                    }
                        reader.Close();
                        query = "SELECT service_name, service_price FROM service WHERE booking_type_id = '" + typeID +"'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox3.Items.Add(reader.GetString(0) + ";  R" + reader.GetString(1) + " - Qty: " + 0);
                        }
                    reader.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0, i = 0;
            string itemString = " ";
            Services = new List<string>();
            foreach (var item in listBox3.Items)
            {
                Services.Add(item.ToString());
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
                Services[itemIndex] = itemString + ": " + quantity;
            }
            listBox3.Items.Clear();
            listBox3.Items.AddRange(Services.ToArray());

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0, i = 0;
            string itemString = " ";
            Products = new List<string>();
            foreach (var item in listBox4.Items)
            {
                Products.Add(item.ToString());
            }
            foreach (var item in listBox4.SelectedItems)
            {
                itemIndex = listBox4.Items.IndexOf(item);
                itemString = listBox4.Items[itemIndex].ToString();
                int pos = itemString.IndexOf(":");
                quantity = Convert.ToInt32(itemString.Substring(pos + 1)) + 1;
                itemString = itemString.Substring(0, pos);
                Products[itemIndex] = itemString + ": " + quantity;
            }
            listBox4.Items.Clear();
            listBox4.Items.AddRange(Products.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Photoshoot_Package_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5)
            {
                MessageBox.Show("Invalid package name and/or description length");
                return;
            }
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    int quantity = 0, itemIndex = 0, posid = 0, posquant = 0, booking_package_id = 0;
                    string itemString = " ";
                    string package_type = "";
                    string query = "SELECT booking_package_type_id FROM booking_package_type WHERE booking_package_type_name = 'Photoshoot'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        package_type = reader.GetString(0);
                    }
                    reader.Close();
                    query = "INSERT INTO `booking_package` (`booking_package_id`, `booking_package_name`, `booking_package_description`, `booking_package_type_id`) VALUES";
                    query += "(NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + package_type + "')";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                    query = "SELECT booking_package_id FROM booking_package WHERE booking_package_name = '" + textBox1.Text + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        booking_package_id = Convert.ToInt32(reader.GetInt32(0));
                    }
                    reader.Close();
                    DataTable product_id = new DataTable();
                    DataTable service_id = new DataTable();
                    foreach (var item in Products)
                    {
                        itemIndex = Products.IndexOf(item);
                        posid = Products[itemIndex].IndexOf(";");
                        itemString = Products[itemIndex].Substring(0, posid);
                        query = "SELECT product_id FROM product WHERE product_name = '" + itemString + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        product_id.Load(reader);
                        reader.Close();
                    }
                    for (int j = 0; j < product_id.Rows.Count; j++)
                    {
                        posquant = Products[j].IndexOf(":");
                        quantity = Convert.ToInt32(Products[j].Substring(posquant + 1));
                        if (quantity >= 1)
                        {
                            query = "INSERT INTO `booking_package_product` (`booking_package_id`, `product_id`, `booking_package_product_quantity`) VALUES";
                            query += "('" + booking_package_id + "', '" + product_id.Rows[j].ItemArray[0].ToString() + "', '" + quantity + "')";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                    }
                    foreach (var item in Services)
                    {
                        itemIndex = Services.IndexOf(item);
                        posid = Services[itemIndex].IndexOf(";");
                        itemString = Services[itemIndex].Substring(0, posid);
                        query = "SELECT service_id FROM service WHERE service_name = '" + itemString + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        service_id.Load(reader);
                        reader.Close();
                    }
                    for (int k = 0; k < service_id.Rows.Count; k++)
                    {
                        query = "INSERT INTO `booking_package_service` (`booking_package_id`, `service_id`) VALUES";
                        query += "('" + booking_package_id + "', '" + service_id.Rows[k].ItemArray[0].ToString() + "')";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception except)
            {

                MessageBox.Show(except.Message);
            }
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0;
            string itemString = " ";
            Products = new List<string>();
            foreach (var item in listBox4.Items)
            {
                Products.Add(item.ToString());
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
                Products[itemIndex] = itemString + ": " + quantity;
            }
            listBox4.Items.Clear();
            listBox4.Items.AddRange(Products.ToArray());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int itemIndex, quantity = 0;
            string itemString = " ";
            Services = new List<string>();
            foreach (var item in listBox3.Items)
            {
                Services.Add(item.ToString());
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
                Services[itemIndex] = itemString + ": " + quantity;
            }
            listBox3.Items.Clear();
            listBox3.Items.AddRange(Services.ToArray());
        }
    }
}
