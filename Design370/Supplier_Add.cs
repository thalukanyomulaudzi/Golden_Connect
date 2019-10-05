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
    public partial class Supplier_Add : Form
    {
        public Supplier_Add()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text.Length <= 2 || txtEmailAddress.Text.Length <= 5 || txtEmailAddress.Text.Length <= 10 || txtTelephoneNo.Text.Length <= 9)
            {
                MessageBox.Show("Invalid character length for one of the inputs");
                return;
            }
            if (cbxSupplierType.SelectedIndex <= -1 )
            {
                MessageBox.Show("Please select a supplier type");
                return;
            }
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    string supplierTypeID = "";
                    string query = "SELECT supplier_type_id FROM supplier_type WHERE supplier_type_name = '" + cbxSupplierType.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    supplierTypeID = reader.GetString(0);
                    reader.Close();
                    query = "INSERT INTO `supplier`(`supplier_id`, `supplier_name`, `supplier_email`, `supplier_phone`, `supplier_location_address`, `supplier_type_id`) VALUES('" +
                                "NULL" + "', '" + txtSupplierName.Text + "', '" + txtEmailAddress.Text + "', '" + txtTelephoneNo.Text + "', '" + txtAddress + "', '" + supplierTypeID + "')";
                    command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        
        }

        private void Supplier_Add_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                string query = "SELECT * FROM supplier_type";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                cbxSupplierType.Items.Clear();
                while (reader.Read())
                {
                    cbxSupplierType.Items.Add(reader.GetString("supplier_type_name"));
                    cbxSupplierType.ValueMember = (reader.GetString("supplier_type_id"));
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
