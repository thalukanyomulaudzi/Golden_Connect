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
                    string query =
                        "SELECT supplier_order.supplier_order_id, supplier.supplier_name, supplier_order.supplier_order_date_placed" +
                        " FROM supplier_order INNER JOIN supplier ON supplier_order.supplier_id=supplier.supplier_id" +
                        " WHERE supplier_order.supplier_order_status_id = " + 1;
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        int i = dgvSupplierOrders.Rows.Add();
                        dgvSupplierOrders.Rows[i].Cells[0].Value = dataTable.Rows[i].ItemArray[0];
                        dgvSupplierOrders.Rows[i].Cells[1].Value = dataTable.Rows[i].ItemArray[1];
                        dgvSupplierOrders.Rows[i].Cells[2].Value = dataTable.Rows[i].ItemArray[2];
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
            ReceivedOrders f = new ReceivedOrders();
            f.ShowDialog();

        }

        private void DgvSupplierOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Button14_Click_1(object sender, EventArgs e)
        {
            Supplier_Orders_Add supplier_Orders_Add = new Supplier_Orders_Add();
            supplier_Orders_Add.Show();
        }

        private void BtnReceiveSupplierOrder_Click_1(object sender, EventArgs e)
        {
            ReceivedOrders f = new ReceivedOrders();
            f.ShowDialog();
        }

        private void DgvSupplierOrders_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn & e.RowIndex >= 0)

            {
                dgvDisplay.Rows.Clear();
                dgvDisplay.Refresh();
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        string query = "SELECT product_name, supplier_order_line_quantity" +
                                       " FROM supplier_order_line JOIN product ON supplier_order_line.product_id=product.product_id" +
                                       " WHERE supplier_order_line.supplier_order_id = '" +
                                       dgvSupplierOrders.SelectedRows[0].Cells[0].Value + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        reader.Close();
                        foreach (DataRow item in dataTable.Rows)
                        {
                            int i = dgvDisplay.Rows.Add();

                            dgvDisplay.Rows[i].Cells[0].Value = dataTable.Rows[i].ItemArray[0];
                            dgvDisplay.Rows[i].Cells[1].Value = dataTable.Rows[i].ItemArray[1];
                            // i = dgvDisplay.Rows.Add();
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn & e.RowIndex >= 0)

            {
                //dgvDisplay.Rows.Clear();
                //dgvDisplay.Refresh();
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {

                        string query = "UPDATE `product` SET `product_stock_quantity` = `product_stock_quantity` + '" +
                                       dgvDisplay.SelectedRows[0].Cells[1].Value + "' WHERE " + "product_name = '" +
                                       dgvDisplay.SelectedRows[0].Cells[0].Value + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();

                        string query1 = "UPDATE `supplier_order` SET `supplier_order_status_id` = '" + 2 + "' WHERE " +
                                        "supplier_order_id = '" + dgvSupplierOrders.SelectedRows[0].Cells[0].Value +
                                        "'";
                        var command1 = new MySqlCommand(query1, dBConnection.Connection);
                        command1.ExecuteNonQuery();

                        MessageBox.Show(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString() + " have been received");
                        dgvDisplay.Rows.RemoveAt(0);
                        dgvDisplay.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvSupplierOrders_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn & e.RowIndex >= 0)

            {
                dgvDisplay.Rows.Clear();
                dgvDisplay.Refresh();
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        string query = "SELECT product_name, supplier_order_line_quantity" +
                                       " FROM supplier_order_line JOIN product ON supplier_order_line.product_id=product.product_id" +
                                       " WHERE supplier_order_line.supplier_order_id = '" +
                                       dgvSupplierOrders.SelectedRows[0].Cells[0].Value + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        reader.Close();
                        foreach (DataRow item in dataTable.Rows)
                        {
                            int i = dgvDisplay.Rows.Add();

                            dgvDisplay.Rows[i].Cells[0].Value = dataTable.Rows[i].ItemArray[0];
                            dgvDisplay.Rows[i].Cells[1].Value = dataTable.Rows[i].ItemArray[1];
                            // i = dgvDisplay.Rows.Add();
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void dgvDisplay_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn & e.RowIndex >= 0)

            {
                //dgvDisplay.Rows.Clear();
                //dgvDisplay.Refresh();
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {

                        string query = "UPDATE `product` SET `product_stock_quantity` = `product_stock_quantity` + '" +
                                       dgvDisplay.SelectedRows[0].Cells[1].Value + "' WHERE " + "product_name = '" +
                                       dgvDisplay.SelectedRows[0].Cells[0].Value + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();

                        string query1 = "UPDATE `supplier_order` SET `supplier_order_status_id` = '" + 2 + "' WHERE " +
                                        "supplier_order_id = '" + dgvSupplierOrders.SelectedRows[0].Cells[0].Value +
                                        "'";
                        var command1 = new MySqlCommand(query1, dBConnection.Connection);
                        command1.ExecuteNonQuery();

                        MessageBox.Show(dgvDisplay.SelectedRows[0].Cells[0].Value.ToString() + " have been received");
                        dgvDisplay.Rows.RemoveAt(0);
                        dgvDisplay.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            Supplier_Orders_Add so = new Supplier_Orders_Add();
            so.ShowDialog();
        }

        private void btnReceiveSupplierOrder_Click_2(object sender, EventArgs e)
        {
            ReceivedOrders f = new ReceivedOrders();
            f.ShowDialog();

        }
    }
}
