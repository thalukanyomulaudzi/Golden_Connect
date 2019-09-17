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
                    empTypes.emptype = dgvEmpType.Rows[e.RowIndex].Cells[3].Value.ToString();
                    empTypes.ShowDialog();
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
                                string deleteEmpType = "DELETE FROM `employee_type` WHERE `employee_type_name` ='" + dgvEmpType.Rows[e.RowIndex].Cells[3].Value + "'";
                                if (dbCon.IsConnect())
                                {
                                    var command = new MySqlCommand(deleteEmpType, dbCon.Connection);
                                    command.ExecuteReader();
                                    MessageBox.Show("Employee Type: " + dgvEmpType.Rows[e.RowIndex].Cells[3].Value + "", "Delete Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
        }

        private void TxtSearchEmpType_TextChanged(object sender, EventArgs e)
        {
            dgvEmpType.Rows.Clear();
            Employee.SearchEmployeeType(txtSearchEmpType.Text, dgvEmpType);
        }

        private void CbxSortEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Types_Activated(object sender, EventArgs e)
        {
            dgvEmpType.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string employeeTypeID = " ";
                    string employeeTypeName = " ";
                    string employeeTypeDescription = " ";
                    DataTable EmployeeTypes = new DataTable();
                    string query = "SELECT employee_type_id, employee_type_name, employee_type_description FROM employee_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    EmployeeTypes.Load(reader);
                    for (int i = 0; i < EmployeeTypes.Rows.Count; i++)
                    {
                        employeeTypeID = EmployeeTypes.Rows[i].ItemArray[0].ToString();
                        employeeTypeName = EmployeeTypes.Rows[i].ItemArray[1].ToString();
                        employeeTypeDescription = EmployeeTypes.Rows[i].ItemArray[2].ToString();
                        dgvEmpType.Rows.Add(employeeTypeID, employeeTypeName, employeeTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
    }
}
