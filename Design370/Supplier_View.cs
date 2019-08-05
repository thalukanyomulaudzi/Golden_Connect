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
    public partial class Supplier_View : Form
    {
        public static bool edit;
        public Supplier_View()
        {
            InitializeComponent();
        }

        private void Supplier_View_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = edit;
            textBox6.Enabled = edit;
            textBox7.Enabled = edit;
            textBox9.Enabled = edit;
            comboBox1.Enabled = edit;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox9.Enabled = true;
            comboBox1.Enabled = true;        }

        private void Supplier_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox5.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
