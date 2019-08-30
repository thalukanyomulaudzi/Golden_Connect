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
    public partial class Service_Types : Form
    {
        public Service_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Service_Types_Add service_Types_Add = new Service_Types_Add();
            service_Types_Add.ShowDialog();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_Types_View service_Types_View = new Service_Types_View();
            string serviceTypeName = "";
            switch (e.ColumnIndex)
            {

                case 2:
                    Service_Types_View.edit = false;
                    serviceTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_Types_View.GetServiceTypeRow = serviceTypeName;
                    service_Types_View.ShowDialog();
                    break;
                case 3:
                    Service_Types_View.edit = true;
                    serviceTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_Types_View.GetServiceTypeRow = serviceTypeName;
                    service_Types_View.ShowDialog();
                    break;
                case 4:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void Service_Types_Load(object sender, EventArgs e)
        {

        }

        private void Service_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string serviceTypeName = " ";
                    string serviceTypeDescription = " ";
                    DataTable ServiceTypes = new DataTable();
                    string query = "SELECT service_type_name, service_type_description FROM service_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ServiceTypes.Load(reader);
                    for (int i = 0; i < ServiceTypes.Rows.Count; i++)
                    {
                        serviceTypeName = ServiceTypes.Rows[i].ItemArray[0].ToString();
                        serviceTypeDescription = ServiceTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(serviceTypeName, serviceTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    dataGridView7.Rows.Clear();
                    string serviceTypeName = " ";
                    string serviceTypeDescription = " ";
                    DataTable ServiceTypes = new DataTable();
                    string query = "SELECT service_type_name, service_type_description FROM service_type WHERE service_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "service_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ServiceTypes.Load(reader);
                    for (int i = 0; i < ServiceTypes.Rows.Count; i++)
                    {
                        serviceTypeName = ServiceTypes.Rows[i].ItemArray[0].ToString();
                        serviceTypeDescription = ServiceTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(serviceTypeName, serviceTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
        }
    }
}
