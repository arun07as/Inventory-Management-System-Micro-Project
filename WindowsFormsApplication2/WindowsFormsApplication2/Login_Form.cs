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

    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Username_textBox.Focus();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\Admin\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From User_Login where Username='" + Username_textBox.Text + "' and Password = '" + Password_textBox.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Main app = new Main();
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Password_textBox.Clear();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Exit_confirm_form Exit_Object = new Exit_confirm_form();
            Exit_Object.StartPosition = FormStartPosition.CenterScreen;
            Exit_Object.ShowDialog();
        }


    }
}
