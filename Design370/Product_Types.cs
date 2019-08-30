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
    public partial class Product_Types : Form
    {
        public Product_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Product_Type_Add product_Type_Add = new Product_Type_Add();
            product_Type_Add.ShowDialog();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_Types_View product_Types_View = new Product_Types_View();
            string productTypeName = "";
            switch (e.ColumnIndex)
            {

                case 2:
                    Product_Types_View.edit = false;
                    productTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_Types_View.GetProductTypeRow = productTypeName;
                    product_Types_View.ShowDialog();
                    break;
                case 3:
                    Product_Types_View.edit = true;
                    productTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_Types_View.GetProductTypeRow = productTypeName;
                    product_Types_View.ShowDialog();
                    break;
                case 4:
                    productTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dataGridView7.Rows.Clear();
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string productTypeID = "";
                                string query = "SELECT product_type_id FROM product_type WHERE product_type_name = '" + productTypeName + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    productTypeID = reader.GetString(0);
                                }
                                reader.Close();
                                query = "DELETE FROM `product_type` WHERE product_type_id = '" + productTypeID + "'";
                                command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception except)
                        {
                            System.Windows.Forms.MessageBox.Show("This product type contains services. It can not be deleted.");
                        }
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void Product_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string productTypeName = " ";
                    string prpductTypeDescription = " ";
                    DataTable ProductTypes = new DataTable();
                    string query = "SELECT product_type_name, product_type_description FROM product_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ProductTypes.Load(reader);
                    for (int i = 0; i < ProductTypes.Rows.Count; i++)
                    {
                        productTypeName = ProductTypes.Rows[i].ItemArray[0].ToString();
                        prpductTypeDescription = ProductTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(productTypeName, prpductTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    dataGridView7.Rows.Clear();
                    string productTypeName = " ";
                    string prpductTypeDescription = " ";
                    DataTable ProductTypes = new DataTable();
                    string query = "SELECT product_type_name, product_type_description FROM product_type WHERE product_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "product_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ProductTypes.Load(reader);
                    for (int i = 0; i < ProductTypes.Rows.Count; i++)
                    {
                        productTypeName = ProductTypes.Rows[i].ItemArray[0].ToString();
                        prpductTypeDescription = ProductTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(productTypeName, prpductTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
        }

        private void Product_Types_Load(object sender, EventArgs e)
        {

        }
    }
}
