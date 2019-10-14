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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Design370
{
    public partial class inventory_Stock_On_Hand : Form
    {
        public inventory_Stock_On_Hand()
        {
            InitializeComponent();
        }
        List<Products> pList = new List<Products>();
        StockOnHand stockRep = new StockOnHand();
        DBConnection db = DBConnection.Instance();
        private void Inventory_Stock_On_Hand_Load(object sender, EventArgs e)
        {
            if(db.IsConnect())
            {
                var command = new MySqlCommand("SELECT `product_name`, `product_stock_quantity` FROM `product`,`product_type` WHERE `product`.`product_type_id` = `product_type`.`product_type_id` " +
                    "AND `product_type`.`product_type_name` = 'Customer Order'", db.Connection);
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    pList.Add(new Products(reader[0].ToString(), Convert.ToInt32(reader[1])));
                    pList.ToList();
                }
                reader.Close();
                bindingSource1.DataSource = pList;
                stockRep.SetDataSource(bindingSource1.DataSource);
                inventoryStock.ReportSource = stockRep;
                inventoryStock.Refresh();
            }
        }
    }
}
