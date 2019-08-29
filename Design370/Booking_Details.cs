﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Booking_Details : Form
    {
        public Booking_Details()
        {
            InitializeComponent();
        }

        private void Booking_Details_Load(object sender, EventArgs e)
        {
            Booking_Customer customer = new Booking_Customer();
            var result = customer.ShowDialog();

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
                txtBookingEmployee.Text = Booking.employeeName;
                dtmBookingDate.Value = Booking.bookingDate;
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string query = "SELECT bp.booking_package_name FROM booking_package bp " +
                        "JOIN booking_package_type bpt ON bp.booking_package_type_id = bpt.booking_package_type_id " +
                        "WHERE bpt.booking_package_type_name = '" + Booking.bookingType + "'";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    var reader = command.ExecuteReader();
                    cmbBookingPackage.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBookingPackage.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                //txtBookingLocation.Clear();
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
            var result = bookingAdd.ShowDialog();
            txtBookingCustomer.Text = Booking.customerName;
        }

        private void BtnBookingChangeDateEmployee_Click(object sender, EventArgs e)
        {
            Booking_Date bookingDate = new Booking_Date();
            var result = bookingDate.ShowDialog();
            dtmBookingDate.Value = Booking.bookingDate;
            txtBookingEmployee.Text = Booking.employeeName;
            loadBookingDetails();
        }

        private void CmbBookingPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
