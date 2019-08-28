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
    public partial class Supplier_View : Form
    {
        public static bool edit;
        public Supplier_View()
        {
            InitializeComponent();
        }

        private void Supplier_View_Load(object sender, EventArgs e)
        {
            txtemail.Enabled = edit;
            txtspNo.Enabled = edit;
            txtspaddress.Enabled = edit;
            txtSPName.Enabled = edit;
            cbxsp.Enabled = edit;

            //using (MysqlConnection.mysqlCon)
            //{
            //    DataTable dt = new DataTable();
            //    MysqlConnection.mysqlCon.Open();
            //    MySqlDataReader myReader = null;
            //    MySqlCommand myCommand = new MySqlCommand("select * from customer_registration where username='" + Session["username"] + "'", con1);

            //    myReader = myCommand.ExecuteReader();

            //    while (myReader.Read())
            //    {
            //        TextBoxPassword.Text = (myReader["password"].ToString());
            //        TextBoxRPassword.Text = (myReader["retypepassword"].ToString());
            //        DropDownListGender.SelectedItem.Text = (myReader["gender"].ToString());
            //        DropDownListMonth.Text = (myReader["birth"].ToString());
            //        DropDownListYear.Text = (myReader["birth"].ToString());
            //        TextBoxAddress.Text = (myReader["address"].ToString());
            //        TextBoxCity.Text = (myReader["city"].ToString());
            //        DropDownListCountry.SelectedItem.Text = (myReader["country"].ToString());
            //        TextBoxPostcode.Text = (myReader["postcode"].ToString());
            //        TextBoxEmail.Text = (myReader["email"].ToString());
            //        TextBoxCarno.Text = (myReader["carno"].ToString());
            //    }
            //}


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtemail.Enabled = true;
            txtspNo.Enabled = true;
            txtspaddress.Enabled = true;
            txtSPName.Enabled = true;
            cbxsp.Enabled = true;        }

        private void Supplier_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtemail.Enabled)
            {
                DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
                e.Cancel = exit == DialogResult.Yes ? false : true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
