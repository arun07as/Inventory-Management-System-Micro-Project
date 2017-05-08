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
    public partial class Customer : Form
    {
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public Customer()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Customer] ORDER BY [CustomerID]", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["CustomerID"];
                dataGridView1.Rows[n].Cells[1].Value = item["CustomerName"];
                dataGridView1.Rows[n].Cells[2].Value = item["Address"];
                dataGridView1.Rows[n].Cells[3].Value = item["PhoneNumber"];
            }
        }

        private bool IfCustomerExists(SqlConnection con1, string customerID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Customer] WHERE [CustomerID] = '" + customerID + "'", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool IfCustomerExists2(SqlConnection con1, string customerID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Customer] WHERE [CustomerID] LIKE '%" + customerID + "%'", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private bool IfCustomerExists3(SqlConnection con1, string customername)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Customer] WHERE [CustomerName] LIKE '" + customername + "%'", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            New_Customer n = new New_Customer(this);
            n.Show();
            LoadData();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (IfCustomerExists(con1, CustomerID_textbox.Text))
            {
                if (MessageBox.Show("Are you sure you want to Delete this?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con1.Open();
                    SqlCommand cmd = new SqlCommand(@"DELETE [Customer] WHERE [CustomerID] = '" + CustomerID_textbox.Text + "'", con1);
                    cmd.ExecuteNonQuery();
                    CustomerID_textbox.Clear();
                    CustomerName_textbox.Clear();
                    Address_textbox.Clear();
                    PhoneNumber_textbox.Clear();
                    con1.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (!string.IsNullOrWhiteSpace(this.CustomerID_textbox.Text))
            {
                CustomerName_textbox.Clear();
                if (IfCustomerExists2(con1, CustomerID_textbox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From [Customer] WHERE [CustomerID] LIKE '%" + CustomerID_textbox.Text + "%' ORDER BY [CustomerID]", con1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["CustomerID"];
                        dataGridView1.Rows[n].Cells[1].Value = item["CustomerName"];
                        dataGridView1.Rows[n].Cells[2].Value = item["Address"];
                        dataGridView1.Rows[n].Cells[3].Value = item["PhoneNumber"];
                    }

                }
                else
                {
                    MessageBox.Show("Not Found!!!!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (!string.IsNullOrWhiteSpace(this.CustomerName_textbox.Text))
            {
                if (IfCustomerExists3(con1, CustomerName_textbox.Text))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From [Customer] WHERE [CustomerName] LIKE '" + CustomerName_textbox.Text + "%' ORDER BY [CustomerID]", con1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["CustomerID"];
                        dataGridView1.Rows[n].Cells[1].Value = item["CustomerName"];
                        dataGridView1.Rows[n].Cells[2].Value = item["Address"];
                        dataGridView1.Rows[n].Cells[3].Value = item["PhoneNumber"];
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
            CustomerName_textbox.Clear();
            CustomerID_textbox.Clear();
            Address_textbox.Clear();
            PhoneNumber_textbox.Clear();
            LoadData();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (IfCustomerExists(con1, CustomerID_textbox.Text))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From [Customer] WHERE [CustomerID] = '" + CustomerID_textbox.Text + "'", con1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    CustomerID_textbox.Text = item["CustomerID"].ToString();
                    CustomerName_textbox.Text = item["CustomerName"].ToString();
                    Address_textbox.Text = item["Address"].ToString();
                    PhoneNumber_textbox.Text = item["PhoneNumber"].ToString();
                }
                Edit_Customer edit = new Edit_Customer(this, CustomerID_textbox.Text, CustomerName_textbox.Text, PhoneNumber_textbox.Text, Address_textbox.Text);
                edit.Show();

                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select the Customer to Edit", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
            {
                CustomerID_textbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CustomerName_textbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Address_textbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                PhoneNumber_textbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }


    }
}
