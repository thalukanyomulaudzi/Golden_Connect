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
using System.Globalization;

namespace Design370
{
    public partial class CustomerReportList : Form
    {
        public CustomerReportList()
        {
            InitializeComponent();
        }

        DBConnection connection = DBConnection.Instance();
        public int monthNum;
        private void CustomerReportList_Load(object sender, EventArgs e)
        {
           
        }
        public List<_Customers> _clist = new List<_Customers>();
        customersRep csrep = new customersRep();
        private void CbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DateTime dates = DateTime.Now;
            monthNum = Convert.ToDateTime("01-" + cbxMonth.SelectedItem.ToString() + "-2019").Month;
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cbxMonth.SelectedIndex > -1)
            {
                var dkt = DateTime.Now;
                if (monthNum > dkt.Month)
                {
                    MessageBox.Show("Cannot yet generate a report for that month", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    csrep.Close();
                    _clist.Clear();
                    customerReport.ReportSource = null;
                    customerReport.Refresh();
                    DateTime dates = DateTime.Now;
                    csrep = new customersRep();
                    var fd = new DateTime(dates.Year, monthNum, 1);
                    var ld = fd.AddMonths(1).AddDays(-1);
                    if (connection.IsConnect())
                    {

                        var command = new MySqlCommand("SELECT * FROM `customer` WHERE `custoemr_join_date` BETWEEN '" + fd.ToString("yyyy-M-dd") + "' AND '" + ld.ToString("yyyy-M-dd") + "'", connection.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            _clist.Add(new _Customers(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                            _clist.ToList();
                        }
                        reader.Close();
                        bindingSource1.DataSource = _clist;
                        csrep.SetDataSource(bindingSource1.DataSource);
                        csrep.SetParameterValue("pMonth", (cbxMonth.SelectedItem.ToString()).ToUpper());
                        customerReport.ReportSource = csrep;
                        customerReport.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select month to generate a report", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
