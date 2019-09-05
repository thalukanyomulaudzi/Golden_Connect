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
    public partial class Product_Type_Add : Form
    {
        DBConnection dbCon = DBConnection.Instance();

        public Product_Type_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtProdTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtProdTypeDesc, "A maximum of 100 characters can be entered");
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProdTypeName.Text.Length <= 2 || txtProdTypeDesc.Text.Length <= 5)
            {
                MessageBox.Show("Invalid character length for name and/or description");
                return;
            }
            try
            {
                if (dbCon.IsConnect())
                {
                    string query = "INSERT INTO `product_type`(`product_type_id`, `product_type_name`, `product_type_description`) VALUES('NULL', '" +
                                txtProdTypeName.Text + "', '" + txtProdTypeDesc.Text + "')";
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

        private void Product_Type_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
