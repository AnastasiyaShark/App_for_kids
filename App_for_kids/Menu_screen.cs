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
    public partial class Menu_screen : Form

    {
        public Menu_screen()
        {
            InitializeComponent();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            this.Hide();
            welcome_screen menu = new welcome_screen();
            menu.Show();
        }
        //При наезде на butt меняется цвет
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 109, 240);
        }
        //При отъезде от butt меняется цвет
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(31, 137, 255);
        }
    }
}
