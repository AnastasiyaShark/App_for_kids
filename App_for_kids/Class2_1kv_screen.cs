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
    public partial class Class2_1kv_screen : Form
    {
        public Class2_1kv_screen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Class2_screen menu = new Class2_screen();
            menu.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            welcome_screen menu = new welcome_screen();
            menu.Show();
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
