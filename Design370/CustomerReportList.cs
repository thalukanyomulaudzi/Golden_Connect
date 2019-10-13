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
                var st = dtStart.Value.Date.ToString("yyyy-M-dd");
                var end = dtEnd.Value.Date.ToString("yyyy-M-dd");
                var command = new MySqlCommand("SELECT * FROM `customer` WHERE `customer_join_date` BETWEEN ` CAST('"+dtStart+"' AS DATE) AND CAST('"+dtEnd+"' AS DATE)", connection.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {

                }
                customerReport.ReportSource = cr;
                customerReport.Refresh();
            }
        }
    }
}
