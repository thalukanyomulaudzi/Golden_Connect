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
    public partial class PrepareOrder : Form
    {
        public PrepareOrder()
        {
            InitializeComponent();
        }
        DBConnection dbCon = DBConnection.Instance();
        private void PrepareOrder_Load(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvPrepareCustomerOrder.ColumnCount = 5;
                dgvPrepareCustomerOrder.Columns[2].Name = "Order ID";
                dgvPrepareCustomerOrder.Columns[2].Width = 140;
                dgvPrepareCustomerOrder.Columns[3].Name = "Order Date";
                dgvPrepareCustomerOrder.Columns[3].Width = 140;
                dgvPrepareCustomerOrder.Columns[4].Name = "Order Quantity";
                dgvPrepareCustomerOrder.Columns[4].Width = 140;
                string ordersToBePrepared = "SELECT * FROM `order`, `order_status` WHERE `order_status`.`order_status_name` = 'Paid' AND `order_status`.`order_status_id` = `order`.`order_status_id`";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvPrepareCustomerOrder.Rows.Add("", "", reader[0], reader[1], reader[5]);
                }
                reader.Close();
            }
        }

        private void DgvPrepareCustomerOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 0:
                    Order.UpdateOrderStatus(Convert.ToInt32(dgvPrepareCustomerOrder.Rows[e.RowIndex].Cells[2].Value), "Prepared");
                    break;
                case 1:
                    OrderImages.orderID = Convert.ToInt32(dgvPrepareCustomerOrder.Rows[e.RowIndex].Cells[2].Value);
                    OrderImages orderImg = new OrderImages();
                    orderImg.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
