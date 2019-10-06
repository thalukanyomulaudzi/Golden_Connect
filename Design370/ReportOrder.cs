using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class ReportOrder : Form
    {
        public ReportOrder()
        {
            InitializeComponent();
        }
        DBConnection dbCon = DBConnection.Instance();
        public int name = 20;
        public int prodCount;
      
        private void ReportOrder_Load(object sender, EventArgs e)
        {
            var dkt = DateTime.Now;
            DateTime dates = DateTime.Now;
            var fd = new DateTime(dates.Year, dates.Month, 1);
            var ld = fd.AddMonths(1).AddDays(-1);
            //MessageBox.Show(fd.ToShortDateString() + " " + ld.ToShortDateString());
            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT COUNT(`order_id`) FROM `order` WHERE `order_date_placed` >= CAST('"+fd.ToString("yyy-M-dd")+ "' AS DATE) AND `order_date_placed` <= CAST('" + ld.ToString("yyy-M-dd") + "' AS DATE)", dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    prodCount = Convert.ToInt32(reader[0]);
                    MessageBox.Show(prodCount.ToString());
                }
                reader.Close();
            }
            CrystalReport1 cs = new CrystalReport1();
            ParameterFields From = new ParameterFields();

            ParameterField TotalProducts = new ParameterField();
            TotalProducts.Name = "pTotalProducts";
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = prodCount.ToString();
            TotalProducts.CurrentValues.Add(val);

            ParameterField StockOnHand = new ParameterField();
            StockOnHand.Name = "pStockOnHand";
            ParameterDiscreteValue val1 = new ParameterDiscreteValue();
            val1.Value = "5";
            StockOnHand.CurrentValues.Add(val1);

            ParameterField OrderTotal = new ParameterField();
            OrderTotal.Name = "pOrderTotal";
            ParameterDiscreteValue val2 = new ParameterDiscreteValue();
            val2.Value = "R25980.00";
            OrderTotal.CurrentValues.Add(val2);

            var date = DateTime.Now;

            ParameterField DAte = new ParameterField();
            DAte.Name = "PDate";
            ParameterDiscreteValue dt = new ParameterDiscreteValue();
            dt.Value = date.ToString("MMMM");
            DAte.CurrentValues.Add(dt);

            From.Add(TotalProducts);
            From.Add(StockOnHand);
            From.Add(OrderTotal);
            From.Add(DAte);

            crystalReportViewer1.ParameterFieldInfo = From;
            crystalReportViewer1.ReportSource = cs;
        }
    }
}
