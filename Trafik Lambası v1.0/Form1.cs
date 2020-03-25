using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trafik_Lambası_v1._0
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int kırmızı = 6;
        int yeşil = 5;

        bool lamba = true;

        int a1 = 12, a2 = 84, a3 = 139, a4 = 204;

        bool başlat = false;


        #endregion



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = kırmızı.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lamba==true)
            {
                kırmızı--;
                label1.Text = kırmızı.ToString();
            }

            else if (lamba==false)
            {
                yeşil--;
                label1.Text = yeşil.ToString();
            }

            if (kırmızı==5)
            {
                pictureBox1.Image = Image.FromFile("Sarı.png");
            }

            else if (kırmızı==0)
            {
                pictureBox1.Image = Image.FromFile("Yeşil.png");
                lamba = false;
                kırmızı = 15;
                yeşil = 5;
            }

            if (yeşil==0)
            {
                pictureBox1.Image = Image.FromFile("Kırmızı.png");
                lamba = true;
                kırmızı = 15;
                yeşil = 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (başlat==false)
            {
                başlat = true;
                timer1.Start();
                timer2.Start();
                button1.Text="B";
               
            }

            else
            {
                başlat = false;
                timer1.Stop();
                timer2.Stop();
                button1.Text = "D";
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lamba==false)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X-5,12);
                pictureBox3.Location = new Point(pictureBox3.Location.X - 5, 79);
                pictureBox4.Location = new Point(pictureBox4.Location.X - 5, 149);
                pictureBox5.Location = new Point(pictureBox5.Location.X - 5, 204);

                if (pictureBox2.Location.X<95)
                {
                    pictureBox2.Location = new Point(603,12);
                }

                if (pictureBox3.Location.X < 95)
                {
                    pictureBox3.Location = new Point(603, 79);
                }

                if (pictureBox4.Location.X < 95)
                {
                    pictureBox4.Location = new Point(423, 149);
                }

                if (pictureBox5.Location.X < 95)
                {
                    pictureBox5.Location = new Point(407, 149);
                }

            }
        }
    }
}
