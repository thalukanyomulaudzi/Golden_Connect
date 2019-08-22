using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Design370
{
    class Photoshoot
    {
        public static void LoadDGVPhotoshoot (System.Windows.Forms.DataGridView dgv)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "Select booking_package_id FROM booking_package;";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        System.Windows.Forms.MessageBox.Show(table.Rows[i].ItemArray[0].ToString());
                    }
                    dBConnection.Close();

                while (reader.Read())
                    {
                        string PackageName = reader.GetString(0);
                        string Services = reader.GetString(1);
                        string Products = reader.GetString(2);
                        string Price = reader.GetString(3);
                        dgv.Rows.Add(PackageName, Services, Products, Price, "View", "Edit", "Delete");
                    }
                    dBConnection.Close();
                }
            }
            catch (Exception e)
            {

                
            }
        }
    }
}
