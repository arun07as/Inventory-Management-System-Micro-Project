using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            ProductStatus_comboBox.SelectedIndex = 0;
            LoadData();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");

            con.Open();
            bool status = false;
            if (ProductStatus_comboBox.SelectedIndex = 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            SqlCommand cmd = new SqlCommand(@"
            INSERT INTO [Stock].[dbo].[Products](
            [ProductCode],
            [ProductName],
            [ProductStatus])
            VALUES(
            '"+ ProductCode_textbox.Text +"','" + ProductName_textbox.Text +"','"+ status +"')",con);
            cmd.ExecuteNonQuery();
            con.Close();


            LoadData();

        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Products]", con);
            DataTable da = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductCode_textbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProductName_textbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                ProductStatus_comboBox.SelectedIndex = 0;
            }
            else
            {
                ProductStatus_comboBox.SelectedIndex = 1;
            }
        }
    }
}
