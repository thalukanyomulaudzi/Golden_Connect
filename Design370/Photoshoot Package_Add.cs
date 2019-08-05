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
    public partial class Photoshoot_Package_Add : Form
    {
        public Photoshoot_Package_Add()
        {
            InitializeComponent();
        }

        private void Photoshoot_Package_Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox3.SelectedItem.ToString());
            listBox3.Items.RemoveAt(listBox3.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox4.SelectedItem.ToString());
            listBox4.Items.RemoveAt(listBox4.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }
    }
}
