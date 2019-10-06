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
    public partial class DeliverOrder : Form
    {
        public DeliverOrder()
        {
            InitializeComponent();
        }
        DBConnection dbCon = DBConnection.Instance();
        DataGridViewButtonColumn completeOrders;
        private void DeliverOrder_Load(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvDeliveries.Rows.Clear();
                completeOrders = new DataGridViewButtonColumn();
                completeOrders.HeaderText = "Complete Order";
                completeOrders.Text = "Done";
                completeOrders.UseColumnTextForButtonValue = true;
                completeOrders.Width = 130;
                dgvDeliveries.ColumnCount = 4;
                dgvDeliveries.Columns[0].Name = "Order ID";
                dgvDeliveries.Columns[0].Width = 100;
                dgvDeliveries.Columns[1].Name = "Customer Name";
                dgvDeliveries.Columns[1].Width = 170;
                dgvDeliveries.Columns[2].Name = "Order Date";
                dgvDeliveries.Columns[2].Width = 140;
                dgvDeliveries.Columns[3].Name = "Order Quantity";
                dgvDeliveries.Columns[3].Width = 120;
                dgvDeliveries.Columns.Add(completeOrders);
                string ordersToBePrepared = "SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity` FROM `order`, `order_status`, `customer` WHERE `order_status`.`order_status_name` = 'Complete' " +
                    "AND `order_status`.`order_status_id` = `order`.`order_status_id` AND `order`.`customer_id` = `customer`.`customer_id`";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvDeliveries.Rows.Add(reader[0], reader[2] + ", " + reader[1], reader[3], reader[4]);
                }
                reader.Close();
            }
        }

        private void DgvDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                Order.UpdateOrderStatus(Convert.ToInt32(dgvDeliveries.Rows[e.RowIndex].Cells[0].Value), "Done");
            }
        }

        private void DeliverOrder_Activated(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvDeliveries.Rows.Clear();
                completeOrders = new DataGridViewButtonColumn();
                completeOrders.HeaderText = "Complete Order";
                completeOrders.Text = "Done";
                completeOrders.UseColumnTextForButtonValue = true;
                completeOrders.Width = 130;
                dgvDeliveries.ColumnCount = 4;
                dgvDeliveries.Columns[0].Name = "Order ID";
                dgvDeliveries.Columns[0].Width = 100;
                dgvDeliveries.Columns[1].Name = "Customer Name";
                dgvDeliveries.Columns[1].Width = 170;
                dgvDeliveries.Columns[2].Name = "Order Date";
                dgvDeliveries.Columns[2].Width = 140;
                dgvDeliveries.Columns[3].Name = "Order Quantity";
                dgvDeliveries.Columns[3].Width = 120;
                dgvDeliveries.Columns.Add(completeOrders);
                string ordersToBePrepared = "SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity` FROM `order`, `order_status`, `customer` WHERE `order_status`.`order_status_name` = 'Complete' " +
                    "AND `order_status`.`order_status_id` = `order`.`order_status_id` AND `order`.`customer_id` = `customer`.`customer_id`";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvDeliveries.Rows.Add(reader[0], reader[2] + ", " + reader[1], reader[3], reader[4]);
                }
                reader.Close();
            }
        }
    }
}
