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
                    string photoshootTypeName = " ";
                    string photoshootTypeDescription = " ";
                    DataTable PhotoshootType = new DataTable();
                    string query = "SELECT photoshoot_type_name, photoshoot_type_description FROM photoshoot_type WHERE photoshoot_type_name LIKE '%" + textBox7.Text + "%' OR ";
                    query += "photoshoot_type_description LIKE '%" + textBox7.Text + "%'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    PhotoshootType.Load(reader);
                    for (int i = 0; i < PhotoshootType.Rows.Count; i++)
                    {
                        photoshootTypeName = PhotoshootType.Rows[i].ItemArray[0].ToString();
                        photoshootTypeDescription = PhotoshootType.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(photoshootTypeName, photoshootTypeDescription, "View", "Edit", "Delete");
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
            string photoshootTypeName = "";
            Photoshoot_Types_View photoshoot_Types_View = new Photoshoot_Types_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Photoshoot_Types_View.edit = false;
                    photoshootTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeName;
                    photoshoot_Types_View.ShowDialog();
                    break;
                case 3:
                    Photoshoot_Types_View.edit = true; photoshootTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeName;
                    photoshoot_Types_View.ShowDialog();
                    break;
                case 4:
                    photoshootTypeName = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                    photoshoot_Types_View.GetPhotoshootTypeViewRow = photoshootTypeName;
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection dBConnection = DBConnection.Instance();
                            if (dBConnection.IsConnect())
                            {
                                string photoshootTypeID = "";
                                string query = "SELECT photoshoot_type_id FROM photoshoot_type WHERE photoshoot_type_name = '" + photoshootTypeName + "'";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                reader.Read();
                                photoshootTypeID = reader.GetString(0);
                                reader.Close();
                                query = "DELETE FROM `photoshoot_type` WHERE photoshoot_type_id = '" + photoshootTypeID + "'";
                                command = new MySqlCommand(query, dBConnection.Connection);
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
                                string photoshootTypeName1 = " ";
                                string photoshootTypeDescription = " ";
                                DataTable EventTypes = new DataTable();
                                string query = "SELECT photoshoot_type_name, photoshoot_type_description FROM photoshoot_type";
                                var command = new MySqlCommand(query, dBConnection.Connection);
                                var reader = command.ExecuteReader();
                                EventTypes.Load(reader);
                                for (int i = 0; i < EventTypes.Rows.Count; i++)
                                {
                                    photoshootTypeName1 = EventTypes.Rows[i].ItemArray[0].ToString();
                                    photoshootTypeDescription = EventTypes.Rows[i].ItemArray[1].ToString();
                                    dataGridView7.Rows.Add(photoshootTypeName1, photoshootTypeDescription, "View", "Edit", "Delete");
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
                    string photoshootTypeName = " ";
                    string photoshootTypeDescription = " ";
                    DataTable PhotoshootTypes = new DataTable();
                    string query = "SELECT photoshoot_type_name, photoshoot_type_description FROM photoshoot_type";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    PhotoshootTypes.Load(reader);
                    for (int i = 0; i < PhotoshootTypes.Rows.Count; i++)
                    {
                        photoshootTypeName = PhotoshootTypes.Rows[i].ItemArray[0].ToString();
                        photoshootTypeDescription = PhotoshootTypes.Rows[i].ItemArray[1].ToString();
                        dataGridView7.Rows.Add(photoshootTypeName, photoshootTypeDescription, "View", "Edit", "Delete");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
    }
}
