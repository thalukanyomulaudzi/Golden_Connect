using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Design370
{
    public partial class Main_Form : Form
    {
        DBConnection dbCon = DBConnection.Instance();
        public Main_Form()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip { ShowAlways = true };
            toolTip1.SetToolTip(txtPhotoshootPackageSearch, "Enter package name");

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
            Customer_Add customerAdd = new Customer_Add();
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
            //Order.LoadOrders(dgvOrders);
            //testConnection(); //this throws out all customer names and surnames, only use during development
            Timeslot.loadTimeslots(dgvTimeslots, DateTime.Today);
            Booking.loadBookings(dgvBookings);

            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.LoadDGV(dgvPhotoshootPackage);
            dgvEventPackages.Rows.Clear();
            Event.LoadDGV(dgvEventPackages);
            dgvProducts.Rows.Clear();
            loadProducts();
            dgvServices.Rows.Clear();
            loadServices();
            dataGridView10.Rows.Clear();
            loadSuppliers();
            empGrid.Rows.Clear();
            Employee.LoadEmployees(empGrid);
            dgvCustomers.Rows.Clear();
            Customer.LoadCustomer(dgvCustomers);
        }

        public void loadSuppliers()
        {
            try
            {
                if (dbCon.IsConnect())
                {
                    string query = "SELECT supplier.supplier_name,supplier.supplier_email, supplier.supplier_phone, supplier_type.supplier_type_name FROM supplier " +
                        "INNER JOIN supplier_type ON supplier.supplier_type_id=supplier_type.supplier_type_id";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView10.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
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
                if (dbCon.IsConnect())
                {
                    string query = "SELECT service.service_id, service.service_name, service_type.service_type_name, service.service_price FROM service INNER JOIN service_type ON service.service_type_id=service_type.service_type_id";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvServices.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
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
                if (dbCon.IsConnect())
                {
                    string query = "SELECT product.product_id, product.product_name, product_type.product_type_name, product.product_price FROM product INNER JOIN product_type ON product.product_type_id=product_type.product_type_id";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvProducts.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "R" + reader.GetString(3), "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private bool connectDB()
        {
            dbCon.DatabaseName = "golden_connect";
            return (dbCon.IsConnect());
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
                reader.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
            Event_Package_Add eventPackageAdd = new Event_Package_Add();
            eventPackageAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event_Types eventTypes = new Event_Types();
            eventTypes.ShowDialog();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Employee_Add employee_Add = new Employee_Add();
            employee_Add.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Customer_Order_Details cOrder = new Customer_Order_Details();
            cOrder.ShowDialog();
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
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string query = "DELETE FROM `service` WHERE service_id = '" + serviceID + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
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
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string query = "DELETE FROM `product` WHERE product_id = '" + productID + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
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
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string supplierID = "";
                                string query = "SELECT supplier_id FROM supplier WHERE supplier_name = '" + supplierName + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    supplierID = reader.GetString(0);
                                }
                                reader.Close();
                                query = "DELETE FROM `supplier` WHERE supplier_id = '" + supplierID + "'";
                                command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception except)
                        {
                            System.Windows.Forms.MessageBox.Show("This supplier is used in a supplier order. It can not be deleted.");
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

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            Timeslot.loadTimeslots(dgvTimeslots,DateTime.Now);
            dgvPhotoshootPackage.Rows.Clear();
            Photoshoot.LoadDGV(dgvPhotoshootPackage);
            dgvEventPackages.Rows.Clear();
            Event.LoadDGV(dgvEventPackages);
            dgvProducts.Rows.Clear();
            loadProducts();
            dgvServices.Rows.Clear();
            loadServices();
            dataGridView10.Rows.Clear();
            loadSuppliers();
            empGrid.Rows.Clear();
            Employee.LoadEmployees(empGrid);
            dgvCustomers.Rows.Clear();
            Customer.LoadCustomer(dgvCustomers);
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

        private void CbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnCaptureOrderPayment_Click(object sender, EventArgs e)
        {
            //Customer_Order_Capture newPayment = new Customer_Order_Capture();
            //newPayment.ShowDialog();
        }

        private void BtnBookingCapture_Click(object sender, EventArgs e)
        {
            try
            {
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
            Photoshoot_Package_Add photoshootPackageAdd = new Photoshoot_Package_Add();
            photoshootPackageAdd.ShowDialog();
        }

        private void btnPhotoshootTypes_Click(object sender, EventArgs e)
        {
            Photoshoot_Types photoshoot_Types = new Photoshoot_Types();
            photoshoot_Types.ShowDialog();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            try
            {
                if (dbCon.IsConnect())
                {
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
                if (dbCon.IsConnect())
                {
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
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void DgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderImages customerOI = new OrderImages();
            Customer_Order_Capture customerPay = new Customer_Order_Capture();
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
                        if (dbCon.IsConnect())
                        {
                            dbCon.Close();
                            dbCon.Open();
                            string checkStatus = "SELECT * FROM `order`, `order_status` WHERE `order`.`order_status_id` = `order_status`.`order_status_id` AND `order_status`.`order_status_name` = 'Pending' AND `order`.`order_id` = '" + dgvOrders.Rows[e.RowIndex].Cells[0].Value + "'";
                            var command = new MySqlCommand(checkStatus, dbCon.Connection);
                            var reader = command.ExecuteReader();
                            reader.Read();
                            if (reader.HasRows)
                            {
                                Customer_Order_Capture.OrderPaymentID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
                                customerPay.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Order already paid, check order status.", "Customer Order Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (dbCon.IsConnect())
                {
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

                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        private void BtnTimeslotAdd_Click(object sender, EventArgs e)
        {
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
    }

    //private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    //{

        
    //}
}