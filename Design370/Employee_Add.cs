﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.IO;

namespace Design370
{
    public partial class Employee_Add : Form
    {
        string titleID = " ";
        string maritalID = " ";
        string employee_type_ID = " ";
        string gender = " ";
        WebCam webcam = new WebCam();
        public Employee_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtEmployeeFirst, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeLast, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeID, "A maximum of 13 characters can be entered");
            toolTip1.SetToolTip(txtEmployeePhone, "A maximum of 10 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeAddress, "A maximum of 100 characters can be entered");
            toolTip1.SetToolTip(txtEmployeeEmail, "A maximum of 50 characters can be entered");
            toolTip1.SetToolTip(cbxEmployeeGender, "Please select a gender");
            toolTip1.SetToolTip(cbxEmployeeMarital, "Please select a marital status");
            toolTip1.SetToolTip(cbxEmployeeTitle, "Please select a title");
            toolTip1.SetToolTip(cbxEmployeeType, "Please select an employee type");
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            cbxEmployeeGender.Items.Add("Male");
            cbxEmployeeGender.Items.Add("Female");
            loadTitles();
            loadMaritalStatus();
            loadTypes();
            //webcam.InitializeWebCam(ref imgCapture);
            //webcam.Start();
        }

        public void loadTitles()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM title";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeTitle.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void loadTypes()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM employee_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeType.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void loadMaritalStatus()
        {
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT * FROM marital_status";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxEmployeeMarital.Items.Add(reader.GetString(1));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void addEmployee()
        {
            if (cbxEmployeeTitle.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a title");
                return;
            }
            if (cbxEmployeeGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender");
                return;
            }
            if (cbxEmployeeMarital.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a marital status");
                return;
            }
            if (cbxEmployeeType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee type");
                return;
            }
            DBConnection dBConnection = DBConnection.Instance();
            try
            {
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT title_id FROM title WHERE title_name = '" + cbxEmployeeTitle.SelectedItem.ToString() + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        titleID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT marital_status_id FROM marital_status WHERE marital_status_name = '" + cbxEmployeeMarital.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        maritalID = reader.GetString(0);
                    }
                    reader.Close();
                    query = "SELECT employee_type_id FROM employee_type WHERE employee_type_name = '" + cbxEmployeeType.SelectedItem.ToString() + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_type_ID = reader.GetString(0);
                    }
                    reader.Close();
                    MemoryStream stream = new MemoryStream();
                    MessageBox.Show("Test");
                    //imgCapture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] pic;
                    //if (stream != null)
                    //    pic = stream.ToArray();
                    //else pic = null;
                    gender = cbxEmployeeGender.SelectedItem.ToString().Substring(0, 1);
                    query = "INSERT INTO employee(employee_first, employee_last, employee_idnumber, employee_phone, " +
                    "employee_email, employee_address, employee_type, employee_gender, employee_marital, employee_title, employee_image) " +
                    "VALUES('" + txtEmployeeFirst.Text + "', '" + txtEmployeeLast.Text + "', '" + txtEmployeeID.Text + "', '" + txtEmployeePhone.Text + "', '" + txtEmployeeEmail.Text.ToLower() + "', '" + txtEmployeeAddress.Text + "', " +
                    "'" + employee_type_ID + "', '" + gender + "', '" + maritalID + "', '" + titleID + "', '" + null + "')";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            Close();
        }

        private void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            if (!Validation.validate(txtEmployeeFirst.Text, "name") || !Validation.validate(txtEmployeeLast.Text, "name") || !Validation.validate(txtEmployeeID.Text, "id")
                || !Validation.validate(txtEmployeeEmail.Text, "email") || !Validation.validate(txtEmployeePhone.Text, "phone"))
            {
                MessageBox.Show("All input fields must be valid");
                return;
            }
            addEmployee();
            User_Add user_Add = new User_Add();
            user_Add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Types_Add employee_Types_Add = new Employee_Types_Add();
            employee_Types_Add.ShowDialog();
        }

        private void TxtEmpEmail_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeEmail, Validation.validate(txtEmployeeEmail.Text, "email"));
        }

        private void TxtEmpFirst_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeFirst, Validation.validate(txtEmployeeFirst.Text, "name"));
        }

        private void TxtEmployeeLast_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeLast, Validation.validate(txtEmployeeLast.Text, "name"));
        }

        private void TxtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeeID, Validation.validate(txtEmployeeID.Text, "id"));
        }

        private void TxtEmployeePhone_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblEmployeePhone, Validation.validate(txtEmployeePhone.Text, "phone"));
        }

        private void BtnEmployeeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Employee_Add_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Employee";
            helpForm.ShowDialog();
        }

        private void bntCapture_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Open a Text File";
            //ofd.Filter = "JPEG Files (*.jpg) | *.jpg"; //Here you can filter which all files you wanted allow to open  
            //DialogResult dr = ofd.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    //imgCapture.Image = System.Drawing.Image.FromFile(ofd.FileName);
            //    //imgCapture.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
