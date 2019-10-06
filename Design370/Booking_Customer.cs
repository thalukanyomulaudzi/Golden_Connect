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
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT customer_id FROM customer WHERE customer_id_number = '" + dgvBookingCustomer.SelectedRows[0].Cells[2].Value.ToString() + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                Booking.customerID = reader.GetString(0);
                reader.Close();

                Booking.customerName = dgvBookingCustomer.SelectedRows[0].Cells[0].Value.ToString() + " " + dgvBookingCustomer.SelectedRows[0].Cells[1].Value.ToString();
                Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
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
                dgvBookingCustomer.Rows.Clear();
                DBConnection dBCon = DBConnection.Instance();
                string query = textBox9.Text == "" ? "SELECT customer_first, customer_last, customer_id_number FROM customer"
                    : "SELECT customer_first, customer_last, customer_id_number FROM customer WHERE customer_first LIKE '%" + textBox9.Text + "%' OR customer_last LIKE '%" + textBox9.Text + "%' OR customer_id_number LIKE '%" + textBox9.Text + "%'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvBookingCustomer.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "View", "Edit", "Delete");
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

        private void DgvBookingAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_View customerView = new Customer_View();
            customerView.customerID = dgvBookingCustomer.SelectedRows[0].Cells[2].Value.ToString();
            switch (e.ColumnIndex)
            {
                case 3:
                    customerView.edit = false;
                    customerView.Show();
                    break;
                case 4:
                    customerView.edit = true;
                    customerView.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBCon = DBConnection.Instance();
                            string query = "DELETE FROM customer WHERE customer_id_number = " + dgvBookingCustomer.SelectedRows[0].Cells[2].Value.ToString();
                            var command = new MySqlCommand(query, dBCon.Connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void Booking_Customer_Activated(object sender, EventArgs e)
        {
            loadDGV();
        }
    }
}
