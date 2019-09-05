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
    public partial class Product_Types : Form
    {
        public Product_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Product_Type_Add product_Type_Add = new Product_Type_Add();
            product_Type_Add.ShowDialog();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_Types_View product_Types_View = new Product_Types_View();
            string productTypeID = "";
            switch (e.ColumnIndex)
            {

                case 3:
                    Product_Types_View.edit = false;
                    productTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_Types_View.GetProductTypeRow = productTypeID;
                    product_Types_View.ShowDialog();
                    break;
                case 4:
                    Product_Types_View.edit = true;
                    productTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    product_Types_View.GetProductTypeRow = productTypeID;
                    product_Types_View.ShowDialog();
                    break;
                case 5:
                    productTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string query = "DELETE FROM `product_type` WHERE product_type_id = '" + productTypeID + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception)
                        {
                            System.Windows.Forms.MessageBox.Show("This product type contains services. It can not be deleted.");
                        }
                        dataGridView7.Rows.Clear();
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string productTypesID = " ";
                                string productTypeName = " ";
                                string prpductTypeDescription = " ";
                                DataTable ProductTypes = new DataTable();
                                string query = "SELECT product_type_id, product_type_name, product_type_description FROM product_type";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                ProductTypes.Load(reader);
                                for (int i = 0; i < ProductTypes.Rows.Count; i++)
                                {
                                    productTypesID = ProductTypes.Rows[i].ItemArray[0].ToString();
                                    productTypeName = ProductTypes.Rows[i].ItemArray[1].ToString();
                                    prpductTypeDescription = ProductTypes.Rows[i].ItemArray[2].ToString();
                                    dataGridView7.Rows.Add(productTypesID, productTypeName, prpductTypeDescription, "View", "Edit", "Delete");
                                }
                                reader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);

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

        private void Product_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string productTypeID = " ";
                    string productTypeName = " ";
                    string prpductTypeDescription = " ";
                    DataTable ProductTypes = new DataTable();
                    string query = "SELECT product_type_id, product_type_name, product_type_description FROM product_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ProductTypes.Load(reader);
                    for (int i = 0; i < ProductTypes.Rows.Count; i++)
                    {
                        productTypeID = ProductTypes.Rows[i].ItemArray[0].ToString();
                        productTypeName = ProductTypes.Rows[i].ItemArray[1].ToString();
                        prpductTypeDescription = ProductTypes.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(productTypeID, productTypeName, prpductTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    dataGridView7.Rows.Clear();
                    string productTypeID = " ";
                    string productTypeName = " ";
                    string prpductTypeDescription = " ";
                    DataTable ProductTypes = new DataTable();
                    string query = "SELECT product_type_id, product_type_name, product_type_description FROM product_type WHERE product_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "product_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ProductTypes.Load(reader);
                    for (int i = 0; i < ProductTypes.Rows.Count; i++)
                    {
                        productTypeID = ProductTypes.Rows[i].ItemArray[0].ToString();
                        productTypeName = ProductTypes.Rows[i].ItemArray[1].ToString();
                        prpductTypeDescription = ProductTypes.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(productTypeID, productTypeName, prpductTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
        }

        private void Product_Types_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // High light and searching apply over selective fields of grid.  
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(textBox7.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(textBox7.Text.Trim().ToLower());
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
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, textBox7.Text.Trim().Length);
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
}
