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
    public partial class Audit_Trail_Report : Form
    {
        public Audit_Trail_Report()
        {
            InitializeComponent();
        }
        DBConnection db = DBConnection.Instance();
        Audit_Trail at = new Audit_Trail();
        private void Audit_Trail_Report_Load(object sender, EventArgs e)
        {
            if(db.IsConnect())
            {
                var cmd = new MySqlDataAdapter("SELECT * FROM `audit_trail`", db.Connection);
                //var reader = cmd.ExecuteReader();
                DataSet ds = new DataSet();
                cmd.Fill(ds, "audit_trail");
                at.SetDataSource(ds);
                crystalReportViewer1.ReportSource = at;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
