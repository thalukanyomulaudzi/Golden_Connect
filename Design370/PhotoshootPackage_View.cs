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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(listBox3, "Multiple items can be selected");
            toolTip1.SetToolTip(listBox4, "Multiple items can be selected");
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 200 characters can be entered");
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
            int typeID = 0;
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    typeID = 0;
                    string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot';";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    typeID = reader.GetInt32(0);
                    reader.Close();
                    query = "SELECT booking_package_id, booking_package_description FROM booking_package WHERE booking_package_name = '" + GetRow + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    booking_package_id = reader.GetInt32(0);
                    textBox1.Text = GetRow;
                    textBox2.Text = reader.GetString(1);
                    reader.Close();
                    query = "SELECT product_id, booking_package_product_quantity FROM booking_package_product WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Product = new DataTable();
                    DataTable Product2 = new DataTable();
                    DataTable Product3 = new DataTable();
                    DataTable ProductType = new DataTable();
                    Product.Load(reader);
                    for (int i = 0; i < Product.Rows.Count; i++)
                    {
                        Product2 = new DataTable();
                        Product3 = new DataTable();
                        query = "SELECT product_name, product_price FROM product WHERE product_id = '" + Product.Rows[i].ItemArray[0] + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Product2.Load(reader);
                        for (int j = 0; j < Product2.Rows.Count; j++)
                        {
                            listBox4.Items.Add(Product2.Rows[j].ItemArray[0] + ";  R" + Product2.Rows[j].ItemArray[1] + " - Qty: " + Product.Rows[i].ItemArray[1]);
                        }
                    }
                    query = "SELECT product_id FROM product WHERE booking_type_id = '" + typeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Product3.Load(reader);
                    for (int m = 0; m < Product3.Rows.Count; m++)
                    {
                        if (Product.Rows.Contains(Product3.Rows[m].ItemArray[0]))
                        {

                        }
                        else
                        {
                            query = "SELECT product_name, product_price FROM product WHERE product_id = '" + Product3.Rows[m].ItemArray[0] + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            reader = command.ExecuteReader();
                            reader.Read();
                            listBox4.Items.Add(reader.GetString(0) + "; R" + reader.GetString(1) + " - Qty: " + 0);
                            reader.Close();
                        }
                    }
                    query = "SELECT service_id FROM booking_package_service WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Service = new DataTable();
                    DataTable Service2 = new DataTable();
                    DataTable Service3 = new DataTable();
                    Service.Load(reader);
                    for (int k = 0; k < Service.Rows.Count; k++)
                    {
                        Service2 = new DataTable();
                        query = "SELECT service_name, service_price FROM service WHERE service_id = '" + Service.Rows[k].ItemArray[0] + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Service2.Load(reader);
                        for (int l = 0; l < Service2.Rows.Count; l++)
                        {
                            listBox3.Items.Add(Service2.Rows[l].ItemArray[0] + ";  R" + Service2.Rows[l].ItemArray[1] + " - Qty: " + 1);
                        }
                    }
                    query = "SELECT service_id FROM service WHERE booking_type_id = '" + typeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Service3.Load(reader);
                    for (int p = 0; p < Service3.Rows.Count; p++)
                    {
                        if (Service.Rows.Contains(Service3.Rows[p].ItemArray[0]))
                        {

                        }

                        else
                        {
                            query = "SELECT service_name, service_price FROM service WHERE service_id = '" + Service3.Rows[p].ItemArray[0] + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            reader = command.ExecuteReader();
                            reader.Read();
                            listBox3.Items.Add(reader.GetString(0) + "; R" + reader.GetString(1) + " - Qty: " + 0);
                            reader.Close();
                        }
                    }

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
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5)
            {
                MessageBox.Show("Invalid character length for name and/or description");
                return;
            }
            int itemIndex1, quantity1 = 0, quantity2 = 0;
            string itemString1 = " ";
            bool flag = false, flag1 = false;
            foreach (var item in listBox3.Items)
            {
                itemIndex1 = listBox3.Items.IndexOf(item);
                itemString1 = listBox3.Items[itemIndex1].ToString();
                int pos = itemString1.IndexOf(":");
                quantity1 = Convert.ToInt32(itemString1.Substring(pos + 1));
                if (quantity1 >= 1)
                {
                    flag = true;
                    break;
                }
            }

            foreach (var item in listBox4.Items)
            {
                itemIndex1 = listBox4.Items.IndexOf(item);
                itemString1 = listBox4.Items[itemIndex1].ToString();
                int pos = itemString1.IndexOf(":");
                quantity2 = Convert.ToInt32(itemString1.Substring(pos + 1));
                if (quantity2 >= 1)
                {
                    flag1 = true;
                    break;
                }
            }

            if (!flag || !flag1)
            {
                MessageBox.Show("No service and/or product selected");
                return;
            }

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    int quantity = 0, itemIndex = 0, posid = 0, posquant = 0, booking_package_id = 0;
                    string itemString = " ";
                    string package_type = " ";
                    string query = "SELECT booking_package_type_id FROM booking_package_type WHERE booking_package_type_name = 'Photoshoot'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    package_type = reader.GetString(0);
                    reader.Close();
                    query = "SELECT booking_package_id FROM booking_package WHERE booking_package_name = '" + textBox1.Text + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    booking_package_id = reader.GetInt32(0);
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
                        if (quantity >= 0)
                        {
                            query = "UPDATE `booking_package_product` SET `booking_package_product_quantity` = '" + quantity + "' WHERE booking_package_id = '" + booking_package_id + "' AND product_id = '" + product_id.Rows[j].ItemArray[0] + "'";
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
                        posquant = Services[k].IndexOf(":");
                        quantity = Convert.ToInt32(Services[k].Substring(posquant + 1));
                        if (quantity == 1)
                        {
                            query = "DELETE FROM `booking_package_service` WHERE booking_package_id = '" + booking_package_id + "' ";
                            query += "AND service_id = '" + service_id.Rows[k].ItemArray[0].ToString() + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                            query = "INSERT INTO `booking_package_service` (`booking_package_id`, `service_id`) VALUES";
                            query += "('" + booking_package_id + "', '" + service_id.Rows[k].ItemArray[0].ToString() + "')";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            query = "DELETE FROM `booking_package_service` WHERE booking_package_id = '" + booking_package_id + "' ";
                            query += "AND service_id = '" + service_id.Rows[k].ItemArray[0].ToString() + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                    }
                    query = "UPDATE `booking_package` SET `booking_package_name` = '" + textBox1.Text + "', ";
                    query += "`booking_package_description` = '" + textBox2.Text + "' WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
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
            Products = new List<string>();
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
            Services = new List<string>();
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
            Products = new List<string>();
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
            Services = new List<string>();
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
