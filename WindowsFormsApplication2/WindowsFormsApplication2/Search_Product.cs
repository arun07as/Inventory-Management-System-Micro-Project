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

    public partial class Search_Product : Form
    {
        Order o;
        public Search_Product()
        {
            InitializeComponent();

        }
        public Search_Product(Order or)
        {
            InitializeComponent();
            o = or;
        }
        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private bool IfProductExists2(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [ProductCode] LIKE '" + productCode + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool IfProductExists3(SqlConnection con, string productname)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [ProductName] LIKE '" + productname + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool IfProductExists4(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Sales] WHERE [ProductCode] = '" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Products] ORDER BY [ProductCode]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"];
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"];
                dataGridView1.Rows[n].Cells[2].Value = item["ProductQuantity"];
                dataGridView1.Rows[n].Cells[3].Value = item["ProductRate"];
            }
        }


        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (!string.IsNullOrWhiteSpace(this.ProductCode_textbox.Text))
            {
                ProductName_textbox.Clear();
                if (IfProductExists2(con, ProductCode_textbox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From [Products] WHERE [ProductCode] LIKE '%" + ProductCode_textbox.Text + "%' ORDER BY [ProductCode]", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"];
                        dataGridView1.Rows[n].Cells[1].Value = item["ProductName"];
                        dataGridView1.Rows[n].Cells[2].Value = item["ProductQuantity"];
                        dataGridView1.Rows[n].Cells[3].Value = item["ProductRate"];
                    }

                }
                else
                {
                    MessageBox.Show("Not Found!!!!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (!string.IsNullOrWhiteSpace(this.ProductName_textbox.Text))
            {
                if (IfProductExists3(con, ProductName_textbox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From [Products] WHERE [ProductName] LIKE '" + ProductName_textbox.Text + "%' ORDER BY [ProductCode]", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"];
                        dataGridView1.Rows[n].Cells[1].Value = item["ProductName"];
                        dataGridView1.Rows[n].Cells[2].Value = item["ProductQuantity"];
                        dataGridView1.Rows[n].Cells[3].Value = item["ProductRate"];
                    }

                }
                else
                {
                    MessageBox.Show("Not Found!!!!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            ProductName_textbox.Clear();
            ProductCode_textbox.Clear();
            ProductQuantity_textbox.Clear();
            ProductRate_textbox.Clear();
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
            {
                ProductCode_textbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ProductName_textbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ProductRate_textbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ProductQuantity_textbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            var sqlQuery = "";
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                if (IfProductExists4(con, ProductCode_textbox.Text))
                {
                    MessageBox.Show("Product already in Order List. Please Edit in Order List", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlQuery = @"
                    INSERT INTO [Sales](
                    [ProductCode],
                    [ProductName],
                    [ProductRate])
                    VALUES(
                    '" + ProductCode_textbox.Text + "','" + ProductName_textbox.Text + "','" + ProductRate_textbox.Text + "')";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    o.LoadData();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Product","No Product Selected",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
