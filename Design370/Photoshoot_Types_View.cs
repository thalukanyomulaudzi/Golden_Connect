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
    public partial class Photoshoot_Types_View : Form
    {
        public string GetPhotoshootTypeViewRow { get; set; }

        public static bool edit;

        public Photoshoot_Types_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtPhotoshootTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtPhotoshootTypeDescription, "A maximum of 200 characters can be entered");
        }

        private void Photoshoot_Types_View_Load(object sender, EventArgs e)
        {
            txtPhotoshootTypeName.Enabled = edit;
            txtPhotoshootTypeDescription.Enabled = edit;

            if (edit == true)
            {
                button2.Enabled = false;
            }

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT photoshoot_type_name, photoshoot_type_description FROM photoshoot_type WHERE photoshoot_type_id = '" + GetPhotoshootTypeViewRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtPhotoshootTypeName.Text = reader.GetString(0);
                        txtPhotoshootTypeDescription.Text = reader.GetString(1);
                    }
                    reader.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPhotoshootTypeName.Enabled)
            {
                if (!Validation.validate(txtPhotoshootTypeName.Text, "name") || !Validation.validate(txtPhotoshootTypeDescription.Text, "name"))
                {
                    MessageBox.Show("All input fields must be valid");
                    return;
                }
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        string booking_type_id = " ";
                        string photoshoot_type_id = " ";
                        string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            booking_type_id = reader.GetString(0);
                        }
                        reader.Close();
                        query = "SELECT photoshoot_type_id FROM photoshoot_type WHERE photoshoot_type_name = '" + Name + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        reader.Read();
                        while (reader.Read())
                        {
                            photoshoot_type_id = reader.GetString(0);
                        }
                        reader.Close();
                        query = "UPDATE `photoshoot_type` SET `photoshoot_type_id` = '" + photoshoot_type_id + "', `photoshoot_type_name` = '" + txtPhotoshootTypeName.Text + "', `photoshoot_type_description`";
                        query += " = '" + txtPhotoshootTypeDescription.Text + "', `booking_type_id` = '" + booking_type_id + "' WHERE photoshoot_type_id = '" + photoshoot_type_id + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtPhotoshootTypeName.Enabled = true;
            txtPhotoshootTypeDescription.Enabled = true;
            button2.Enabled = false;
        }

        private void Photoshoot_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void TxtPhotoshootTypeName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPhotoshootTypeName, Validation.validate(txtPhotoshootTypeName.Text, "name"));
        }

        private void TxtPhotoshootTypeDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPhotoshootTypeDescription, Validation.validate(txtPhotoshootTypeDescription.Text, "name"));
        }
    }
}
