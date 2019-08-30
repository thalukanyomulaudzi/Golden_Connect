using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Design370
{
    class Timeslot
    {

        const short DaysInWeek = 7;
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
                        reader.Close();
                        return true;
                    }
                    reader.Close();
                }
                return false;
            }
            catch (Exception e)
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
                    for (int i = 0; i < DaysInWeek; i++)//loop 7 times to generate a weeks worth of timeslots
                    {
                        int j;
                        query = "INSERT IGNORE INTO `timeslot` (`timeslot_id`, `timeslot_date`, `timeslot_start`, `timeslot_end`) VALUES ";
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
                }
                linkTimeslots();
                //removeDuplicates();
            }
            catch (Exception e)
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
                        DateTime day = DateTime.Now;
                        for (int i = 0; i < span.TotalDays; i++)
                        {
                            int j;
                            query = "INSERT IGNORE INTO `timeslot` (`timeslot_id`, `timeslot_date`, `timeslot_start`, `timeslot_end`) VALUES ";
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
                    }
                    linkTimeslots();
                    //removeDuplicates();
                }
                else System.Windows.Forms.MessageBox.Show("The time selected is more than the max 180 days away from today");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void loadTimeslots(System.Windows.Forms.DataGridView dgv, DateTime startDay)
        {
            try
            {
                dgv.Rows.Clear();
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    DateTime day = startDay;
                    List<string> available = new List<string>();
                    int i;
                    string query = "";
                    MySqlCommand command;
                    MySqlDataReader reader;
                    DateTime headerDay = day;
                    for (int j = 0; j < DaysInWeek ; j++)
                    {
                        dgv.Columns[j].HeaderText = headerDay.ToString("dddd, MMM dd yyyy");
                        headerDay = headerDay.AddDays(1);
                    }

                    for (i=8;i<10;i++)
                    {
                        query = "SELECT et.available FROM employee_timeslot et JOIN timeslot t ON et.timeslot_id = t.timeslot_id WHERE t.timeslot_date BETWEEN '" + 
                            day.ToString("yyyy'-'MM'-'dd") + "' AND '" + day.AddDays(DaysInWeek).ToString("yyyy'-'MM'-'dd") + "' AND t.timeslot_start = '0" + i + ":00:00'";
                        command = new MySqlCommand(query, dBCon.Connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            available.Add(reader.GetInt16(0) != 0 ? "Available" : "Unavailable");
                        }
                        dgv.Rows.Add(available.ToArray());
                        dgv.Rows[dgv.Rows.Count-1].HeaderCell.Value = "0" + i + ":00:00";
                        available.Clear();
                        reader.Close();
                    }
                    for (i = 10; i < 16; i++)
                    {
                        query = "SELECT a.available FROM employee_timeslot a JOIN timeslot b ON a.timeslot_id = b.timeslot_id WHERE b.timeslot_date BETWEEN '" +
                                    day.ToString("yyyy'-'MM'-'dd") + "' AND '" + day.AddDays(DaysInWeek).ToString("yyyy'-'MM'-'dd") + "' AND timeslot_start = '" + i + ":00:00'";
                        command = new MySqlCommand(query, dBCon.Connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            available.Add(reader.GetBoolean(0) ? "Available" : "Unavailable");
                        }
                        dgv.Rows.Add(available.ToArray());
                        dgv.Rows[dgv.Rows.Count-1].HeaderCell.Value = i + ":00:00";
                        available.Clear();
                        reader.Close();
                    }
                    dgv.TopLeftHeaderCell.Value = "Times";
                    dgv.AutoResizeRowHeadersWidth(System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void clearTimeslots()//deletes old timeslots from the db
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "DELETE FROM timeslot WHERE timeslot_date < CURDATE()";
                var command = new MySqlCommand(query, dBCon.Connection);
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void removeDuplicates()//outdated function
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string query = "DELETE slot1 FROM timeslot slot1 INNER JOIN timeslot slot2 WHERE slot1.timeslot_id > slot2.timeslot_id AND slot1.timeslot_date = slot2.timeslot_date AND slot1.timeslot_start = slot2.timeslot_start";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public static void linkTimeslots()//link timeslots to employees
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                if (dBCon.IsConnect())
                {
                    string query = "SELECT `employee_id` FROM `employee` WHERE `employee_type` = 4";
                    var command = new MySqlCommand(query, dBCon.Connection);
                    var reader = command.ExecuteReader();
                    List<short> employees = new List<short>();
                    while (reader.Read())
                    {
                        employees.Add(reader.GetInt16(0));
                    }
                    reader.Close();
                    query = "SELECT timeslot_id FROM timeslot";
                    command = new MySqlCommand(query, dBCon.Connection);
                    reader = command.ExecuteReader();
                    List<short> timeslots = new List<short>();
                    while (reader.Read())
                    {
                        timeslots.Add(reader.GetInt16(0));
                    }
                    reader.Close();
                    for (int i = 0; i < employees.Count; i++)
                    {
                        for (int j = 0; j < timeslots.Count; )
                        {
                            query = "INSERT IGNORE INTO `employee_timeslot` (`employee_id`, `timeslot_id`, `available`, `booking_id`) VALUES ";
                            switch (timeslots.Count % 10)
                            {
                                case 0:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 9;
                                case 9:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 8;
                                case 8:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 7;
                                case 7:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 6;
                                case 6:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 5;
                                case 5:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 4;
                                case 4:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 3;
                                case 3:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 2;
                                case 2:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL),";
                                    timeslots.RemoveAt(0);
                                    goto case 1;
                                case 1:
                                    query += "('" + employees[i].ToString() + "', '" + timeslots[0] + "', '1', NULL);";
                                    timeslots.RemoveAt(0);
                                    break;
                            }
                            command = new MySqlCommand(query, dBCon.Connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
