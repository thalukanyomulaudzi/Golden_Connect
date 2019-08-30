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
    public partial class Product_List : Form
    {
        public Product_List()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT product.product_id, product.product_name, product.product_stock_quantity, product.product_price, product_type.product_type_name" +
                        " FROM product INNER JOIN product_type ON product.product_type_id=product_type.product_type_id";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dgvProductList.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[4]); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtProductQuantity.Text.ToString() != "")
                {
                    int s = Convert.ToInt32(dgvProductList.SelectedRows[0].Cells[3].Value) + Convert.ToInt32(txtProductQuantity.Text);
                    Supplier_Orders_Add sd = new Supplier_Orders_Add();

                    Globals.ProductID = dgvProductList.SelectedRows[0].Cells[0].Value.ToString();
                    Globals.ProductName = dgvProductList.SelectedRows[0].Cells[1].Value.ToString();
                    Globals.ProductQuantity = s;
                    Globals.ProductTypeName = dgvProductList.SelectedRows[0].Cells[4].Value.ToString();
                    sd.Refresh();
                }
                else if (txtProductQuantity.Text.ToString() == "")
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("Enter quantity to place order");
                    
                }
             
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }



        }
    }
}
