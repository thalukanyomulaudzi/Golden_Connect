using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class Settings : Form
    {
        public static int Timeout { get; set; } = 300;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numTimeout.Value = Timeout;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Timeout = (int)Math.Floor(numTimeout.Value);
        }
    }
}
