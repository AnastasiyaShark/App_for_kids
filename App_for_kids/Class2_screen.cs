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
    public partial class Class2_screen : Form
    {
        public Class2_screen()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            welcome_screen menu = new welcome_screen();
            menu.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu_screen menu = new Menu_screen();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2_1kv_screen menu = new Class2_1kv_screen();
            menu.Show();
            this.Close();
        }
    }
}
