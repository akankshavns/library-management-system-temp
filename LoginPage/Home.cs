using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Books.FlatAppearance.BorderSize = 0;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = false;
        private void MenuSlider_Tick(object sender, EventArgs e)
        {
           
            
                if (sidebarExpand)
                {
                    menuBar.Width -= 10;
                if  (menuBar.Width <= 60)
                    {
                        sidebarExpand = false;
                        MenuSlider.Stop();
                    }
                }
                else
                {
                    menuBar.Width += 10;
                    if (menuBar.Width >= 194)
                    {
                        sidebarExpand = true;
                        MenuSlider.Stop();
                    }

                }
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuSlider.Start();
        }

        private void Student_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
