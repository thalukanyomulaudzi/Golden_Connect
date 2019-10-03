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
        private void DeliverOrder_Load(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvDeliveries.ColumnCount = 4;
                dgvDeliveries.Columns[1].Name = "Order ID";
                dgvDeliveries.Columns[1].Width = 170;
                dgvDeliveries.Columns[2].Name = "Order Date";
                dgvDeliveries.Columns[2].Width = 210;
                dgvDeliveries.Columns[3].Name = "Order Quantity";
                dgvDeliveries.Columns[3].Width = 170;
                string ordersToBePrepared = "SELECT * FROM `order`, `order_status` WHERE `order_status`.`order_status_name` = 'Prepared' AND `order_status`.`order_status_id` = `order`.`order_status_id`";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvDeliveries.Rows.Add("", reader[0], reader[1], reader[5]);
                }
                reader.Close();
            }
        }

        private void DgvDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                Order.UpdateOrderStatus(Convert.ToInt32(dgvDeliveries.Rows[e.RowIndex].Cells[1].Value), "Delivered");
            }
        }
    }
}
