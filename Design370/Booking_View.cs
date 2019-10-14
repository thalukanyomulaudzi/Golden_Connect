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
    public partial class Booking_View : Form
    {
        public static bool edit;
        public string GetBookingRow { get; set; }
        public Booking_View()
        {
            InitializeComponent();
        }

        private void Booking_View_Load(object sender, EventArgs e)
        {
            txtBookingCustomer.Enabled = edit;
            txtBookingEmployee.Enabled = edit;
            txtBookingLocation.Enabled = edit;
            txtBookingTime.Enabled = edit;
            txtBookingTotal.Enabled = edit;
            dgvProducts.Enabled = edit;
            dgvServices.Enabled = edit;
            dgvProductsInPackage.Enabled = edit;
            dgvServicesInPackage.Enabled = edit;
            cmbBookingPackage.Enabled = edit;
            numBookingGuests.Enabled = edit;
            btnBookingChangeCustomer.Enabled = edit;
            btnBookingChangeDateEmployee.Enabled = edit;
            btnBookingEdit.Enabled = !edit;
        }

        private void btnBookingEdit_Click(object sender, EventArgs e)
        {
            txtBookingCustomer.Enabled = true;
            txtBookingEmployee.Enabled = true;
            txtBookingLocation.Enabled = true;
            txtBookingTime.Enabled = true;
            txtBookingTotal.Enabled = true;
            dgvProducts.Enabled = true;
            dgvServices.Enabled = true;
            dgvProductsInPackage.Enabled = true;
            dgvServicesInPackage.Enabled = true;
            cmbBookingPackage.Enabled = true;
            numBookingGuests.Enabled = true;
            btnBookingChangeCustomer.Enabled = true;
            btnBookingChangeDateEmployee.Enabled = true;
            btnBookingEdit.Enabled = false;
        }
    }
}
