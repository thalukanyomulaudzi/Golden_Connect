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
    public partial class Product_Types : Form
    {
        public Product_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Product_Type_Add product_Type_Add = new Product_Type_Add();
            product_Type_Add.Show();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_Types_View product_Types_View = new Product_Types_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Product_Types_View.edit = false;
                    product_Types_View.Show();
                    break;
                case 3:
                    Product_Types_View.edit = true;
                    product_Types_View.Show();
                    break;
                case 4:
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
