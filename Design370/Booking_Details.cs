using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Design370
{
    public partial class Booking_Details : Form
    {
        private List<string> products = new List<string>();
        private List<string> services = new List<string>();
        public Booking_Details()
        {
            InitializeComponent();
        }

        private void Booking_Details_Load(object sender, EventArgs e)
        {
            Booking_Customer customer = new Booking_Customer();
            DialogResult result = customer.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Dispose();
                return;
            }

            Booking_Date bookEventDate = new Booking_Date();
            result = bookEventDate.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Dispose();
                return;
            }
            loadBookingDetails();
        }


        private void Booking_Details_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void BtnBookingChangeCustomer_Click(object sender, EventArgs e)
        {
            Booking_Customer bookingAdd = new Booking_Customer();
            DialogResult result = bookingAdd.ShowDialog();
            txtBookingCustomer.Text = Booking.customerName;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Booking_Date bookingDate = new Booking_Date();
            DialogResult result = bookingDate.ShowDialog();
            loadBookingDetails();
        }
        private void CmbBookingPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            double linePrice = 0;
            double totalPrice = 0;
            int productTypeID, serviceTypeID;
            DataTable products = new DataTable();
            DataTable services = new DataTable();

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                string query = "SELECT product_type_id FROM product_type WHERE product_type_name = '" + Booking.bookingType + "'";
                var command = new MySqlCommand(query, dBConnection.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                productTypeID = reader.GetInt32(0);
                reader.Close();

                query = "SELECT product_id, booking_package_product_quantity FROM booking_package_product WHERE booking_package_name = '" + cmbBookingPackage.Text + "'";
                command = new MySqlCommand(query, dBConnection.Connection);
                reader = command.ExecuteReader();
                products.Load(reader);
                for (int i = 0; i < products.Rows.Count; i++)
                {
                    query = "SELECT p.product_id, p.product_name, p.product_price, bpp.booking_package_product_quantity " +
                        "FROM product p INNER JOIN booking_package_product bpp ON p.product_id = bpp.product_id " +
                        "JOIN booking_package bp ON bp.booking_package_id = bpp.booking_package_id" +
                        "WHERE p.product_id = '" + products.Rows[i].ItemArray[0] + "' AND bp.booking_package_name = '" + cmbBookingPackage.Text + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    linePrice = reader.GetDouble(2) * reader.GetDouble(3);
                    dgvProducts.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(3), "R" + string.Format("{0:0.00}", linePrice), "Add", "Remove");
                    totalPrice += linePrice;
                    reader.Close();
                }
                reader.Close();
                products.Clear();
                query = "SELECT product_id, product_name, product_price FROM product WHERE product_type_id = '" + productTypeID + "'";
                command = new MySqlCommand(query, dBConnection.Connection);
                reader = command.ExecuteReader();
                products.Load(reader);
                for (int i = 0; i < products.Rows.Count; i++)
                {
                    dgvProducts.Rows.Add(products.Rows[i].ItemArray[0], products.Rows[i].ItemArray[1], "R" + products.Rows[i].ItemArray[2], "Add");
                }
                reader.Close();

                query = "SELECT service_type_id FROM service_type WHERE service_type_name = '" + Booking.bookingType + "'";
                command = new MySqlCommand(query, dBConnection.Connection);
                reader = command.ExecuteReader();
                reader.Read();
                serviceTypeID = reader.GetInt32(0);
                reader.Close();

                query = "SELECT service_id FROM booking_package_service WHERE booking_package_name = '" + cmbBookingPackage.Text + "'";
                command = new MySqlCommand(query, dBConnection.Connection);
                reader = command.ExecuteReader();
                services.Load(reader);
                for (int i = 0; i < services.Rows.Count; i++)
                {
                    query = "SELECT service_id, service_name, service_price FROM service WHERE service_id = '" + services.Rows[i].ItemArray[0] + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    dgvServicesInPackage.Rows.Add(reader.GetString(0), reader.GetString(1), "R" + reader.GetString(2), "Remove");
                    totalPrice += Convert.ToDouble(reader.GetString(2));
                    reader.Close();
                }
                reader.Close();

                services.Clear();
                query = "SELECT service_id, service_name, service_price FROM service WHERE service_type_id = '" + serviceTypeID + "'";
                command = new MySqlCommand(query, dBConnection.Connection);
                reader = command.ExecuteReader();
                services.Load(reader);
                for (int p = 0; p < services.Rows.Count; p++)
                {
                    dgvServices.Rows.Add(services.Rows[p].ItemArray[0], services.Rows[p].ItemArray[1], "R" + services.Rows[p].ItemArray[2], "Add");
                }
                reader.Close();

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
            textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);








            loadPackages();
        }
        private void BtnBookingProceed_Click(object sender, EventArgs e)
        {
            if (cmbBookingPackage.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a package first");
                DialogResult = DialogResult.None;
                return;
            }
            MySqlCommand command;
            MySqlDataReader reader = null;
            try
            {
                string ID;
                DBConnection dBCon = DBConnection.Instance();
                //get type id
                string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = '" + Booking.bookingType + "'";
                command = new MySqlCommand(query, dBCon.Connection);
                reader = command.ExecuteReader();
                reader.Read();
                string typeID = reader.GetString(0);
                reader.Close();

                //get status id
                query = "SELECT booking_status_id FROM booking_status WHERE booking_status_name = 'Pending'";
                command.CommandText = query;
                reader = command.ExecuteReader();
                reader.Read();
                string statusID = reader.GetString(0);
                reader.Close();

                //get booking package id
                query = "SELECT booking_package_id FROM booking_package WHERE booking_package_name = '" + cmbBookingPackage.Text + "'";
                command.CommandText = query;
                reader = command.ExecuteReader();
                reader.Read();
                string packageID = reader.GetString(0);
                reader.Close();

                //insert booking
                query = "INSERT IGNORE INTO `booking` (`booking_id`, `customer_id`, `date_created`, `location_address`, `discount_id`, " +
                    "`booking_type_id`, `booking_status_id`, `transport_fee_id`, `booking_package_id`, `booking_guests`) " +
                    "VALUES (NULL, '" + Booking.customerID + "', '" + DateTime.Now.ToString("yyyy'-'MM'-'dd") + "', '" + txtBookingLocation.Text + "', NULL, '" +
                    typeID + "', '" + statusID + "', '" + "1" + "', '" + packageID + "', '";

                query += Booking.bookingType == "Photoshoot"
                    ? numBookingGuests.Value.ToString() + "');"
                    : 0 + "');";

                query += "UPDATE employee_timeslot et JOIN timeslot t ON et.timeslot_id = t.timeslot_id " +
                    "SET booking_id = LAST_INSERT_ID(), et.available = 0 " +
                    "WHERE t.timeslot_date = '" + dtmBookingDate.Value.ToString("yyyy'-'MM'-'dd") + "' AND t.timeslot_start = '" + txtBookingTime.Text + "';";
                command.CommandText = query;
                command.ExecuteNonQuery();


                foreach (var item in products)
                {
                    query = "SELECT product_id FROM product WHERE product_name = '" + item.Substring(0, item.IndexOf(";")) + "'";
                    command.CommandText = query;
                    reader = command.ExecuteReader();
                    reader.Read();
                    ID = reader.GetString(0);
                    reader.Close();

                    int quantity = Convert.ToInt32(item.Substring(item.IndexOf("-") + 1));
                    if (quantity > 0)
                    {
                        query = "INSERT IGNORE INTO booking_product (booking_id, product_id, booking_product_quantity) " +
                            "VALUES (LAST_INSERT_ID(), '" + ID + "', '" + quantity + "');";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
                foreach (var item in services)
                {
                    query = "SELECT service_id FROM service WHERE service_name = '" + item.Substring(0, item.IndexOf(";")) + "'";
                    command.CommandText = query;
                    reader = command.ExecuteReader();
                    reader.Read();
                    ID = reader.GetString(0);
                    reader.Close();
                    int quantity = Convert.ToInt32(item.Substring(item.IndexOf("-") + 1));
                    if (quantity > 0)
                    {
                        query = "INSERT IGNORE INTO booking_service (booking_id, service_id) " +
                            "VALUES (LAST_INSERT_ID(), '" + ID + "');";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                reader.Close();
            }
        }
        private void updateTotal()
        {
            txtBookingTotal.Text = 5.ToString();
        }
        private void loadLists()
        {
            products.Clear();
            services.Clear();
            foreach (var item in lstBookingProducts.Items)
                products.Add(item.ToString());
            foreach (var item in lstBookingServices.Items)
                services.Add(item.ToString());
        }
        private void loadPackages()
        {
            try
            {
                loadLists();
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT p.product_name, p.product_price, bpp.booking_package_product_quantity FROM product p " +
                    "JOIN product_type pt ON p.product_type_id = pt.product_type_id " +
                    "JOIN booking_package_product bpp ON p.product_id = bpp.product_id " +
                    "WHERE pt.product_type_name = '" + Booking.bookingType + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(reader.GetString(0) + "; R" + reader.GetString(1) + " - " + reader.GetString(2));
                }
                reader.Close();

                query = "SELECT s.service_name, s.service_price FROM service s " +
                    "JOIN service_type st ON s.service_type_id = st.service_type_id " +
                    "WHERE st.service_type_name = '" + Booking.bookingType + "'";
                command.CommandText = query;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    services.Add(reader.GetString(0) + "; R" + reader.GetString(1) + " - 1");
                }
                reader.Close();
                foreach (var item in products)
                    lstBookingProducts.Items.Add(item);
                foreach (var item in services)
                    lstBookingServices.Items.Add(item);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadBookingDetails()
        {
            try
            {
                txtBookingCustomer.Text = Booking.customerName;
                dtmBookingDate.Value = Booking.bookingDate;
                txtBookingEmployee.Text = Booking.employeeName;
                txtBookingTime.Text = Booking.time;
                DBConnection dBCon = DBConnection.Instance();

                if (Booking.bookingType == "Photoshoot")
                {
                    numBookingGuests.Enabled = false;
                }
                if (dBCon.IsConnect())
                {
                    string query = "SELECT bp.booking_package_name FROM booking_package bp " +
                        "JOIN booking_package_type bpt ON bp.booking_package_type_id = bpt.booking_package_type_id " +
                        "WHERE bpt.booking_package_type_name = '" + Booking.bookingType + "'";
                    MySqlCommand command = new MySqlCommand(query, dBCon.Connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    cmbBookingPackage.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBookingPackage.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LstBookingProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
