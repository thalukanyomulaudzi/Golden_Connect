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
           // DataTable orders = new DataTable();
            //Place Order Button
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string supplier_order_id = "";
                    string query = "INSERT INTO `supplier_order` (`supplier_order_id`, `supplier_id`, `supplier_order_date_placed`, `supplier_order_status_id`) VALUES";
                    query += "('" + "NULL" + "', '" + Globals.SupplierID + "', '" + dateTimePicker1.Text + "', '" + 1 + "')";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                    query = "SELECT supplier_order_id FROM supplier_order WHERE supplier_id = '" + Globals.SupplierID + "' AND supplier_order_date_placed = '" + dateTimePicker1.Text + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    supplier_order_id = reader.GetString(0);
                    reader.Close();
                    for (int i = 0; i < dgvOrderProductList.Rows.Count; i++)
                    {
                        query = "INSERT INTO `supplier_order_line` (`supplier_order_id`, `product_id`, `supplier_order_line_quantity` ) VALUES('" + supplier_order_id + "', " +
                            "'" + dgvOrderProductList.Rows[i].Cells[0].Value + "', '" + dgvOrderProductList.Rows[i].Cells[2].Value + "')";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Order has been placed");
            }
            this.Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {

            Supplier_List list = new Supplier_List();
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
            Product_List f = new Product_List();
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
