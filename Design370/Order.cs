using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public class Order
    {
        private static DBConnection dbCon = DBConnection.Instance();

        public Order() { }

        public Order(string name, int qty, string[] imgs, int productID, long orderID)
        {
            getOrderName = name;
            getOrderQuanity = qty;
            getOrderImages = imgs;
            getProductID = productID;
            getOrderID = orderID;
        }

        public string getOrderName { get; set; }

        public int getOrderQuanity { get; set; }

        public string[] getOrderImages { get; set; }

        public int getProductID { get; set; }

        public long getOrderID { get; set; }

        public static void LoadOrders(DataGridView dgv)
        {
            try
            {
                dbCon.Close();
                dbCon.Open();
                dgv.ColumnCount = 8;
                dgv.Columns[2].Name = "Order ID";
                dgv.Columns[2].Width = 150;
                dgv.Columns[3].Name = "Customer Name";
                dgv.Columns[3].Width = 150;
                dgv.Columns[4].Name = "Date Placed";
                dgv.Columns[4].Width = 150;
                dgv.Columns[5].Name = "Order Quantity";
                dgv.Columns[5].Width = 150; 
                dgv.Columns[6].Name = "Order Total";
                dgv.Columns[6].Width = 150;
                dgv.Columns[7].Name = "Order Status";
                dgv.Columns[7].Width = 150;
                dgv.ReadOnly = true;
                if (dbCon.IsConnect())
                {
                    string orders = "SELECT `order_id`, `order_date_placed`, `customer`.`customer_first`, `order_quantity`, `order_total`, `order_status`.`order_status_name`, `customer`.`customer_last` " +
                        "FROM `order`, `customer`, `order_status` " +
                        "WHERE `order`.`customer_id` = `customer`.`customer_id` AND `order`.`order_status_id` = `order_status`.`order_status_id`";
                    var command = new MySqlCommand(orders, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv.Rows.Add("", "", reader[0], reader[2] + " " + reader[6], reader[1], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
