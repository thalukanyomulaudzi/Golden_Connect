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
    public partial class Service_Add : Form
    {
        public Service_Add()
        {
            InitializeComponent();
        }


        private void Button3_Click_1(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void Service_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
