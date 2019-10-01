using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public class Order
    {
        private static DBConnection dbCon = DBConnection.Instance();

        public Order() { }

        public Order(string name, string[] imgs, int item_id, int productID)
        {
            getOrderName = name;
            getOrderImages = imgs;
            getItemID = item_id;
            getProductID = productID;
        }

        public string getOrderName { get; set; }

        //public int getOrderQuanity { get; set; }

        public string[] getOrderImages { get; set; }

        public int getItemID { get; set; }

        public int getProductID { get; set; }

        public static void LoadOrders(DataGridView dgv)
        {
            try
            {
                dbCon.Close();
                dbCon.Open();
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
                if (dbCon.IsConnect())
                {
                    string orders = "SELECT `order_id`, `order_date_placed`, `customer`.`customer_first`, `order_total`, `order_status`.`order_status_name`, `customer`.`customer_last` " +
                        "FROM `order`, `customer`, `order_status` " +
                        "WHERE `order`.`customer_id` = `customer`.`customer_id` AND `order`.`order_status_id` = `order_status`.`order_status_id`";
                    var command = new MySqlCommand(orders, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv.Rows.Add(reader[0], reader[2] + " " + reader[5], reader[1], "R"+reader[3], reader[4]);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                dbCon.Close();
            }
        }
        static int statusID;
        private static int getStatusID(string statusName)
        {
            if(dbCon.IsConnect())
            {
                dbCon.Close();
                dbCon.Open();
                string getID = "SELECT * FROM `order_status` WHERE `order_status_name` = '"+statusName+"'";
                var cmd = new MySqlCommand(getID, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                reader.Read();
                statusID = Convert.ToInt32(reader[0]);
            }
            return statusID;
        }

        public static void UpdateOrderStatus(int orderID, string status)
        {
            statusID = getStatusID(status);
            if(dbCon.IsConnect())
            {
                dbCon.Close();
                dbCon.Open();
                string update = "UPDATE `order` SET `order_status_id` = '"+statusID+"' WHERE `order_id` = '"+orderID+"'";
                var command = new MySqlCommand(update, dbCon.Connection);
                command.ExecuteReader();
                MessageBox.Show("Order: "+orderID + " successfully updated!");
            }
        }
    }
}
