using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Design370
{
    public partial class Login : Form
    {
        private bool shown = false;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User.login(txtID.Text.Trim(), txtPassword.Text.Trim());
        }

        private void LblPasswordShow_Click(object sender, EventArgs e)
        {
            shown = !shown;
            txtPassword.PasswordChar = shown ? '\0' : '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
