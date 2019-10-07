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
    public partial class Customer_Order_Details : Form
    {
        public Customer_Order_Details()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DBConnection dbCon = DBConnection.Instance();
        public string names;
        public int customerID;
        public void loadDGV(DataGridView dgv)
        {
            DataGridViewButtonColumn btnSelect = new DataGridViewButtonColumn();
            btnSelect.Text = "Select";
            btnSelect.HeaderText = "Action";
            btnSelect.UseColumnTextForButtonValue = true;
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "First Name";
            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Name = "Last Name";
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Name = "ID Number";
            dgv.Columns[2].Width = 103;
            dgv.Columns[3].Name = "Email Address";
            dgv.Columns[3].Width = 180;
            dgv.Columns[4].Name = "Phone Number";
            dgv.Columns[4].Width = 130;
            dgv.Columns.Add(btnSelect);
            dgv.ReadOnly = true;
        }
        private void Customer_Order_Details_Load(object sender, EventArgs e)
        {
            loadDGV(dgvSearchCustomer);
            if(dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT * FROM `customer`", dbCon.Connection);
                var reader = command.ExecuteReader();
                dgvSearchCustomer.Rows.Clear();
                while(reader.Read())
                {
                    dgvSearchCustomer.Rows.Add(reader[1], reader[2], reader[5], reader[3], reader[4]);
                }
                reader.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void DgvSearchCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 && dgvSearchCustomer.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    if (dbCon.IsConnect())
                    {
                        var command = new MySqlCommand("SELECT `customer_id` FROM `customer` " +
                            "WHERE `customer_id_number` = '" + Convert.ToInt64(dgvSearchCustomer.Rows[e.RowIndex].Cells[2].Value.ToString()) + "'", dbCon.Connection);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            customerID = Convert.ToInt32(reader[0]);
                        }
                        reader.Close();
                        names = dgvSearchCustomer.Rows[e.RowIndex].Cells[0].Value.ToString() + " " +
                            dgvSearchCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Customer_Order_New newCustomerOrder = new Customer_Order_New(this);
                        this.Close();
                        newCustomerOrder.ShowDialog();
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void TxtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    loadDGV(dgvSearchCustomer);
                    string query = "SELECT * FROM `customer` WHERE `customer_first` LIKE '%" + txtCustomerSearch.Text + "%' OR `customer_last` LIKE '%" + txtCustomerSearch.Text + "%' OR `customer_id_number` LIKE '%" + txtCustomerSearch.Text + "%' " +
                        "OR `customer_email` LIKE '%" + txtCustomerSearch.Text + "%' OR `customer_phone` LIKE '%" + txtCustomerSearch.Text + "%'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvSearchCustomer.Rows.Add(reader[1], reader[2], reader[5], reader[3], reader[4]);
                    }
                    reader.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Customer_Add newCust = new Customer_Add();
            newCust.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void Customer_Order_Details_Activated(object sender, EventArgs e)
        {
            //loadDGV(dgvSearchCustomer);
            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT * FROM `customer`", dbCon.Connection);
                var reader = command.ExecuteReader();
                dgvSearchCustomer.Rows.Clear();
                while (reader.Read())
                {
                    dgvSearchCustomer.Rows.Add(reader[1], reader[2], reader[5], reader[3], reader[4]);
                }
                reader.Close();
            }
        }

        private void Customer_Order_Details_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void Customer_Order_Details_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Select_Customer";
            helpForm.ShowDialog();
        }
    }
}
