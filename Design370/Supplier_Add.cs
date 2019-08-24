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

            using (MysqlConnection.mysqlCon)
            {
                MySqlCommand mysqlCmd = new MySqlCommand("SELECT * FROM supplier_type", MysqlConnection.mysqlCon);

                MysqlConnection.mysqlCon.Open();
                MySqlDataReader mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                {
                    cbxSupplierType.Items.Add(mysqlReader["suppleir_type_name"].ToString());
                    cbxSupplierType.ValueMember = (mysqlReader["supplier_type_id"].ToString());

                }

                mysqlReader.Close();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.cbxSupplierType.SelectedIndex + 1;

            string prodInsert = "INSERT INTO supplier(supplier_name, supplier_email, supplier_phone, supplier_location_address, supplier_type_id) VALUES('" +
                                txtSupplierName.Text + "', '" + txtEmailAddress.Text + "', '" + txtTelephoneNo.Text + "', '" + txtAddress.Text + "', '" + 
                                selectedIndex.ToString() + "')";
            MysqlConnection.cmd = new MySqlCommand(prodInsert, MysqlConnection.mysqlCon);
            try
            {
                MysqlConnection.mysqlCon.Open();
                MySqlDataReader checkIfExist = MysqlConnection.cmd.ExecuteReader();
                if (checkIfExist.HasRows)
                {
                    MessageBox.Show("Supplier already exits!");
                }
                else
                {
                    MessageBox.Show("New Supplier Inserted!");
                    MysqlConnection.mysqlCon.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
            }
            this.Close();
        }
    }
}
