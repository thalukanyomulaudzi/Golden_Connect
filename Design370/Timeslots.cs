using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class Timeslots
    {

        public static void generateTimeslotsAround(DateTime dateTime)//this function generates timeslots for a week centered around the datetime given
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {








                    dBCon.Close();
                }
                removeDuplicates();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void generateTimeslotsUpTo(DateTime dateTime)//generated timeslots up to a date, max range 180 days
        {
            try
            {
                TimeSpan span = dateTime.Subtract(DateTime.Now);
                if (span.TotalDays < 0)
                {
                    System.Windows.Forms.MessageBox.Show("That day is in the past, please select a date in the future");//prevent generating timeslots for the past
                    return;
                }
                if (span.TotalDays < 180)
                {
                    DBConnection dBcon = DBConnection.Instance();
                    if (dBcon.IsConnect())
                    {
                        string query;
                        DateTime day = dateTime;
                        for (int i = 0; i < span.TotalDays; i++)
                        {
                            int j;
                            query = "INSERT INTO `timeslot` (`timeslot_id`, `timeslot_date`, `timeslot_start`, `timeslot_end`) VALUES ";
                            query += "(NULL, '" + day.ToString("yyyy'-'MM'-'dd") + "', '08:00:00', '09:00:00'),(NULL, '" + day.ToString("yyyy'-'MM'-'dd") + "', '09:00:00', '10:00:00'),";
                            for (j = 10; j < 16; j++)
                            {
                                query += "(NULL, '" + day.ToString("yyyy'-'MM'-'dd") + "', '" + j + ":00:00', '" + (j + 1) + ":00:00'),";
                            }
                            query = query.Remove(query.Length - 1);
                            query += ";";
                            day = day.AddDays(1);
                            var command = new MySqlCommand(query, dBcon.Connection);
                            command.ExecuteNonQuery();
                        }
                        dBcon.Close();
                    }
                    removeDuplicates();
                }
                else System.Windows.Forms.MessageBox.Show("The time selected is more than the max 180 days away from today");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void loadTimeslots()
        {
            
        }
        public static void clearTimeslots()
        {
            
        }
        public static void removeDuplicates()
        {
            try
            {
                DBConnection dBcon = DBConnection.Instance();
                if (dBcon.IsConnect())
                {
                    string query = "DELETE slot1 FROM timeslot slot1 INNER JOIN timeslot slot2  WHERE slot1.timeslot_id > slot2.timeslot_id AND slot1.timeslot_date = slot2.timeslot_date AND slot1.timeslot_start = slot2.timeslot_start;";
                    var command = new MySqlCommand(query, dBcon.Connection);
                    command.ExecuteNonQuery();
                    dBcon.Close();
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
