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
    public partial class Supplier_Orders_Add : Form
    {
        public Supplier_Orders_Add(string supplier_name, string supplier_email,string supplier_phone)
        {
            InitializeComponent();
            txtSupplierName.Text = supplier_name;
            txtEmailAddress.Text = supplier_email;
            txtTelephoneNo.Text = supplier_phone;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            SupplierList list = new SupplierList();
            list.ShowDialog();
        }

        private void Supplier_Orders_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductList f = new ProductList();
            f.ShowDialog();
        }
    }
}
