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
    public partial class Service_Types_Add : Form
    {
        DBConnection dbCon = DBConnection.Instance();

        public Service_Types_Add()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServTypeName.Text.Length <= 2 || txtServTypeDesc.Text.Length <= 5)
            {
                MessageBox.Show("Invalid character length for name and/or description");
                return;
            }
            try
            {
                if (dbCon.IsConnect())
                {
                    string query = "INSERT INTO `product_type`(`product_type_name`, `product_type_description`, `product_type_id`) VALUES('" +
                                txtServTypeName.Text + "', '" + txtServTypeDesc.Text + "', NULL')";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
