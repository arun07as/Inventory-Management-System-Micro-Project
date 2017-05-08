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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
            var sqlQuery = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sqlQuery = @"DELETE FROM [Sales]";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sqlQuery = @"DELETE FROM [Sales]";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.MdiParent = this;
            o.Show();
        }
    }
}
