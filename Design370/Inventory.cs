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
    public partial class Inventory : Form
    {
        DBConnection db = DBConnection.Instance();
        List<ProductsOnHand> _list = new List<ProductsOnHand>();
        //ProductsOnHand report = new ProductsOnHand();
        public Inventory()
        { 
            InitializeComponent();
        }
        inventoryReport rep = new inventoryReport();
        private void Inventory_Load(object sender, EventArgs e)
        {
            string query = "SELECT `product_name`, `product_stock_quantity` FROM `product` WHERE `product_type_id` = '4'";
            if (db.IsConnect())
            {
                var cmd = new MySqlCommand(query, db.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    _list.Add(new ProductsOnHand(reader[0].ToString(), Convert.ToInt32(reader[1])));
                    _list.ToList();
                }
                reader.Close();
            }
            productsOnHandBindingSource1.DataSource = _list;
            rep.SetDataSource(productsOnHandBindingSource1.DataSource);
            inv.ReportSource = rep;
            inv.Refresh();
        }
    }
}
