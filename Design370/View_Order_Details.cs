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
using System.IO;

namespace Design370
{
    public partial class View_Order_Details : Form
    {
        DBConnection dbCon = DBConnection.Instance();
        public static int customerID;
        public static int order_id;
        public const decimal VAT = 15/100;
        PictureBox productImges;
        public View_Order_Details()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public decimal orderToT = 0;
        public decimal subToT = 0;
        public int qty = 0;
        private void View_Order_Details_Load(object sender, EventArgs e)
        {
            if(dbCon.IsConnect())
            {
                lblOrderID.Text = order_id.ToString();
                var command = new MySqlCommand("SELECT `customer_first`, `customer_last`, `customer_email`, `customer_phone` FROM `customer` WHERE `customer_id` = '"+customerID+"'", dbCon.Connection);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    lblCustName.Text = reader[1].ToString() + ", " + reader[0].ToString();
                    lblEmail.Text = reader[2].ToString();
                    lblPhone.Text = reader[3].ToString();
                }
                reader.Close();

                var cmd = new MySqlCommand("SELECT `delivery_location_address` FROM `delivery` WHERE `order_id` = '"+order_id+"'", dbCon.Connection);
                var readr = cmd.ExecuteReader();
                if(readr.Read())
                {
                    if (readr[0].ToString() == "")
                    {
                        lblDelAddress.Text = "Collected";
                    }
                    else
                    {
                        lblDelAddress.Text = readr[0].ToString();
                        //webBrowser1.Navigate("http://maps.google.com/maps?q="+lblDelAddress.Text+"");
                    }
                }
                else
                {
                    lblDelAddress.Text = "Collected";
                }
                readr.Close();

                var commnd = new MySqlCommand("SELECT `product_name`, `product_price`, `order_line_quantity` FROM `order_line`, `product` WHERE `order_line`.`order_id` = '" + order_id+ "' AND `order_line`.`product_id` = `product`.`product_id`", dbCon.Connection);
                var read = commnd.ExecuteReader();
                while (read.Read())
                {
                    Label pd = new Label();
                    Label count = new Label();
                    Label price = new Label();
                    Label subT = new Label();
                    pd.AutoSize = false;
                    pd.Dock = DockStyle.Fill;
                    pd.Font = new Font("Bahnschrift SemiLight", 14, FontStyle.Regular);
                    pd.TextAlign = ContentAlignment.MiddleCenter;
                    count.AutoSize = false;
                    count.Dock = DockStyle.Fill;
                    count.Font = new Font("Bahnschrift SemiLight", 14, FontStyle.Regular);
                    count.TextAlign = ContentAlignment.MiddleCenter;
                    price.AutoSize = false;
                    price.Dock = DockStyle.Fill;
                    price.Font = new Font("Bahnschrift SemiLight", 14, FontStyle.Regular);
                    price.TextAlign = ContentAlignment.MiddleCenter;
                    subT.AutoSize = false;
                    subT.Dock = DockStyle.Fill;
                    subT.Font = new Font("Bahnschrift SemiLight", 14, FontStyle.Regular);
                    subT.TextAlign = ContentAlignment.MiddleCenter;
                    pd.Text = read[0].ToString();
                    count.Text = read[2].ToString();
                    price.Text = "R"+read[1].ToString();
                    orderToT += (Convert.ToDecimal(price.Text.Remove(0, 1)) * Convert.ToInt32(count.Text));
                    subToT = Convert.ToDecimal(price.Text.Remove(0, 1)) * Convert.ToInt32(count.Text);
                    subT.Text = "R"+subToT.ToString();
                    tblOrderProducts.RowCount = tblOrderProducts.RowCount + 1;
                    tblOrderProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblOrderProducts.Controls.Add(pd, 0, tblOrderProducts.RowCount - 1);
                    tblOrderProducts.Controls.Add(count, 1, tblOrderProducts.RowCount - 1);
                    tblOrderProducts.Controls.Add(price, 2, tblOrderProducts.RowCount - 1);
                    tblOrderProducts.Controls.Add(subT, 3, tblOrderProducts.RowCount - 1);
                    subToT = 0;
                    qty++;
                }
                read.Close();
                displayPhotos();
                decimal vat = (orderToT * 15 / 100);
                lblSUb.Text = "R"+(orderToT - vat).ToString("0.##");
                lblOrderTotl.Text = "R"+ ((orderToT - vat) + vat).ToString("0.##");
                lblVat.Text = "R"+ vat.ToString("0.##");
                orderToT = 0;
                vat = 0;
                lblQty.Text = qty.ToString();
            }
        }

        byte[] photo;
        MemoryStream img;
        int cellNum = 0;
        private void displayPhotos()
        {
            tblImages.RowCount = tblImages.RowCount + 1;
            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT `order_image` FROM `order_image`, `product` WHERE `order_image`.`order_id` = '" + order_id + "' " +
                    "AND `product`.`product_id` = `order_image`.`product_id`", dbCon.Connection);
                var reader = command.ExecuteReader();
                tblImages.RowCount = 0;
                while (reader.Read())
                {
                    Label prod = new Label();
                    prod.AutoSize = false;
                    prod.Dock = DockStyle.Fill;
                    prod.Font = new Font("Bahnschrift SemiLight", 14, FontStyle.Regular);
                    prod.TextAlign = ContentAlignment.MiddleCenter;

                    photo = (byte[])reader[0];
                    img = new MemoryStream(photo);
                    productImges = new PictureBox();
                    productImges.Image = Image.FromStream(img);
                    productImges.SizeMode = PictureBoxSizeMode.StretchImage;
                    productImges.Height = 90;
                    productImges.Width = 112;
                    productImges.Dock = DockStyle.Top;
                    if (cellNum < tblImages.ColumnCount)
                    {
                        cellNum++;
                    }
                    else
                    {
                        cellNum = 0;
                        tblImages.RowCount = tblImages.RowCount + 1;
                        tblImages.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }
                    tblImages.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tblImages.Controls.Add(productImges, cellNum, tblImages.RowCount - 1);
                }
                reader.Close();
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblDelAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:"+lblEmail.Text);
        }
    }
}
