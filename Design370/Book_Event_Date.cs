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
            
            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
            row.Cells["Time"].Value = "09:00 - 10:00";
            row.Cells["Monday"].Value = "Available";
            row.Cells["Tuesday"].Value = "Avaliable";
            row.Cells["Wednesday"].Value = "Avaliable";
            row.Cells["Thursday"].Value = "Avaliable";
            row.Cells["Friday"].Value = "Booked";
            row.Cells["Saturday"].Value = "Avaliable";
            row.Cells["Sunday"].Value = "Booked";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
