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
    public partial class Employee_Add : Form
    {
        public Employee_Add()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Employee_Types employee_Types = new Employee_Types();
            employee_Types.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
