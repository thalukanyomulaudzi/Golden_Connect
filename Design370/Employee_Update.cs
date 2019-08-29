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
    public partial class Employee_Update : Form
    {
        public static bool edit;
        public static string employeeID;
        int ms, et;
        int msID, emtID;
        public Employee_Update()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtEmpFirst.Enabled = edit;
            txtEmpLast.Enabled = edit;
            txtEmpPhone.Enabled = edit;
            txtEmpEmail.Enabled = edit;
            txtEmpAddress.Enabled = edit;
            cbxEmpMarital.Enabled = edit;
            cbxEmpType.Enabled = edit;
            loadAllEmployeesForEdit();
            MysqlConnection.mysqlCon.Open();
            string load = "SELECT * FROM `employee` WHERE `employee_idnumber` = '" + employeeID + "'";
            MysqlConnection.cmd = new MySqlCommand(load, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            while (MysqlConnection.reader.Read())
            {
                txtEmpFirst.Text = MysqlConnection.reader.GetString("employee_first");
                txtEmpLast.Text = MysqlConnection.reader.GetString("employee_last");
                txtEmpPhone.Text = MysqlConnection.reader.GetString("employee_phone");
                txtEmpEmail.Text = MysqlConnection.reader.GetString("employee_email");
                txtEmpAddress.Text = MysqlConnection.reader.GetString("employee_address");
                ms = Convert.ToInt32(MysqlConnection.reader.GetString("employee_marital"));
                et = Convert.ToInt32(MysqlConnection.reader.GetString("employee_type"));
            }

            MysqlConnection.mysqlCon.Close();
            load_EMPType(et);
            load_MS(ms);
        }

        private void loadAllEmployeesForEdit()
        {
            load_EMPTypes();
            load_MaritalStatus();
        }

        public void load_EMPTypes()
        {
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM `employee_type`";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                cbxEmpType.Items.Clear();
                while (MysqlConnection.reader.Read())
                {
                    cbxEmpType.Items.Add(MysqlConnection.reader[1]);
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        public void load_EMPType(int i)
        {
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM `employee_type` WHERE `employee_type_id` = '" + i + "'";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    cbxEmpType.Text = MysqlConnection.reader.GetString("employee_type_name");
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        public void load_MaritalStatus()
        {
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM `marital_status`";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                cbxEmpMarital.Items.Clear();
                while (MysqlConnection.reader.Read())
                {
                    cbxEmpMarital.Items.Add(MysqlConnection.reader[1]);
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void BtnSaveEmpEdit_Click(object sender, EventArgs e)
        {

            MysqlConnection.mysqlCon.Open();
            string TitlesQuery = "SELECT `marital_status_id`, `employee_type_id` FROM `marital_status`, `employee_type` WHERE `marital_status_name` = '" + cbxEmpMarital.SelectedItem.ToString() + "' AND `employee_type_name` = '" + cbxEmpType.SelectedItem.ToString() + "'";
            MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            MysqlConnection.reader.Read();
            if (MysqlConnection.reader.HasRows)
            {
                msID = Convert.ToInt32(MysqlConnection.reader.GetString("marital_status_id"));
                emtID = Convert.ToInt32(MysqlConnection.reader.GetString("employee_type_id"));
            }
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            string editEMP = "UPDATE `employee` SET `employee_first` = @FN, `employee_last` = @LN, `employee_marital` = @MS, `employee_email` = @EM, `employee_phone` = @PN, " +
                "`employee_type` = @ET, `employee_address` = @ADD WHERE `employee_idnumber` = @EID";
            MysqlConnection.cmd = new MySqlCommand(editEMP, MysqlConnection.mysqlCon);
            MysqlConnection.cmd.Parameters.AddWithValue("@FN", txtEmpFirst.Text);
            MysqlConnection.cmd.Parameters.AddWithValue("@LN", txtEmpLast.Text);
            MysqlConnection.cmd.Parameters.AddWithValue("@MS", msID);
            MysqlConnection.cmd.Parameters.AddWithValue("@EM", txtEmpEmail.Text);
            MysqlConnection.cmd.Parameters.AddWithValue("@PN", txtEmpPhone.Text);
            MysqlConnection.cmd.Parameters.AddWithValue("@ET", emtID);
            MysqlConnection.cmd.Parameters.AddWithValue("@ADD", txtEmpAddress.Text);
            MysqlConnection.cmd.Parameters.AddWithValue("@EID", employeeID);
            int done = MysqlConnection.cmd.ExecuteNonQuery();
            if (done > 0)
            {
                if (MessageBox.Show("Employee Information: " + txtEmpFirst.Text + " " + txtEmpLast.Text + "\n Update Status: Successfully Updated", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    
                }
            }
            else
            {

                MessageBox.Show("Employee Information: " + txtEmpFirst.Text + " " + txtEmpLast.Text + "\n Update Status: Error Updating Employee", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MysqlConnection.mysqlCon.Close();
        }

        public void load_MS(int i)
        {
            MysqlConnection.mysqlCon.Close();
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM `marital_status` WHERE `marital_status_id` = '" + i + "'";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    cbxEmpMarital.Text = MysqlConnection.reader.GetString("marital_status_name");
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }
    }
}
