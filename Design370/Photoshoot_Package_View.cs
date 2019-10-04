using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Design370
{
    public partial class Photoshoot_Package_View : Form
    {
        public static bool edit;
        string bookingPackageName = " ";
        string serviceID = " ";
        string productID = " ";
        string serviceTypeID = " ";
        string productTypeID = " ";
        double TotalPrice = 0;
        public string GetRow { get; set; }
        List<string> Products = new List<string>();
        List<string> Services = new List<string>();

        public Photoshoot_Package_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtPackageName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtPackageDescription, "A maximum of 200 characters can be entered");
        }

        private void PhotoshootPackage_View_Load(object sender, EventArgs e)
        {
            txtPackageName.Enabled = edit;
            txtPackageDescription.Enabled = edit;
            textBox3.Enabled = edit;
            txtSearchServices.Enabled = edit;
            txtSearchProducts.Enabled = edit;
            txtSearchPIP.Enabled = edit;
            txtSearchSIP.Enabled = edit;
            dgvProducts.Enabled = edit;
            dgvServices.Enabled = edit;
            dgvProductsInPackage.Enabled = edit;
            dgvServicesInPackage.Enabled = edit;
            button5.Enabled = !edit;

            int booking_package_id;
            double price = 0;
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    productTypeID = " ";
                    string query = "SELECT product_type_id FROM product_type WHERE product_type_name = 'Photoshoot';";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    productTypeID = reader.GetString(0);
                    reader.Close();
                    query = "SELECT booking_package_name, booking_package_description FROM booking_package WHERE booking_package_id = '" + GetRow + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookingPackageName = reader.GetString(0);
                        txtPackageName.Text = reader.GetString(0);
                        txtPackageDescription.Text = reader.GetString(1);
                    }
                    reader.Close();
                    booking_package_id = Convert.ToInt32(GetRow);
                    query = "SELECT product_id, booking_package_product_quantity FROM booking_package_product WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Product = new DataTable();
                    DataTable Product2 = new DataTable();
                    DataTable Product3 = new DataTable();
                    DataTable ProductType = new DataTable();
                    Product.Load(reader);
                    for (int i = 0; i < Product.Rows.Count; i++)
                    {
                        query = "SELECT product.product_id, product.product_name, product.product_price, booking_package_product.booking_package_product_quantity " +
                            "FROM product INNER JOIN booking_package_product ON product.product_id = booking_package_product.product_id" +
                            " WHERE product.product_id = '" + Product.Rows[i].ItemArray[0] + "' AND booking_package_product.booking_package_id = '" + booking_package_id + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Product2.Clear();
                        Product2.Load(reader);
                        for (int j = 0; j < Product2.Rows.Count; j++)
                        {
                            price = Convert.ToDouble(Product2.Rows[j].ItemArray[3])*Convert.ToDouble(Product2.Rows[j].ItemArray[2]);
                            dgvProductsInPackage.Rows.Add(Product2.Rows[j].ItemArray[0], Product2.Rows[j].ItemArray[1],Product2.Rows[j].ItemArray[3],"R" + string.Format("{0:0.00}", price), "Add", "Remove");
                            TotalPrice += (Convert.ToDouble(Product2.Rows[j].ItemArray[2]) * Convert.ToDouble(Product2.Rows[j].ItemArray[3]));
                        }
                        reader.Close();
                    }
                    reader.Close();
                    query = "SELECT product_id, product_name, product_price FROM product WHERE product_type_id = '" + productTypeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Product3.Load(reader);
                    for (int m = 0; m < Product3.Rows.Count; m++)
                    {
                        dgvProducts.Rows.Add(Product3.Rows[m].ItemArray[0], Product3.Rows[m].ItemArray[1],"R" + Product3.Rows[m].ItemArray[2], "Add");
                    }
                    serviceTypeID = " ";
                    query = "SELECT service_type_id FROM service_type WHERE service_type_name = 'Photoshoot';";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    serviceTypeID = reader.GetString(0);
                    reader.Close();
                    query = "SELECT service_id FROM booking_package_service WHERE booking_package_id = '" + booking_package_id + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    DataTable Service = new DataTable();
                    DataTable Service2 = new DataTable();
                    DataTable Service3 = new DataTable();
                    Service.Load(reader);
                    for (int k = 0; k < Service.Rows.Count; k++)
                    {
                        query = "SELECT service_id, service_name, service_price FROM service WHERE service_id = '" + Service.Rows[k].ItemArray[0] + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        Service2.Clear();
                        Service2.Load(reader);
                        for (int l = 0; l < Service2.Rows.Count; l++)
                        {
                            dgvServicesInPackage.Rows.Add(Service2.Rows[l].ItemArray[0], Service2.Rows[l].ItemArray[1], "R" + Service2.Rows[l].ItemArray[2], "Remove");
                            TotalPrice += Convert.ToDouble(Service2.Rows[l].ItemArray[2]);
                        }
                        reader.Close();
                    }
                    reader.Close();
                    query = "SELECT service_id, service_name, service_price FROM service WHERE service_type_id = '" + serviceTypeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Service3.Load(reader);
                    for (int p = 0; p < Service3.Rows.Count; p++)
                    {
                        dgvServices.Rows.Add(Service3.Rows[p].ItemArray[0], Service3.Rows[p].ItemArray[1], "R" + Service3.Rows[p].ItemArray[2], "Add");
                    }
                    reader.Close();
                }
            
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
            textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtPackageName.Enabled = true;
            txtPackageDescription.Enabled = true;
            textBox3.Enabled = true;
            txtSearchProducts.Enabled = true;
            txtSearchServices.Enabled = true;
            txtSearchSIP.Enabled = true;
            txtSearchPIP.Enabled = true;
            dgvProducts.Enabled = true;
            dgvServices.Enabled = true;
            dgvProductsInPackage.Enabled = true;
            dgvServicesInPackage.Enabled = true;
            button5.Enabled = false;
        }

        private void PhotoshootPackage_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (txtPackageName.Enabled)
            {
                DataTable Services = new DataTable();
                DataTable Products = new DataTable();
                if (!Validation.validate(txtPackageName.Text, "name") || !Validation.validate(txtPackageDescription.Text, "name"))
                {
                    MessageBox.Show("Name and description must be valid");
                    return;
                }
                if (dgvServicesInPackage.Rows.Count == 0)
                {
                    MessageBox.Show("No services have been added to the package");
                    return;
                }
                else if (dgvProductsInPackage.Rows.Count == 0)
                {
                    MessageBox.Show("No products have been added to the package");
                    return;
                }
                foreach (DataGridViewColumn column in dgvServicesInPackage.Columns)
                {
                    Services.Columns.Add(column.Name);
                }
                foreach (DataGridViewRow row in dgvServicesInPackage.Rows)
                {
                    DataRow dRow = Services.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    Services.Rows.Add(dRow);
                }
                foreach (DataGridViewColumn column in dgvProductsInPackage.Columns)
                {
                    Products.Columns.Add(column.Name);
                }
                foreach (DataGridViewRow row in dgvProductsInPackage.Rows)
                {
                    DataRow dRow = Products.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    Products.Rows.Add(dRow);
                }
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        int booking_package_id = 0;
                        string package_type = " ";
                        string query = "SELECT booking_package_type_id FROM booking_package_type WHERE booking_package_type_name = 'Photoshoot'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            package_type = reader.GetString(0);
                        } 
                        reader.Close();
                        query = "SELECT booking_package_id FROM booking_package WHERE booking_package_name = '" + bookingPackageName + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            booking_package_id = reader.GetInt32(0);
                        }
                        reader.Close();
                        query = "DELETE FROM `booking_package_product` WHERE booking_package_id = '" + booking_package_id + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                        query = "DELETE FROM `booking_package_service` WHERE booking_package_id = '" + booking_package_id + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                        query = "DELETE FROM `booking_package` WHERE booking_package_id = '" + booking_package_id + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                        query = "INSERT INTO `booking_package` (`booking_package_id`, `booking_package_name`, `booking_package_description`, `booking_package_type_id`) VALUES";
                        query += "('" + booking_package_id + "', '" + txtPackageName.Text + "', '" + txtPackageDescription.Text + "', '" + package_type + "')";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                        for (int k = 0; k < Services.Rows.Count; k++)
                        {
                            query = "INSERT INTO `booking_package_service` (`booking_package_id`, `service_id`) VALUES('" + booking_package_id + "', " +
                            "'" + Services.Rows[k].ItemArray[0] + "')";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                        for (int l = 0; l < Products.Rows.Count; l++)
                        {
                            query = "INSERT INTO `booking_package_product` (`booking_package_id`, `product_id`, `booking_package_product_quantity`) VALUES" +
                                "('" + booking_package_id + "', '" + Products.Rows[l].ItemArray[0] + "', '" + Products.Rows[l].ItemArray[2] + "')";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                catch (Exception except)
                {

                    MessageBox.Show(except.Message);
                }
                this.Close();
            }
            this.Close();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection dBConnection = DBConnection.Instance();
            switch (e.ColumnIndex)
            {
                case 3:
                    try
                    {
                        if (dBConnection.IsConnect())
                        {
                            Services.Clear();
                            serviceID = dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string query = "SELECT service_id, service_name, service_price FROM service WHERE service_id = '" + serviceID + "'";
                            var command = new MySqlCommand(query, dBConnection.Connection);
                            var reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (dgvServicesInPackage.Rows.Count == 0)
                                {
                                    dgvServicesInPackage.Rows.Add(reader.GetString(0), reader.GetString(1), "R" + reader.GetString(2), "Remove");
                                    TotalPrice += reader.GetDouble(2);
                                    textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                                }
                                else
                                {
                                    foreach (DataGridViewRow item in dgvServicesInPackage.Rows)
                                    {
                                        Services.Add(item.Cells[0].Value.ToString());
                                    }
                                    if (dgvServicesInPackage.Rows.ToString().Contains(reader.GetString(0)) || Services.Contains(reader.GetString(0)))
                                    {
                                        MessageBox.Show("This service is already in the package");
                                    }
                                    else
                                    {
                                        dgvServicesInPackage.Rows.Add(reader.GetString(0), reader.GetString(1), "R" + reader.GetString(2), "Remove");
                                        TotalPrice += reader.GetDouble(2);
                                        textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                                    }
                                }
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgvServicesInPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection dBConnection = DBConnection.Instance();
            string itemString = " ";
            int posid = 0;
            switch (e.ColumnIndex)
            {
                case 3:
                    try
                    {
                        if (dBConnection.IsConnect())
                        {
                            posid = dgvServicesInPackage.Rows[e.RowIndex].Cells[2].Value.ToString().IndexOf("R");
                            itemString = dgvServicesInPackage.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(posid + 1);
                            TotalPrice -= Convert.ToDouble(itemString);
                            dgvServicesInPackage.Rows.Remove(dgvServicesInPackage.Rows[e.RowIndex]);
                            textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection dBConnection = DBConnection.Instance();
            switch (e.ColumnIndex)
            {
                case 3:
                    try
                    {
                        if (dBConnection.IsConnect())
                        {
                            Products.Clear();
                            productID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string query = "SELECT product_id, product_name, product_price FROM product WHERE product_id = '" + productID + "'";
                            var command = new MySqlCommand(query, dBConnection.Connection);
                            var reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (dgvProductsInPackage.Rows.Count == 0)
                                {
                                    dgvProductsInPackage.Rows.Add(reader.GetString(0), reader.GetString(1), "1", "R" + reader.GetString(2), "Add", "Remove");
                                    TotalPrice += reader.GetDouble(2);
                                    textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                                }
                                else
                                {
                                    foreach (DataGridViewRow item in dgvProductsInPackage.Rows)
                                    {
                                        Products.Add(item.Cells[0].Value.ToString());
                                    }
                                    if (dgvProductsInPackage.Rows.ToString().Contains(reader.GetString(0)) || Products.Contains(reader.GetString(0)))
                                    {
                                        MessageBox.Show("This product is already in the package. To add to its quantity, use the add button in the table on the left");
                                    }
                                    else
                                    {
                                        dgvProductsInPackage.Rows.Add(reader.GetString(0), reader.GetString(1), "1", "R" + reader.GetString(2), "Add", "Remove");
                                        TotalPrice += reader.GetDouble(2);
                                        textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                                    }
                                }
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgvProductsInPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection dBConnection = DBConnection.Instance();
            string productInPackage = " ";
            string itemString = " ";
            string prodName = " ";
            int productQuantity = 0, posid = 0;
            double productPrice = 0;
            switch (e.ColumnIndex)
            {
                case 4:
                    try
                    {
                        if (dBConnection.IsConnect())
                        {
                            productInPackage = dgvProductsInPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                            productQuantity = Convert.ToInt32(dgvProductsInPackage.Rows[e.RowIndex].Cells[2].Value);
                            posid = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().IndexOf("R");
                            itemString = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(posid + 1);
                            productPrice = Convert.ToDouble(itemString);
                            productQuantity += 1;
                            string query = "SELECT product_id, product_name, product_price FROM product WHERE product_id = '" + productInPackage + "'";
                            var command = new MySqlCommand(query, dBConnection.Connection);
                            var reader = command.ExecuteReader();
                            reader.Read();
                            productPrice += Convert.ToDouble(reader.GetString(2));
                            TotalPrice += reader.GetDouble(2);
                            textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                            dgvProductsInPackage.Rows[e.RowIndex].SetValues(reader.GetString(0), reader.GetString(1), productQuantity, "R" + string.Format("{0:0.00}", productPrice), "Add", "Remove");
                            reader.Close();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        if (dBConnection.IsConnect())
                        {
                            productInPackage = dgvProductsInPackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                            prodName = dgvProductsInPackage.Rows[e.RowIndex].Cells[1].Value.ToString();
                            productQuantity = Convert.ToInt32(dgvProductsInPackage.Rows[e.RowIndex].Cells[2].Value);
                            posid = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().IndexOf("R");
                            itemString = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(posid + 1);
                            productPrice = Convert.ToDouble(itemString);
                            if (productQuantity >= 2)
                            {
                                string query = "SELECT product_id, product_name, product_price FROM product WHERE product_id = '" + productInPackage + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                reader.Read();
                                productPrice -= Convert.ToDouble(reader.GetString(2));
                                TotalPrice -= reader.GetDouble(2);
                                textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                                reader.Close();
                                productQuantity -= 1;
                                dgvProductsInPackage.Rows[e.RowIndex].SetValues(productInPackage, prodName, productQuantity, "R" + string.Format("{0:0.00}", productPrice), "Add", "Remove");
                            }
                            else if (productQuantity == 1)
                            {
                                posid = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().IndexOf("R");
                                itemString = dgvProductsInPackage.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(posid + 1);
                                dgvProductsInPackage.Rows.Remove(dgvProductsInPackage.Rows[e.RowIndex]);
                                TotalPrice -= Convert.ToDouble(itemString);
                                textBox3.Text = "R" + string.Format("{0:0.00}", TotalPrice);
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    string query = "SELECT product_id, product_name, product_price FROM product " +
                        "WHERE product_name LIKE '%" + txtSearchProducts.Text + "%' AND product_type_id = '" + productTypeID + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvProducts.Rows.Add(reader.GetString(0), reader.GetString(1), "R" + reader.GetString(2), "Add");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dgvProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearchProducts.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearchProducts.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearchProducts.Text.Trim().Length);
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

        private void txtSearchPIP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvProductsInPackage.Rows];
                    currencyManager.SuspendBinding();
                    for (int i = 0; i < dgvProductsInPackage.Rows.Count; i++)
                    {
                        dgvProductsInPackage.Rows[i].Visible = true;
                    }
                    for (int u = 0; u < dgvProductsInPackage.RowCount; u++)
                    {
                        if (dgvProductsInPackage.Rows[u].Cells[1].Value.ToString().Contains(txtSearchPIP.Text))
                        {
                            dgvProductsInPackage.Rows[u].Visible = true;
                        }
                        else
                        {
                            dgvProductsInPackage.Rows[u].Visible = false;
                        }
                    }
                    currencyManager.ResumeBinding();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dgvProductsInPackage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex == 1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearchPIP.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearchPIP.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearchPIP.Text.Trim().Length);
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

        private void txtSearchServices_TextChanged(object sender, EventArgs e)
        {
            dgvServices.Rows.Clear();
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    string query = "SELECT service_id, service_name, service_price FROM service " +
                        "WHERE service_name LIKE '%" + txtSearchServices.Text + "%' AND service_type_id = '" + serviceTypeID + "'";
                    var command = new MySqlCommand(query, dbCon.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvServices.Rows.Add(reader.GetString(0), reader.GetString(1), "R" + reader.GetString(2), "Add");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dgvServices_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearchServices.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearchServices.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearchServices.Text.Trim().Length);
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

        private void txtSearchSIP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvProductsInPackage.Rows];
                    currencyManager.SuspendBinding();
                    for (int i = 0; i < dgvProductsInPackage.Rows.Count; i++)
                    {
                        dgvProductsInPackage.Rows[i].Visible = true;
                    }
                    for (int u = 0; u < dgvProductsInPackage.RowCount; u++)
                    {
                        if (dgvProductsInPackage.Rows[u].Cells[1].Value.ToString().Contains(txtSearchPIP.Text))
                        {
                            dgvProductsInPackage.Rows[u].Visible = true;
                        }
                        else
                        {
                            dgvProductsInPackage.Rows[u].Visible = false;
                        }
                    }
                    currencyManager.ResumeBinding();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dgvServicesInPackage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex == 1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtSearchSIP.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtSearchSIP.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtSearchSIP.Text.Trim().Length);
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

        private void TxtPackageName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPackageName, Validation.validate(txtPackageName.Text, "name"));
        }

        private void TxtPackageDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPackageDescription, Validation.validate(txtPackageDescription.Text, "name"));
        }
    }
}
