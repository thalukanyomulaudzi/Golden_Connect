using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace Design370
{
    class Employee
    {
        public static DBConnection dbCon = DBConnection.Instance();
        public static string EmployeeID { get; set; }

        public static void deleteEmployee(DataGridView dgv)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    string query = "DELETE FROM `employee` WHERE employee_id = '" + EmployeeID + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception except)
            {
                System.Windows.Forms.MessageBox.Show(except.Message);
            }
        }
        public static void LoadEmployees(DataGridView dgvEmp)
        {
            try
            {
                DataTable Employee = new DataTable();
                string query = "SELECT employee.employee_id, employee.employee_first, employee.employee_last, employee.employee_idnumber, employee.employee_phone," +
                    " employee.employee_email, employee_type.employee_type_name FROM employee INNER JOIN employee_type ON employee.employee_type = " +
                    "employee_type.employee_type_id";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                Employee.Load(reader);
                dgvEmp.Rows.Clear();
                for (int i = 0; i < Employee.Rows.Count; i++)
                {
                    dgvEmp.Rows.Add(Employee.Rows[i].ItemArray[0], Employee.Rows[i].ItemArray[3], Employee.Rows[i].ItemArray[2] + ", " + Employee.Rows[i].ItemArray[1],
                        Employee.Rows[i].ItemArray[4], Employee.Rows[i].ItemArray[5], Employee.Rows[i].ItemArray[6], "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void SearchEmployees(DataGridView dgvEmp)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    DataTable Employee = new DataTable();
                    string query = "SELECT employee.employee_id, employee.employee_first, employee.employee_last, employee.employee_idnumber, employee.employee_phone," +
                        " employee.employee_email, employee_type.employee_type_name FROM employee INNER JOIN employee_type ON employee.employee_type = " +
                        "employee_type.employee_type_id WHERE employee.employee_first LIKE '%" + EmployeeID + "%' OR employee.employee_last LIKE '%" + EmployeeID + "%' OR " +
                        "employee.employee_idnumber LIKE '%" + EmployeeID + "%'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    Employee.Load(reader);
                    for (int i = 0; i < Employee.Rows.Count; i++)
                    {
                        dgvEmp.Rows.Add(Employee.Rows[i].ItemArray[0], Employee.Rows[i].ItemArray[3], Employee.Rows[i].ItemArray[2] + ", " + Employee.Rows[i].ItemArray[1],
                            Employee.Rows[i].ItemArray[4], Employee.Rows[i].ItemArray[5], Employee.Rows[i].ItemArray[6], "View", "Edit", "Delete");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void LoadEmployeeTypes(ComboBox sortCombo)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    string loadEmp = "SELECT * FROM `employee_type`";
                    var command = new MySqlCommand(loadEmp, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sortCombo.Items.Add(reader[1]);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void SearchEmployeeType(DataGridView dgvEmpType)
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    DataTable EmployeeType = new DataTable();
                    string query = "SELECT employee_type_id, employee_type_name, employee_type_description FROM employee_type WHERE employee_type_name LIKE '%" + EmployeeID + "%'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    EmployeeType.Load(reader);
                    for (int i = 0; i < EmployeeType.Rows.Count; i++)
                    {
                        dgvEmpType.Rows.Add(EmployeeType.Rows[i].ItemArray[0], EmployeeType.Rows[i].ItemArray[1], EmployeeType.Rows[i].ItemArray[2], "View", "Edit", "Delete");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private static void setColumns(System.Windows.Forms.DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            dgv.Columns[3].Name = "First Name";
            dgv.Columns[3].Width = 190;
            dgv.Columns[4].Name = "Last Name";
            dgv.Columns[4].Width = 190;
            dgv.Columns[5].Name = "ID Number";
            dgv.Columns[5].Width = 187;
            dgv.Columns[6].Name = "Telephone";
            dgv.Columns[6].Width = 150;
            dgv.Columns[7].Name = "Email Address";
            dgv.Columns[7].Width = 230;
            dgv.ReadOnly = true;
        }
    }
}
