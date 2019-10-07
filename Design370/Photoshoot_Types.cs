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
    public partial class Photoshoot_Types : Form
    {
        public Photoshoot_Types()
        {
            InitializeComponent();
        }

        private void Photoshoot_Types_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    dataGridView7.Rows.Clear();
                    string photoshootTypeID = " ";
                    string photoshootTypeName = " ";
                    string photoshootTypeDescription = " ";
                    DataTable PhotoshootType = new DataTable();
                    string query = "SELECT photoshoot_type_id, photoshoot_type_name, photoshoot_type_description FROM photoshoot_type WHERE photoshoot_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "photoshoot_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    PhotoshootType.Load(reader);
                    for (int i = 0; i < PhotoshootType.Rows.Count; i++)
                    {
                        photoshootTypeID = PhotoshootType.Rows[i].ItemArray[0].ToString();
                        photoshootTypeName = PhotoshootType.Rows[i].ItemArray[1].ToString();
                        photoshootTypeDescription = PhotoshootType.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(photoshootTypeID, photoshootTypeName, photoshootTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Photoshoot_Type_Add photoshoot_Types_Add = new Photoshoot_Type_Add();
            photoshoot_Types_Add.ShowDialog();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string photoshootTypeID = "";
            Photoshoot_Types_View photoshoot_Types_View = new Photoshoot_Types_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    Photoshoot_Types_View.edit = false;
                    photoshootTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeID;
                    photoshoot_Types_View.ShowDialog();
                    break;
                case 4:
                    Photoshoot_Types_View.edit = true;
                    photoshootTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeID;
                    photoshoot_Types_View.ShowDialog();
                    break;
                case 5:
                    photoshootTypeID = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeID;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string query = "DELETE FROM `photoshoot_type` WHERE photoshoot_type_id = '" + photoshootTypeID + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception except)
                        {
                            System.Windows.Forms.MessageBox.Show(except.Message);
                        }
                        dataGridView7.Rows.Clear();
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string photoshootTypesID = " ";
                                string photoshootTypeName1 = " ";
                                string photoshootTypeDescription = " ";
                                DataTable EventTypes = new DataTable();
                                string query = "SELECT photoshoot_type_id, photoshoot_type_name, photoshoot_type_description FROM photoshoot_type";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                EventTypes.Load(reader);
                                for (int i = 0; i < EventTypes.Rows.Count; i++)
                                {
                                    photoshootTypesID = EventTypes.Rows[i].ItemArray[0].ToString();
                                    photoshootTypeName1 = EventTypes.Rows[i].ItemArray[1].ToString();
                                    photoshootTypeDescription = EventTypes.Rows[i].ItemArray[2].ToString();
                                    dataGridView7.Rows.Add(photoshootTypesID, photoshootTypeName1, photoshootTypeDescription, "View", "Edit", "Delete");
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

        private void Photoshoot_Types_Activated(object sender, EventArgs e)
        {
            dataGridView7.Rows.Clear();
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string photoshootTypesID = " ";
                    string photoshootTypeName1 = " ";
                    string photoshootTypeDescription = " ";
                    DataTable EventTypes = new DataTable();
                    string query = "SELECT photoshoot_type_id, photoshoot_type_name, photoshoot_type_description FROM photoshoot_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    EventTypes.Load(reader);
                    for (int i = 0; i < EventTypes.Rows.Count; i++)
                    {
                        photoshootTypesID = EventTypes.Rows[i].ItemArray[0].ToString();
                        photoshootTypeName1 = EventTypes.Rows[i].ItemArray[1].ToString();
                        photoshootTypeDescription = EventTypes.Rows[i].ItemArray[2].ToString();
                        dataGridView7.Rows.Add(photoshootTypesID, photoshootTypeName1, photoshootTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

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

        private void Photoshoot_Types_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Photoshoot_Types";
            helpForm.ShowDialog();
        }
    }
}
