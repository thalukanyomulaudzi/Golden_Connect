using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Book_Event_Date bookEventDate = new Book_Event_Date();
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

                    string query = "";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Booking_Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("The booking creation has been canceled");
        }

        private void CbxBookingAdditions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBookingChangeCustomer_Click(object sender, EventArgs e)
        {
            Booking_Customer bookingAdd = new Booking_Customer();
            var result =  bookingAdd.ShowDialog();
        }
    }
}
