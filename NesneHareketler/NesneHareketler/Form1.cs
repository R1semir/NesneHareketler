using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneHareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
            // YUKARI
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 22)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer2_Tick(object sender, EventArgs e)
            // SAĞA
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 939)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
            // AŞAĞI
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 587)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
            // SOLA
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 191)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <= 388)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 359)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <= 295)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 192)
            {
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <= 199)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 792)
            {
                timer10.Stop();
                timer11.Start();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 388)
            {
                timer11.Stop();
                timer12.Start();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 503)
            {
                timer12.Stop();
                timer13.Start();
            }

        }


        private void timer13_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <= 292)
            {
                timer13.Stop();
                timer14.Start();
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >= 649)
            {
                timer14.Stop();
                timer15.Start();
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 587)
            {
                timer15.Stop();
                timer16.Start();
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if(pictureBox1.Left <= 30)
            {
                timer16.Stop();
                MessageBox.Show("Dönme İşlemi Bitmiştir İşlem Tekrarlanıyor...");
                timer1.Start();
            }
        }
    }
}
