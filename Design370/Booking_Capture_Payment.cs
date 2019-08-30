using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Design370
{
    public partial class Booking_Capture_Payment : Form
    {
        public Booking_Capture_Payment()
        {
            InitializeComponent();
        }

        private void Booking_Capture_Payment_Load(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader reader;
            try
            {
                dgvBookingPayments.Rows.Clear();
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT c.customer_first, c.customer_last, p.payment_amount, p.payment_date FROM customer c " +
                    "JOIN payment p ON c.customer_id = p.customer_id " +
                    "WHERE p.booking_id = '" + Booking.bookingID + "'";
                command = new MySqlCommand(query, dBCon.Connection);
                reader = command.ExecuteReader();
                dgvBookingPayments.Rows.Clear();
                while (reader.Read())
                {
                    dgvBookingPayments.Rows.Add(reader.GetString(0) + " " + reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                reader.Close();
                double total = 0;

                query = "SELECT p.product_price, bp.booking_product_quantity FROM product p " +
                    "JOIN booking_product bp ON p.product_id = bp.product_id " +
                    "WHERE bp.booking_id = '"+Booking.bookingID+"'";
                command.CommandText = query;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    total += reader.GetDouble(0) * reader.GetInt16(1);
                }
                reader.Close();
                txtBookingOutstandingTotal.Text = total.ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*\.?\d{2}?");
            double payment;
            if (regex.IsMatch(txtBookingPaymentAmount.Text))
            {
                payment = Convert.ToDouble(txtBookingPaymentAmount.Text);
            }
        }

        private void BtnBookingPaymentCapture_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "INSERT INTO `payment` (`payment_id`, `customer_id`, `payment_amount`, `payment_date`, `payment_type_id`, `order_id`, `booking_id`) " +
                    "VALUES (NULL, '" + Booking.customerID + "', '" + txtBookingPaymentAmount.Text + "', '" + DateTime.Now.ToString("yyyy'-'MM'-'dd") + "', '1', NULL, '" + Booking.bookingID + "');";
                MessageBox.Show(query);
                var command = new MySqlCommand(query, dBCon.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
