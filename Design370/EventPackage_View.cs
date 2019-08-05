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
    public partial class EventPackage_View : Form
    {
        public static bool edit;
        public EventPackage_View()
        {
            InitializeComponent();
        }

        private void EventPackage_View_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = edit;
            textBox2.Enabled = edit;
            listBox1.Enabled = edit;
            listBox2.Enabled = edit;
            listBox3.Enabled = edit;
            listBox4.Enabled = edit;
            button1.Enabled = edit;
            button2.Enabled = edit;
            button3.Enabled = edit;
            button4.Enabled = edit;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            listBox3.Enabled = true;
            listBox4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void EventPackage_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
