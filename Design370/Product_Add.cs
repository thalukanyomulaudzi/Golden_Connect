using System;
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
            toolTip1.SetToolTip(cbxProductType, "If disabled, choose a booking type first");
            toolTip1.SetToolTip(txtProductName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtProductDescription, "A maximum of 100 characters can be entered");
        }



        private void Button3_Click_1(object sender, EventArgs e)
        {
            Product_Type_Add product_Type_add = new Product_Type_Add();
            product_Type_add.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (!Validation.validate(txtProductName.Text, "name") || !Validation.validate(txtProductDescription.Text, "name") || !Validation.validate(txtProductPrice.Text, "price"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            if (cbxProductType.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a product type");
                return;
            }
            try
            {
                if (dbCon.IsConnect())
                {
                    string bookingTypeID = "";
                    string query = "SELECT product_type_id FROM product_type WHERE product_type_name = '" + cbxProductType.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    bookingTypeID = reader.GetString(0);
                    reader.Close();
                    query = "INSERT INTO `product`(`product_name`, `product_description`, `product_price`, `product_type_id`) VALUES('" +
                                txtProductName.Text + "', '" + txtProductDescription.Text + "', '" + txtProductPrice.Text + "', '" + bookingTypeID + "')";
                    command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
                Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Product_Add_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Product_Add_Activated(object sender, EventArgs e)
        {
            cbxProductType.Items.Clear();
            try
            {
                if (dbCon.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM product_type", dbCon.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        cbxProductType.Items.Add(mysqlReader["product_type_name"].ToString());
                        cbxProductType.ValueMember = (mysqlReader["product_type_id"].ToString());

                    }
                    mysqlReader.Close();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductPrice, Validation.validate(txtProductPrice.Text, "price"));
        }

        private void TxtProductame_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductName, Validation.validate(txtProductName.Text,"name"));
        }

        private void TxtProductDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductDescription, Validation.validate(txtProductDescription.Text, "name"));
        }

        private void Product_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Product";
            helpForm.ShowDialog();
        }
    }
}
