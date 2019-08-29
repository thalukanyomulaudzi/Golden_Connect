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
    public partial class Event_Types_View : Form
    {
        public string GetEventTypeViewRow { get; set; }

        public static bool edit;
        public Event_Types_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtEventTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEventTypeDescription, "A maximum of 200 characters can be entered");
        }

        private void Event_Types_View_Load(object sender, EventArgs e)
        {
            txtEventTypeName.Enabled = edit;
            txtEventTypeDescription.Enabled = edit;
            string Name = "";

            btnEventTypeEdit.Enabled = !edit;
            
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT event_type_name, event_type_description FROM event_type WHERE event_type_name = '" + GetEventTypeViewRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtEventTypeName.Text = reader.GetString(0);
                        txtEventTypeDescription.Text = reader.GetString(1);
                    }
                    reader.Close();
                    Name = txtEventTypeName.Text;
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtEventTypeName.Enabled = true;
            txtEventTypeDescription.Enabled = true;
        }

        private void Event_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtEventTypeName.Enabled)
            {
                DialogResult SaveChanges = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                if (SaveChanges == DialogResult.Yes)
                {
                    if (txtEventTypeName.Text.Length <= 2 || txtEventTypeDescription.Text.Length <= 5)
                    {
                        MessageBox.Show("Invalid character length for name and/or description");
                        return;
                    }
                    try
                    {
                        DBConnection dBConnection = DBConnection.Instance();
                        if (dBConnection.IsConnect())
                        {
                            string booking_type_id = " ";
                            string event_type_id = " ";
                            string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Event'";
                            var command = new MySqlCommand(query, dBConnection.Connection);
                            var reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                booking_type_id = reader.GetString(0);
                            }
                            reader.Close();
                            query = "SELECT event_type_id FROM event_type WHERE event_type_name = '" + Name + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                event_type_id = reader.GetString(0);
                            }
                            reader.Close();
                            query = "UPDATE `event_type` SET `event_type_id` = '" + event_type_id + "', `event_type_name` = '" + txtEventTypeName.Text + "', `event_type_description`";
                            query += " = '" + txtEventTypeDescription.Text + "', `booking_type_id` = '" + booking_type_id + "' WHERE event_type_id = '" + event_type_id + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);

                    }
                }
                else
                {

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtEventTypeName.Enabled)
            {
                if (txtEventTypeName.Text.Length <= 2 || txtEventTypeDescription.Text.Length <= 5)
                {
                    MessageBox.Show("Invalid character length for name and/or description");
                    return;
                }
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        string booking_type_id = " ";
                        string event_type_id = " ";
                        string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Event'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            booking_type_id = reader.GetString(0);
                        }
                        reader.Close();
                        query = "SELECT event_type_id FROM event_type WHERE event_type_name = '" + Name + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        while (reader.Read())
                        {
                            event_type_id = reader.GetString(0);
                        }
                        reader.Close();
                        query = "UPDATE `event_type` SET `event_type_id` = '" + event_type_id + "', `event_type_name` = '" + txtEventTypeName.Text + "', `event_type_description`";
                        query += " = '" + txtEventTypeDescription.Text + "', `booking_type_id` = '" + booking_type_id + "' WHERE event_type_id = '" + event_type_id + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);

                }
                this.Close();
            }
            this.Close();
        }

        private void BtnEditEmpType_Click(object sender, EventArgs e)
        {

        }
    }
}
