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
    public partial class Book_Event_Date : Form
    {
        public Book_Event_Date()
        {
            InitializeComponent();
        }

        private void Book_Event_Date_Load(object sender, EventArgs e)
        {
            Timeslots.loadTimeslots(dgvBookEvent, DateTime.Today);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
