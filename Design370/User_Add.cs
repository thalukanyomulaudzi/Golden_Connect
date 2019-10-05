using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class User_Add : Form
    {
        private bool shown = false;

        public User_Add()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT username FROM user WHERE username = '" + txtID.Text.Trim() + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("That username is already taken");
                    reader.Close();
                    return;
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            if (txtPassword.Text.Trim() != txtPasswordConfirm.Text.Trim())
            {
                MessageBox.Show("The passwords do not match");
                return;
            }
            User.addUser(txtID.Text.Trim(), txtPassword.Text.Trim());
        }

        private void LblPasswordShow_Click(object sender, EventArgs e)
        {
            shown = !shown;
            txtPassword.PasswordChar = shown ? '\0' : '*';
            txtPasswordConfirm.PasswordChar = shown ? '\0' : '*';
        }
    }
}
