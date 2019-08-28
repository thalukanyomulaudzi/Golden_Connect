using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Design370
{
    class Bookings
    {
        public static void loadBookings(System.Windows.Forms.DataGridView dgv, string search = "")
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    List<short> bookingIDs = new List<short>();
                    List<DateTime> bookingDates = new List<DateTime>();
                    string query = "SELECT DISTINCT et.booking_id, t.timeslot_date FROM employee_timeslot et JOIN timeslot t ON et.timeslot_id = t.timeslot_id WHERE et.booking_id IS NOT NULL";
                    System.Windows.Forms.MessageBox.Show(query);
                    var command = new MySqlCommand(query, dBCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookingIDs.Add(reader.GetInt16(0));
                        bookingDates.Add(DateTime.Parse(reader.GetString(1)));
                        System.Windows.Forms.MessageBox.Show("Test");
                    }
                    reader.Close();

                    query = search != "" ? "SELECT * FROM booking b JOIN customer c ON b.customer_id = c.customer_id WHERE c.customer_last LIKE %" + search + "%"
                        : "SELECT * FROM booking b JOIN customer c ON b.customer_id = c.customer_id";
                    command = new MySqlCommand(query, dBCon.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void loadEmployeeAvailable(System.Windows.Forms.DataGridView dgv, DateTime dateTime)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();








            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
