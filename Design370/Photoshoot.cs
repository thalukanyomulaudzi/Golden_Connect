﻿using System;
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
        public static void LoadDGV (System.Windows.Forms.DataGridView dgv)
        {
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    double TotalPrice = 0;
                    string PackageName = " ";
                    string ProductCount = " ";
                    string ServiceCount = " ";
                    string query = "SELECT booking_package_id, booking_package_name FROM booking_package;";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    DataTable bookingpackage = new DataTable();
                    bookingpackage.Load(reader);
                    for (int i = 0; i < bookingpackage.Rows.Count; i++)
                    {
                        DataTable booking_package_product = new DataTable();
                        PackageName = bookingpackage.Rows[i].ItemArray[1].ToString();
                        query = "SELECT product_id, booking_package_product_quantity FROM booking_package_product WHERE booking_package_id = '" + bookingpackage.Rows[i].ItemArray[0].ToString() + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        booking_package_product.Load(reader);
                        for (int j = 0; j < booking_package_product.Rows.Count; j++)
                        {
                            DataTable product = new DataTable();
                            ProductCount = booking_package_product.Rows.Count.ToString();
                            query = "SELECT product_price FROM product WHERE product_id = '" + booking_package_product.Rows[j].ItemArray[0].ToString() + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            reader = command.ExecuteReader();
                            product.Load(reader);
                            for (int k = 0; k < product.Rows.Count; k++)
                            {
                                TotalPrice += Convert.ToInt32(booking_package_product.Rows[j].ItemArray[1]) * Convert.ToDouble(product.Rows[k].ItemArray[0]);
                            }
                        }
                        DataTable booking_package_service = new DataTable();
                        query = "SELECT service_id FROM booking_package_service WHERE booking_package_id = '" + bookingpackage.Rows[i].ItemArray[0].ToString() + "'";
                        command = new MySqlCommand(query, dBConnection.Connection);
                        reader = command.ExecuteReader();
                        booking_package_service.Load(reader);
                        for (int l = 0; l < booking_package_service.Rows.Count; l++)
                        {
                            DataTable service = new DataTable();
                            ServiceCount = booking_package_service.Rows.Count.ToString();
                            query = "SELECT service_price FROM service WHERE service_id = '" + booking_package_service.Rows[l].ItemArray[0].ToString() + "'";
                            command = new MySqlCommand(query, dBConnection.Connection);
                            reader = command.ExecuteReader();
                            service.Load(reader);
                            for (int m = 0; m < service.Rows.Count; m++)
                            {
                                TotalPrice += Convert.ToDouble(service.Rows[m].ItemArray[0]);
                            }

                        }
                        dgv.Rows.Add(PackageName, ServiceCount, ProductCount, TotalPrice, "View", "Edit", "Delete");
                    }

                    reader.Close();
                }
            }
            catch (Exception e)
            {

                
            }
        }
    }
}
