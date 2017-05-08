using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Exit_confirm_form : Form
    {
        public Exit_confirm_form()
        {
            InitializeComponent();
        }

        private void Exit_Yes_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_No_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_confirm_form_Load(object sender, EventArgs e)
        {

        }
    }
}
