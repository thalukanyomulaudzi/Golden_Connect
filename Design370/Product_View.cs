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
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 100 characters can be entered");

        }

        private void Product_View_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            textBox3.Enabled = edit;
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
                    string query = "SELECT product_id, product_name, product_description, product_price, product_type_id FROM product WHERE product_id = '" + GetProductRow + "'";
                    mysqlCmd = new MySqlCommand(query, dbConnection.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        productID = mysqlReader.GetString(0);
                        textBox1.Text = mysqlReader.GetString(1);
                        textBox2.Text = mysqlReader.GetString(2);
                        textBox3.Text = mysqlReader.GetString(3);
                        productTypeID = mysqlReader.GetString(4);
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
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
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
            if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5 || textBox3.Text.Length == 0)
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
                    query = "UPDATE `product` SET `product_name` = '" + textBox1.Text + "', `product_description` = '" +
                        "" + textBox2.Text + "', `product_price` = '" + textBox3.Text + "', `product_type_id` = '" +
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
    }
}
