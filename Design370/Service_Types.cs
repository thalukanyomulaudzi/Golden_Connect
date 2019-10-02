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
    public partial class Service_Types : Form
    {
        public Service_Types()
        {
            InitializeComponent();
        }


        private void Button14_Click_1(object sender, EventArgs e)
        {
            Service_Types_Add service_Types_Add = new Service_Types_Add();
            service_Types_Add.ShowDialog();
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_Types_View service_Types_View = new Service_Types_View();
            string serviceTypeID = "";
            switch (e.ColumnIndex)
            {

                case 3:
                    Service_Types_View.edit = false;
                    serviceTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_Types_View.GetServiceTypeRow = serviceTypeID;
                    service_Types_View.ShowDialog();
                    break;
                case 4:
                    Service_Types_View.edit = true;
                    serviceTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    service_Types_View.GetServiceTypeRow = serviceTypeID;
                    service_Types_View.ShowDialog();
                    break;
                case 5:
                    serviceTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string query = "DELETE FROM `service_type` WHERE service_type_id = '" + serviceTypeID + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception)
                        {
                            System.Windows.Forms.MessageBox.Show("This service type contains services. It can not be deleted.");
                        }
                        dataGridView7.Rows.Clear();
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string serviceTypesID = " ";
                                string serviceTypeName = " ";
                                string serviceTypeDescription = " ";
                                DataTable ServiceTypes = new DataTable();
                                string query = "SELECT service_type_id, service_type_name, service_type_description FROM service_type";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                ServiceTypes.Load(reader);
                                for (int i = 0; i < ServiceTypes.Rows.Count; i++)
                                {
                                    serviceTypesID = ServiceTypes.Rows[i].ItemArray[0].ToString();
                                    serviceTypeName = ServiceTypes.Rows[i].ItemArray[1].ToString();
                                    serviceTypeDescription = ServiceTypes.Rows[i].ItemArray[2].ToString();
                                    dataGridView7.Rows.Add(serviceTypesID, serviceTypeName, serviceTypeDescription, "View", "Edit", "Delete");
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

        private void Service_Types_Load(object sender, EventArgs e)
        {

        }

        private void Service_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string serviceTypeID = " ";
                    string serviceTypeName = " ";
                    string serviceTypeDescription = " ";
                    DataTable ServiceTypes = new DataTable();
                    string query = "SELECT service_type_id, service_type_name, service_type_description FROM service_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ServiceTypes.Load(reader);
                    for (int i = 0; i < ServiceTypes.Rows.Count; i++)
                    {
                        serviceTypeID = ServiceTypes.Rows[i].ItemArray[0].ToString();
                        serviceTypeName = ServiceTypes.Rows[i].ItemArray[1].ToString();
                        serviceTypeDescription = ServiceTypes.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(serviceTypeID, serviceTypeName, serviceTypeDescription, "View", "Edit", "Delete");
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
                    string serviceTypeID = " ";
                    string serviceTypeName = " ";
                    string serviceTypeDescription = " ";
                    DataTable ServiceTypes = new DataTable();
                    string query = "SELECT service_type_id, service_type_name, service_type_description FROM service_type WHERE service_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "service_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    ServiceTypes.Load(reader);
                    for (int i = 0; i < ServiceTypes.Rows.Count; i++)
                    {
                        serviceTypeID = ServiceTypes.Rows[i].ItemArray[0].ToString();
                        serviceTypeName = ServiceTypes.Rows[i].ItemArray[1].ToString();
                        serviceTypeDescription = ServiceTypes.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(serviceTypeID, serviceTypeName, serviceTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
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
