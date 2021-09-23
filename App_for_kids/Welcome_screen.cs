using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_for_kids
{
    public partial class welcome_screen : Form
    {
        public welcome_screen()
        {
            InitializeComponent();
        }

      


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu_screen menu = new Menu_screen();
            menu.Show();
        }
    }
}
