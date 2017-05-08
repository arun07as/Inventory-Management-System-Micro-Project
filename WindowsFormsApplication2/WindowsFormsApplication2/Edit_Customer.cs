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
    public partial class Edit_Customer : Form
    {
        Customer c;
        string id;
        public Edit_Customer(Customer cu,string code, string name, string add, string ph)
        {
            c = cu;
            id = code;
            InitializeComponent();
            this.CustomerID_textbox.Text = code;
            this.CustomerName_textbox.Text = name;
            this.Address_textbox.Text = add;
            this.PhoneNumber_textbox.Text = ph;

        }
        public Edit_Customer()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IfCustomerExists(SqlConnection con1, string CustomerID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Customer] WHERE [CustomerID] = '" + CustomerID + "'", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (!string.IsNullOrWhiteSpace(this.CustomerID_textbox.Text) && !string.IsNullOrWhiteSpace(this.CustomerName_textbox.Text) && !string.IsNullOrWhiteSpace(this.Address_textbox.Text) && !string.IsNullOrWhiteSpace(this.PhoneNumber_textbox.Text))
            {
                if ((CustomerID_textbox.Text != id && !IfCustomerExists(con1, CustomerID_textbox.Text)) || CustomerID_textbox.Text == id)
                {
                    con1.Open();
                    var sqlQuery = "";

                    sqlQuery = @"
                    UPDATE [Customer] SET
                    [CustomerID] = '" + CustomerID_textbox.Text + "',[CustomerName] = '" + CustomerName_textbox.Text + "',[Address] = '" + Address_textbox.Text + "',[PhoneNumber] = '" + PhoneNumber_textbox.Text + "'WHERE [CustomerID]='" + id + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con1);
                    cmd.ExecuteNonQuery();
                    con1.Close();
                    c.LoadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Customer ID already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Fill all values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
