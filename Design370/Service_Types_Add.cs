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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtServTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtServTypeDesc, "A maximum of 100 characters can be entered");
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
                    string query = "INSERT INTO `service_type`(`service_type_id`, `service_type_name`, `service_type_description`) VALUES('NULL', '" +
                                txtServTypeName.Text + "', '" + txtServTypeDesc.Text + "')";
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

        private void Service_Types_Add_Load(object sender, EventArgs e)
        {

        }

        private void TxtServTypeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
