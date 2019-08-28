using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class Bookings
    {
        public static void loadBookings(System.Windows.Forms.DataGridView dgv, string search = "")
        {
            DBConnection dBCon = DBConnection.Instance();
            if (dBCon.IsConnect())
            {
                string query = "SELECT booking_id FROM booking WHERE";






                query = "SELECT * FROM booking b JOIN customer c ON b.customer_id = c.customer_id WHERE c.customer_last LIKE %" + search + "%";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }
        }
    }
}
