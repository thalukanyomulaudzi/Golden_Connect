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
    public partial class Supplier_Orders : Form
    {

        public Supplier_Orders()
        {
            InitializeComponent();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Supplier_Orders_Add supplier_Orders_Add = new Supplier_Orders_Add();
            supplier_Orders_Add.Show();
        }

        private void Supplier_Orders_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT supplier_order_line.supplier_order_id, supplier_order_line.product_id, product.product_name, supplier_order_line.supplier_order_line_quantity" +
                        " FROM supplier_order_line INNER JOIN product ON supplier_order_line.product_id=product.product_id";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    foreach(DataRow item in dataTable.Rows)
                    {
                        int i = dgvSupplierOrders.Rows.Add();
                        dgvSupplierOrders.Rows[i].Cells[0].Value = false;
                        dgvSupplierOrders.Rows[i].Cells[1].Value = dataTable.Rows[i].ItemArray[0];
                        dgvSupplierOrders.Rows[i].Cells[2].Value = dataTable.Rows[i].ItemArray[2];
                        dgvSupplierOrders.Rows[i].Cells[3].Value = dataTable.Rows[i].ItemArray[3];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReceiveSupplierOrder_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow item in dgvSupplierOrders.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dgvReceivedOrders.Rows.Add();
                    dgvReceivedOrders.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dgvReceivedOrders.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dgvReceivedOrders.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();

                    
                }

            }

             dgvSupplierOrders.Rows.Cast<DataGridViewRow>().Where(row => (bool?)row.Cells[0].Value == true)
             .ToList().ForEach(row => 
             {
                 dgvSupplierOrders.Rows.Remove(row);
             });

            //DBConnection dBConnection = DBConnection.Instance();
            //try
            //{
            //    if (dBConnection.IsConnect())
            //    {
            //        string query = "UPDATE `customer` SET `customer_id` = '" + GetCustomerRow + "', `customer_first` = '" + txtCustomerFirst.Text + "', `customer_last` = '" + txtCustomerLast.Text +
            //            "', `customer_email` = '" + txtCustomerEmail.Text.ToLower() + "', `customer_phone` = '" + txtCustomerPhone.Text + "', `customer_id_number` = '" + txtCustomerID.Text + "' WHERE " +
            //            "customer_id = '" + GetCustomerRow + "'";
            //        var command = new MySqlCommand(query, dBConnection.Connection);
            //        command.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //}
        }

        private void DgvSupplierOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if((bool)dgvSupplierOrders.SelectedRows[0].Cells[0].Value == false)
            {
                dgvSupplierOrders.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgvSupplierOrders.SelectedRows[0].Cells[0].Value = false;
            }
        }
    }
}
