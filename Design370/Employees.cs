using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Design370
{
    class Employees
    {
        public static DBConnection dbCon = DBConnection.Instance();
        public static string EmployeeID { get; set; }

        public static bool deleteEmployee()
        {
            try
            {

                DBConnection dB = DBConnection.Instance();
                if (dB.IsConnect())
                {
                    string deleteEmp = "DELETE FROM `employee` WHERE `employee_idnumber` = '" + EmployeeID + "'";
                    var command = new MySqlCommand(deleteEmp, dB.Connection);
                    command.ExecuteReader();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        public Employees()
        {

        }

        public static void LoadEmployees(DataGridView dgvEmp)
        {
            try
            {
                setColumns(dgvEmp);
                if (dbCon.IsConnect())
                {
                    string loadEmp = "SELECT * FROM `employee`";
                    var command = new MySqlCommand(loadEmp, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvEmp.Rows.Add("", "", "", reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public static void SearchEmployees(string searchText, DataGridView dgvEmp)
        {
            try
            {
                setColumns(dgvEmp);
                if (dbCon.IsConnect())
                {
                    string loadEmp = "SELECT * FROM `employee` WHERE `employee_idnumber` LIKE @ID OR `employee_first` LIKE @FIRST OR `employee_last` LIKE @LAST OR `employee_email` LIKE @MAIL";
                    var command = new MySqlCommand(loadEmp, dbCon.Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@ID", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@FIRST", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@LAST", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@MAIL", "%" + searchText + "%");
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvEmp.Rows.Add("", "", "", reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        static int id;
        public static void SortEmployees(string sort, DataGridView dgvEmp)
        {
            id = getEmpType(sort);
            try
            {
                setColumns(dgvEmp);
                if (dbCon.IsConnect())
                {
                    string loadEmp = "SELECT * FROM `employee` WHERE `employee_type` = '" + id + "'";
                    var command = new MySqlCommand(loadEmp, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvEmp.Rows.Add("", "", "", reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                    reader.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private static int t;
        public static int getEmpType(string sort)
        {
            if (dbCon.IsConnect())
            {
                dbCon.Close();
                dbCon.Open();
                string empTypes = "SELECT * FROM `employee_type` WHERE `employee_type_name` = '" + sort + "'";
                var command = new MySqlCommand(empTypes, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    t = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
            }
            return t;
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

        public static void SearchEmployeeType(string text, DataGridView dgvEmpType)
        {
            try
            {
                dgvEmpType.ColumnCount = 5;
                dgvEmpType.Columns[3].Name = "Employee Type Name";
                dgvEmpType.Columns[3].Width = 230;
                dgvEmpType.Columns[4].Name = "Employee Type Description";
                dgvEmpType.Columns[4].Width = 320;
                dgvEmpType.ReadOnly = true;
                dbCon.Close();
                dbCon.Open();
                if (dbCon.IsConnect())
                {
                    string loadTypes = "SELECT * FROM `employee_type` WHERE `employee_type_name` LIKE @Name";
                    var command = new MySqlCommand(loadTypes, dbCon.Connection);
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@Name", "%"+text+"%");
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvEmpType.Rows.Add("", "", "", reader[1], reader[2]);
                    }
                    dbCon.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
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
