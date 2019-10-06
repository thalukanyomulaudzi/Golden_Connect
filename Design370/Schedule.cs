using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Design370
{
    class Schedule
    {
        List<List<string>> scheduleTable = new List<List<string>>();
        List<string> scheduleList = new List<string>();

        public static void loadSchedule(System.Windows.Forms.DataGridView dgv, DateTime startDay)
        {
            DBConnection dBCon = DBConnection.Instance();

            string start = startDay.ToString("yyyy'-'MM'-'dd");
            string end = startDay.AddDays(7).ToString("yyyy'-'MM'-'dd");
            string query = "SELECT schedule_date, schedule_start_time, schedule_end_time, schedule_employee " +
                "FROM schedule WHERE schedule_date BETWEEN '" + start + "' AND '" + end + "'";
            var command = new MySqlCommand(query, dBCon.Connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

            }
            reader.Close();
        }
    }
}
