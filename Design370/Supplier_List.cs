using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Design370
{
    public partial class Supplier_List : Form
    {

        public Supplier_List()
        {
            InitializeComponent();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT supplier_id, supplier_name,supplier_email, supplier_phone, supplier_location_address FROM supplier";
                var adapter = new MySqlDataAdapter(query, dBCon.Connection);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvSupplierList.DataSource = table;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {

            Supplier_Orders_Add sd = new Supplier_Orders_Add();
            Globals.SupplierID = dgvSupplierList.SelectedRows[0].Cells[0].Value.ToString();
            Globals.SupplierName = dgvSupplierList.SelectedRows[0].Cells[1].Value.ToString();
            Globals.SupplierEmail = dgvSupplierList.SelectedRows[0].Cells[2].Value.ToString();
            Globals.SupplierPhone = dgvSupplierList.SelectedRows[0].Cells[3].Value.ToString();

            sd.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
