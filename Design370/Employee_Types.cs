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
    public partial class Employee_Types : Form
    {
        DBConnection dbCon = DBConnection.Instance();
        public Employee_Types()
        {
            InitializeComponent();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Employee_Types_Add employee_Types_Add = new Employee_Types_Add();
            employee_Types_Add.Show();
        }

        private void DgvEmpType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_Types_View empTypes = new Employee_Types_View();
            switch(e.ColumnIndex)
            {
                case 0:
                    //Don't deem it necessary to have!!
                    break;
                case 1:
                    empTypes.emptype = dgvEmpType.Rows[e.RowIndex].Cells[3].Value.ToString();
                    empTypes.ShowDialog();
                    break;
                case 2:
                    try
                    {
                        if (dgvEmpType.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            if (MessageBox.Show("Are sure you want to delete this type?", "Delete Employee Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dbCon.Open();
                                string deleteEmpType = "DELETE FROM `employee_type` WHERE `employee_type_name` ='" + dgvEmpType.Rows[e.RowIndex].Cells[3].Value + "'";
                                if (dbCon.IsConnect())
                                {
                                    var command = new MySqlCommand(deleteEmpType, dbCon.Connection);
                                    command.ExecuteReader();
                                    MessageBox.Show("Employee Type: " + dgvEmpType.Rows[e.RowIndex].Cells[3].Value + "", "Delete Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dbCon.Close();
                                }
                            }
                            else
                            {
                                //Nothing
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("Please make a valid Employee Type Selection");
                        }
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    break;
                default:
                        
                break;
                    
            }
        }

        private void Employee_Types_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmpType.ColumnCount = 5;
                dgvEmpType.Columns[3].Name = "Employee Type Name";
                dgvEmpType.Columns[3].Width = 230;
                dgvEmpType.Columns[4].Name = "Employee Type Description";
                dgvEmpType.Columns[4].Width = 320;
                dgvEmpType.ReadOnly = true;
                dbCon.Open();
                if (dbCon.IsConnect())
                {
                    string loadTypes = "SELECT * FROM `employee_type`";
                    var command = new MySqlCommand(loadTypes, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvEmpType.Rows.Add("", "", "", reader[1], reader[2]);
                    }
                    dbCon.Close();
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
