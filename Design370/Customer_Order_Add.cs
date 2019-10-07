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
    public partial class Customer_Order_Add : Form
    {
        public Customer_Order_Add()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Customer_Order_Details customerOrderDetails = new Customer_Order_Details();
            customerOrderDetails.Show();
        }

        private void Customer_Order_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Place_Customer_Order";
            helpForm.ShowDialog();
        }
    }
}
