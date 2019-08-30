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
    public partial class Product_Add : Form
    {
        DBConnection dbCon = DBConnection.Instance();

        public Product_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(cbxProductTypes, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtProductame, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtProductDescr, "A maximum of 100 characters can be entered");
        }



        private void Button3_Click_1(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (txtProductame.Text.Length <= 2 || txtProductDescr.Text.Length <= 5 || txtProductPrice.Text.Length == 0)
            {
                MessageBox.Show("Invalid character length for name and/or description and/or price");
                return;
            }
            if (cbxProductTypes.SelectedIndex <= -1 || comboBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a booking type and/or service type");
                return;
            }
            try
            {
                if (dbCon.IsConnect())
                {
                    string productTypeID = "";
                    string bookingTypeID = "";
                    string query = "SELECT product_type_id FROM product_type WHERE product_type_name = '" + cbxProductTypes.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    productTypeID = reader.GetString(0);
                    reader.Close();
                    query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = '" + comboBox1.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dbCon.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    bookingTypeID = reader.GetString(0);
                    reader.Close();
                    query = "INSERT INTO `product`(`product_name`, `product_description`, `product_price`, `product_type_id`, `booking_type_id`) VALUES('" +
                                txtProductame.Text + "', '" + txtProductDescr.Text + "', '" + txtProductPrice.Text + "', '" + productTypeID + "', '" + bookingTypeID + "')";
                    command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Product_Add_Load(object sender, EventArgs e)
        {
            cbxProductTypes.Enabled = false;
            try
            {
                if (dbCon.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM booking_type", dbCon.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        comboBox1.Items.Add(mysqlReader["booking_type_name"].ToString());
                        comboBox1.ValueMember = (mysqlReader["booking_type_id"].ToString());

                    }
                    mysqlReader.Close();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProductTypes.Enabled = true;
            cbxProductTypes.Items.Clear();
            try
            {
                if (dbCon.IsConnect())
                {
                    string bookingTypeID = "";
                    string productTypeID = "";
                    var mysqlCmd = new MySqlCommand("SELECT booking_type_ID FROM booking_type WHERE booking_type_name = '" + comboBox1.SelectedItem + "'", dbCon.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {

                        bookingTypeID = mysqlReader.GetString(0);

                    }
                    mysqlReader.Close();
                    mysqlCmd = new MySqlCommand("SELECT product_type_id FROM product WHERE booking_type_id = '" + bookingTypeID + "'", dbCon.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {

                        productTypeID = mysqlReader.GetString(0);

                    }
                    mysqlReader.Close();
                    mysqlCmd = new MySqlCommand("SELECT * FROM product_type WHERE product_type_id = '" + productTypeID + "'", dbCon.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        cbxProductTypes.Items.Add(mysqlReader["product_type_name"].ToString());
                        cbxProductTypes.ValueMember = (mysqlReader["product_type_id"].ToString());
                    }
                    mysqlReader.Close();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
