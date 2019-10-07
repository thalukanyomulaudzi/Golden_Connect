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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        DBConnection db = DBConnection.Instance();
        List<ProductsOnHand> _list = new List<ProductsOnHand>();
       // ProductsOnHand report = new ProductsOnHand();
        //InvReport c = new InvReport();
        private void InventoryReport_Load(object sender, EventArgs e)
        {
            //c.SetDataSource(bindingSource1.DataSource);
            //rChat.ReportSource = c;
            //rChat.Refresh();
            //List<InventoryReport> _list = db.Query<InventoryReport>(query, CommandType.Text).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

    }
}
