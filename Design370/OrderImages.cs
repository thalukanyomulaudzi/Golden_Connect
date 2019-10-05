using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Design370
{
    public partial class OrderImages : Form
    {
        public static int orderID;
        byte[] images;
        int[] imageIDs;
        int currentImage = 0;
        int numImages = 0;
        int[] productIDs = new int[10];
        int prodqty = 0;
        DBConnection dbCon = DBConnection.Instance();
        public OrderImages()
        {
            InitializeComponent();
            custOrderProductList.BeginUpdate();

            custOrderProductList.Nodes.Add("Products");
        }
        private void OrderImages_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = orderID.ToString();
            getProductIDs();

            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                foreach (int product in productIDs)
                {
                    query = "SELECT pt.`product_type_name` FROM `product_type` pt " +
                    "JOIN `product` p ON p.`product_type_id` = pt.`product_type_id` " +
                    "WHERE p.`product_id` = '" + product + "'";
                    command = new MySqlCommand(query, dBCon.Connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        custOrderProductList.Nodes[0].Nodes.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            int node = 0;
            foreach (int id in productIDs)
            {
                prodqty = ProductCount(id);
                ProductList(id, node, prodqty);
                node++;

                //string viewProduct = "SELECT * FROM `order_line` WHERE `product_id` = '"+product+"' AND `order_id` = '"+orderID+"'";
            }
            custOrderProductList.ExpandAll();
            loadImages(orderID);
            Imgs(0);
        }

        public void ProductList(int id, int node, int qty)
        {
            string list = "SELECT DISTINCT(`product_name`) FROM `product`, `order_line` WHERE `order_line`.`order_id` = '" + orderID + "' AND `product`.`product_id` = '" + id + "'";
            var command = new MySqlCommand(list, dbCon.Connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                custOrderProductList.Nodes[0].Nodes[node].Nodes.Add(qty + " - " + reader[0].ToString());
            }
            reader.Close();
        }
        public int ProductCount(int productId)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT order_line_quantity FROM order_line " +
                    "WHERE order_id = '" + orderID + "' AND product_id = '" + productId + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    prodqty = reader.GetInt32(0);
                }
                reader.Close();
                return prodqty;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public void getProductIDs()
        {
            try
            {
                int count = 0;
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT DISTINCT(`product_id`) FROM `order_image` WHERE `order_id` = '" + orderID + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                count = 0;
                while (reader.Read())
                {
                    productIDs[count] = reader.GetInt32(0);
                    count++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int getImageQuantity(int id)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT `order_image_id` FROM `order_image` WHERE `order_id` = '" + id + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                int qty = 0;
                while (reader.Read())
                {
                    qty++;
                }
                reader.Close();
                return qty;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public void viewImages(int img)
        {
            if (img < 0)
                currentImage = 0;
            else if (img >= numImages)
                currentImage = numImages - 1;
            else
                Imgs(img);
        }

        public void Imgs(int init)
        {
            try
            {
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT `order_image` FROM `order_image` WHERE `order_image_id` = '" + imageIDs[init] + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    images = (byte[])reader[0];
                    MemoryStream streamImg = new MemoryStream(images);
                    productImg.Image = Image.FromStream(streamImg);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadImages(int id)
        {
            try
            {
                imageIDs = new int[getImageQuantity(id)];
                DBConnection dBCon = DBConnection.Instance();
                string query = "SELECT * FROM `order_image` WHERE `order_id` = '" + id + "'";
                var command = new MySqlCommand(query, dBCon.Connection);
                var reader = command.ExecuteReader();
                numImages = 0;
                while (reader.Read())
                {
                    imageIDs[numImages] = reader.GetInt32("order_image_id");
                    numImages++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BtnPrevImage_Click(object sender, EventArgs e)
        {
            viewImages(--currentImage);
        }

        private void BtnNextImg_Click(object sender, EventArgs e)
        {
            viewImages(++currentImage);
        }
    }
}
