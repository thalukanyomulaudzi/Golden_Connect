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
    public partial class Photoshoot_Type_Add : Form
    {
        public Photoshoot_Type_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtPhotoshootTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtPhotoshootTypeDescription, "A maximum of 200 characters can be entered");
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string query = "SELECT booking_type_id FROM booking_type WHERE booking_type_name = 'Photoshoot'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        booking_type_id = reader.GetString(0);
                    }
                    reader.Close();
                    query = "INSERT INTO `photoshoot_type` (`photoshoot_type_id`, `photoshoot_type_name`, `photoshoot_type_description`, `booking_type_id`) VALUES";
                    query += "(NULL, '" + txtPhotoshootTypeName.Text + "', '" + txtPhotoshootTypeDescription.Text + "', '" + booking_type_id + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Photoshoot_Type_Add_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Photoshoot_Type_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Photoshoot_Type";
            helpForm.ShowDialog();
        }
    }
}
