using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                MessageBox.Show("Customer selection has been canceled");
                Dispose();
                return;
            }

            Booking_Date bookEventDate = new Booking_Date();
            result = bookEventDate.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Timeslot/employee selection has been canceled");
                Dispose();
                return;
            }
            loadBookingDetails();
        }

        private void loadBookingDetails()
        {
            try
            {
                txtBookingCustomer.Text = Booking.customerName;
                dtmBookingDate.Value = Booking.bookingDate;
                txtBookingEmployee.Text = Booking.employeeName;
                DBConnection dBCon = DBConnection.Instance();
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
        private void Booking_Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Booking creation has been canceled");
        }
        private void CbxBookingAdditions_CheckedChanged(object sender, EventArgs e)
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
            lstBookingProducts.Items.Clear();
            lstBookingServices.Items.Clear();
            loadPackages();
        }
        private void loadPackages()
        {
            try
            {
                loadLists();
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT p.product_name, p.product_price, bpp.booking_package_product_quantity FROM product p " +
                    "JOIN booking_type bt ON p.booking_type_id = bt.booking_type_id " +
                    "JOIN booking_package_product bpp ON p.product_id = bpp.product_id " +
                    "WHERE bt.booking_type_name = '" + Booking.bookingType + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(reader.GetString(0) + "; R" + reader.GetString(1) + " - " + reader.GetString(2));
                }
                reader.Close();

                query = "SELECT service_name, s.service_price FROM service s " +
                    "JOIN booking_type bt ON s.booking_type_id = bt.booking_type_id " +
                    "WHERE bt.booking_type_name = '" + Booking.bookingType + "'";
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
        private void BtnBookingProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBookingProductQuantity.Value < 1)
                {
                    MessageBox.Show("Please enter a value in the numberbox on the left");
                    return;
                }
                loadLists();
                foreach (int position in lstBookingProducts.SelectedIndices)
                {
                    int quantity = Convert.ToInt32(lstBookingProducts.Items[position].ToString().Substring(lstBookingProducts.Items[position].ToString().IndexOf("-") + 1));
                    quantity += (int)numBookingProductQuantity.Value;
                    if (quantity >= 10)
                    {
                        MessageBox.Show("That is a very high amount to have of a product, please check the amounts carefully");
                    }
                    products[position] = products[position].Substring(0, products[position].IndexOf("-") + 1) + " " + quantity;
                    lstBookingProducts.Items[position] = products[position];
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void BtnBookingProductRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (numBookingProductQuantity.Value < 1)
                {
                    MessageBox.Show("Please enter a value in the numberbox on the left");
                    return;
                }
                loadLists();
                foreach (int position in lstBookingProducts.SelectedIndices)
                {
                    int quantity = Convert.ToInt32(lstBookingProducts.Items[position].ToString().Substring(lstBookingProducts.Items[position].ToString().IndexOf("-") + 1));
                    quantity -= (int)numBookingProductQuantity.Value;
                    if (quantity <= 0)
                    {
                        MessageBox.Show("This product has been removed");
                        quantity = 0;
                    }
                    products[position] = products[position].Substring(0, products[position].IndexOf("-") + 1) + " " + quantity;
                    lstBookingProducts.Items[position] = products[position];
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void BtnBookingServiceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                loadLists();
                foreach (int position in lstBookingServices.SelectedIndices)
                {
                    int quantity = Convert.ToInt32(lstBookingServices.Items[position].ToString().Substring(lstBookingServices.Items[position].ToString().IndexOf("-") + 1));
                    if (quantity == 1)
                    {
                        MessageBox.Show("This service is already added");
                        break;
                    }
                    quantity += 1;
                    services[position] = services[position].Substring(0, services[position].IndexOf("-") + 1) + " " + quantity;
                    lstBookingServices.Items[position] = services[position];
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void BtnBookingServiceRemove_Click(object sender, EventArgs e)
        {
            try
            {
                loadLists();
                foreach (int position in lstBookingServices.SelectedIndices)
                {
                    int quantity = Convert.ToInt32(lstBookingServices.Items[position].ToString().Substring(lstBookingServices.Items[position].ToString().IndexOf("-") + 1));
                    if (quantity == 0)
                    {
                        MessageBox.Show("This service is already removed");
                        break;
                    }
                    quantity -= 1;
                    services[position] = services[position].Substring(0, services[position].IndexOf("-") + 1) + " " + quantity;
                    lstBookingServices.Items[position] = services[position];
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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
        private void BtnBookingProceed_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "";
                var command = new MySqlCommand(query, dBCon.Connection);
                command.ExecuteNonQuery();




            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
