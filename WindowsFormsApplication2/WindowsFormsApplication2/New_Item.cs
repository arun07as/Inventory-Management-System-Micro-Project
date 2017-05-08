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
    public partial class New_Item : Form
    {
        Products f;
        public New_Item(Products fo)
        {
            InitializeComponent();
            f = fo;
        }
        public New_Item()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");

            con.Open();


            var sqlQuery = "";
            if (IfProductExists(con, ProductCode_textbox.Text))
            {
                MessageBox.Show("Product Code already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlQuery = @"
                INSERT INTO [Products](
                [ProductCode],
                [ProductName],
                [ProductRate],
                [ProductQuantity])
                VALUES(
                '" + ProductCode_textbox.Text + "','" + ProductName_textbox.Text + "','" + ProductRate_textbox.Text + "','" + ProductQuantity_textbox.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                f.LoadData();
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
