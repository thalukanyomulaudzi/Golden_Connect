using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Design370
{
    public partial class Product_Types_View : Form
    {
        public static bool edit;
        string product_type_id = "";
        string helpstring = " ";
        public string GetProductTypeRow { get; set; }
        public Product_Types_View()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtProductTypeName, "A maximum of 25 characters can be entered");
            toolTip1.SetToolTip(txtProductTypeDescription, "A maximum of 200 characters can be entered");
        }

        private void Product_Types_View_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                this.Text = "Edit Product Type";
                helpstring = "Edit_Product_Type";
            }
            else if (!edit)
            {
                this.Text = "View Product Type";
                helpstring = "View_Product_Type";
            }
            txtProductTypeName.Enabled = edit;
            txtProductTypeDescription.Enabled = edit;
            if (edit == true)
            {
                button2.Enabled = false;
            }
            try
            {
                DBConnection dBConnection = DBConnection.Instance();
                if (dBConnection.IsConnect())
                {
                    string query = "SELECT product_type_id, product_type_name, product_type_description FROM product_type WHERE product_type_id = '" + GetProductTypeRow + "'";
                    var command = new MySqlCommand(query, dBConnection.Connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product_type_id = reader.GetString(0);
                        txtProductTypeName.Text = reader.GetString(1);
                        txtProductTypeDescription.Text = reader.GetString(2);
                    }
                    reader.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Text = "Edit Product Type";
            helpstring = "Edit_Product_Type";
            txtProductTypeName.Enabled = true;
            txtProductTypeDescription.Enabled = true;
            button2.Enabled = false;
        }

        private void Product_Types_View_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtProductTypeName.Enabled)
            {
                if (!Validation.validate(txtProductTypeName.Text, "name") || !Validation.validate(txtProductTypeDescription.Text, "name"))
                {
                    MessageBox.Show("All input fields must be valid");
                    return;
                }
                try
                {
                    DBConnection dBConnection = DBConnection.Instance();
                    if (dBConnection.IsConnect())
                    {
                        string query = "UPDATE `product_type` SET `product_type_id` = '" + product_type_id + "', `product_type_name` = '" + txtProductTypeName.Text + "', `product_type_description`";
                        query += " = '" + txtProductTypeDescription.Text + "' WHERE product_type_id = '" + product_type_id + "'";
                        var command = new MySqlCommand(query, dBConnection.Connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);

                }
                this.Close();
            }
            this.Close();
        }

        private void TxtProductTypeName_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductTypeName, Validation.validate(txtProductTypeName.Text, "name"));
        }

        private void TxtProductTypeDescription_TextChanged(object sender, EventArgs e)
        {
            Validation.checkMark(lblProductTypeDescription, Validation.validate(txtProductTypeDescription.Text, "name"));
        }

        private void Product_Types_View_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.HelpInfo = helpstring;
            helpForm.ShowDialog();
        }
    }
}
