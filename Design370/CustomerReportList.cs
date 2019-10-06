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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Design370
{
    public partial class CustomerReportList : Form
    {
        public CustomerReportList()
        {
            InitializeComponent();
        }
        DBConnection connection = DBConnection.Instance();
        private void CustomerReportList_Load(object sender, EventArgs e)
        {
            var dkt = DateTime.Now;
            DateTime dates = DateTime.Now;
            var fd = new DateTime(dates.Year, dates.Month, 1);
            var ld = fd.AddMonths(1).AddDays(-1);
            CustomerReport cr = new CustomerReport();
            if(connection.IsConnect())
            {
                var adpt = new MySqlDataAdapter("SELECT * FROM `customer`", connection.Connection);
                DataSet dt = new DataSet();
                adpt.Fill(dt, "customer");
                cr.SetDataSource(dt);
                cr.SetParameterValue("pStartDate", dkt.ToString("MMMM"));
                //cr.SetParameterValue("pEndDate", ld.ToString("yyyy-M-dd"));
                customerReport.ReportSource = cr;
                customerReport.Refresh();
            }
        }
    }
}
