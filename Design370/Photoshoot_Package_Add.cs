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
    public partial class Photoshoot_Package_Add : Form
    {
        string serviceID = " ";
        string productID = " ";
        string serviceTypeID = " ";
        string productTypeID = " ";
        double TotalPrice = 0;
        List<string> Services = new List<string>();
        List<string> Products = new List<string>();
        public Photoshoot_Package_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtPackageName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtPackageDescription, "A maximum of 200 characters can be entered");
        }

        private void Photoshoot_Package_Add_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    DataTable Services = new DataTable();
                    DataTable Products = new DataTable();
                    serviceTypeID = " ";
                    string query = "SELECT service_type_id FROM service_type WHERE service_type_name = 'Photoshoot'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    serviceTypeID = reader.GetString(0);
                    reader.Close();
                    query = "SELECT service_id, service_name, service_price FROM service WHERE service_type_id = '" + serviceTypeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Services.Load(reader);
                    reader.Close();
                    for (int i = 0; i < Services.Rows.Count; i++)
                    {
                        dgvServices.Rows.Add(Services.Rows[i].ItemArray[0], Services.Rows[i].ItemArray[1], "R" + Services.Rows[i].ItemArray[2], "Add");
                    }
                    productTypeID = " ";
                    query = "SELECT product_type_id FROM product_type WHERE product_type_name = 'Photoshoot'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    productTypeID = reader.GetString(0);
                    reader.Close();
                    query = "SELECT product_id, product_name, product_price FROM product WHERE product_type_id = '" + productTypeID + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    Products.Load(reader);
                    reader.Close();
                    for (int i = 0; i < Products.Rows.Count; i++)
                    {
                        dgvProducts.Rows.Add(Products.Rows[i].ItemArray[0], Products.Rows[i].ItemArray[1], "R" + Products.Rows[i].ItemArray[2], "Add");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Photoshoot_Package_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
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
                    string package_type = "";
                    int booking_package_id = 0;
                    string query = "SELECT booking_package_type_id FROM booking_package_type WHERE booking_package_type_name = 'Photoshoot'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    package_type = reader.GetString(0);
                    reader.Close();
                    query = "INSERT INTO `booking_package` (`booking_package_id`, `booking_package_name`, `booking_package_description`, `booking_package_type_id`) VALUES";
                    query += "(NULL, '" + txtPackageName.Text + "', '" + txtPackageDescription.Text + "', '" + package_type + "')";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    command.ExecuteNonQuery();
                    query = "SELECT booking_package_id FROM booking_package WHERE booking_package_name = '" + txtPackageName.Text + "'";
                    command = new MySqlCommand(query, dBConnection.Connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    booking_package_id = Convert.ToInt32(reader.GetInt32(0));
                    reader.Close();
                    for (int i = 0; i < Services.Rows.Count; i++)
                    {
                        query = "INSERT INTO `booking_package_service` (`booking_package_id`, `service_id`) VALUES('" + booking_package_id + "', " +
                            "'" + Services.Rows[i].ItemArray[0] + "')";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                    }
                    for (int j = 0; j < Products.Rows.Count; j++)
                    {
                        query = "INSERT INTO `booking_package_product` (`booking_package_id`, `product_id`, `booking_package_product_quantity`) VALUES" +
                            "('" + booking_package_id + "', '" + Products.Rows[j].ItemArray[0] + "', '" + Products.Rows[j].ItemArray[2] + "')";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
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
            
        }

        private void dgvProductsInPackage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
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
            
        }

        private void dgvServicesInPackage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void TxtPackageName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPackageName, Validation.validate(txtPackageName.Text, "name"));
        }

        private void TxtPackageDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblPackageDescription, Validation.validate(txtPackageDescription.Text, "name"));
        }

        private void Photoshoot_Package_Add_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Add_Photoshoot_Package";
            helpForm.ShowDialog();
        }
    }
}
