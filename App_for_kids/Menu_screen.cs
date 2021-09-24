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
        //переход на начальную страницу (общий)
        private void goBack()
        {
            welcome_screen menu = new welcome_screen();
            menu.Show();
            this.Close();
        }
       
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            chengeColorMouseEnter(button1);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            chengeColorMouseEnter(button2);
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            chengeColorMouseEnter(button3);
        }
        
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            chengeColorMouseLeave(button1);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            chengeColorMouseLeave(button2);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            chengeColorMouseLeave(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //При наезде на butt меняется цвет (общий)
        private void chengeColorMouseEnter(Button button)
        {
            button.ForeColor = Color.FromArgb(0, 109, 240);
        }
        //При отъезде от butt меняется цвет (общий)
        private void chengeColorMouseLeave(Button button)
        {
            button.ForeColor = Color.FromArgb(31, 137, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2_screen class2 = new Class2_screen();
            class2.Show();
            this.Close();
        }
    }
}
