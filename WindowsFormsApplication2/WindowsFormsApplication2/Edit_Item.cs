using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Edit_Item : Form
    {
        Products p;
        string c;
        public Edit_Item(Products pr,string code, string name, string rate, string qty)
        {
            p = pr;
            c = code;
            InitializeComponent();
            this.ProductCode_textbox.Text = code;
            this.ProductName_textbox.Text = name;
            this.ProductRate_textbox.Text = rate;
            this.ProductQuantity_textbox.Text = qty;

        }
        public Edit_Item()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [ProductCode] = '" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (!string.IsNullOrWhiteSpace(this.ProductCode_textbox.Text) && !string.IsNullOrWhiteSpace(this.ProductName_textbox.Text) && !string.IsNullOrWhiteSpace(this.ProductRate_textbox.Text) && !string.IsNullOrWhiteSpace(this.ProductQuantity_textbox.Text))
            {
                if((ProductCode_textbox.Text != c && !IfProductExists(con,ProductCode_textbox.Text))||ProductCode_textbox.Text==c)
                {
                    con.Open();
                    var sqlQuery = "";

                    sqlQuery = @"
                    UPDATE [Products] SET
                    [ProductCode] = '" + ProductCode_textbox.Text + "',[ProductName] = '" + ProductName_textbox.Text + "',[ProductRate] = '" + ProductRate_textbox.Text + "',[ProductQuantity] = '" + ProductQuantity_textbox.Text + "'WHERE [ProductCode]='" + c + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    p.LoadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Product Code already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Fill all values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
