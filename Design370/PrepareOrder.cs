using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Design370
{
    public partial class PrepareOrder : Form
    {
        public PrepareOrder()
        {
            InitializeComponent();
        }
        public static string CustomerNames;
        DBConnection dbCon = DBConnection.Instance();
        DataGridViewButtonColumn viewOrder, prepare;
        public int each = 0;
        public int size;
        OrderList[] olist = null;
        public int getSize()
        {
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand("SELECT COUNT(`order_id`) FROM `order`, `order_status` WHERE `order`.`order_status_id` = `order_status`.`order_status_id` AND " +
                    "`order_status`.`order_status_name` = 'Ready'", dbCon.Connection);
                var OrderReader = cmd.ExecuteReader();
                OrderReader.Read();
                if (OrderReader.HasRows)
                {
                    size = Convert.ToInt32(OrderReader[0]);
                }
                OrderReader.Close();
            }
            return size;
        }

        private void PrepareOrder_Load(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvPrepareCustomerOrder.Rows.Clear();
                viewOrder = new DataGridViewButtonColumn();
                prepare = new DataGridViewButtonColumn();
                viewOrder.HeaderText = "View Order";
                viewOrder.Text = "View";
                viewOrder.UseColumnTextForButtonValue = true;
                prepare.HeaderText = "Prepare Order";
                prepare.Text = "Prepared";
                prepare.Width = 120;
                prepare.UseColumnTextForButtonValue = true;
                dgvPrepareCustomerOrder.ColumnCount = 4;
                dgvPrepareCustomerOrder.Columns[0].Name = "Order ID";
                dgvPrepareCustomerOrder.Columns[0].Width = 140;
                dgvPrepareCustomerOrder.Columns[1].Name = "Customer Name";
                dgvPrepareCustomerOrder.Columns[1].Width = 170;
                dgvPrepareCustomerOrder.Columns[2].Name = "Order Date";
                dgvPrepareCustomerOrder.Columns[2].Width = 140;
                dgvPrepareCustomerOrder.Columns[3].Name = "Order Quantity";
                dgvPrepareCustomerOrder.Columns[3].Width = 130;
                dgvPrepareCustomerOrder.Columns.Add(viewOrder);
                dgvPrepareCustomerOrder.Columns.Add(prepare);
                string ordersToBePrepared = "SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity` FROM `order`, `order_status`, `customer` " +
                    "WHERE `order_status`.`order_status_name` = 'Ready' AND `order_status`.`order_status_id` = `order`.`order_status_id` AND " +
                    "`order`.`customer_id` = `customer`.`customer_id` AND `order_status`.`order_status_name` = 'Ready'";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvPrepareCustomerOrder.Rows.Add(reader[0], reader[1].ToString() + ", " + reader[2].ToString(), Convert.ToDateTime(reader[3]).Date.ToString("yyyy-M-dd"), reader[4]);
                }
                reader.Close();
            }
        }

        private void DgvPrepareCustomerOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            View_Order_Details viewOrder = new View_Order_Details();
            switch (e.ColumnIndex)
            {
                case 5:
                    Order.UpdateOrderStatus(Convert.ToInt32(dgvPrepareCustomerOrder.Rows[e.RowIndex].Cells[0].Value), "Complete");
                    break;
                case 4:
                    if (e.RowIndex >= 0)
                    {
                        int orderID = Convert.ToInt32(dgvPrepareCustomerOrder.Rows[e.RowIndex].Cells[0].Value);
                        if (dbCon.IsConnect())
                        {
                            string checkStatus = "SELECT `customer_id` FROM `order` WHERE `order_id` = '" + orderID + "'";
                            var command = new MySqlCommand(checkStatus, dbCon.Connection);
                            var reader = command.ExecuteReader();
                            reader.Read();
                            if (reader.HasRows)
                            {
                                View_Order_Details.customerID = Convert.ToInt32(reader[0]);
                                View_Order_Details.order_id = orderID;
                                reader.Close();
                                viewOrder.ShowDialog();
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Word Doc|*.docx";
                saveFileDialog1.Title = "Save document File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    olist = new OrderList[getSize()];

                    if (dbCon.IsConnect())
                    {
                        string orders = "SELECT `order_id`, `order_date_placed`, `customer`.`customer_first`, `order_total`, `order_status`.`order_status_name`, `customer`.`customer_last` " +
                                "FROM `order`, `customer`, `order_status` " +
                                "WHERE `order`.`customer_id` = `customer`.`customer_id` AND `order`.`order_status_id` = `order_status`.`order_status_id` AND `order_status`.`order_status_name` = 'Ready'";
                        var command = new MySqlCommand(orders, dbCon.Connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            olist[each] = new OrderList(Convert.ToInt32(reader[0]), reader[5].ToString() + ", " + reader[2].ToString(), Convert.ToDateTime(reader[1]), Convert.ToDecimal(reader[3]), reader[4].ToString());
                            each++;
                        }
                        reader.Close();
                    }

                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                    //Set animation status for Word application
                    //winword.ShowAnimation = false;
                    winword.Visible = false;
                    object missing = System.Reflection.Missing.Value;
                    Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    //Add header into the document
                    foreach (Section section in document.Sections)
                    {
                        Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                        headerRange.Font.Size = 15;
                        headerRange.Text = "ORDERS TO BE PREPARED";
                    }

                    foreach (Section wordSection in document.Sections)
                    {
                        Range footer = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footer.Font.ColorIndex = WdColorIndex.wdBlack;
                        footer.Font.Size = 10;
                        footer.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        footer.Text = "ORDERS";
                    }

                    document.Content.SetRange(0, 0);
                    //document.Content.Text = "This is test document " + Environment.NewLine;

                    //Adding Paragraph with Heading 1 Style
                    Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Font.Size = 12;
                    para1.Range.Text = "The following tables contains a list of all the orders which are to be prepared!";
                    para1.Range.InsertParagraphAfter();

                    //Create a 5X5 table and insert some dummy record
                    Table firstTable = document.Tables.Add(para1.Range, getSize(), 5, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    int eachRow = 0;
                    foreach (Row row in firstTable.Rows)
                    {
                        foreach (Cell cell in row.Cells)
                        {
                            if (cell.RowIndex == 1)
                            {
                                if (cell.ColumnIndex == 1)
                                {
                                    cell.Range.Text = "Order ID";
                                }
                                else if (cell.ColumnIndex == 2)
                                {
                                    cell.Range.Text = "Customer Name";
                                }
                                else if (cell.ColumnIndex == 3)
                                {
                                    cell.Range.Text = "Order Date";
                                }
                                else if (cell.ColumnIndex == 4)
                                {
                                    cell.Range.Text = "Order Total";
                                }
                                else if (cell.ColumnIndex == 5)
                                {
                                    cell.Range.Text = "Order Status";
                                }
                                cell.Range.Font.Bold = 1;
                                //other format properties goes here
                                cell.Range.Font.Name = "Ebrima";
                                cell.Range.Font.Size = 10;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                                //cell.Shading.ForegroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            }
                            else
                            {
                                //Row Data
                                if (cell.ColumnIndex == 1)
                                {
                                    cell.Range.Text = olist[eachRow].getOrderID.ToString();
                                }
                                else if (cell.ColumnIndex == 2)
                                {
                                    cell.Range.Text = olist[eachRow].getCustomerName;
                                }
                                else if (cell.ColumnIndex == 3)
                                {
                                    cell.Range.Text = olist[eachRow].getOrderDate.ToString();
                                }
                                else if (cell.ColumnIndex == 4)
                                {
                                    cell.Range.Text = "R" + olist[eachRow].getOrderTotal.ToString();
                                }
                                else if (cell.ColumnIndex == 5)
                                {
                                    cell.Range.Text = olist[eachRow].getOrderStatus;
                                }
                            }
                        }
                        eachRow++;
                    }

                    //Save the document
                    object filename = saveFileDialog1.FileName;
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    eachRow = 0;
                    each = 0;
                    olist = null;
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
                else
                {
                    saveFileDialog1.Reset();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void PrepareOrder_Activated(object sender, EventArgs e)
        {
            if (dbCon.IsConnect())
            {
                dgvPrepareCustomerOrder.Rows.Clear();
                viewOrder = new DataGridViewButtonColumn();
                prepare = new DataGridViewButtonColumn();
                viewOrder.HeaderText = "View Order";
                viewOrder.Text = "View";
                viewOrder.UseColumnTextForButtonValue = true;
                prepare.HeaderText = "Prepare Order";
                prepare.Text = "Prepared";
                prepare.Width = 120;
                prepare.UseColumnTextForButtonValue = true;
                dgvPrepareCustomerOrder.ColumnCount = 4;
                dgvPrepareCustomerOrder.Columns[0].Name = "Order ID";
                dgvPrepareCustomerOrder.Columns[0].Width = 140;
                dgvPrepareCustomerOrder.Columns[1].Name = "Customer Name";
                dgvPrepareCustomerOrder.Columns[1].Width = 170;
                dgvPrepareCustomerOrder.Columns[2].Name = "Order Date";
                dgvPrepareCustomerOrder.Columns[2].Width = 140;
                dgvPrepareCustomerOrder.Columns[3].Name = "Order Quantity";
                dgvPrepareCustomerOrder.Columns[3].Width = 130;
                dgvPrepareCustomerOrder.Columns.Add(viewOrder);
                dgvPrepareCustomerOrder.Columns.Add(prepare);
                string ordersToBePrepared = "SELECT `order_id`, `customer_first`, `customer_last`, `order_date_placed`, `order_quantity` FROM `order`, `order_status`, `customer` WHERE `order_status`.`order_status_name` = 'Ready' AND `order_status`.`order_status_id` = `order`.`order_status_id` AND " +
                    "`order`.`customer_id` = `customer`.`customer_id` AND `order_status`.`order_status_name` = 'Ready'";
                var command = new MySqlCommand(ordersToBePrepared, dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvPrepareCustomerOrder.Rows.Add(reader[0], reader[1].ToString() + ", " + reader[2].ToString(), Convert.ToDateTime(reader[3]).Date.ToString("yyyy-M-dd"), reader[4]);
                }
                reader.Close();
            }
        }
    }
}
