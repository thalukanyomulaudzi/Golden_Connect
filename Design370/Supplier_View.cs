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
        public string GetSupplierRow { get; set; }
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
            string box = "";
            string id = "";

            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    var mysqlCmd = new MySqlCommand("SELECT * FROM supplier WHERE supplier_name = '" + GetSupplierRow + "'", dbCon.Connection);
                    var mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        txtSPName.Text = mysqlReader.GetString(1);
                        txtemail.Text = mysqlReader.GetString(2);
                        txtspNo.Text = mysqlReader.GetString(3);
                        txtspaddress.Text = mysqlReader.GetString(4);
                        id = mysqlReader.GetString(5);
                    }
                    mysqlReader.Close();
                    mysqlCmd = new MySqlCommand("SELECT * FROM supplier_type", dbCon.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        cbxsp.Items.Add(mysqlReader["supplier_type_name"].ToString());
                        cbxsp.ValueMember = (mysqlReader["supplier_type_id"].ToString());
                    }
                    mysqlReader.Close();
                    mysqlCmd = new MySqlCommand("SELECT supplier_type_name FROM supplier_type WHERE supplier_type_id = '" + id + "'", dbCon.Connection);
                    mysqlReader = mysqlCmd.ExecuteReader();
                    while (mysqlReader.Read())
                    {
                        box = mysqlReader.GetString(0);
                    }
                    mysqlReader.Close();
                    cbxsp.SelectedItem = box;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supplier_View_Activated(object sender, EventArgs e)
        {

        }
    }
}
