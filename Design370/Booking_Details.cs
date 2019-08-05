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
    public partial class Booking_Details : Form
    {
        public Booking_Details()
        {
            InitializeComponent();
        }

        private void Booking_Details_Load(object sender, EventArgs e)
        {
            Booking_Dialog bookingDialog = new Booking_Dialog();
            DialogResult result = bookingDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "Event";
            }
            if (result == DialogResult.No)
            {
                textBox1.Text = "Photoshoot";
            }
            if (result == DialogResult.Cancel)
            {

            }
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            String[] times = { "10:00", "12:00" };
            ComboBox comboBoxTime = new ComboBox();
            comboBoxTime.Items.AddRange(times);
            comboBoxTime.Location = new Point(213, 252);
            comboBoxTime.Width = 100;
            comboBoxTime.Height = 24;
            comboBoxTime.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle == BorderStyle.None)
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox2.BorderStyle = BorderStyle.None;
                pictureBox3.BorderStyle = BorderStyle.None;
                pictureBox4.BorderStyle = BorderStyle.None;
            }
            else if (pictureBox1.BorderStyle == BorderStyle.Fixed3D)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BorderStyle == BorderStyle.None)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                pictureBox3.BorderStyle = BorderStyle.None;
                pictureBox4.BorderStyle = BorderStyle.None;
            }
            else if (pictureBox2.BorderStyle == BorderStyle.Fixed3D)
            {
                pictureBox2.BorderStyle = BorderStyle.None;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BorderStyle == BorderStyle.None)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
                pictureBox2.BorderStyle = BorderStyle.None;
                pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                pictureBox4.BorderStyle = BorderStyle.None;
            }
            else if (pictureBox3.BorderStyle == BorderStyle.Fixed3D)
            {
                pictureBox3.BorderStyle = BorderStyle.None;
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BorderStyle == BorderStyle.None)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
                pictureBox2.BorderStyle = BorderStyle.None;
                pictureBox3.BorderStyle = BorderStyle.None;
                pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (pictureBox4.BorderStyle == BorderStyle.Fixed3D)
            {
                pictureBox4.BorderStyle = BorderStyle.None;
            }
        }

        private void Booking_Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to cancel making the booking?", "Cancel booking", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Booking_Dialog bookingDialog = new Booking_Dialog();
            DialogResult result = bookingDialog.ShowDialog();

            textBox1.Text = result == DialogResult.Yes ? "Event" : "Photoshoot";
        }
    }
}
