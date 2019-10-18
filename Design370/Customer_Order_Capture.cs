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
        public static int orderPaymentID;
        DBConnection dbCon = DBConnection.Instance();
        public int paymentID, customerID;
        public string customerPhone, customerLastName;

        public Customer_Order_Capture()
        {
            InitializeComponent();
        }

        public void createDgv()
        {
            DataGridViewButtonColumn view = new DataGridViewButtonColumn();
            view.HeaderText = "View Order";
            view.Text = "View";
            view.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn pay = new DataGridViewButtonColumn();
            pay.HeaderText = "Make Payment";
            pay.Text = "Select";
            pay.UseColumnTextForButtonValue = true;
            dgvPayments.Rows.Clear();
            dgvPayments.ColumnCount = 5;
            dgvPayments.Columns[0].Name = "Order ID";
            dgvPayments.Columns[0].Width = 100;
            dgvPayments.Columns[1].Name = "Customer Name";
            dgvPayments.Columns[1].Width = 140;
            dgvPayments.Columns[2].Name = "Date Placed";
            dgvPayments.Columns[2].Width = 120;
            dgvPayments.Columns[3].Name = "Order Quantity";
            dgvPayments.Columns[3].Width = 120;
            dgvPayments.Columns[4].Name = "Order Total";
            dgvPayments.Columns[4].Width = 110;
            dgvPayments.Columns.Add(pay);
            dgvPayments.Columns.Add(view);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        public string nm;

        private void CapturePayment_Load(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                createDgv();
                var command = new MySqlCommand("SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity`, `order_total` FROM `order`,`customer`,`order_status`" +
                    " WHERE `order`.`order_status_id` = `order_status`.`order_status_id` AND `order_status`.`order_status_name` = 'Pending' AND `order`.`customer_id` = `customer`.`customer_id`", dbCon.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    dgvPayments.Rows.Add(reader[0], reader[2] + ", " + reader[1], Convert.ToDateTime(reader[3]).Date.ToString("yyyy-M-dd"), reader[4], "R"+reader[5]);
                }
                reader.Close();
            }
        }

        private void BtnSavePayment_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != String.Empty && Convert.ToDecimal(txtAmount.Text) >= Convert.ToDecimal((dgvPayments.Rows[index].Cells[4].Value.ToString()).Remove(0, 1)))
            {
                Customer_Order_Paymebt_Receipt payOrder = new Customer_Order_Paymebt_Receipt();
                Customer_Order_Paymebt_Receipt.payAmount = txtAmount.Text;
                if (dbCon.IsConnect())
                {
                    string paymentData = "INSERT INTO `payment` (`payment_amount`, `customer_id`, `order_id`, `booking_id`) " +
                        "VALUES ('" + txtAmount.Text + "', '" + customerID + "', '"+Convert.ToInt32(lblOrderID.Text)+"', NULL)";
                    var command = new MySqlCommand(paymentData, dbCon.Connection);
                    var reader = command.ExecuteReader();
                   
                    reader.Close();

                    //var cm = new MySqlCommand("SELECT `customer_email`, `customer_phone` FROM `customer` WHERE `customer_id` = '" + customerID + "'", dbCon.Connection);
                    //var re = cm.ExecuteReader();
                    //re.Read();
                    //if (re.HasRows)
                    //{
                    //    // = Convert.ToInt32(reader[0]);
                    //    eml = reader[0].ToString();
                    //    pn = reader[1].ToString();
                    //}
                    //re.Close();

                    var updateorder = new MySqlCommand("UPDATE `order` SET `order_status_id` = '2' WHERE `order_id` = '"+Convert.ToInt32(lblOrderID.Text)+"'", dbCon.Connection);
                    var updated = updateorder.ExecuteReader();
                    updated.Close();

                    //int sent = SendSMS("CI00206948", eml, "om0QGsm1", pn, "Good Day "+nm+"\nThis Message serves as a notice to inform you that your order payment has been received. \n\nThank you for your support.\n\nGolden Hour");
                    //if (sent == 0)
                    //{

                    //    //updateOrder(OrderPaymentID);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Message not sent!");
                    //}
                    //payOrder.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Cannot make payment less that what you have ordered", "Customer Order Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public decimal orderTotal;
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtAmount.Text != String.Empty && Convert.ToDecimal(txtAmount.Text) >= Convert.ToDecimal(orderTotal))
            {
                Validation.checkMark(lblOrderPayment, Validation.validate(txtAmount.Text, "price"));
            }
        }
        int index = 0;
        public string eml;
        public string pn;
        private void DgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {

                nm = dgvPayments.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblOrderID.Text = dgvPayments.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dbCon.IsConnect())
                {
                    var command = new MySqlCommand("SELECT `customer_id` FROM `order` WHERE `order_id` = '"+Convert.ToInt32(lblOrderID.Text) +"'", dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        customerID = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                }
                
                dgvPayments.Rows[index].DefaultCellStyle.BackColor = Color.White;
                dgvPayments.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                index = e.RowIndex;
                Customer_Order_Paymebt_Receipt.id = Convert.ToInt32(dgvPayments.Rows[e.RowIndex].Cells[0].Value);
                btnSavePayment.Enabled = true;
            }
            else if(e.ColumnIndex == 6)
            {
                View_Order_Details viewOrder = new View_Order_Details();
                int orderID = Convert.ToInt32(dgvPayments.Rows[e.RowIndex].Cells[0].Value);
                if (dbCon.IsConnect())
                {
                    string checkStatus = "SELECT `customer_id` FROM `order` WHERE `order_id` = '" + orderID + "'";
                    var command = new MySqlCommand(checkStatus, dbCon.Connection);
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
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                createDgv();
                var command = new MySqlCommand("SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity`, `order_total` FROM `order`,`customer`,`order_status`" +
                    " WHERE `order`.`order_status_id` = `order_status`.`order_status_id` AND `order_status`.`order_status_name` = 'Pending' AND `order`.`customer_id` = `customer`.`customer_id` AND `customer`.`customer_first` = '%"+txtSearch.Text+ "%' OR `customer`.`customer_last` = '%" + txtSearch.Text + "%'", dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvPayments.Rows.Add(reader[0], reader[2] + ", " + reader[1], Convert.ToDateTime(reader[3]).Date.ToString("yyyy-M-dd"), reader[4], reader[5]);
                }
                reader.Close();
            }
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {
                //MessageBox.Show("Number");
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
