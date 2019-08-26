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

        private void Supplier_Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
