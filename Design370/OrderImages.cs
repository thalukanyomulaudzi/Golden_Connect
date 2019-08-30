using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Design370
{
    public partial class OrderImages : Form
    {
        public static int orderID;
        byte[] images;
        int[] imageID;
        int i = 0;
        int index = 0;
        int count = 0;
        int size = 0;
        int[] productID = new int[10];
        DBConnection dbCon = DBConnection.Instance();
        public OrderImages()
        {
            InitializeComponent();
            custOrderProductList.BeginUpdate();
            
            custOrderProductList.Nodes.Add("Products");
        }
        int r = 0;
        private void OrderImages_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = orderID.ToString();
            
            getProductID();

            
            foreach (int product in productID)
            {
                dbCon.Close();
                dbCon.Open();
                string type = "SELECT `product_type_name` FROM `product_type`, `product` WHERE `product`.`product_type_id` = `product_type`.`product_type_id` AND `product`.`product_id` = '"+product+"'";
                var command = new MySqlCommand(type, dbCon.Connection);
                var reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    custOrderProductList.Nodes[0].Nodes.Add(reader[0].ToString());

                }
                reader.Close();
                prodqty = ProductCount(product);
                ProductList(product, r, prodqty);
                r++;
               
                //string viewProduct = "SELECT * FROM `order_line` WHERE `product_id` = '"+product+"' AND `order_id` = '"+orderID+"'";
                dbCon.Close();
            }
            ;//
            custOrderProductList.ExpandAll();
            //
            loadImages(orderID);
            Imgs(0);
        }

        public void ProductList(int id, int r, int qty)
        {
            string list = "SELECT DISTINCT(`product_name`) FROM `product`, `order_line` WHERE `order_line`.`order_id` = '" + orderID+"' AND `product`.`product_id` = '"+id+"'";
            var command = new MySqlCommand(list, dbCon.Connection);
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                custOrderProductList.Nodes[0].Nodes[r].Nodes.Add(qty + " - " + reader[0].ToString());
            }
            reader.Close();
        }
        int prodqty = 0;
        public int ProductCount(int id)
        {
            string list = "SELECT COUNT(`product_name`) FROM `product`, `order_line` WHERE `order_line`.`order_id` = '" + orderID + "' AND `product`.`product_id` = '" + id + "'";
            var command = new MySqlCommand(list, dbCon.Connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                prodqty++;
            }
            reader.Close();
            return prodqty;
        }

        public void getProductID()
        {
            if (dbCon.IsConnect())
            {
                dbCon.Close();
                dbCon.Open();
                string getProducts = "SELECT DISTINCT(`product_id`) FROM `order_image` WHERE `order_id` = '" + orderID + "'";
                var command = new MySqlCommand(getProducts, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productID[count] = Convert.ToInt32(reader[0]);
                    count++;
                }
                reader.Close();
                dbCon.Close();
            }
        }

        public int getImageSize(int id)
        {
            size = 0;
            string load = "SELECT `order_image_id` FROM `order_image` WHERE `order_id` = '" + id + "'";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(load, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();

            while (MysqlConnection.reader.Read())
            {
                size++;
            }
            MysqlConnection.mysqlCon.Close();
            return size;
        }

        public void viewImages(int img)
        {
            if (img < 0)
            {
                i = 0;
            }
            else if (img >= index)
            {
                i = index - 1;
            }
            else
            {
                if (img > -1 && img < index)
                {
                    Imgs(img);
                }
            }
        }

        public void Imgs(int init)
        {
            string load = "SELECT `order_image` FROM `order_image` WHERE `order_image_id` = '" + imageID[init] + "'";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(load, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();
            MysqlConnection.reader.Read();
            if (MysqlConnection.reader.HasRows)
            {
                images = (byte[])MysqlConnection.reader[0];
                MemoryStream streamImg = new MemoryStream(images);
                productImg.Image = Image.FromStream(streamImg);
            }
            MysqlConnection.mysqlCon.Close();
        }

        public void loadImages(int id)
        {
            index = 0;
            imageID = new int[getImageSize(id)];
            string load = "SELECT * FROM `order_image` WHERE `order_id` = '" + id + "'";
            MysqlConnection.mysqlCon.Open();
            MysqlConnection.cmd = new MySqlCommand(load, MysqlConnection.mysqlCon);
            MysqlConnection.reader = MysqlConnection.cmd.ExecuteReader();

            while (MysqlConnection.reader.Read())
            {
                imageID[index] = Convert.ToInt32(MysqlConnection.reader.GetString("order_image_id"));
                index++;
            }
            MysqlConnection.mysqlCon.Close();
        }

        private void BtnPrevImage_Click(object sender, EventArgs e)
        {
            i--;
            viewImages(i);
        }

        private void BtnNextImg_Click(object sender, EventArgs e)
        {
            i++;
            viewImages(i);
        }
    }
}
