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

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvBookEvent.Rows.Clear();
            TimeSpan span = (dateTimePicker1.Value.Subtract(DateTime.Now));
            MessageBox.Show(span.TotalDays.ToString());
            if (span.TotalDays <= 2)
                Timeslots.loadTimeslots(dgvBookEvent, DateTime.Now);
            else
                Timeslots.loadTimeslots(dgvBookEvent, dateTimePicker1.Value.Subtract(TimeSpan.FromDays(3)));
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Booking_Dialog bookingDialog = new Booking_Dialog();
            bookingDialog.Show();
        }

        private void DgvBookEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
