using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Design370
{
    class Customer
    {
        public static DBConnection dbCon = DBConnection.Instance();
        public static string CustomerID { get; set; }

        public static void LoadCustomer(DataGridView dgvCus)
        {
            try
            {
                DataTable Customer = new DataTable();
                string query = "SELECT customer_id, customer_id_number, customer_last, customer_first, customer_phone, customer_email FROM customer";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                Customer.Load(reader);
                dgvCus.Rows.Clear();
                for (int i = 0; i < Customer.Rows.Count; i++)
                {
                    dgvCus.Rows.Add(Customer.Rows[i].ItemArray[0], Customer.Rows[i].ItemArray[1], Customer.Rows[i].ItemArray[2] + ", " + Customer.Rows[i].ItemArray[3],
                        Customer.Rows[i].ItemArray[4], Customer.Rows[i].ItemArray[5], "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void SearchCustomer(DataGridView dgvCus)
        {
            try
            {
                DataTable Customer = new DataTable();
                string query = "SELECT customer_id, customer_id_number, customer_last, customer_first, customer_phone, customer_email FROM customer WHERE customer_id_number LIKE " +
                    "'%" + CustomerID + "%' OR customer_last LIKE '%" + CustomerID + "%' OR customer_first LIKE '%" + CustomerID + "%'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                Customer.Load(reader);
                for (int i = 0; i < Customer.Rows.Count; i++)
                {
                    dgvCus.Rows.Add(Customer.Rows[i].ItemArray[0], Customer.Rows[i].ItemArray[1], Customer.Rows[i].ItemArray[2] + ", " + Customer.Rows[i].ItemArray[3],
                        Customer.Rows[i].ItemArray[4], Customer.Rows[i].ItemArray[5], "View", "Edit", "Delete");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void deleteCustomer(DataGridView dgvCus)
        {
            try
            {
                string query = "DELETE FROM `customer` WHERE customer_id = '" + CustomerID + "'";
                var command = new MySqlCommand(query, dbCon.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                System.Windows.Forms.MessageBox.Show(except.Message);
            }
        }
    }
}
