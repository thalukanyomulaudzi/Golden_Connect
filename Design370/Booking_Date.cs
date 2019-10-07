using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Design370
{
    public partial class Booking_Date : Form
    {
        public Booking_Date()
        {
            InitializeComponent();
        }

        private void Booking_Date_Load(object sender, EventArgs e)
        {
            dgvBookEvent.RowTemplate.Height = 50;
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvBookEvent.Rows.Clear();
            TimeSpan span = (dateTimePicker1.Value.Subtract(DateTime.Now));
            if (span.TotalDays <= 2)
                Booking.firstDayOfWeek = DateTime.Now;
            else
                Booking.firstDayOfWeek = dateTimePicker1.Value.Subtract(TimeSpan.FromDays(3));
            Timeslot.loadTimeslots(dgvBookEvent, Booking.firstDayOfWeek);
        }

        private void DgvBookEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                CultureInfo cultureInfo = CultureInfo.InvariantCulture;
                DateTime dateTime;
                dateTime = DateTime.ParseExact(dgvBookEvent.Columns[e.ColumnIndex].HeaderText, "dddd, MMM dd yyyy", cultureInfo);
                dateTime = dateTime.AddHours(8 + dgvBookEvent.CurrentRow.Index);
                //MessageBox.Show(dateTime.ToString());//shows the selected DateTime in a messagebox
                dgvBookingEmployees.Rows.Clear();
                string query = "SELECT e.employee_first, e.employee_last, et.available, e.employee_id " +
                    "FROM employee e " +
                    "JOIN employee_timeslot et ON e.employee_id = et.employee_id " +
                    "JOIN timeslot t ON et.timeslot_id = t.timeslot_id " +
                    "WHERE t.timeslot_date = '" + dateTime.ToString("yyyy'-'MM'-'dd") + "' AND t.timeslot_start = '" + dateTime.ToString("HH:mm:ss") + "'";

                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvBookingEmployees.Rows.Add(reader.GetString(0) + " " + reader.GetString(1), reader.GetBoolean(2).ToString(), reader.GetString(3));
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Book_Event_Date_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void Booking_Date_Activated(object sender, EventArgs e)
        {
            Timeslot.loadTimeslots(dgvBookEvent, DateTime.Today);
            txtBookingCustomerName.Text = Booking.customerName;
        }

        private void LblBookingDateNextWeek_MouseEnter(object sender, EventArgs e)
        {
            lblBookingDateNextWeek.ForeColor = Color.Blue;
        }

        private void LblBookingDateNextWeek_MouseLeave(object sender, EventArgs e)
        {
            lblBookingDateNextWeek.ForeColor = Color.Black;
        }

        private void LblBookingDatePreviousWeek_MouseEnter(object sender, EventArgs e)
        {
            lblBookingDatePreviousWeek.ForeColor = Color.Blue;
        }

        private void LblBookingDatePreviousWeek_MouseLeave(object sender, EventArgs e)
        {
            lblBookingDatePreviousWeek.ForeColor = Color.Black;
        }

        private void LblBookingDatePreviousWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.Subtract(TimeSpan.FromDays(7));
            if (dateTimePicker1.Value < DateTime.Today)
            {
                dateTimePicker1.Value = DateTime.Today;
                MessageBox.Show("Cannot go into the past to create a booking");
            }
        }

        private void LblBookingDateNextWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value += TimeSpan.FromDays(7);
        }

        private void DgvBookEvent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.ToString() == "Available")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else if (e.Value.ToString() == "Unavailable")
            {
                e.CellStyle.BackColor = Color.Red;
            }
        }

        private void BtnChangeCustomer_Click(object sender, EventArgs e)
        {
            Booking_Customer booking_Customer = new Booking_Customer();
            booking_Customer.ShowDialog();
        }

        private void BtnBookingPhotoshoot_Click(object sender, EventArgs e)
        {
            try
            {
                Booking.bookingType = "Photoshoot";
                Booking.bookingDate = DateTime.Parse(dgvBookEvent.Columns[dgvBookEvent.CurrentCell.ColumnIndex].HeaderText);
                Booking.employeeName = dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Booking.employeeID = dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Booking.time = dgvBookEvent.Rows[dgvBookEvent.CurrentRow.Index].HeaderCell.Value.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void BtnBookingEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Booking.bookingType = "Event";
                Booking.bookingDate = DateTime.Parse(dgvBookEvent.Columns[dgvBookEvent.CurrentCell.ColumnIndex].HeaderText);
                Booking.employeeName = dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Booking.employeeID = dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Booking.time = dgvBookEvent.Rows[dgvBookEvent.CurrentRow.Index].HeaderCell.Value.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
