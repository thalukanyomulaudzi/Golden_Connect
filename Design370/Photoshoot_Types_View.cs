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
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 200 characters can be entered");
        }

        private void Photoshoot_Types_View_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;

            if (edit == true)
            {
                button2.Enabled = false;
            }

            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT photoshoot_type_name, photoshoot_type_description FROM photoshoot_type WHERE photoshoot_type_name = '" + GetPhotoshootTypeViewRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = reader.GetString(0);
                        textBox2.Text = reader.GetString(1);
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
            if (textBox1.Enabled)
            {
                if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5)
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
                        string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            booking_type_id = reader.GetString(0);
                        }
                        reader.Close();
                        query = "INSERT INTO `photoshoot_type` (`photoshoot_type_id`, `photoshoot_type_name`, `photoshoot_type_description`, `booking_type_id`) VALUES";
                        query += "(NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + booking_type_id + "')";
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
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void Photoshoot_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Enabled)
            {
                DialogResult SaveChanges = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                if (SaveChanges == DialogResult.Yes)
                {
                    if (textBox1.Text.Length <= 2 || textBox2.Text.Length <= 5)
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
                            string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot'";
                            var command = new MySqlCommand(query, dBConnection.Connection);
                            var reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                booking_type_id = reader.GetString(0);
                            }
                            reader.Close();
                            query = "INSERT INTO `photoshoot_type` (`photoshoot_type_id`, `photoshoot_type_name`, `photoshoot_type_description`, `booking_type_id`) VALUES";
                            query += "(NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + booking_type_id + "')";
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
    }
}
