﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace Design370
{
    public partial class Product_View : Form
    {
        public static bool edit;
        public string GetProductRow { get; set; }
        string productID = "";
        string helpstring = " ";
        public Product_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(comboBox1, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtProductName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtProductDescription, "A maximum of 100 characters can be entered");

        }

        private void Product_View_Load(object sender, EventArgs e)
        {

            txtProductName.Enabled = edit;
            txtProductDescription.Enabled = edit;
            txtProductPrice.Enabled = edit;
            comboBox1.Enabled = edit;
            button3.Enabled = edit;
            button2.Enabled = !edit;
            if (edit)
            {
                this.Text = "Edit Product";
                helpstring = "Edit_Product";
            }
            else if (!edit)
            {
                this.Text = "View Product";
                helpstring = "View_Product";
            }

            try
            {
                DBConnection dbConnection = DBConnection.Instance();
                string productTypeID = "";
                string productTypeName = "";
                if (dbConnection.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM product_type", dbConnection.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        comboBox1.Items.Add(mysqlReader["product_type_name"].ToString());
                        comboBox1.ValueMember = (mysqlReader["product_type_id"].ToString());
                    }
                    mysqlReader.Close();
                    string query = "SELECT product_id, product_name, product_description, product_price, product_type_id, image FROM product WHERE product_id = '" + GetProductRow + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();

                    while (mysqlReader.Read())
                    {
                        productID = mysqlReader.GetString(0);
                        txtProductName.Text = mysqlReader.GetString(1);
                        txtProductDescription.Text = mysqlReader.GetString(2);
                        txtProductPrice.Text = mysqlReader.GetString(3);
                        productTypeID = mysqlReader.GetString(4);

                        //byte[] imgg = (byte[])(mysqlReader["image"]);
                        //if (imgg == null)
                        //{
                        //    pictureBox1.Image = null;
                        //}
                        //else
                        //{
                        //    MemoryStream mstream = new MemoryStream(imgg);
                        //    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                        //}
                    }
                    mysqlReader.Close();

                    query = "SELECT product_type_name FROM product_type WHERE product_type_id = '" + productTypeID + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    mysqlReader.Read();
                    productTypeName = mysqlReader.GetString(0);
                    mysqlReader.Close();
                    comboBox1.SelectedIndex = comboBox1.FindStringExact(productTypeName);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtProductName.Enabled = true;
            txtProductDescription.Enabled = true;
            txtProductPrice.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
            comboBox1.Enabled = true;
            this.Text = "Edit Product";
            helpstring = "Edit_Product";
        }

        private void Product_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double price = txtProductPrice.Text.Contains("R") ? Convert.ToDouble(txtProductPrice.Text.Substring(1)) : Convert.ToDouble(txtProductPrice.Text);

            if (txtProductName.Text.Length <= 2 || txtProductDescription.Text.Length <= 5 || txtProductPrice.Text.Length == 0)
            {
                MessageBox.Show("Invalid character length for name and/or description and/or price");
                return;
            }
            if (comboBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a product type");
                return;
            }
            try
            {
                DBConnection dbConnection = DBConnection.Instance();
                if (dbConnection.IsConnect())
                {
                    string productTypeID = "";
                    string query = "SELECT product_type_id FROM product_type WHERE product_type_name = '" + comboBox1.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    productTypeID = reader.GetString(0);
                    reader.Close();

                    //MemoryStream stream = new MemoryStream();
                    //pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] pic = stream.ToArray();

                    query = "UPDATE `product` SET `product_name` = '" + txtProductName.Text + "', `product_description` = '" +
                        "" + txtProductDescription.Text + "', `product_price` = '" + price + "', `product_type_id` = '" +
                        "" + productTypeID + "' WHERE product_id = '" + productID + "'";
                    command = new MySqlCommand(query, dbConnection.Connection);
                    command.ExecuteNonQuery();

                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Product_View_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = helpstring;
            helpForm.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductName, Validation.validate(txtProductName.Text, "name"));
        }

        private void TxtProductDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductDescription, Validation.validate(txtProductDescription.Text, "name"));
        }

        private void TxtProductPrice_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductPrice, Validation.validate(txtProductPrice.Text, "price"));
        }


    }
}
