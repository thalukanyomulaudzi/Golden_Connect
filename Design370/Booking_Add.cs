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
    public partial class Booking_Add : Form
    {
        public Booking_Add()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Book_Event_Date bookEventDate = new Book_Event_Date();
            bookEventDate.ShowDialog();
        }

        private void Booking_Add_Load(object sender, EventArgs e)
        {
            loadDGV();
            
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            loadDGV();
        }
        private void loadDGV()
        {
            try
            {
                dgvBookingAdd.Rows.Clear();
                DBConnection dBCon = DBConnection.Instance();
                string query = textBox9.Text == "" ? "SELECT customer_first, customer_last, customer_id_number FROM customer"
                    : "SELECT customer_first, customer_last, customer_id_number FROM customer WHERE customer_first LIKE '%" + textBox9.Text + "%' OR customer_last LIKE '%" + textBox9.Text + "%' OR customer_id_number LIKE '%" + textBox9.Text + "%'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvBookingAdd.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
