using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class Event_Types_View : Form
    {
        public static bool edit;
        public Event_Types_View()
        {
            InitializeComponent();
        }

        private void Event_Types_View_Load(object sender, EventArgs e)
        {
            txtEmpTypeName.Enabled = edit;
            txtEmpTypeDescription.Enabled = edit;
        }

        private void Event_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtEmpTypeName.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditEmpType_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
