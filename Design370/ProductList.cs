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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            using (MysqlConnection.mysqlCon)
            {
                MysqlConnection.mysqlCon.Open();

                string sql = "SELECT product.product_id, product.product_name, product.product_stock_quantity, product.product_price, product_type.product_type_name FROM product INNER JOIN product_type ON product.product_type_id=product_type.product_type_id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, MysqlConnection.mysqlCon);
                DataTable dtb1 = new DataTable();
                adapter.Fill(dtb1);
                dgvProductList.AutoGenerateColumns = false;
                dgvProductList.DataSource = dtb1;
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                int s = Convert.ToInt32(dgvProductList.SelectedRows[0].Cells[3].Value) + Convert.ToInt32(txtProductQuantity.Text);
                Supplier_Orders_Add sd = new Supplier_Orders_Add();

                Globals.ProductID = dgvProductList.SelectedRows[0].Cells[0].Value.ToString();
                Globals.ProductName = dgvProductList.SelectedRows[0].Cells[1].Value.ToString();
                Globals.ProductQuantity = s;
                Globals.ProductTypeName = dgvProductList.SelectedRows[0].Cells[4].Value.ToString();
                sd.Refresh();
             
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }



        }
    }
}
