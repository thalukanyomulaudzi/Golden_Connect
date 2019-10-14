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
    public partial class ReceivedOrders : Form
    {
        public ReceivedOrders()
        {
            InitializeComponent();
        }

        private void ReceivedOrders_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT supplier_order_line.supplier_order_id, product.product_name, supplier_order_line.supplier_order_line_quantity" +
                                   " FROM supplier_order_line" +
                                   " JOIN product ON supplier_order_line.product_id = product.product_id" +
                                   " JOIN supplier_order ON supplier_order_line.supplier_order_id = supplier_order.supplier_order_id" +
                                   " WHERE supplier_order.supplier_order_status_id = " + 2;
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        int i = dgvReceivedOrders.Rows.Add();
                        dgvReceivedOrders.Rows[i].Cells[0].Value = dataTable.Rows[i].ItemArray[0];
                        dgvReceivedOrders.Rows[i].Cells[1].Value = dataTable.Rows[i].ItemArray[1];
                        dgvReceivedOrders.Rows[i].Cells[2].Value = dataTable.Rows[i].ItemArray[2];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
