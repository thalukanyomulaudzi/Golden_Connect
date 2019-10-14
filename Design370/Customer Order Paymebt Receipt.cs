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
    public partial class Customer_Order_Paymebt_Receipt : Form
    {
        public Customer_Order_Paymebt_Receipt()
        {
            InitializeComponent();
        }

        public List<Customer_Order_Receipts> list = new List<Customer_Order_Receipts>();
        public orderPayments cor = new orderPayments();
        DBConnection dbCon = DBConnection.Instance();
        public static int id;
        public decimal orderTotal = 0;
        public decimal vat = 0;
        public decimal subTotal = 0;
        public decimal price, qty, change;
        public string name, phone, email;
        public static string payAmount;
        private void Customer_Order_Paymebt_Receipt_Load(object sender, EventArgs e)
        {
            cor.Close();
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
            cor = new orderPayments();
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand("SELECT `customer_first`, `customer_last`, `customer_phone`, `customer_email` FROM `customer`, `order` " +
                    "WHERE `customer`.`customer_id` = `order`.`customer_id` AND `order`.`order_id` = '"+id+"'", dbCon.Connection);
                var getCustomer = cmd.ExecuteReader();
                getCustomer.Read();
                if(getCustomer.HasRows)
                {
                    name = getCustomer[1].ToString() + ", " + getCustomer[0].ToString();
                    phone = getCustomer[2].ToString();
                    email = getCustomer[3].ToString();
                }
                getCustomer.Close();

                var command = new MySqlCommand("SELECT `product_name`, `product_price`, `order_line_quantity` FROM `product`,`order`,`order_line` " +
                    "WHERE `order_line`.`product_id` = `product`.`product_id` AND `order_line`.`order_id` = `order`.`order_id` AND `order_line`.`order_id` = '" + id + "'", dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Customer_Order_Receipts(reader[0].ToString(), "R" + reader[1].ToString(), reader[2].ToString()));
                    price = Convert.ToDecimal(reader[1].ToString());
                    qty = Convert.ToDecimal(reader[2].ToString());
                    orderTotal += (price * qty);
                    list.ToList();
                }
            
                reader.Close();
                vat = orderTotal * Convert.ToDecimal(0.15);
                subTotal = orderTotal - vat;
                bindingSource1.DataSource = list;
                change = Convert.ToDecimal(payAmount) - orderTotal;
                cor.SetDataSource(bindingSource1.DataSource);
                cor.SetParameterValue("pSubTotal", "R" + (subTotal).ToString("0.##"));
                cor.SetParameterValue("pVat", "R" + (vat).ToString("0.##"));
                cor.SetParameterValue("pOrderT", "R" + (orderTotal).ToString());
                cor.SetParameterValue("pName", name);
                cor.SetParameterValue("pPhone", phone);
                cor.SetParameterValue("pEmail", email);
                cor.SetParameterValue("pAmount", "R"+payAmount);
                cor.SetParameterValue("pChange", "R"+change.ToString());
                crystalReportViewer1.ReportSource = cor;
                crystalReportViewer1.Refresh();
                list.Clear();
                orderTotal = 0;
            }
        }
    }
}
