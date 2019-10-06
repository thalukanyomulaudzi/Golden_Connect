using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Timeslot_Add : Form
    {
        public Timeslot_Add()
        {
            InitializeComponent();
        }

        private void Timeslot_Add_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(30);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Timeslot.generateTimeslotsUpTo(dateTimePicker1.Value);
        }
    }
}
