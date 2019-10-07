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
using System.Web.Util;
using System.Net;
using System.Collections;
using System.IO;

namespace Design370
{
    public partial class Customer_Order_New : Form
    {
        /*******************************************************************/
        DBConnection dbCon = DBConnection.Instance();
        public DataGridView dgv;
        public Order[] items = new Order[10];
        public Random orderID = new Random();
        Customer_Order_Details customer;
        string cNames;
        string[] photos;
        byte[] saveImg = null;
        decimal orderTotal = 0;
        public decimal price;
        public int row = 0;
        public string product;
        public int prodID;
        public int pQty = 0;
        public int photo = 0;
        public int photoSize;
        public decimal subTotal;
        public bool saveCurrentOrder = false;
        /*******************************************************************/
        /*******************************************************************/
        public Customer_Order_New(Customer_Order_Details getCustNames)
        {
            InitializeComponent();
            customer = getCustNames;
            dgv = dgvOrderList;
            cNames = customer.names;
            lblCustomerNames.Text = cNames;
            DataGridViewButtonColumn deleteOrder = new DataGridViewButtonColumn();
            DataGridViewButtonColumn viewPhotos = new DataGridViewButtonColumn();
            deleteOrder.Text = "Remove Product";
            deleteOrder.UseColumnTextForButtonValue = true;
            deleteOrder.Visible = true;
            deleteOrder.HeaderText = "Action";
            viewPhotos.Text = "View Images";
            viewPhotos.UseColumnTextForButtonValue = true;
            viewPhotos.Visible = true;
            viewPhotos.HeaderText = "Print Images";
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Product Name";
            dgv.Columns[0].Width = 120;
            dgv.Columns[1].Name = "Description";
            dgv.Columns[1].Width = 118;
            dgv.Columns[2].Name = "Product Price";
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Name = "Item ID";
            dgv.Columns[3].Width = 70;
            dgv.Columns.Add(viewPhotos);
            dgv.Columns.Add(deleteOrder);
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeight = 30;
            ID = orderID.Next(1, 9999);
            while (getOrderID(ID) == false)
            {
                ID = orderID.Next(1, 9999);
            }
        }

        public bool getOrderID(int o)
        {
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand("SELECT `order_id` FROM `order`", dbCon.Connection);
                var read = cmd.ExecuteReader();
                while (read.Read())
                {
                    if (Convert.ToInt32(read[0]) == o)
                    {
                        return false;
                    }
                }
                read.Close();
            }
            return true;
        }

        private void NewCustomerOrder_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = ID.ToString();
            if (dbCon.IsConnect())
            {
                var command = new MySqlCommand("SELECT `product_name`, `product_stock_quantity` FROM `product`, `product_type` WHERE `product`.`product_type_id` = `product_type`.`product_type_id` AND " +
                    "`product_type`.`product_type_name` = 'Customer Order' AND `product`.`product_stock_quantity` != '0';", dbCon.Connection);
                var reader = command.ExecuteReader();
                lboxProductTypes.Items.Clear();
                while (reader.Read())
                {
                    lboxProductTypes.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            pQty = Convert.ToInt32(nQty.Value);
            //lboxProductTypes.SelectedIndex = 0;
            btnAddProduct.Enabled = false;
            btnSaveOrder.Enabled = false;
            controls.Hide();
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public int images;
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadingPhoto = new OpenFileDialog();
            uploadingPhoto.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            uploadingPhoto.Multiselect = true;
            if (uploadingPhoto.ShowDialog() == DialogResult.OK)
            {
                photos = uploadingPhoto.FileNames;
                btnAddProduct.Enabled = true;
                btnSaveOrder.Enabled = true;
                photoSize = 0;
                photo = 0;
                photoSize = photos.Length;
                images = photoSize;
                pBoxPrintPhoto.Image = Image.FromFile(photos[0]);
                lblPhoto.Text = "Image " + (photo+1).ToString() + " of " + photoSize.ToString();
                controls.Show();
                saveCurrentOrder = true;
                if (photoSize == 1)
                {
                    btnPrev.Visible = false;
                    btnNext.Visible = false;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddProduct.Visible = true;
                }
                else if(photoSize > 1)
                {
                    btnPrev.Visible = true;
                    btnNext.Visible = true;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;
                    btnAddProduct.Visible = true;
                }
            }
            else
            {
                uploadingPhoto.Reset();
                photo = 0;
                photoSize = 0;
            }
            
        }

        private void DgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    string pr;
                    int size = items.Length;
                    for (int i = 0; i < size; i++)
                    {
                        if (items[i] != null && items[i].getOrderName == dgvOrderList.Rows[e.RowIndex].Cells[0].Value.ToString())
                        {
                            pr = dgvOrderList.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 1);
                            orderTotal -= Convert.ToDecimal(pr);
                            lblOTotal.Text = "R" +orderTotal.ToString();
                            items[i] = null;
                            dgv.Rows.RemoveAt(e.RowIndex);
                            break;
                        }
                    }
                }
                else if(e.ColumnIndex == 4)
                {
                    int size = items.Length;
                    photo = 0;
                    photoSize = 0;
                    int itemID = Convert.ToInt32(dgvOrderList.Rows[e.RowIndex].Cells[3].Value.ToString().Remove(0, 1));
                    for(int d = 0; d < size; d++)
                    {
                        if(items[d] != null && items[d].getItemID == itemID)
                        {
                            photoSize = items[d].getOrderImages.Length;
                            photos = items[d].getOrderImages;
                            controls.Visible = true;
                            lblPhoto.Text = "Image " + (photo + 1).ToString() + " of " + photoSize.ToString();
                            pBoxPrintPhoto.Image = Image.FromFile(photos[photo]);
                            if (photoSize == 1)
                            {
                                btnPrev.Visible = false;
                                btnNext.Visible = false;
                                btnPrev.Enabled = false;
                                btnNext.Enabled = false;
                            }
                            else if (photoSize > 1)
                            {
                                btnPrev.Visible = true;
                                btnNext.Visible = true;
                                btnPrev.Enabled = false;
                                btnNext.Enabled = true;
                            }
                            break;
                        }
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }
        public decimal subT;
        public int stock;
        private void lbox_ProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count;
            if(dbCon.IsConnect())
            {
                product = lboxProductTypes.SelectedItem.ToString();
                var command = new MySqlCommand("SELECT `product_price`, `product_id`, `product_stock_quantity` FROM `product` WHERE `product_name` = '"+product+"'", dbCon.Connection);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    price = Convert.ToDecimal(reader[0]);
                    lblPrice.Text = "R" + price.ToString();
                    prodID = Convert.ToInt16(reader[1]);
                    count = Convert.ToInt32(reader[2]);
                    lblStock.Text = count.ToString() + " Items";
                    subT = price * pQty;
                }
                reader.Close();

                var stockCmd = new MySqlCommand("SELECT `product_stock_quantity` FROM `product` WHERE `product_name` = '" + product + "'", dbCon.Connection);
                var stReader = stockCmd.ExecuteReader();
                if (stReader.Read())
                {
                    stock = Convert.ToInt32(stReader[0]);
                    nQty.Maximum = stock;
                }
                stReader.Close();
            }
        }

        public void displayTotal(decimal amount)
        {
            var hold = String.Format("{0:0.##}", amount);
            if (hold.EndsWith("00"))
            {
                lblOTotal.Text = "R" + hold.ToString() + ".00";
            }
            else
            {
                lblOTotal.Text = "R" + hold.ToString();
            }
        }
        Random itemID = new Random();
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            int item_id = itemID.Next(1, 99);
            dgv.Rows.Add(product, "Phone Cover", lblPrice.Text, "#" + item_id.ToString(), images);
            items[row] = new Order(product, photos, item_id, prodID, pQty);
            row++;
            orderTotal += subT;
            displayTotal(orderTotal);
            lblOTotal.Text = "R"+orderTotal.ToString();
            controls.Hide();
            pBoxPrintPhoto.Image = null;
            btnAddProduct.Enabled = false;
            saveCurrentOrder = false;
            lboxProductTypes.SelectedIndex = 0;
            btnAddProduct.Visible = false;
        }
        
        private void NQty_ValueChanged(object sender, EventArgs e)
        {
            pQty = Convert.ToInt32(nQty.Value);
            if (pQty < stock)
            {
                subT = price * pQty;
            }
            else if(pQty == stock)
            {
                subT = price * pQty;
                MessageBox.Show("No More Stock Left", "Customer Order", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public int ID;
        public bool saved = false;
        private void BtnSaveOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (row == 0)
                {
                    int item_id = itemID.Next(1, 99);
                    dgv.Rows.Add(product, "Phone Cover", lblPrice.Text, "#" + item_id.ToString(), images);
                    items[row] = new Order(product, photos, item_id, prodID, pQty);
                    orderTotal += (pQty * price);
                    lblOTotal.Text = "R"+orderTotal.ToString();
                    row++;
                }
                else if(saveCurrentOrder == true)
                {
                    if (MessageBox.Show("Do you want to save the current item?", "Place Customer Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int item_id = itemID.Next(1, 99);
                        dgv.Rows.Add(product, "Phone Cover", lblPrice.Text, "#" + item_id.ToString(), images);
                        items[row] = new Order(product, photos, item_id, prodID, pQty);
                        row++;
                        orderTotal += subT;
                        lblOTotal.Text = "R"+orderTotal.ToString();
                    }
                }

                //SavingOrder save = new SavingOrder();
                if (dbCon.IsConnect())
                {
                    var date = DateTime.Now;
                    string orderInsert = "INSERT INTO `order` (`order_id`, `order_date_placed`, `customer_id`, `order_status_id`, `order_total`, `order_quantity`) " +
                        "VALUES(@id, @date, @cID, @osd, @OrderTotal, @QTY)";
                    var com = new MySqlCommand(orderInsert, dbCon.Connection);
                    com.Parameters.AddWithValue("@id", ID);
                    com.Parameters.AddWithValue("@date", date);
                    com.Parameters.AddWithValue("@cID", customer.customerID);
                    com.Parameters.AddWithValue("@osd", 1);
                    com.Parameters.AddWithValue("@OrderTotal", orderTotal);
                    com.Parameters.AddWithValue("@QTY", row);
                    com.ExecuteNonQuery();

                    if (rBtnDelivered.Checked == true)
                    {
                        var delivery = new MySqlCommand("INSERT INTO `delivery` (`delivery_id`, `delivery_location_address`, `delivery_date`, `order_id`, `delivery_fee_id`, `delivery_status_id`) " +
                            "VALUES(NULL, @ADDR, @DELDATE, @OID, @FEE, @ODSTATUS)", dbCon.Connection);
                        delivery.Parameters.AddWithValue("@ADDR", txtDelAddress.Text);
                        delivery.Parameters.AddWithValue("@DELDATE", date);
                        delivery.Parameters.AddWithValue("@OID", ID);
                        delivery.Parameters.AddWithValue("@FEE", 1);
                        delivery.Parameters.AddWithValue("@ODSTATUS", 1);
                        delivery.ExecuteNonQuery();
                    }
                }

                foreach (Order item in items)
                {
                    if (item != null)
                    {
                        saved = true;
                        if (dbCon.IsConnect())
                        {
                            var command = new MySqlCommand("INSERT INTO `order_line` (`product_id`, `order_id`, `order_line_quantity`) " +
                            "VALUES (@ProductID, @orderID, @quantity)", dbCon.Connection);
                            command.Parameters.AddWithValue("@orderID", ID);
                            command.Parameters.AddWithValue("@quantity", item.getProductQty);
                            command.Parameters.AddWithValue("@ProductID", item.getProductID);
                            int complete = command.ExecuteNonQuery();
           
                            int size = item.getOrderImages.Length;
                            int prodID = item.getProductID;
                            for (int indx = 0; indx < size; indx++)
                            {
                                FileStream file = new FileStream(item.getOrderImages[indx].ToString(), FileMode.Open, FileAccess.Read);
                                BinaryReader read = new BinaryReader(file);
                                saveImg = read.ReadBytes((int)file.Length);
                                var cmd = new MySqlCommand("INSERT INTO `order_image` (`order_image`, `order_id`, `product_id`) " +
                                    "VALUES (@image, @orderID, @ImageProduct)", dbCon.Connection);
                                cmd.Parameters.AddWithValue("@orderID", ID);
                                cmd.Parameters.AddWithValue("@ImageProduct", prodID);
                                cmd.Parameters.AddWithValue("@image", saveImg);
                                int uploaded = cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                //SendSMS(String AccountID, String Email, String Password, String Recipient, String Message);
                if (dbCon.IsConnect())
                {
                    var comnd = new MySqlCommand("INSERT INTO `audit_trail` (`audit_trail_id`, `employee_id`, `audit_trail_date_time`, `audit_trail_description`) " +
                        "VALUES(NULL, @EMPID, @DT, @ADESC)", dbCon.Connection);
                    comnd.Parameters.AddWithValue("@EMPID", 1);
                    comnd.Parameters.AddWithValue("@DT", DateTime.Now);
                    comnd.Parameters.AddWithValue("@ADESC", "A new order " + ID + " was placed by Simon for " + customer.names);
                    comnd.ExecuteNonQuery();
                }
                this.Close();
                if (saved == true)
                {
                    if (MessageBox.Show("Order Successfully Saved!", "Customer Order", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                      
                        if (MessageBox.Show("Do you want to place a new order?", "Place Customer Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            updateStock();
                            ID = orderID.Next(1, 9999);
                            while (getOrderID(ID) == false)
                            {
                                ID = orderID.Next(1, 9999);
                            }
                            items = null;
                            items = new Order[10];
                            row = 0;
                            lblOrderID.Text = ID.ToString();
                            saved = false;
                            dgv.Rows.Clear();
                            btnAddProduct.Enabled = false;
                            btnSaveOrder.Enabled = false;
                            lblOTotal.Text = "R0.00";
                            pBoxPrintPhoto.Image = null;
                            controls.Hide();
                            orderTotal = 0;
                            Customer_Order_Details selectCustomer = new Customer_Order_Details();
                            selectCustomer.ShowDialog();
                        }
                        else
                        {
                            this.Close();
                            updateStock();
                            items = null;
                            row = 0;
                            saved = false;
                        }
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        public void updateStock()
        {
            if (dbCon.IsConnect())
            {
                int size = items.Length;
                for (int i = 0; i < size; i++)
                {
                    if (items[i] != null)
                    {
                        var commnd = new MySqlCommand("SELECT `product_stock_quantity` FROM `product` WHERE `product_name` = '" + items[i].getOrderName + "'", dbCon.Connection);
                        var r = commnd.ExecuteReader();
                        if (r.Read())
                        {
                            int q = Convert.ToInt32(r[0]);
                            q -= 1;
                            r.Close();
                            var updCmd = new MySqlCommand("UPDATE `product` SET `product_stock_quantity` = '" + q + "' WHERE `product_name` = '" + items[i].getOrderName + "'", dbCon.Connection);
                            var u = updCmd.ExecuteReader();
                            u.Close();
                        }
                        r.Close();
                    }
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            photo++;
            nextImage(photo);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            photo--;
            prevImage(photo);
        }

        public void prevImage(int index)
        {
            if (index > 0)
            {
                btnNext.Enabled = true;
                pBoxPrintPhoto.Image = Image.FromFile(photos[photo]);
                lblPhoto.Text = "Image " + (index + 1).ToString() + " of " + photoSize.ToString();
            }
            else if (index == 0)
            {
                pBoxPrintPhoto.Image = Image.FromFile(photos[index]);
                lblPhoto.Text = "Image " + (index + 1).ToString() + " of " + photoSize.ToString();
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void Customer_Order_New_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                this.Close();
                var comnd = new MySqlCommand("INSERT INTO `audit_trail` (`audit_trail_id`, `employee_id`, `audit_trail_date_time`, `audit_trail_description`) " +
                    "VALUES(NULL, @EMPID, @DT, @ADESC)", dbCon.Connection);
                comnd.Parameters.AddWithValue("@EMPID", 1);
                comnd.Parameters.AddWithValue("@DT", DateTime.Now);
                comnd.Parameters.AddWithValue("@ADESC", "Simon cancelled the ordering process for " + customer.names + "");
                comnd.ExecuteNonQuery();
            }
        }

        public void nextImage(int i)
        {
            if (i < photoSize)
            {
                if (i == photoSize - 1)
                {
                    pBoxPrintPhoto.Image = Image.FromFile(photos[i]);
                    lblPhoto.Text = "Image " + (i + 1).ToString() + " of " + photoSize.ToString();
                    btnNext.Enabled = false;
                    btnPrev.Enabled = true;
                }
                else
                {
                    btnPrev.Enabled = true;
                    pBoxPrintPhoto.Image = Image.FromFile(photos[i]);
                    lblPhoto.Text = "Image " + (i + 1).ToString() + " of " + photoSize.ToString();
                }
            }
        }

        public int SendSMS(String AccountID, String Email, String Password, String Recipient, String Message)
        {
            WebClient Client = new WebClient();
            String RequestURL, RequestData;

            RequestURL = "https://redoxygen.net/sms.dll?Action=SendSMS";

            RequestData = "AccountId=" + AccountID
                + "&Email=" + System.Web.HttpUtility.UrlEncode(Email)
                + "&Password=" + System.Web.HttpUtility.UrlEncode(Password)
                + "&Recipient=" + System.Web.HttpUtility.UrlEncode(Recipient)
                + "&Message=" + System.Web.HttpUtility.UrlEncode(Message);

            byte[] PostData = Encoding.ASCII.GetBytes(RequestData);
            byte[] Response = Client.UploadData(RequestURL, PostData);

            String Result = Encoding.ASCII.GetString(Response);
            int ResultCode = System.Convert.ToInt32(Result.Substring(0, 4));

            return ResultCode;
        }

        private void rBtnDelivered_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnDelivered.Checked == true)
            {
                pnlDeliveryAddress.Visible = true;
            }
        }

        private void RBtnCollected_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnCollected.Checked == true)
            {
                pnlDeliveryAddress.Visible = false;
            }
        }
        private void Customer_Order_New_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = "Place_Customer_Order";
            helpForm.ShowDialog();
        }
    }
}
