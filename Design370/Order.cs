using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public class Order
    {
        private static DBConnection dbCon = DBConnection.Instance();

        public Order() { }

        public Order(string name, string[] imgs, int item_id, int productID, int qty)
        {
            getOrderName = name;
            getOrderImages = imgs;
            getItemID = item_id;
            getProductID = productID;
            getProductQty = qty;
        }

        public string getOrderName { get; set; }

        //public int getOrderQuanity { get; set; }

        public string[] getOrderImages { get; set; }

        public int getItemID { get; set; }

        public int getProductID { get; set; }

        public int getProductQty { get; set; }

        public static void LoadOrders(DataGridView dgv)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    DataGridViewButtonColumn viewOrder, payOrder;
                    viewOrder = new DataGridViewButtonColumn();
                    payOrder = new DataGridViewButtonColumn();
                    viewOrder.HeaderText = "Action";
                    viewOrder.Text = "View Order";
                    viewOrder.UseColumnTextForButtonValue = true;
                    viewOrder.Width = 130;
                    dgv.Rows.Clear();
                    dgv.ColumnCount = 5;
                    dgv.Columns[0].Name = "Order ID";
                    dgv.Columns[0].Width = 150;
                    dgv.Columns[1].Name = "Customer Name";
                    dgv.Columns[1].Width = 190;
                    dgv.Columns[2].Name = "Date Placed";
                    dgv.Columns[2].Width = 180;
                    dgv.Columns[3].Name = "Order Total";
                    dgv.Columns[3].Width = 150;
                    dgv.Columns[4].Name = "Order Status";
                    dgv.Columns[4].Width = 150;
                    dgv.Columns.Add(viewOrder);
                    dgv.ReadOnly = true;
                    dgv.RowHeadersVisible = false;
                    string orders = "SELECT `order_id`, `order_date_placed`, `customer`.`customer_first`, `order_total`, `order_status`.`order_status_name`, `customer`.`customer_last` " +
                        "FROM `order`, `customer`, `order_status` " +
                        "WHERE `order`.`customer_id` = `customer`.`customer_id` AND `order`.`order_status_id` = `order_status`.`order_status_id` ORDER BY `order_date_placed` DESC";
                    var command = new MySqlCommand(orders, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv.Rows.Add(reader[0], reader[5] +", " + reader[2], Convert.ToDateTime(reader[1]).ToString("yyyy-M-dd"), "R"+reader[3], reader[4]);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
         
            }
        }
        static int statusID;
        private static int getStatusID(string statusName)
        {
            if(dbCon.IsConnect())
            {
                string getID = "SELECT * FROM `order_status` WHERE `order_status_name` = '" + statusName + "'";
                var cmd = new MySqlCommand(getID, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                reader.Read();
                statusID = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            return statusID;
        }

        public static void UpdateOrderStatus(int orderID, string status)
        {
            statusID = getStatusID(status);
            if(dbCon.IsConnect())
            {
                string update = "UPDATE `order` SET `order_status_id` = '"+statusID+"' WHERE `order_id` = '"+orderID+"'";
                var command = new MySqlCommand(update, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("Order: "+orderID + " successfully updated!");
            }
        }
    }
}
