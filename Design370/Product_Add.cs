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
    public partial class Product_Add : Form
    {
        public Product_Add()
        {
            InitializeComponent();
        }



        private void Button3_Click_1(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
