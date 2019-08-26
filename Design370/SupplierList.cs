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
    public partial class SupplierList : Form
    {
      
        public SupplierList()
        {
            InitializeComponent();
        }
 
        private void SupplierList_Load(object sender, EventArgs e)
        {
            using (MysqlConnection.mysqlCon)
            {
                MysqlConnection.mysqlCon.Open();

                string sql = "SELECT supplier_id, supplier_name,supplier_email, supplier_phone, supplier_location_address FROM supplier";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, MysqlConnection.mysqlCon);
                DataTable dtb1 = new DataTable();
                adapter.Fill(dtb1);
                //dtb1.Columns.Add("View");
                //for (int i = 0; i < dtb1.Rows.Count; i++)
                //{
                //    dtb1.Rows[i]["View"] = "View";
                //}

                dgvSupplierList.DataSource = dtb1;
            }
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
           
            Supplier_Orders_Add sd = new Supplier_Orders_Add();

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
