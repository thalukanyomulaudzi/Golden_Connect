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
    public partial class Supplier_Orders_Add : Form
    {
        public Supplier_Orders_Add()
        {
            InitializeComponent();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            dgvOrderProductList.EnableHeadersVisualStyles = false;
            btnPlaceOrder.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Place Order Button

           // string StrQuery, StrQuery1;
            try
            {
                for (int i = 0; i < dgvOrderProductList.Rows.Count; i++)
                {
                    //StrQuery = @"INSERT INTO supplier_order VALUES (" + Globals.SupplierID.ToString() + ", "
                    //           + dateTimePicker1.Text + ", "
                    //           + 1 + ", ";

                    //StrQuery1 = @"INSERT INTO supplier_order_line VALUES (" + Globals.SupplierID.ToString() +
                    //           ", "
                    //           + dgvOrderProductList.Rows[i].Cells["Column1"].Value + ", "
                    //           + dgvOrderProductList.Rows[i].Cells["Column3"].Value + ")";

                    //comm.CommandText = StrQuery;
                    //comm.CommandText = StrQuery1;
                    //comm.ExecuteNonQuery();
                    //"SELECT product.product_name, product_type.product_type_name, product.product_price FROM product INNER JOIN product_type ON product.product_type_id=product_type.product_type_id";
                    string strquery = "INSERT INTO supplier_order(supplier_order.supplier_id, supplier_order.supplier_order_date_placed, supplier_order.supplier_order_status_id) VALUES('" +
                                        Globals.SupplierID.ToString() + "', '" + dateTimePicker1.Text + "', '" + 1 + "'); " +
                                      "INSERT INTO supplier_order_line(supplier_order_line.product_id, supplier_order_line.supplier_order_line_quantity) VALUES('" +
                                      dgvOrderProductList.Rows[i].Cells["Column1"].Value + "', '" + dgvOrderProductList.Rows[i].Cells["Column3"] + "', '" + 1 + "')";


                    //string strquery1 = "INSERT INTO supplier_order_line(supplier_order.supplier_id, supplier_order.supplier_order_date_placed, supplier_order.supplier_order_status_id) VALUES('" +
                    //                  Globals.SupplierID.ToString() + "', '" + dateTimePicker1.Text + "', '" + 1 + "')";
                    MysqlConnection.cmd = new MySqlCommand(strquery, MysqlConnection.mysqlCon);
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
                //using (MysqlConnection.mysqlCon)
                //{
                //    using (MySqlCommand comm = new MySqlCommand())
                //    {
                //        comm.Connection = MysqlConnection.mysqlCon;
                //        MysqlConnection.mysqlCon.Open();

                //    }
                //}
            }
            catch (Exception ee )
            {
                MessageBox.Show(ee.Message);
            }


            this.Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {

            SupplierList list = new SupplierList();
            list.ShowDialog();

            txtSupplierName.Text = Globals.SupplierName;
            txtEmailAddress.Text = Globals.SupplierEmail;
            txtTelephoneNo.Text = Globals.SupplierPhone;

            if (DialogResult == DialogResult.OK)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                dgvOrderProductList.EnableHeadersVisualStyles = true;
                btnPlaceOrder.Enabled = true;
                txtType.Text = "Supplier Order";
            }

        }

        private void Supplier_Orders_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //dgvOrderProductList.Rows.RemoveAt(0);
            ProductList f = new ProductList();
            f.ShowDialog();

            
            string[] row_value = new string[] {Globals.ProductID, Globals.ProductName, Globals.ProductQuantity.ToString(), Globals.ProductTypeName};


            dgvOrderProductList.Rows.Add(row_value);

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrderProductList.SelectedRows)
            {
                dgvOrderProductList.Rows.RemoveAt(row.Index);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
