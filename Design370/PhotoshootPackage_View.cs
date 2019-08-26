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

        public string GetRow { get; set; }
        List<string> Products;
        List<string> Services;

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
            if (edit == true)
            {
                button5.Enabled = false;
            }

            int booking_package_id = 0;
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT booking_package_id, booking_package_description FROM booking_package WHERE booking_package_name = '" + GetRow +"'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        booking_package_id = Convert.ToInt32(reader.GetString(0));
                        textBox1.Text = GetRow;
                        textBox2.Text = reader.GetString(1);
                    }
                    reader.Close();
                    query = "SELECT product_id, booking_package_product_quantity FROM booking_package_product WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Product = new DataTable();
                    Product.Load(reader);
                    for (int i = 0; i < Product.Rows.Count; i++)
                    {
                        DataTable Product2 = new DataTable();
                        query = "SELECT product_name, product_price FROM product WHERE product_id = '" + Product.Rows[i].ItemArray[0] + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Product2.Load(reader);
                        for (int j = 0; j < Product2.Rows.Count; j++)
                        {
                            listBox4.Items.Add(Product2.Rows[j].ItemArray[0] + ";  R" + Product2.Rows[j].ItemArray[1] + " - Qty: " + Product.Rows[i].ItemArray[1]);
                        }
                    }
                    query = "SELECT service_id FROM booking_package_service WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Service = new DataTable();
                    Service.Load(reader);
                    for (int k = 0; k < Service.Rows.Count; k++)
                    {
                        DataTable Service2 = new DataTable();
                        query = "SELECT service_name, service_price FROM service WHERE service_id = '" + Service.Rows[k].ItemArray[0] + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Service2.Load(reader);
                        for (int l = 0; l < Service2.Rows.Count; l++)
                        {
                            listBox3.Items.Add(Service2.Rows[l].ItemArray[0] + ";  R" + Service2.Rows[l].ItemArray[1] + " - Qty: " + 1);
                        }
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
            button5.Enabled = false;
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
                    query = "UPDATE `booking_package` (`booking_package_id`, `booking_package_name`, `booking_package_description`, `booking_package_type_id`) VALUES";
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
                            query = "UPDATE `booking_package_product` (`booking_package_id`, `product_id`, `booking_package_product_quantity`) VALUES";
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
                        query = "UPDATE `booking_package_service` (`booking_package_id`, `service_id`) VALUES";
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

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
    }
}
