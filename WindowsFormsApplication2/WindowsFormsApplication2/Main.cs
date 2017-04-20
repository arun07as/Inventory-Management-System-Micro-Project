using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
    
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
    }
}
