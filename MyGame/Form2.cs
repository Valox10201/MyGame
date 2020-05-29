using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 form1 = new Form1();
        private bool Jump = false;
        public int gravity = 5;
        int o = 0;
        int u = 0;
        int t = 0;
        bool final = false;
        Rectangle fin1 = new Rectangle();
        public void Plat(int x, int y, int width, int height, Color color)
        {
            PictureBox plat = new PictureBox();
            plat.Location = new Point(x, y);
            plat.Width = width;
            plat.Height = height;
            plat.BackColor = color;
            plat.Tag = "Room";
            this.Controls.Add(plat);
        }
        public void Final(int x, int y, int width, int height)
        {
            PictureBox fin = new PictureBox();
            fin.Location = new Point(x, y);
            fin.Width = width;
            fin.Height = height;
            Bitmap f = new Bitmap(MyGame.Properties.Resources.fin);
            fin.SizeMode = PictureBoxSizeMode.StretchImage;
            fin.BackColor = Color.Transparent;
            fin.Image = f;
            fin.Tag = "Final";
            fin1 = fin.Bounds;
            this.Controls.Add(fin);
        }
        public void Pause(int sec)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < sec)
            {
                Application.DoEvents();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Hero.Top += gravity;
        }

        private void leftTime_Tick(object sender, EventArgs e)
        {
            Hero.Left -= 5;
        }

        private void rightTime_Tick(object sender, EventArgs e)
        {
            Hero.Left += 5;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A) && !final)
            {
                leftTime.Start();
            }
            else if ((e.KeyCode == Keys.D) && !final)
            {
                rightTime.Start();
            }
            else if (e.KeyCode == Keys.W && !Jump && !final && t == 0)
            {
                Jump = true;
                u = 1;
                gravity = -2;
                Pause(400);
                gravity = 0;
                Pause(100);
                gravity = 5;
                u = 2;
            }
            else if ((e.KeyCode == Keys.R) && final)
            {
                this.Close();
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                leftTime.Stop();
            }
            else if (e.KeyCode == Keys.D)
            {
                rightTime.Stop();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Final(50, 40, 100, 100);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                if (Hero.Bounds.IntersectsWith(i.Bounds) && i is PictureBox && i.Tag.ToString() == "Room" && Jump && u == 2)
                {
                    Jump = false;
                    u = 0;
                }
                else if (Hero.Bounds.IntersectsWith(i.Bounds) && i is PictureBox && i.Tag.ToString() == "Room" && !Jump && u == 0)
                {
                    gravity = 0;
                    o = 0;
                    t = 0;
                }
                else if (!Hero.Bounds.IntersectsWith(i.Bounds) && i is PictureBox && i.Tag.ToString() == "Room" && !Jump && u == 0)
                {
                    o++;
                    if (o == this.Controls.Count)
                    {
                        gravity = 5;
                        t = 1;
                    }
                }
                else if (Hero.Bounds.IntersectsWith(fin1))
                {
                    pictureBox16.Visible = true;
                    final = true;
                    gravity = 0;
                }
                
            }
            if (Hero.Location.Y > 700)
            {
                Hero.Location = new Point(26, 625);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hero_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Hero2.Location = new Point(Hero.Location.X, Hero.Location.Y - 10);
        }
    }
}
