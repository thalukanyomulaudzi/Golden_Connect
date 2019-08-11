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
    public partial class Product_Type_Add : Form
    {
        public Product_Type_Add()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prodTypeInsert = "INSERT INTO product_type(product_type_name, product_type_description) VALUES('" +
                                txtProdTypeName.Text + "', '" + txtProdTypeDesc.Text + "')";
            MysqlConnection.cmd = new MySqlCommand(prodTypeInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Product Type already exits!");
                }
                else
                {
                    MessageBox.Show("New Product Type Inserted!");
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
