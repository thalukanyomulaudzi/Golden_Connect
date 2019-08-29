using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class Event_Types : Form
    {
        public Event_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Event_Types_Add event_Types_Add = new Event_Types_Add();
            event_Types_Add.ShowDialog();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eventTypeName = "";
            Event_Types_View event_Types_View = new Event_Types_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Event_Types_View.edit = false;
                    eventTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    event_Types_View.GetEventTypeViewRow = eventTypeName;
                    event_Types_View.ShowDialog();
                    break;
                case 3:
                    Event_Types_View.edit = true; eventTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    event_Types_View.GetEventTypeViewRow = eventTypeName;
                    event_Types_View.ShowDialog();
                    break;
                case 4:
                    eventTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    event_Types_View.GetEventTypeViewRow = eventTypeName;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string eventTypeID = "";
                                string query = "SELECT event_type_id FROM event_type WHERE event_type_name = '" + eventTypeName + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                reader.Read();
                                eventTypeID = reader.GetString(0);
                                reader.Close();
                                query = "DELETE FROM `event_type` WHERE event_type_id = '" + eventTypeID + "'";
                                command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception except)
                        {
                            System.Windows.Forms.MessageBox.Show(except.Message);
                        }
                        dataGridView7.Rows.Clear();
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string eventTypeName1 = " ";
                                string eventTypeDescription = " ";
                                DataTable EventTypes = new DataTable();
                                string query = "SELECT event_type_name, event_type_description FROM event_type";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                EventTypes.Load(reader);
                                for (int i = 0; i < EventTypes.Rows.Count; i++)
                                {
                                    eventTypeName1 = EventTypes.Rows[i].ItemArray[0].ToString();
                                    eventTypeDescription = EventTypes.Rows[i].ItemArray[1].ToString();
                                    dataGridView7.Rows.Add(eventTypeName1, eventTypeDescription, "View", "Edit", "Delete");
                                }
                                reader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);

                        }
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void Event_Types_Load(object sender, EventArgs e)
        {
            
        }

        private void Event_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string eventTypeName = " ";
                    string eventTypeDescription = " ";
                    DataTable EventTypes = new DataTable();
                    string query = "SELECT event_type_name, event_type_description FROM event_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    EventTypes.Load(reader);
                    for (int i = 0; i < EventTypes.Rows.Count; i++)
                    {
                        eventTypeName = EventTypes.Rows[i].ItemArray[0].ToString();
                        eventTypeDescription = EventTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(eventTypeName, eventTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    dataGridView7.Rows.Clear();
                    string eventTypeName = " ";
                    string eventTypeDescription = " ";
                    DataTable EventType = new DataTable();
                    string query = "SELECT event_type_name, event_type_description FROM event_type WHERE event_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "event_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    EventType.Load(reader);
                    for (int i = 0; i < EventType.Rows.Count; i++)
                    {
                        eventTypeName = EventType.Rows[i].ItemArray[0].ToString();
                        eventTypeDescription = EventType.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(eventTypeName, eventTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
        }
    }
}
