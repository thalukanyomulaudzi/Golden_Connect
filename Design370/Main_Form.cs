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
    public partial class Main_Form : Form
    {
        DBConnection dbCon = DBConnection.Instance();
        public Main_Form()
        {
            InitializeComponent();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            // Use our own font.
            Font _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Regular, GraphicsUnit.Pixel);

            if (e.State == DrawItemState.Selected)
            {
                _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Bold, GraphicsUnit.Pixel);

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Gold);
                g.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Add customerAdd= new Customer_Add();
            customerAdd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!connectDB())//First in function
            {
                MessageBox.Show("Could not connect to database " + dbCon.DatabaseName + ", please contact network administrator");
                Application.Exit();
            }
            loadEmployees();
            //testConnection(); //this throws out all customer names and surnames, only use during development
            //Timeslots.generateTimeslotsUpTo(DateTime.Now.AddDays(1));
            //Timeslots.linkTimeslots();
            Timeslots.loadTimeslots(dataGridView5, DateTime.Today);
            //Timeslots.removeDuplicates();
            //MessageBox.Show(Timeslots.timeslotExists(DateTime.Parse("2019-08-29 09:00:00")).ToString());
            loadSuppliers();
        }

        public void loadSuppliers()
        {
            using (MysqlConnection.mysqlCon)
            {
                MysqlConnection.mysqlCon.Open();

                string sql = "SELECT supplier_id, supplier_name,supplier_email, supplier_phone, supplier_location_address FROM supplier";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, MysqlConnection.mysqlCon);
                DataTable dtb1 = new DataTable();
                adapter.Fill(dtb1);
                //dtb1.Columns.Add("View");
                //for (int i = 0; i < dtb1.Rows.Count; i++)
                //{
                //    dtb1.Rows[i]["View"] = "View";
                //}
                dataGridView10.AutoGenerateColumns = false;
                dataGridView10.DataSource = dtb1;
            }
        }
        private bool connectDB()
        {
            dbCon.DatabaseName = "golden_connect";
            return (dbCon.IsConnect());
        }

        public void loadEmployees()
        {
            MysqlConnection.mysqlCon.Open();
            string employees = "SELECT employee_first, employee_last, employee_idnumber, employee_phone, employee_email " +
                "FROM employee";
            MysqlConnection.cmd = new MySqlCommand(employees, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(MysqlConnection.reader);
            empGrid.DataSource = table;
            MysqlConnection.mysqlCon.Close();
        }

        private void testConnection()//only in use during dev stage for example code
        {
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT customer_first,customer_last FROM customer";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string first = reader.GetString(0);
                    string last = reader.GetString(1);
                    MessageBox.Show(first + "," + last);
                }
                dbCon.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Service_Add service_Add = new Service_Add();
            service_Add.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Photoshoot_Package_Add photoshootPackageAdd = new Photoshoot_Package_Add();
            photoshootPackageAdd.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Customer_View customerView = new Customer_View();
            switch (e.ColumnIndex)
            {
                
                case 1:
                    Customer_View.edit = false;
                    customerView.Show();
                    break;
                case 2:
                    Customer_View.edit = true;
                    customerView.Show();
                    break;
                case 3:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    } else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Event_Package_Add eventPackageAdd = new Event_Package_Add();
            eventPackageAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event_Types eventTypes = new Event_Types();
            eventTypes.Show();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Book_Event_Date bookDate = new Book_Event_Date();
            bookDate.Show();
            //Booking_Dialog booking_Dialog = new Booking_Dialog();
            //booking_Dialog.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
            dbCon.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Employee_Add employee_Add = new Employee_Add();
            employee_Add.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            NewCustomerOrder cOrder = new NewCustomerOrder();
            cOrder.ShowDialog();
        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_View employeeView = new Employee_View();
            switch (e.ColumnIndex)
            {

                case 0:
                    Employee_View.edit = false;
                    employeeView.Show();
                    break;
                case 1:
                    Employee_View.edit = true;
                    employeeView.Show();
                    break;
                case 2:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        
                    }
                    else
                    {
                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Employee_Types EmployeeTypes = new Employee_Types();
            EmployeeTypes.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Product_Add product_Add = new Product_Add();
            product_Add.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.Show();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Supplier_Add supplier_Add = new Supplier_Add();
            supplier_Add.Show();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Supplier_Orders supplier_Orders = new Supplier_Orders();
            supplier_Orders.Show();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_View service_View = new Service_View();
            ServiceEdit.Text = "Edit";
            ServiceDelete.Text = "Delete";
            ServiceView.Text = "View";
            
            switch (e.ColumnIndex)
            {

                case 3:
                    Service_View.edit = false;
                    service_View.Show();
                    break;
                case 4:
                    Service_View.edit = true;
                    service_View.Show();
                    break;
                case 5:
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

        private void DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string packageName;
            PhotoshootPackage_View photoshootPackage_View = new PhotoshootPackage_View();
            switch (e.ColumnIndex)
            {

                case 4:
                    PhotoshootPackage_View.edit = false;
                    packageName = dgvPhotoshootPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshootPackage_View.GetRow = packageName;
                    photoshootPackage_View.ShowDialog();
                    break;
                case 5:
                    PhotoshootPackage_View.edit = true;
                    packageName = dgvPhotoshootPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshootPackage_View.GetRow = packageName;
                    photoshootPackage_View.ShowDialog();
                    break;
                case 6:
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

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_View product_View = new Product_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    Product_View.edit = false;
                    product_View.Show();
                    break;
                case 4:
                    Product_View.edit = true;
                    product_View.Show();
                    break;
                case 5:
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

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventPackage_View eventPackage_View = new EventPackage_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    EventPackage_View.edit = false;
                    eventPackage_View.Show();
                    break;
                case 4:
                    EventPackage_View.edit = true;
                    eventPackage_View.Show();
                    break;
                case 5:
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

        private void DataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Supplier_View supplier_View = new Supplier_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Supplier_View.edit = false;
                    supplier_View.Show();
                    break;
                case 3:
                    Supplier_View.edit = true;
                    supplier_View.Show();
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

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MysqlConnection.mysqlCon.Open();
            string employees = "SELECT employee_first, employee_last, employee_idnumber, employee_phone, employee_email " +
                "FROM employee WHERE employee_first LIKE '%"+txtSearch.Text+"%' OR employee_last LIKE '%"+txtSearch.Text+"%' OR employee_idnumber LIKE '%"+txtSearch.Text+"%'";
            MysqlConnection.cmd = new MySqlCommand(employees, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(MysqlConnection.reader);
            empGrid.DataSource = table;
            MysqlConnection.mysqlCon.Close();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {
        }

        private void TabPage6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.LoadDGV(dgvPhotoshootPackage);
        }
    }
}