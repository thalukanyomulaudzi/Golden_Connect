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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Design370
{
    public partial class Customer_Payment_Receipt : Form
    {
        public Customer_Payment_Receipt()
        {
            InitializeComponent();
        }
        DBConnection dB = DBConnection.Instance();
        public static int Order_ID;
        public static string customerName;
        /*
         * 
         * 
         */
        public string customerPhone;
        public string customerEmail;
        public DateTime date = DateTime.Now.Date;
        public int productQty = 0;
        public decimal vatAmount = 0;
        public decimal subTotal = 0;
        public decimal orderTotal = 0;
        int status;
        private void Customer_Payment_Receipt_Load(object sender, EventArgs e)
        {
            CustomerOrderReceipt receipt = new CustomerOrderReceipt();
           
            if (dB.IsConnect())
            {
                var cmd = new MySqlCommand("SELECT `order_status_id` FROM `order_status` WHERE `order_status_name` = 'Ready'", dB.Connection);
                var read = cmd.ExecuteReader();
                read.Read();
                if(read.HasRows)
                {
                    status = Convert.ToInt32(read[0]);
                }
                read.Close();

                var cmdUpdateStatus = new MySqlCommand("UPDATE `order` SET `order_status_id` = '"+status+"' WHERE `order_id` = '"+Order_ID+"'", dB.Connection);
                var change = cmdUpdateStatus.ExecuteReader();
                change.Close();

                var command = new MySqlCommand("SELECT `product_price`, `order_line_quantity`, `customer_phone`, `customer_email` FROM `product`, `order_line`, `customer`, `order` " +
                    "WHERE `order_line`.`order_id` = '"+Order_ID+"' AND `product`.`product_id` = `order_line`.`product_id` AND `order`.`customer_id` = `customer`.`customer_id` AND `order`.`order_id` = `order_line`.`order_id`", dB.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    subTotal += ((Convert.ToInt32(reader[1])) * (Convert.ToDecimal(reader[0])));
                    customerEmail = reader[3].ToString();
                    customerPhone = reader[2].ToString();
                    productQty += 1;
                }
                reader.Close();
            }
            vatAmount = subTotal * Convert.ToDecimal(0.15);
            decimal sub = subTotal - vatAmount;
            receipt.SetParameterValue("pName", customerName);
            receipt.SetParameterValue("pPhone", customerPhone);
            receipt.SetParameterValue("pEmail", customerEmail);
            receipt.SetParameterValue("pOrderID", Order_ID);
            receipt.SetParameterValue("pPayDate", date.ToString("yyyy-M-dd"));
            receipt.SetParameterValue("pQty", productQty);
            receipt.SetParameterValue("pVat", "R"+vatAmount.ToString("0.##"));
            receipt.SetParameterValue("pSubTotal", "R"+ sub.ToString("0.##"));
            receipt.SetParameterValue("pOrderTotal", "R"+subTotal.ToString("0.##"));
            customerOrderReceipt.ReportSource = receipt;
            customerOrderReceipt.Refresh();
            productQty = 0;
        }
    }
}
