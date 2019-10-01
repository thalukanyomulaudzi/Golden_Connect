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
    public partial class Service_Types_View : Form
    {
        public static bool edit;
        string service_type_id = " ";
        public string GetServiceTypeRow { get; set; }
        public Service_Types_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox1, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(textBox2, "A maximum of 200 characters can be entered");
        }

        private void Service_Types_View_Load(object sender, EventArgs e)
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
                    string query = "SELECT service_type_id, service_type_name, service_type_description FROM service_type WHERE service_type_id = '" + GetServiceTypeRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        service_type_id = reader.GetString(0);
                        textBox1.Text = reader.GetString(1);
                        textBox2.Text = reader.GetString(2);
                    }
                    reader.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = false;
        }

        private void Service_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
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
                        string query = "UPDATE `service_type` SET `service_type_id` = '" + service_type_id + "', `service_type_name` = '" + textBox1.Text + "', `service_type_description`";
                        query += " = '" + textBox2.Text + "' WHERE service_type_id = '" + service_type_id + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
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
    }
}
