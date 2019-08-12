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
    public partial class Booking_Add : Form
    {
        public Booking_Add()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Booking_Details bookingDetails = new Booking_Details();
            bookingDetails.Show();
        }

        private void Booking_Add_Load(object sender, EventArgs e)
        {
            
        }
    }
}
