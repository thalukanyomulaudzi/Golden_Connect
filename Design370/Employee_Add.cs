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
    public partial class Employee_Add : Form
    {
        int titleID, msID, EMPType;
        public Employee_Add()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Employee_Types employee_Types = new Employee_Types();
            employee_Types.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult exit = MessageBox.Show("Do you want to save these changes?", "Save changes", MessageBoxButtons.YesNo);
            //e.Cancel = exit == DialogResult.Yes ? false : true;
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            load_Titles();
            load_MaritalStatus();
            load_EMPTypes();
        }

        public void load_Titles()
        {
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM title";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    cmTITLE.Items.Add(MysqlConnection.reader[1]);
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        public void load_EMPTypes()
        {
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM employee_type";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    cmEMTP.Items.Add(MysqlConnection.reader[1]);
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
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT * FROM marital_status";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    cmMS.Items.Add(MysqlConnection.reader[1]);
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void CmMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT marital_status_id FROM marital_status WHERE marital_status_name = '" + this.cmMS.SelectedItem.ToString() + "'";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    msID = Convert.ToInt32(MysqlConnection.reader[0]);
                    MessageBox.Show("" + msID + "");
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void btn_ADDEMP_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        public void addEmployee()
        {
            MysqlConnection.mysqlCon.Open();
            string insertQuery = "INSERT INTO employee(employee_first, employee_last, employee_idnumber, employee_phone, " +
                "employee_email, employee_address, employee_type, employee_gender, employee_marital, employee_title) " +
                "VALUES('"+txtFN.Text+"', '"+txtLN.Text+"', '"+txtID.Text+"', '"+txtTEL.Text+"', '"+txtEMAIL.Text+"', '"+txtADDRS.Text+"', " +
                "'"+EMPType+"', '"+cmGEND.SelectedItem.ToString()+"', '"+msID+"', '"+titleID+"')";
            
            try
            {
                MysqlConnection.cmd = new MySqlCommand(insertQuery, MysqlConnection.mysqlCon);
                MysqlConnection.cmd.ExecuteReader();
                MessageBox.Show("New Employee Inserted!");
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void CmEMTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT employee_type_id FROM employee_type WHERE employee_type_name = '" + this.cmEMTP.SelectedItem.ToString() + "'";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    EMPType = Convert.ToInt32(MysqlConnection.reader[0]);
                    MessageBox.Show("" + EMPType + "");
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void CmTITLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            MysqlConnection.mysqlCon.Open();
            try
            {
                string TitlesQuery = "SELECT title_id FROM title WHERE title_name = '" +this.cmTITLE.SelectedItem.ToString()+ "'";
                MysqlConnection.cmd = new MySqlCommand(TitlesQuery, MysqlConnection.mysqlCon);
                MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
                while (MysqlConnection.reader.Read())
                {
                    titleID = Convert.ToInt32(MysqlConnection.reader[0]);
                    MessageBox.Show(""+titleID+"");
                }
                MysqlConnection.mysqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                MysqlConnection.mysqlCon.Close();
            }
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
