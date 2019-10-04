using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Design370
{
    class Booking
    {
        public static string bookingType = "", customerName = "", employeeName = "", customerID, employeeID, time, bookingID;
        public static DateTime bookingDate = new DateTime(), firstDayOfWeek = new DateTime();
        public static void loadBookings(System.Windows.Forms.DataGridView dgv, string search = "")
        {
            try
            {
                dgv.Rows.Clear();
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    List<short> bookingIDs = new List<short>();
                    List<DateTime> bookingDates = new List<DateTime>();
                    string query = "SELECT DISTINCT et.booking_id, t.timeslot_date FROM employee_timeslot et JOIN timeslot t ON et.timeslot_id = t.timeslot_id WHERE et.booking_id IS NOT NULL";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookingIDs.Add(reader.GetInt16(0));
                        bookingDates.Add(DateTime.Parse(reader.GetString(1)));
                    }
                    reader.Close();

                    query = search != ""
                        ? "SELECT t.timeslot_date, t.timeslot_start, c.customer_first, c.customer_last, bs.booking_status_name, b.booking_id FROM booking b " +
                        "JOIN customer c ON b.customer_id = c.customer_id " +
                        "JOIN employee_timeslot et ON et.booking_id = b.booking_id " +
                        "JOIN timeslot t ON et.timeslot_id = t.timeslot_id " +
                        "JOIN booking_status bs ON b.booking_status_id = bs.booking_status_id " +
                        "WHERE c.customer_first LIKE '%" + search + "%' OR c.customer_last LIKE '%" + search + "%' OR c.customer_id_number LIKE '%" + search + "%'"
                        : "SELECT t.timeslot_date, t.timeslot_start, c.customer_first, c.customer_last, bs.booking_status_name, b.booking_id FROM booking b " +
                        "JOIN customer c ON b.customer_id = c.customer_id " +
                        "JOIN employee_timeslot et ON et.booking_id = b.booking_id " +
                        "JOIN timeslot t ON et.timeslot_id = t.timeslot_id " +
                        "JOIN booking_status bs ON b.booking_status_id = bs.booking_status_id ";
                    command = new MySqlCommand(query, dBCon.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv.Rows.Add(reader.GetString(5), reader.GetString(0), reader.GetString(2) + " " + reader.GetString(3), reader.GetString(4), "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
