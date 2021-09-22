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
            this.comboBox1.Size = new System.Drawing.Size(100, 60);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Typical";
            string[] installs = new string[] { "Typical", "Compact", "Custom" };
            comboBox1.Items.AddRange(installs);
            this.Controls.Add(this.comboBox1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome_screen menu = new welcome_screen();
            menu.Show();
        }

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedState = comboBox1.SelectedItem.ToString();
            
          
        }
    }
}
