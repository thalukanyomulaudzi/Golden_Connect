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
    public partial class Event_Types : Form
    {
        public Event_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Event_Types_Add event_Types_Add = new Event_Types_Add();
            event_Types_Add.Show();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Event_Types_View event_Types_View = new Event_Types_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Event_Types_View.edit = false;
                    event_Types_View.Show();
                    break;
                case 3:
                    Event_Types_View.edit = true;
                    event_Types_View.Show();
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

        private void Event_Types_Load(object sender, EventArgs e)
        {

        }
    }
}
