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
       
        public Product_Add()
        {
            InitializeComponent();

            using (MysqlConnection.mysqlCon)
            {
                MySqlCommand mysqlCmd = new MySqlCommand("SELECT * FROM product_type", MysqlConnection.mysqlCon);

                MysqlConnection.mysqlCon.Open();
                MySqlDataReader mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                {
                    cbxProductTypes.Items.Add(mysqlReader["product_type_name"].ToString());
                    cbxProductTypes.ValueMember = (mysqlReader["product_type_id"].ToString());

                }

                mysqlReader.Close();

            }
        }



        private void Button3_Click_1(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.cbxProductTypes.SelectedIndex + 1;

            string prodInsert = "INSERT INTO product(product_name, product_description, product_price, product_type_id) VALUES('" +
                                txtProductame.Text + "', '" + txtProductDescr.Text + "', '" + txtProductPrice.Text + "', '" + selectedIndex.ToString() + "')";
            MysqlConnection.cmd = new MySqlCommand(prodInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Product already exits!");
                }
                else
                {
                    MessageBox.Show("New Product Inserted!");
                    MysqlConnection.mysqlCon.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
            }
        }
    }
}
