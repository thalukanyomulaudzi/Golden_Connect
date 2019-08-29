using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Booking_Customer : Form
    {
        public Booking_Customer()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Booking.customerName = dgvBookingAdd.SelectedRows[0].Cells[0].Value.ToString() + " " + dgvBookingAdd.SelectedRows[0].Cells[1].Value.ToString();
            Dispose();
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
                    dgvBookingAdd.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Booking_Customer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
