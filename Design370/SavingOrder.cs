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
    public partial class SavingOrder : Form
    {
        public SavingOrder()
        {
            InitializeComponent();
        }

        private void SavingOrder_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            saveOrder.Increment(2);
            if(saveOrder.Value == 100)
            {
                timer1.Stop();
                //this.Close();
            }
        }
    }
}
