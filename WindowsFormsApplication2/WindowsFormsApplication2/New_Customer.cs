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
    public partial class New_Customer : Form
    {
        Customer c;
        public New_Customer()
        {
            InitializeComponent();
        }
        public New_Customer(Customer cu)
        {
            InitializeComponent();
            c = cu;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con1.Open();

            var sqlQuery = "";
            if (IfCustomerExists(con1, CustomerID_textbox.Text))
            {
                MessageBox.Show("Customer ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlQuery = @"
                INSERT INTO [Customer](
                [CustomerID],
                [CustomerName],
                [Address],
                [PhoneNumber])
                VALUES(
                '" + CustomerID_textbox.Text + "','" + CustomerName_textbox.Text + "','" + Address_textbox.Text + "','" + PhoneNumber_textbox.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con1);
                cmd.ExecuteNonQuery();
                con1.Close();
                c.LoadData();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
