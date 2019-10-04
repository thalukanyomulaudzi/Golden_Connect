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
    public partial class Event_Types_Add : Form
    {
        public Event_Types_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtEventTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEventTypeDescription, "A maximum of 200 characters can be entered");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Event'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        booking_type_id = reader.GetString(0);
                    }
                    reader.Close();
                    query = "INSERT INTO `event_type` (`event_type_id`, `event_type_name`, `event_type_description`, `booking_type_id`) VALUES";
                    query += "(NULL, '" + txtEventTypeName.Text + "', '" + txtEventTypeDescription.Text + "', '" + booking_type_id + "')";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Types_Add_Load(object sender, EventArgs e)
        {

        }

        private void Event_Types_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void TxtEventTypeName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEventTypeName, Validation.validate(txtEventTypeName.Text, "name"));
        }

        private void TxtEventTypeDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEventTypeDescription, Validation.validate(txtEventTypeDescription.Text, "name"));
        }
    }
}
