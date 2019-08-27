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
        public Supplier_Orders_Add()
        {
            InitializeComponent();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Place Order Button


            this.Close();
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {

            SupplierList list = new SupplierList();
            list.ShowDialog();

            txtSupplierName.Text = Globals.SupplierName;
            txtEmailAddress.Text = Globals.SupplierEmail;
            txtTelephoneNo.Text = Globals.SupplierPhone;

            if (DialogResult == DialogResult.OK)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                dgvOrderProductList.EnableHeadersVisualStyles = true;
                btnPlaceOrder.Enabled = true;
                txtType.Text = "Supplier Order";
            }

        }

        private void Supplier_Orders_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //dgvOrderProductList.Rows.RemoveAt(0);
            ProductList f = new ProductList();
            f.ShowDialog();

            
            string[] row_value = new string[] {Globals.ProductID, Globals.ProductName, Globals.ProductQuantity.ToString(), Globals.ProductTypeName};


            dgvOrderProductList.Rows.Add(row_value);

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrderProductList.SelectedRows)
            {
                dgvOrderProductList.Rows.RemoveAt(row.Index);
            }
        }
    }
}
