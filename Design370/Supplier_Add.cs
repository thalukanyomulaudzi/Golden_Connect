using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
            if (!Validation.validate(txtSupplierName.Text, "name") || !Validation.validate(txtSupplierPhone.Text, "phone") || !Validation.validate(txtSupplierEmail.Text, "email"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }

            if (cbxSupplierType.SelectedIndex <= -1)
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
                    query = "INSERT INTO `supplier`( `supplier_name`,`supplier_email`, `supplier_phone`, `supplier_location_address`, `supplier_type_id`) VALUES('" +
                                 txtSupplierName.Text + "', '" + txtSupplierEmail.Text + "', '" + txtSupplierPhone.Text + "', '" + txtAddress.Text + "', '" + supplierTypeID + "')";
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

        private void TxtSupplierName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblSupplierName, Validation.validate(txtSupplierName.Text, "name"));
        }

        private void TxtTelephoneNo_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblSupplierPhone, Validation.validate(txtSupplierPhone.Text, "phone"));
        }

        private void TxtSupplierEmail_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblSupplierEmail, Validation.validate(txtSupplierEmail.Text, "email"));
        }
    }
}
