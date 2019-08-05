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
    public partial class Employee_Types : Form
    {
        public Employee_Types()
        {
            InitializeComponent();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Employee_Types_Add employee_Types_Add = new Employee_Types_Add();
            employee_Types_Add.Show();
        }
    }
}
