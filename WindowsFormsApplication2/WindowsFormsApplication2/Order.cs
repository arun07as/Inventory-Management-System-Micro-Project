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
    public partial class Order : Form
    {
        int amount = 0;
        public Order()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            amount = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Sales] ORDER BY [ProductCode]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int t;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"];
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"];
                dataGridView1.Rows[n].Cells[2].Value = item["ProductQuantity"];
                dataGridView1.Rows[n].Cells[3].Value = item["ProductRate"];
                dataGridView1.Rows[n].Cells[4].Value = item["Amount"];
                int.TryParse(item["Amount"].ToString(), out t);
                amount = amount + t;
            }
            label4.Text = amount.ToString(); ;
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sqlQuery = @"DELETE FROM [Sales]";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            this.Close();
        }
        private void SearchProduct_button_Click_1(object sender, EventArgs e)
        {
            int k = dataGridView1.Rows.Count - 1;
            Search_Product s = new Search_Product(this);
            s.ShowDialog();
            dataGridView1.CurrentCell = dataGridView1.Rows[k].Cells[2];
            dataGridView1.BeginEdit(true);
            dataGridView1.Rows[k].Cells[4].Value = Convert.ToDouble(dataGridView1.Rows[k].Cells[3].Value) * Convert.ToDouble(dataGridView1.Rows[k].Cells[2].Value);
        }

        private void Save_Button_Click_1(object sender, EventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sqlQuery = @"DELETE FROM [Sales]";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void Clear_button_Click_1(object sender, EventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            sqlQuery = @"DELETE FROM [Sales]";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column3")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
                con.Open();
                int k = dataGridView1.Rows.Count - 1;
               /* if (k > -1)*/
                {
                    //dataGridView1.Rows[k].Cells[4].Value = /*Convert.ToString*/(Convert.ToInt32(dataGridView1.Rows[k].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[k].Cells[2].Value));
                    int quantity, rate, code;
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString(), out quantity) && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString(), out rate))
                    {
                        int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),out code);
                        int price = quantity * rate;
                        dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value = price.ToString();
                        var sqlQuery = "";

                        sqlQuery = @"UPDATE [Sales] SET [ProductQuantity] = '" + quantity + "', [Amount] = '" + price + "' WHERE [ProductCode] = '" +code+ "'  ";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                con.Close();
                LoadData();
            }
        }
    }
}
