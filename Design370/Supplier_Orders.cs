using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design370
{
    public partial class Supplier_Orders : Form
    {
        public Supplier_Orders()
        {
            InitializeComponent();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Supplier_Orders_Add supplier_Orders_Add = new Supplier_Orders_Add();
            supplier_Orders_Add.Show();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierOrders_View supplier_Orders_View = new SupplierOrders_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    SupplierOrders_View.edit = false;
                    supplier_Orders_View.Show();
                    break;
                case 4:
                    SupplierOrders_View.edit = true;
                    supplier_Orders_View.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
