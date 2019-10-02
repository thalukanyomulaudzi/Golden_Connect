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
    public partial class ReportsExample : Form
    {
        public ReportsExample()
        {
            InitializeComponent();
        }
        DBConnection db = DBConnection.Instance();
        private void ReportsExample_Load(object sender, EventArgs e)
        {
            if (db.IsConnect())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `customer1`", db.Connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet set = new DataSet();
                adapter.Fill(set, "customer");
                CrystalReport1 rep = new CrystalReport1();
                rep.SetDataSource(set);
                crystalReportViewer1.ReportSource = rep;
                crystalReportViewer1.Refresh();
                db.Close();
            }
        }
    }
}
