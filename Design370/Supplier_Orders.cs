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
        string supplier_name = "";
        string supplier_email ="";
        string supplier_phone ="";
        public Supplier_Orders()
        {
            InitializeComponent();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Supplier_Orders_Add supplier_Orders_Add = new Supplier_Orders_Add(supplier_name,  supplier_email,  supplier_phone);
            supplier_Orders_Add.Show();
        }


    }
}
