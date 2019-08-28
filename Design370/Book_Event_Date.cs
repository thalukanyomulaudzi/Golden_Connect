using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class Book_Event_Date : Form
    {
        public Book_Event_Date()
        {
            InitializeComponent();
        }

        private void Book_Event_Date_Load(object sender, EventArgs e)
        {
            Timeslots.loadTimeslots(dgvBookEvent, DateTime.Today);
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvBookEvent.Rows.Clear();
            TimeSpan span = (dateTimePicker1.Value.Subtract(DateTime.Now));
            MessageBox.Show(span.TotalDays.ToString());
            if (span.TotalDays <= 2)
                Timeslots.loadTimeslots(dgvBookEvent, DateTime.Now);
            else
                Timeslots.loadTimeslots(dgvBookEvent, dateTimePicker1.Value.Subtract(TimeSpan.FromDays(3)));
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvBookEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();

                CultureInfo cultureInfo = CultureInfo.InvariantCulture;
                DateTime dateTime;
                dateTime = DateTime.ParseExact(dgvBookEvent.Columns[e.ColumnIndex].HeaderText, "dddd, MMM dd \"'\"yy", cultureInfo);
                dateTime = dateTime.AddHours(8 + dgvBookEvent.CurrentRow.Index);
                //MessageBox.Show(dateTime.ToString());//shows the selected DateTime in a messagebox
                dgvBookingEmployees.Rows.Clear();
                string query = "SELECT e.employee_first, e.employee_last, et.available " +
                    "FROM employee e " +
                    "JOIN employee_timeslot et ON e.employee_id = et.employee_id " +
                    "JOIN timeslot t ON et.timeslot_id = t.timeslot_id " +
                    "WHERE t.timeslot_date = '" + dateTime.ToString("yyyy'-'MM'-'dd") + "' AND t.timeslot_start = '" + dateTime.ToString("HH:mm:ss") + "'";

                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvBookingEmployees.Rows.Add(reader.GetString(0) + " " + reader.GetString(1), reader.GetBoolean(2).ToString());
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bookingDetails("Event");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bookingDetails("Photoshoot");
        }
        private void bookingDetails(string bookingType)
        {
            if (dgvBookingEmployees.SelectedCells.Count == 0 || dgvBookEvent.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a timeslot and employee");
                return;
            }
            Booking.bookingType = bookingType;
            Booking_Details bookingDetails = new Booking_Details();
            bookingDetails.ShowDialog();
        }
    }
}
