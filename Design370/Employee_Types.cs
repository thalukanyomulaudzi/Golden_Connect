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
                case 3:
                    empTypes.emptype = dgvEmpType.Rows[e.RowIndex].Cells[3].Value.ToString();
                    MessageBox.Show("Test");
                    empTypes.ShowDialog();
                    break;
                case 4:
                    empTypes.emptype = dgvEmpType.Rows[e.RowIndex].Cells[3].Value.ToString();
                    empTypes.ShowDialog();
                    break;
                case 5:
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
            string employeeTypeName = txtSearchEmpType.Text;
            Employee.EmployeeID = employeeTypeName;
            dgvEmpType.Rows.Clear();
            Employee.SearchEmployeeType(dgvEmpType);
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

        private void dgvEmpType_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearchEmpType.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearchEmpType.Text.Trim().ToLower());
                    // IF search text is exists inside grid cell then startIndexInCellValue value will be greater then 0 or equal to 0  
                    if (startIndexInCellValue >= 0)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, true);
                        //the highlite rectangle  
                        Rectangle hl_rect = new Rectangle();
                        hl_rect.Y = e.CellBounds.Y + 2;
                        hl_rect.Height = e.CellBounds.Height - 5;
                        //find the size of the text before the search word in grid cell data.  
                        String sBeforeSearchword = gridCellValue.Substring(0, startIndexInCellValue);
                        //size of the search word in the grid cell data  
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearchEmpType.Text.Trim().Length);
                        Size s1 = TextRenderer.MeasureText(e.Graphics, sBeforeSearchword, e.CellStyle.Font, e.CellBounds.Size);
                        Size s2 = TextRenderer.MeasureText(e.Graphics, sSearchWord, e.CellStyle.Font, e.CellBounds.Size);
                        if (s1.Width > 5)
                        {
                            hl_rect.X = e.CellBounds.X + s1.Width - 5;
                            hl_rect.Width = s2.Width - 6;
                        }
                        else
                        {
                            hl_rect.X = e.CellBounds.X + 2;
                            hl_rect.Width = s2.Width - 6;
                        }
                        //color for showing highlighted text in grid cell  
                        SolidBrush hl_brush;
                        hl_brush = new SolidBrush(Color.Gold);
                        //paint the background behind the search word  
                        e.Graphics.FillRectangle(hl_brush, hl_rect);
                        hl_brush.Dispose();
                        e.PaintContent(e.CellBounds);
                    }
                }
            }
        }
    }
}
