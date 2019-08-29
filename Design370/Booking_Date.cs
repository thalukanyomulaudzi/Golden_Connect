using MySql.Data.MySqlClient;
using System;
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
            Timeslot.loadTimeslots(dgvBookEvent, DateTime.Today);
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvBookEvent.Rows.Clear();
            TimeSpan span = (dateTimePicker1.Value.Subtract(DateTime.Now));
            if (span.TotalDays <= 2)
                Timeslot.loadTimeslots(dgvBookEvent, DateTime.Now);
            else
                Timeslot.loadTimeslots(dgvBookEvent, dateTimePicker1.Value.Subtract(TimeSpan.FromDays(3)));
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
                dateTime = DateTime.ParseExact(dgvBookEvent.Columns[e.ColumnIndex].HeaderText, "dddd, MMM dd yyyy", cultureInfo);
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
            try
            {
                Booking.bookingType = bookingType;
                Booking.bookingDate = DateTime.Parse(dgvBookEvent.Columns[dgvBookEvent.CurrentCell.ColumnIndex].HeaderText);
                Booking.employeeName = dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Booking.employeeID = Convert.ToInt16(dgvBookingEmployees.Rows[dgvBookingEmployees.CurrentCell.RowIndex].Cells[2].Value);
                foreach (DataGridCell cell in dgvBookEvent.SelectedCells)
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Book_Event_Date_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
