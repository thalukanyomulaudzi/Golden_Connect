using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class User_Add : Form
    {
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
    }
}
