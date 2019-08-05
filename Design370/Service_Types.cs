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
    public partial class Service_Types : Form
    {
        public Service_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Service_Types_Add service_Types_Add = new Service_Types_Add();
            service_Types_Add.Show();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_Types_View service_Types_View = new Service_Types_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Service_Types_View.edit = false;
                    service_Types_View.Show();
                    break;
                case 3:
                    Service_Types_View.edit = true;
                    service_Types_View.Show();
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
