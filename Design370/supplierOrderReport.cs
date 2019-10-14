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
    public partial class supplierOrderReport : Form
    {
        public supplierOrderReport()
        {
            InitializeComponent();
        }
        DBConnection dB = DBConnection.Instance();
        private void SupplierOrderReport_Load(object sender, EventArgs e)
        {
            SupplierOrderReport sp = new SupplierOrderReport();
            if(dB.IsConnect())
            {
                var dkt = DateTime.Now;
                DateTime dates = DateTime.Now;
                var fd = new DateTime(dates.Year, dates.Month, 1);
                var ld = fd.AddMonths(1).AddDays(-1);
                string query = " SELECT supplier_order1.supplier_order_id, supplier_order1.supplier_order_date_placed, product1.product_name, supplier1.supplier_name, supplier_order1.supplier_order_number, supplier_order_line1.supplier_order_line_quantity FROM((golden_connect.supplier_order_line supplier_order_line1 INNER JOIN golden_connect.supplier_order supplier_order1 ON supplier_order_line1.supplier_order_id = supplier_order1.supplier_order_id) INNER JOIN golden_connect.product product1 ON supplier_order_line1.product_id = product1.product_id) INNER JOIN golden_connect.supplier supplier1 ON supplier_order1.supplier_id = supplier1.supplier_id";
                var adapt = new MySqlDataAdapter(query, dB.Connection);
                DataSet dt = new DataSet();
                adapt.Fill(dt, "supplier_order");
                sp.SetDataSource(dt);
                supplierOrderRep.ReportSource = sp;
                supplierOrderRep.Refresh();
            }
        }
    }
}
