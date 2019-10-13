using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Design370
{
    public partial class Main_Form : Form
    {

        DBConnection dbCon = DBConnection.Instance();

        public Main_Form()
        {
            InitializeComponent();
            if (!connectDB())//First in function
            {
                MessageBox.Show("Could not connect to database " + dbCon.DatabaseName + ", please contact network administrator");
                Application.Exit();
            }
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)//Draw tabcontrol with tabs on left side
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            Font _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Regular, GraphicsUnit.Pixel);
            if (e.State == DrawItemState.Selected)
            {
                _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Bold, GraphicsUnit.Pixel);
                _textBrush = new SolidBrush(Color.Gold);
                g.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            StringFormat _stringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 0)
            {
                MessageBox.Show("Your user level is not high enough to do this.\n Required level: Receptionist");
                return;
            }
            Customer_Add customerAdd = new Customer_Add();
            customerAdd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool connectDB()
        {
            //dbCon.DatabaseName = "4d3dGYntTO";
            dbCon.DatabaseName = "golden_connect";
            return (dbCon.IsConnect());
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            //    if (User.ID < 0)
            //    {
            //        Login login = new Login();
            //        login.ShowDialog();
            //    }
            //    timer1.Start();
            Booking.loadBookings(dgvBookings);
            Timeslot.loadTimeslots(dgvTimeslots, DateTime.Now);
            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.LoadDGV(dgvPhotoshootPackage);
            dgvEventPackages.Rows.Clear();
            Event.LoadDGV(dgvEventPackages);
            loadProducts();
            loadServices();
            loadSuppliers();
            Employee.LoadEmployees(empGrid);
            Customer.LoadCustomer(dgvCustomers);
            Order.LoadOrders(dgvOrders);
            Timeslot.clearTimeslots();
        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            if (User.ID < 0)
            {
                Login login = new Login();
                login.ShowDialog();
            }
            timer1.Start();
            Booking.loadBookings(dgvBookings);
            Timeslot.loadTimeslots(dgvTimeslots, DateTime.Now);
            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.LoadDGV(dgvPhotoshootPackage);
            dgvEventPackages.Rows.Clear();
            Event.LoadDGV(dgvEventPackages);
            loadProducts();
            loadServices();
            loadSuppliers();
            Employee.LoadEmployees(empGrid);
            Customer.LoadCustomer(dgvCustomers);
            Order.LoadOrders(dgvOrders);
        }
        public void loadSuppliers()
        {
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT supplier.supplier_name,supplier.supplier_email, supplier.supplier_phone, supplier_type.supplier_type_name FROM supplier " +
                    "INNER JOIN supplier_type ON supplier.supplier_type_id=supplier_type.supplier_type_id";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                dataGridView10.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView10.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public void loadServices()
        {
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT service.service_id, service.service_name, service_type.service_type_name, service.service_price FROM service INNER JOIN service_type ON service.service_type_id=service_type.service_type_id";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                dgvServices.Rows.Clear();
                while (reader.Read())
                {
                    dgvServices.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void loadProducts()
        {
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT product.product_id, product.product_name, product_type.product_type_name, product.product_price FROM product INNER JOIN product_type ON product.product_type_id=product_type.product_type_id";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                dgvProducts.Rows.Clear();
                while (reader.Read())
                {
                    dgvProducts.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Service_Add service_Add = new Service_Add();
            service_Add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_View customerView = new Customer_View();
            string customerID = " ";
            switch (e.ColumnIndex)
            {
                case 5:
                    customerView.edit = false;
                    customerID = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    customerView.GetCustomerRow = customerID;
                    customerView.ShowDialog();
                    break;
                case 6:
                    customerView.edit = true;
                    customerID = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    customerView.GetCustomerRow = customerID;
                    customerView.ShowDialog();
                    break;
                case 7:
                    customerID = dgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Customer.CustomerID = customerID;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dgvCustomers.Rows.Clear();
                        Customer.deleteCustomer(dgvCustomers);
                        Customer.LoadCustomer(dgvCustomers);
                    }
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Event_Package_Add eventPackageAdd = new Event_Package_Add();
            eventPackageAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Event_Types eventTypes = new Event_Types();
            eventTypes.ShowDialog();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (User.ID >= 0)
            {
                DialogResult exit = MessageBox.Show("Do you really want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
                if (exit == DialogResult.Yes)
                {
                    dbCon.Close();
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Employee_Add employee_Add = new Employee_Add();
            employee_Add.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 0)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Receptionist");
                return;
            }
            Customer_Order_Details cOrder = new Customer_Order_Details();
            cOrder.Show();
        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_View employeeView = new Employee_View();
            string employeeID = " ";
            switch (e.ColumnIndex)
            {

                case 6:
                    Employee_View.edit = false;
                    employeeID = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    employeeView.GetEmployeeRow = employeeID;
                    employeeView.ShowDialog();
                    break;
                case 7:
                    Employee_View.edit = true;
                    employeeID = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    employeeView.GetEmployeeRow = employeeID;
                    employeeView.ShowDialog();
                    break;
                case 8:
                    employeeID = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Employee.EmployeeID = employeeID;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        empGrid.Rows.Clear();
                        Employee.deleteEmployee(empGrid);
                        Employee.LoadEmployees(empGrid);
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
            if (User.AccessLevel <= 2)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Owner");
                return;
            }
            Employee_Types EmployeeTypes = new Employee_Types();
            EmployeeTypes.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Product_Add product_Add = new Product_Add();
            product_Add.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Product_Types product_Types = new Product_Types();
            product_Types.Show();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Supplier_Add supplier_Add = new Supplier_Add();
            supplier_Add.ShowDialog();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Supplier_Orders supplier_Orders = new Supplier_Orders();
            supplier_Orders.Show();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_View service_View = new Service_View();
            string serviceID = "";
            switch (e.ColumnIndex)
            {

                case 4:
                    Service_View.edit = false;
                    serviceID = dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_View.GetServiceRow = serviceID;
                    service_View.ShowDialog();
                    break;
                case 5:
                    Service_View.edit = true;
                    serviceID = dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_View.GetServiceRow = serviceID;
                    service_View.ShowDialog();
                    break;
                case 6:
                    serviceID = dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dgvProducts.Rows.Clear();
                        try
                        {
                            dbCon = DBConnection.Instance();
                            if (dbCon.IsConnect())
                            {
                                string query = "DELETE FROM `service` WHERE service_id = '" + serviceID + "'";
                                var command = new MySqlCommand(query, dbCon.Connection);
                                command.ExecuteNonQuery();
                                loadServices();
                            }
                        }
                        catch (Exception)
                        {
                            System.Windows.Forms.MessageBox.Show("This service is used in a package. It can not be deleted.");
                        }
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
            string packageID;
            Photoshoot_Package_View photoshootPackage_View = new Photoshoot_Package_View();
            switch (e.ColumnIndex)
            {

                case 5:
                    Photoshoot_Package_View.edit = false;
                    packageID = dgvPhotoshootPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshootPackage_View.GetRow = packageID;
                    photoshootPackage_View.ShowDialog();
                    break;
                case 6:
                    Photoshoot_Package_View.edit = true;
                    packageID = dgvPhotoshootPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshootPackage_View.GetRow = packageID;
                    photoshootPackage_View.ShowDialog();
                    break;
                case 7:
                    packageID = dgvPhotoshootPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Photoshoot.GetRowPhotoshoot = packageID;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dgvPhotoshootPackage.Rows.Clear();
                        Photoshoot.DeletePhotoshoot(dgvPhotoshootPackage);
                        Photoshoot.LoadDGV(dgvPhotoshootPackage);
                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string productID = "";
            Product_View product_View = new Product_View();
            switch (e.ColumnIndex)
            {
                case 4:
                    Product_View.edit = false;
                    productID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_View.GetProductRow = productID;
                    product_View.ShowDialog();
                    break;
                case 5:
                    Product_View.edit = true;
                    productID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_View.GetProductRow = productID;
                    product_View.ShowDialog();
                    break;
                case 6:
                    productID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dgvProducts.Rows.Clear();
                        try
                        {
                            dbCon = DBConnection.Instance();
                            if (dbCon.IsConnect())
                            {
                                string query = "DELETE FROM `product` WHERE product_id = '" + productID + "'";
                                var command = new MySqlCommand(query, dbCon.Connection);
                                command.ExecuteNonQuery();
                                loadProducts();
                            }
                        }
                        catch (Exception)
                        {
                            System.Windows.Forms.MessageBox.Show("This product is used in a package. It can not be deleted.");
                        }
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
            string packageID;
            Event_Package_View eventPackage_View = new Event_Package_View();
            switch (e.ColumnIndex)
            {
                case 5:
                    Event_Package_View.edit = false;
                    packageID = dgvEventPackages.Rows[e.RowIndex].Cells[0].Value.ToString();
                    eventPackage_View.GetEventViewRow = packageID;
                    eventPackage_View.ShowDialog();
                    break;
                case 6:
                    Event_Package_View.edit = true;
                    packageID = dgvEventPackages.Rows[e.RowIndex].Cells[0].Value.ToString();
                    eventPackage_View.GetEventViewRow = packageID;
                    eventPackage_View.ShowDialog();
                    break;
                case 7:
                    packageID = dgvEventPackages.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Event.GetRowEvent = packageID;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dgvEventPackages.Rows.Clear();
                        Event.DeleteEvent(dgvEventPackages);
                        Event.LoadDGV(dgvEventPackages);
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
            string supplierName;
            Supplier_View supplier_View = new Supplier_View();
            switch (e.ColumnIndex)
            {

                case 4:
                    Supplier_View.edit = false;
                    supplierName = dataGridView10.Rows[e.RowIndex].Cells[0].Value.ToString();
                    supplier_View.GetSupplierRow = supplierName;
                    supplier_View.ShowDialog();
                    break;
                case 5:
                    Supplier_View.edit = true;
                    supplierName = dataGridView10.Rows[e.RowIndex].Cells[0].Value.ToString();
                    supplier_View.GetSupplierRow = supplierName;
                    supplier_View.ShowDialog();
                    break;
                case 6:
                    supplierName = dataGridView10.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        dataGridView10.Rows.Clear();
                        try
                        {
                            dbCon = DBConnection.Instance();
                            string supplierID = "";
                            string query = "SELECT supplier_id FROM supplier WHERE supplier_name = '" + supplierName + "'";
                            var command = new MySqlCommand(query, dbCon.Connection);
                            var reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                supplierID = reader.GetString(0);
                            }
                            reader.Close();
                            query = "DELETE FROM `supplier` WHERE supplier_id = '" + supplierID + "'";
                            command = new MySqlCommand(query, dbCon.Connection);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
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
            string employeeName = txtSearch.Text;
            Employee.EmployeeID = employeeName;
            empGrid.Rows.Clear();
            Employee.SearchEmployees(empGrid);
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {
        }

        private void TabPage6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            Booking.loadBookings(dgvBookings, txtBookingSearch.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string packageName = txtPhotoshootPackageSearch.Text;
            Photoshoot.GetRowPhotoshoot = packageName;
            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.SearchPhotoshootPackage(dgvPhotoshootPackage);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string packageName = txtEventPackageSearch.Text;
            Event.GetRowEvent = packageName;
            dgvEventPackages.Rows.Clear();
            Event.SearchEventPackage(dgvEventPackages);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Photoshoot_Types photoshoot_Types = new Photoshoot_Types();
            photoshoot_Types.ShowDialog();
        }


        private void BtnBookingCapture_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT c.customer_id FROM customer c JOIN booking b ON b.customer_id = c.customer_id ";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                Booking.customerID = reader.GetString(0);
                reader.Close();
                Booking.bookingID = dgvBookings.SelectedRows[0].Cells["bookingID"].Value.ToString();
                Booking_Capture_Payment capture_Payment = new Booking_Capture_Payment();
                capture_Payment.ShowDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void BtnBookingAdd_Click(object sender, EventArgs e)
        {
            Booking_Details details = new Booking_Details();
            var result = details.ShowDialog();
            if (result == DialogResult.Cancel)
                MessageBox.Show("Booking creation has been canceled");
        }

        private void BtnPhotoshootPackageAdd_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Photoshoot_Package_Add photoshootPackageAdd = new Photoshoot_Package_Add();
            photoshootPackageAdd.ShowDialog();
        }

        private void btnPhotoshootTypes_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel <= 1)
            {
                MessageBox.Show("Your user level is not high enough to do this.\nRequired level: Manager");
                return;
            }
            Photoshoot_Types photoshoot_Types = new Photoshoot_Types();
            photoshoot_Types.ShowDialog();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT product.product_id, product.product_name, product_type.product_type_name, product.product_price FROM product " +
                        "INNER JOIN product_type ON product.product_type_id=product_type.product_type_id " +
                        "WHERE product.product_name LIKE '%" + txtProductSearch.Text + "%' OR product_type.product_type_name LIKE '%" + txtProductSearch.Text + "%'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvProducts.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvServices.Rows.Clear();
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT service.service_id, service.service_name, service_type.service_type_name, service.service_price FROM service " +
                        "INNER JOIN service_type ON service.service_type_id=service_type.service_type_id " +
                        "WHERE service.service_name LIKE '%" + textBox2.Text + "%' OR service_type.service_type_name LIKE '%" + textBox2.Text + "%'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvServices.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderImages customerOI;
            Customer_Order_Capture customerPay = new Customer_Order_Capture();
            View_Order_Details viewOrder = new View_Order_Details();
            switch (e.ColumnIndex)
            {
                case 0:
                    OrderImages.orderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[2].Value);
                    customerOI = new OrderImages();
                    customerOI.ShowDialog();
                    break;
                case 5:
                    if (e.RowIndex >= 0)
                    {
                        int orderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
                        if (dbCon.IsConnect())
                        {
                            string checkStatus = "SELECT `customer_id` FROM `order` WHERE `order_id` = '" + orderID + "'";
                            var command = new MySqlCommand(checkStatus, dbCon.Connection);
                            var reader = command.ExecuteReader();
                            reader.Read();
                            if (reader.HasRows)
                            {

                                View_Order_Details.customerID = Convert.ToInt32(reader[0]);
                                View_Order_Details.order_id = orderID;
                                reader.Close();
                                viewOrder.ShowDialog();

                            }
                            reader.Close();
                        }
                    }
                    break;
                default:
                    break;

            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            PrepareOrder prepareCustOrdr = new PrepareOrder();
            prepareCustOrdr.ShowDialog();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            DeliverOrder deliveries = new DeliverOrder();
            deliveries.ShowDialog();
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            dgvServices.Rows.Clear();
            try
            {
                dbCon = DBConnection.Instance();
                string query = "SELECT supplier.supplier_name,supplier.supplier_email, supplier.supplier_phone, supplier_type.supplier_type_name FROM supplier " +
                        "INNER JOIN supplier_type ON supplier.supplier_type_id=supplier_type.supplier_type_id " +
                        "WHERE supplier.supplier_name LIKE '%" + textBox10.Text + "%' OR supplier_type.supplier_type_name LIKE '%" + textBox10.Text + "%' " +
                        "OR supplier.supplier_email LIKE '%" + textBox10.Text + "%' OR supplier.supplier_phone LIKE '%" + textBox10.Text + "%'";
                var command = new MySqlCommand(query, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView10.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "View", "Edit", "Delete");
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    //view
                    break;
                case 4:
                    //edit
                    break;
                case 5:
                    //delete
                    break;
                default:
                    break;
            }
        }

        private void BtnTimeslotAdd_Click(object sender, EventArgs e)
        {
            if (User.AccessLevel < 2)
            {
                MessageBox.Show("Your user level is not high enough. Required level: Manager");
                return;
            }
            Timeslot_Add timeslotAdd = new Timeslot_Add();
            timeslotAdd.ShowDialog();
        }

        private void dgvProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtProductSearch.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtProductSearch.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtProductSearch.Text.Trim().Length);
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

        private void dgvServices_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(textBox2.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(textBox2.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, textBox2.Text.Trim().Length);
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

        private void dgvPhotoshootPackage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtPhotoshootPackageSearch.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtPhotoshootPackageSearch.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtPhotoshootPackageSearch.Text.Trim().Length);
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

        private void dgvEventPackages_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtEventPackageSearch.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtEventPackageSearch.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtEventPackageSearch.Text.Trim().Length);
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

        private void empGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearch.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearch.Text.Trim().Length);
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

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtCustomerSearch.Text;
            Customer.CustomerID = customerName;
            dgvCustomers.Rows.Clear();
            Customer.SearchCustomer(dgvCustomers);
        }

        private void dgvCustomers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtCustomerSearch.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtCustomerSearch.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtCustomerSearch.Text.Trim().Length);
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

        private void txtSearchManual_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Enter(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("Training_Manual.pdf");
            axAcroPDF1.setShowToolbar(true);
            LoadTreeViewFromXmlFile("Treeview.xml", treeView1);
            treeView1.CollapseAll();
        }

        private void LoadTreeViewFromXmlFile(string filename, TreeView trv)
        {
            // Load the XML document.
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load(filename);

            // Add the root node's children to the TreeView.
            trv.Nodes.Clear();
            AddTreeViewChildNodes(trv.Nodes, xml_doc.DocumentElement);
        }

        private void AddTreeViewChildNodes(TreeNodeCollection parent_nodes, XmlNode xml_node)
        {
            foreach (XmlNode child_node in xml_node.ChildNodes)
            {
                // Make the new TreeView node.
                TreeNode new_node = parent_nodes.Add(child_node.Name);

                // Recursively make this node's descendants.
                AddTreeViewChildNodes(new_node.Nodes, child_node);

                // If this is a leaf node, make sure it's visible.
                if (new_node.Nodes.Count == 0) new_node.EnsureVisible();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            axAcroPDF1.Select();
            SendKeys.Send("^(S)");
        }

        private void tabPage12_Leave(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Customer")
                axAcroPDF1.setCurrentPage(28);
            else if (e.Node.Text == "Add_Customer")
                axAcroPDF1.setCurrentPage(28);
            else if (e.Node.Text == "Search_Customer")
                axAcroPDF1.setCurrentPage(32);
            else if (e.Node.Text == "Maintain_Customer")
                axAcroPDF1.setCurrentPage(34);
            else if (e.Node.Text == "Employee")
                axAcroPDF1.setCurrentPage(4);
            else if (e.Node.Text == "Add_Employee")
                axAcroPDF1.setCurrentPage(4);
            else if (e.Node.Text == "Search_Employee")
                axAcroPDF1.setCurrentPage(9);
            else if (e.Node.Text == "Maintain_Employee")
                axAcroPDF1.setCurrentPage(11);
            else if (e.Node.Text == "Add_Employee_Type")
                axAcroPDF1.setCurrentPage(15);
            else if (e.Node.Text == "Search_Employee_Type")
                axAcroPDF1.setCurrentPage(19);
            else if (e.Node.Text == "Maintain_Employee_Type")
                axAcroPDF1.setCurrentPage(22);
            else if (e.Node.Text == "Timeslots")
                axAcroPDF1.setCurrentPage(125);
            else if (e.Node.Text == "Add_Timeslot")
                axAcroPDF1.setCurrentPage(125);
            else if (e.Node.Text == "Search Timeslot")
                axAcroPDF1.setCurrentPage(125);
            else if (e.Node.Text == "Maintain_Timeslot")
                axAcroPDF1.setCurrentPage(1255);
            else if (e.Node.Text == "Services")
                axAcroPDF1.setCurrentPage(38);
            else if (e.Node.Text == "Add_Service")
                axAcroPDF1.setCurrentPage(38);
            else if (e.Node.Text == "Search_Service")
                axAcroPDF1.setCurrentPage(42);
            else if (e.Node.Text == "Maintain_Service")
                axAcroPDF1.setCurrentPage(45);
            else if (e.Node.Text == "Add_Service_Type")
                axAcroPDF1.setCurrentPage(48);
            else if (e.Node.Text == "Search_Service_Type")
                axAcroPDF1.setCurrentPage(52);
            else if (e.Node.Text == "Products")
                axAcroPDF1.setCurrentPage(55);
            else if (e.Node.Text == "Add_Product")
                axAcroPDF1.setCurrentPage(59);
            else if (e.Node.Text == "Search_Product")
                axAcroPDF1.setCurrentPage(59);
            else if (e.Node.Text == "Maintain_Product")
                axAcroPDF1.setCurrentPage(63);
            else if (e.Node.Text == "Add_Product_Type")
                axAcroPDF1.setCurrentPage(65);
            else if (e.Node.Text == "Search_Product_Type")
                axAcroPDF1.setCurrentPage(73);
            else if (e.Node.Text == "Maintain_Product_Type")
                axAcroPDF1.setCurrentPage(76);
            else if (e.Node.Text == "Photoshoots")
                axAcroPDF1.setCurrentPage(80);
            else if (e.Node.Text == "Add_Photoshoot_Package")
                axAcroPDF1.setCurrentPage(80);
            else if (e.Node.Text == "Search_Photoshoot_Package")
                axAcroPDF1.setCurrentPage(85);
            else if (e.Node.Text == "Maintain_Photoshoot_Package")
                axAcroPDF1.setCurrentPage(87);
            else if (e.Node.Text == "Add_Photoshoot_Type")
                axAcroPDF1.setCurrentPage(91);
            else if (e.Node.Text == "View_Photoshoot_Type")
                axAcroPDF1.setCurrentPage(96);
            else if (e.Node.Text == "Maintain_Photoshoot_Type")
                axAcroPDF1.setCurrentPage(99);
            else if (e.Node.Text == "Events")
                axAcroPDF1.setCurrentPage(104);
            else if (e.Node.Text == "Add_Event_Package")
                axAcroPDF1.setCurrentPage(104);
            else if (e.Node.Text == "Search_Event_Package")
                axAcroPDF1.setCurrentPage(107);
            else if (e.Node.Text == "Maintain_Event_Package")
                axAcroPDF1.setCurrentPage(110);
            else if (e.Node.Text == "Add_Event_Type")
                axAcroPDF1.setCurrentPage(113);
            else if (e.Node.Text == "View_Event_Type")
                axAcroPDF1.setCurrentPage(117);
            else if (e.Node.Text == "Maintain_Event_Type")
                axAcroPDF1.setCurrentPage(120);
            else if (e.Node.Text == "Customer_Order")
                axAcroPDF1.setCurrentPage(140);
            else if (e.Node.Text == "Place_Customer_Order")
                axAcroPDF1.setCurrentPage(140);
            else if (e.Node.Text == "Capture_Payment")
                axAcroPDF1.setCurrentPage(143);
        }

        private void BtnGenCustRpt_Click(object sender, EventArgs e)
        {
            CustomerReportList custRep = new CustomerReportList();
            custRep.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            axAcroPDF1.Select();
            SendKeys.Send("^f");
            SendKeys.Flush();
            SendKeys.Send(txtSearchManual.Text);
            SendKeys.Flush();
            SendKeys.Send("^g");
            SendKeys.Flush();
        }

        private void txtSearchManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                axAcroPDF1.Select();
                SendKeys.Send("^f");
                SendKeys.Flush();
                SendKeys.Send(txtSearchManual.Text);
                SendKeys.Flush();
                SendKeys.Send("^g");
                SendKeys.Flush();
            }
        }
        private void LblDebug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User access level: " + User.AccessLevel.ToString());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimeInactive.Text = User.GetLastInputTime().ToString();
            lblUser.Text = "Logged in as: " + User.Name;
            if (User.lastInputTime() > Settings.Timeout)
            {
                timer1.Stop();
                User.logout();
                MessageBox.Show("You have been logged out due to inactivity");
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Training_Manual.pdf"));
        }

        private void Main_Form_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Customer_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Employee_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Timeslots_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Services_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Products_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Photoshoots_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Photoshoots_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Customer_Order_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage9)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Booking_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage10)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Supplier_Tab_Page";
                helpForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage11)
            {
                HelpForm helpForm = new HelpForm();
                helpForm.HelpInfo = "Reports_Tab_Page";
                helpForm.ShowDialog();
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            User.logout();
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}