using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class Timeslots
    {
        public static bool timeslotExists(DateTime dateTime)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string dateTimeString = dateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
                    short pos = (short)dateTimeString.IndexOf('T');
                    string dateString = dateTimeString.Remove(pos);
                    string timeString = dateTimeString.Substring(pos + 1);
                    System.Windows.Forms.MessageBox.Show(dateString + " " + timeString);
                    string query = "SELECT * FROM timeslot WHERE timeslot_date = '" + dateString + "' AND timeslot_start = '" + timeString + "'";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dBCon.Close();
                        return true;
                    }
                    dBCon.Close();
                }
                return false;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        public static void generateTimeslotsAround(DateTime dateTime)//this function generates timeslots for a week centered around the datetime given
        {
            try
            {
                TimeSpan span = dateTime.Subtract(DateTime.Now);
                while (span.TotalDays < 3)//pad out start date to accomodate for timeslots close to the current date 
                {
                    dateTime.AddDays(1);
                }
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    DateTime startDay = dateTime.Subtract(TimeSpan.FromDays(3));
                    string query = "";
                    DateTime day = dateTime;
                    for (int i = 0; i < 7; i++)//loop 7 times to generate a weeks worth of timeslots
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
                        var command = new MySqlCommand(query, dBCon.Connection);
                        command.ExecuteNonQuery();
                    }
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
                    DBConnection dBCon = DBConnection.Instance();
                    if (dBCon.IsConnect())
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
                            System.Windows.Forms.MessageBox.Show(query);
                            day = day.AddDays(1);
                            var command = new MySqlCommand(query, dBCon.Connection);
                            command.ExecuteNonQuery();
                        }
                        dBCon.Close();
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
        public static void loadTimeslots(System.Windows.Forms.DataGridView dgv)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string query = "SELECT * FROM";
                    var command = new MySqlCommand(query, dBCon.Connection);



                    dgv.Rows.Add();
                }
                

            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void clearTimeslots()
        {
            
        }
        public static void removeDuplicates()
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string query = "DELETE slot1 FROM timeslot slot1 INNER JOIN timeslot slot2 WHERE slot1.timeslot_id > slot2.timeslot_id AND slot1.timeslot_date = slot2.timeslot_date AND slot1.timeslot_start = slot2.timeslot_start;";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    command.ExecuteReader();
                    dBCon.Close();
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }










        public static void dummy()
        {
            DBConnection dbcon = DBConnection.Instance();
            if (dbcon.IsConnect())
            {
                string query = "Select booking_package_id FROM booking_package;";
                var command = new MySqlCommand(query, dbcon.Connection);
                var reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    System.Windows.Forms.MessageBox.Show(table.Rows[i].ItemArray[0].ToString());
                }
                dbcon.Close();
            }
        }
    }
}
