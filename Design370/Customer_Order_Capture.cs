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
using System.Net;
using System.Web.Util;
using System.Collections;
using System.IO;

namespace Design370
{
    public partial class Customer_Order_Capture : Form
    {
        public static int OrderPaymentID;
        DBConnection dbCon = DBConnection.Instance();
        int paymentID, customerID;
        string customerPhone, customerLastName;
        public Customer_Order_Capture()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CapturePayment_Load(object sender, EventArgs e)
        {
            cbxPaymentType.Items.Clear();
            lblOID.Text = OrderPaymentID.ToString();
            if(dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT * FROM `order` WHERE `order_id` = '" + OrderPaymentID + "'", dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lblAmountDue.Text = "R" + reader.GetString("order_total");
                    customerID = Convert.ToInt32(reader.GetString("customer_id"));
                }
                reader.Close();
            }

            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT * FROM `customer`", dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    customerPhone = reader.GetString("customer_phone");
                    customerLastName = reader.GetString("customer_first");
                }
                reader.Close();
            }

            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT * FROM `payment_type`", dbCon.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    cbxPaymentType.Items.Add(reader.GetString("payment_type_name"));
                }
                reader.Close();
            }
        }
        
        private void CbxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                string paymentData = cbxPaymentType.SelectedItem.ToString();
                var command = new MySqlCommand("SELECT `payment_type_id` FROM `payment_type` WHERE `payment_type_name` = '" + paymentData + "'", dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    paymentID = Convert.ToInt32(reader[0]);
                }
                reader.Close();
            }
        }

        private void BtnSavePayment_Click(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                string paymentData = "INSERT INTO `payment` (`payment_id`, `payment_type_id`, `payment_amount`, `customer_id`, `order_id`, `booking_id`) " +
                    "VALUES (NULL, '"+paymentID+"', '"+txtAmount.Text+"', '"+customerID+"', NULL, NULL)";
                var command = new MySqlCommand(paymentData, dbCon.Connection);
                var reader = command.ExecuteReader();
                int sent = SendSMS("CI00206948", "u15231748@tuks.co.za", "om0QGsm1", "0733859365", "Good Day\nThis Message serves as a notice to inform you that your order payment has been received. \n\nThank you for your support.\n\nGolden Hour");
                if (sent == 0)
                {
                    MessageBox.Show("Order payment for: " + customerLastName + " has been captured successfully");
                    updateOrder(OrderPaymentID);
                }
                else
                {
                    MessageBox.Show("Message not sent!");
                }
                reader.Close();
            }
        }

        public void updateOrder(int orderid)
        {
            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("UPDATE `order` SET `order_status_id` = 3 WHERE `order_id` = '" + orderid + "'", dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Close();
            }
        }

        public int SendSMS(String AccountID, String Email, String Password, String Recipient, String Message)
        {
            WebClient Client = new WebClient();
            String RequestURL, RequestData;

            RequestURL = "https://redoxygen.net/sms.dll?Action=SendSMS";

            RequestData = "AccountId=" + AccountID
                + "&Email=" + System.Web.HttpUtility.UrlEncode(Email)
                + "&Password=" + System.Web.HttpUtility.UrlEncode(Password)
                + "&Recipient=" + System.Web.HttpUtility.UrlEncode(Recipient)
                + "&Message=" + System.Web.HttpUtility.UrlEncode(Message);

            byte[] PostData = Encoding.ASCII.GetBytes(RequestData);
            byte[] Response = Client.UploadData(RequestURL, PostData);

            String Result = Encoding.ASCII.GetString(Response);
            int ResultCode = System.Convert.ToInt32(Result.Substring(0, 4));

            return ResultCode;
        }
    }
}
