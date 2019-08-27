﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Design370
{
    public partial class NewCustomerOrder : Form
    {
        int qty = 0;
        decimal p_price = 0;
        decimal subTotal = 0;
        decimal sumTotal = 0;
        int imageCounter = 0;
        int[] names;
        int counter;
        int customerID = 0;
        string orderDescription;
        string[] photos;
        byte[] saveImg = null;
        OpenFileDialog upload = new OpenFileDialog();
        int i = 0;
        Order[] orders = new Order[40];
        string search;
        int searchType;
        int index = 0;
        int orderID = 0;
        Random rnd = new Random();
        bool generated = false;
        decimal discount = 0;
        public NewCustomerOrder()
        {
            InitializeComponent();
        }

        private void NewCustomerOrder_Load(object sender, EventArgs e)
        {
            names = new int[getSize()];
            counter = 0;
            txtSeach.Enabled = false;
            btnP.Enabled = false;
            string csearch = "SELECT * FROM Customer Order By customer_id ASC";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(csearch, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            customers.Items.Clear();
            while (MysqlConnection.reader.Read())
            {
                customers.Items.Add(MysqlConnection.reader.GetString("customer_first") + " " + MysqlConnection.reader.GetString("customer_last"));
                names[counter] = Convert.ToInt32(MysqlConnection.reader.GetString("customer_id"));
                counter++;
            }
            MysqlConnection.mysqlCon.Close();
            loadProducts();
        }

        private void loadProducts()
        {
            string products = "SELECT * FROM Product";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(products, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            while (MysqlConnection.reader.Read())
            {
                cmOrderList.Items.Add(MysqlConnection.reader.GetString("product_name"));
            }
            MysqlConnection.mysqlCon.Close();
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {
            finalOrder(); //Function that finalises the order quantity!
            MysqlConnection.mysqlCon.Open();

            if (newOrder() == 1)
            {
                for (int l = 0; l < i; l++)
                {
                    orderDescription += (orders[l].getOrderQuanity) + " - " + orders[l].getOrderName;
                    if (l < i - 1)
                        orderDescription += (", \n");
                }

                if (newOrderLine() == 1)
                {
                    foreach (Order order in orders)
                    {
                        if (order != null)
                        {
                            int size = order.getOrderImages.Length;
                            for (int p = 0; p < size; p++)
                            {
                                FileStream file = new FileStream(order.getOrderImages[p].ToString(), FileMode.Open, FileAccess.Read);
                                BinaryReader read = new BinaryReader(file);
                                saveImg = read.ReadBytes((int)file.Length);
                                string path = "INSERT INTO `order_image` (`order_image`, `order_id`) VALUES (@image, @orderID)";
                                MysqlConnection.cmd = new MySqlCommand(path, MysqlConnection.mysqlCon);
                                MysqlConnection.cmd.Parameters.AddWithValue("@image", saveImg);
                                MysqlConnection.cmd.Parameters.AddWithValue("@orderID", orderID);
                                int uploaded = MysqlConnection.cmd.ExecuteNonQuery();
                                if (uploaded == 1)
                                {

                                }
                            }
                        }
                    }
                    MessageBox.Show("New Order Saved");
                    generated = false;
                    sumTotal = 0;
                    subTotal = 0;
                    imageCounter = 0;
                    i = 0;
                    lblOrders.Text = (i).ToString();
                    qty = 1;
                    lblTotal.Text = "R" + sumTotal.ToString() + ".00";
                    lblPrice.Text = "R" + subTotal.ToString() + ".00";
                    lblq.Text = "0";
                    lblOrderid.Text = "Select Product";
                    lblProduct.Text = "Select Product";
                    lblImages.Text = imageCounter.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ooops...");
            }
            MysqlConnection.mysqlCon.Close();
        }

        private void LinkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            upload.Multiselect = true;
            upload.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (upload.ShowDialog() == DialogResult.OK)
            {
                photos = upload.FileNames;
                foreach (string image in photos)
                {
                    imageCounter += 1;
                }
                MysqlConnection.mysqlCon.Close();
            }
            lblImages.Text = imageCounter.ToString();
        }

        public void finalOrder()
        {
            if (i > 0)
            {
                if (MessageBox.Show("Do you want to save the current order?", "Place Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orders[i] = new Order(cmOrderList.SelectedItem.ToString(), qty, photos);
                    i++;
                    sumTotal += subTotal;
                    lblOrders.Text = (i).ToString();
                }
                else
                {
                    //Do nothing
                }
            }
            else
            {
                orders[i] = new Order(cmOrderList.SelectedItem.ToString(), qty, photos);
                i++;
                sumTotal += subTotal;
                lblOrders.Text = (i).ToString();
            }
        }

        public decimal getDiscount(int product)
        {
            decimal discount;
            string find = "SELECT discount_percentage FROM discount WHERE product_id = '" + product + "'";
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(find, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            MysqlConnection.reader.Read();
            if (MysqlConnection.reader.HasRows)
            {
                discount = Convert.ToDecimal(MysqlConnection.reader[0].ToString());
                MysqlConnection.mysqlCon.Close();
                return discount;
            }
            else
            {
                discount = 0;
                MysqlConnection.mysqlCon.Close();
                return discount;
            }

        }

        private int getOrderID()
        {
            MysqlConnection.mysqlCon.Open();
            orderID = rnd.Next();
            string search = "SELECT * FROM `order`";
            MysqlConnection.cmd = new MySqlCommand(search, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            while (MysqlConnection.reader.Read())
            {
                if (MysqlConnection.reader.GetString("order_id") == orderID.ToString())
                {
                    Random rnd = new Random();
                    orderID = rnd.Next();
                    getOrderID();
                    break;
                }
            }
            MysqlConnection.mysqlCon.Close();
            return orderID;
        }

        public int newOrder()
        {
            string orderInsert = "INSERT INTO `order` (`order_id`, `order_date_placed`, `customer_id`, `order_status_id`) " +
                "VALUES(@id, @date, @cID, @osd)";
            MysqlConnection.cmd = new MySqlCommand(orderInsert, MysqlConnection.mysqlCon);
            MysqlConnection.cmd.Parameters.AddWithValue("@id", orderID);
            MysqlConnection.cmd.Parameters.AddWithValue("@date", DateTime.Now);
            MysqlConnection.cmd.Parameters.AddWithValue("@cID", customerID);
            MysqlConnection.cmd.Parameters.AddWithValue("@osd", 1);
            int done = MysqlConnection.cmd.ExecuteNonQuery();
            return done;
        }

        public int newOrderLine()
        {
            string orderLineInsert = "INSERT INTO `order_line` (`order_id`, `order_line_quantity`, `order_total`, `order_line_description`) " +
            "VALUES (@orderID, @quantity, @orderTotal, @description)";
            MysqlConnection.cmd = new MySqlCommand(orderLineInsert, MysqlConnection.mysqlCon);
            MysqlConnection.cmd.Parameters.AddWithValue("@orderID", orderID);
            MysqlConnection.cmd.Parameters.AddWithValue("@quantity", i);
            MysqlConnection.cmd.Parameters.AddWithValue("@orderTotal", sumTotal);
            MysqlConnection.cmd.Parameters.AddWithValue("@description", orderDescription);
            int complete = MysqlConnection.cmd.ExecuteNonQuery();
            return complete;
        }

        private void CmOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (generated == false)
            {
                lblOrderid.Text = getOrderID().ToString();
                generated = true;
            }
            int id = 0;
            if (cmOrderList.SelectedIndex > -1)
            {
                string products = "SELECT * FROM Product WHERE product_name = '" + cmOrderList.SelectedItem.ToString() + "'";
                MysqlConnection.mysqlCon.Open();
                MysqlConnection.cmd = new MySqlCommand(products, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    lblProduct.Text = MysqlConnection.reader.GetString("product_name");
                    lblProductPrice.Text = "R" + MysqlConnection.reader.GetString("product_price").ToString();
                    p_price = Convert.ToDecimal(MysqlConnection.reader.GetString("product_price"));
                    lblq.Text = Convert.ToInt32(orderQuantity.Value).ToString();
                    id = Convert.ToInt32(MysqlConnection.reader.GetString("product_id"));
                }
                linkUpload.Visible = true;
                MysqlConnection.mysqlCon.Close();
                discount = getDiscount(id);
                lblD.Text = discount.ToString() + "%";
                lblTotal.Text = "R" + (sumTotal + ((p_price * Convert.ToDecimal(orderQuantity.Value)) - ((p_price * Convert.ToDecimal(orderQuantity.Value)) * discount / 100))).ToString();
                qty = Convert.ToInt32(orderQuantity.Value);
                lblPrice.Text = "R" + ((p_price * Convert.ToDecimal(orderQuantity.Value)) - ((p_price * Convert.ToDecimal(orderQuantity.Value)) * discount / 100)).ToString();
            }
        }

        private void OrderQuantity_ValueChanged(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(orderQuantity.Value);
            lblq.Text = qty.ToString();
            subTotal = (qty * p_price) - (p_price * discount / 100);
            lblPrice.Text = "R" + subTotal.ToString();
            lblTotal.Text = "R" + (sumTotal + subTotal).ToString();
        }

        private void BtnAddP_Click(object sender, EventArgs e)
        {
            orders[i] = new Order(cmOrderList.SelectedItem.ToString(), qty, photos);
            i++;
            sumTotal += subTotal;
            lblOrders.Text = (i).ToString();
            qty = 1;
            lblq.Text = qty.ToString();
            imageCounter = 0;
            lblImages.Text = imageCounter.ToString();
        }

        public int getSize()
        {
            int i = 0;
            string csearch = "SELECT * FROM Customer Order By customer_id ASC";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(csearch, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            while (MysqlConnection.reader.Read())
            {
                i += 1;
            }
            MysqlConnection.mysqlCon.Close();
            return i;
        }

        public string searchCust(string text)
        {
            if (searchType == 0)
            {
                search = "SELECT * FROM Customer WHERE customer_first LIKE '%" + text + "%' OR customer_last LIKE '%" + text + "%' OR customer_email LIKE '%" + text + "%' " +
                    "OR  customer_phone LIKE '%" + text + "%'";
            }
            else if (searchType == 1)
            {
                search = "SELECT * FROM Customer WHERE customer_first LIKE '%" + text + "%' OR customer_last LIKE '%" + text + "%'";
            }
            else if (searchType == 2)
            {
                search = "SELECT * FROM Customer WHERE customer_email LIKE '%" + text + "%'";
            }
            else if (searchType == 3)
            {
                search = "SELECT * FROM Customer WHERE customer_phone LIKE '%" + text + "%'";
            }
            return search;
        }

        private void TxtSeach_TextChanged(object sender, EventArgs e)
        {
            counter = 0;
            MysqlConnection.mysqlCon.Open();
            //string search = " LIKE '%" + txtSeach.Text + "%' OR customer_id LIKE '%" + txtSeach.Text + "%'";
            customers.Items.Clear();
            MysqlConnection.cmd = new MySqlCommand(searchCust(txtSeach.Text), MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            //DataTable table = new DataTable();
            //table.Load(MysqlConnection.reader);
            //dgvCustOrder.DataSource = table;
            while (MysqlConnection.reader.Read())
            {
                customers.Items.Add(MysqlConnection.reader.GetString("customer_first") + " " + MysqlConnection.reader.GetString("customer_last"));
                names[counter] = Convert.ToInt32(MysqlConnection.reader.GetString("customer_id"));
                counter++;
            }
            MysqlConnection.mysqlCon.Close();
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            customerOrderTab.SelectedIndex = 1;
        }

        private void Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = customers.SelectedIndex;
            if (index > -1)
            {
                btnP.Enabled = true;
                string csearch = "SELECT * FROM Customer WHERE customer_id = '" + names[index] + "'";
                MysqlConnection.mysqlCon.Open();
                MysqlConnection.cmd = new MySqlCommand(csearch, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    lblName.Text = MysqlConnection.reader.GetString("customer_first") + " " + MysqlConnection.reader.GetString("customer_last");
                    lblEmail.Text = MysqlConnection.reader.GetString("customer_email");
                    lblTel.Text = MysqlConnection.reader.GetString("customer_phone");
                }
                MysqlConnection.mysqlCon.Close();
                customerID = names[index];
            }
        }
    }
}