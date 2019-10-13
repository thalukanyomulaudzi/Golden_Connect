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
    public partial class Customer_Order_Payment : Form
    {
        DBConnection dB = DBConnection.Instance();
        public Customer_Order_Payment()
        {
            InitializeComponent();
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.HeaderText = "Select Order";
            select.Text = "Select";
            select.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn viewOrder = new DataGridViewButtonColumn();
            viewOrder.HeaderText = "View Order";
            viewOrder.Text = "View";
            viewOrder.UseColumnTextForButtonValue = true;
            dgvOrderPayment.Rows.Clear();
            dgvOrderPayment.ColumnCount = 4;
            dgvOrderPayment.Columns[0].Name = "Order ID";
            dgvOrderPayment.Columns[0].Width = 100;
            dgvOrderPayment.Columns[1].Name = "Customer Name";
            dgvOrderPayment.Columns[1].Width = 190;
            dgvOrderPayment.Columns[2].Name = "Date Placed";
            dgvOrderPayment.Columns[2].Width = 120;
            dgvOrderPayment.Columns[3].Name = "Order Total";
            dgvOrderPayment.Columns[3].Width = 120;
            dgvOrderPayment.Columns.Add(select);
            dgvOrderPayment.Columns.Add(viewOrder);
        }

        private void Customer_Order_Payment_Load(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            if(dB.IsConnect())
            {
                string query = "SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_total` FROM `order`, `customer`, `order_status` " +
                    "WHERE `order`.`customer_id` = `customer`.`customer_id` AND `order_status`.`order_status_id` = `order`.`order_status_id` AND `order_status`.`order_status_name` = 'Pending'";
                var command = new MySqlCommand(query, dB.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var date = Convert.ToDateTime(reader[3]).Date;
                    dgvOrderPayment.Rows.Add(reader[0], reader[2] + ", " + reader[1], date.ToString("yyyy-M-dd"), "R"+reader[4]);
                }
                reader.Close();
            }
        }

        private void DgvOrderPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            View_Order_Details viewOrder = new View_Order_Details();
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                int orderID = Convert.ToInt32(dgvOrderPayment.Rows[e.RowIndex].Cells[0].Value);
                if (dB.IsConnect())
                {
                    string checkStatus = "SELECT `customer_id` FROM `order` WHERE `order_id` = '" + orderID + "'";
                    var command = new MySqlCommand(checkStatus, dB.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        View_Order_Details.customerID = Convert.ToInt32(reader[0]);
                        View_Order_Details.order_id = orderID;
                        reader.Close();
                        viewOrder.ShowDialog();
                    }
                    reader.Close();
                }
            }
            else if(e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                lblOrderID.Text = dgvOrderPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblOT.Text = dgvOrderPayment.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblPayDate.Text = DateTime.Now.Date.ToString("yyyy-M-dd");
                Customer_Payment_Receipt.Order_ID = Convert.ToInt32(dgvOrderPayment.Rows[e.RowIndex].Cells[0].Value);
                Customer_Payment_Receipt.customerName = dgvOrderPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnPay.Enabled = true;
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
        Customer_Payment_Receipt cR = new Customer_Payment_Receipt();
        private void BtnPay_Click(object sender, EventArgs e)
        {
            cR.ShowDialog();
        }
    }
}
