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
        private bool IfProductExists(SqlConnection con, string productCode)
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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            con.Open();
            int k,i;
            bool flag = true;
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int n;
                int.TryParse(dataGridView1.Rows[i].Cells[2].Value.ToString(), out n);
                if (n == 0 || n == null)
                {
                    MessageBox.Show("Please Enter Quantity for " + dataGridView1.Rows[i].Cells[1].ToString(), "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (k = 0; k < dataGridView1.Rows.Count - 1; k++)
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("Select * From [Products] ORDER BY [ProductCode]", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            int code, code2, qty, qty2;
                            int.TryParse(dataGridView1.Rows[k].Cells["Column1"].Value.ToString(), out code);
                            int.TryParse(item["ProductCode"].ToString(), out code2);
                            if (code == code2)
                            {
                                int.TryParse(item["ProductQuantity"].ToString(), out qty2);
                                int.TryParse(dataGridView1.Rows[k].Cells[2].Value.ToString(), out qty);
                                if (qty > qty2)
                                {
                                    MessageBox.Show("Not enough Stock for product at row " + (k + 1), "Stock not enough", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    flag = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (flag)
                    {
                        var sqlq = @"UPDATE [Products] SET [ProductQuantity] = P.[ProductQuantity] - S.[ProductQuantity] FROM [Products] P Inner Join [Sales] as S on P.[ProductCode]=S.[ProductCode]";
                        SqlCommand cm = new SqlCommand(sqlq, con);
                        cm.ExecuteNonQuery();
                        var sqlQuery = "";
                        sqlQuery = @"DELETE FROM [Sales]";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        break;
                    }
                }
            }
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
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
                {
                    int quantity, rate, code;
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString(), out quantity) && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString(), out rate))
                    {
                        int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out code);
                        int price = quantity * rate;
                        dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value = price.ToString();
                        var sqlQuery = "";

                        sqlQuery = @"UPDATE [Sales] SET [ProductQuantity] = '" + quantity + "', [Amount] = '" + price + "' WHERE [ProductCode] = '" + code + "'  ";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    con.Close();
                    LoadData();
                }
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
            {
                string selectedUser = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (IfProductExists(con, selectedUser))
                {
                    if (MessageBox.Show("Are you sure you want to Delete this?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE [Sales] WHERE [ProductCode] = '" + selectedUser + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Product....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null && dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null && dataGridView1.SelectedRows[0].Cells[3].Value != null)
            {
            }
        }

        private void SearchCustomer_button_Click(object sender, EventArgs e)
        {
            Search_Customer cu = new Search_Customer();
            cu.ShowDialog();
            if (cu.flag)
            {
                CustomerID_textbox.Text = cu.id.ToString();
                CustomerName_textbox.Text = cu.name.ToString();
            }
        }
    }
}
