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
    



        // добавляем набор элементов
        public Menu_screen()
        {
            InitializeComponent();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome_screen menu = new welcome_screen();
            menu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome_screen menu = new welcome_screen();
            menu.Show();
        }
    }
}
