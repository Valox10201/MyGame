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
        public void Final(int x, int y, int width, int height, Color color)
        {
            PictureBox fin = new PictureBox();
            fin.Location = new Point(x, y);
            fin.Width = width;
            fin.Height = height;
            fin.BackColor = color;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (e.KeyCode == Keys.A)
            {
                leftTime.Start();
            }
            else if (e.KeyCode == Keys.D)
            {
                rightTime.Start();
            }
            else if (e.KeyCode == Keys.W && !Jump)
            {
                Jump = true;
                u = 1;
                gravity = -7;
                Pause(400);
                gravity = 0;
                Pause(100);
                gravity = 5;
                u = 2;
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
            Final(1000, 50, 30, 30, Color.Red);
            Plat(0, 600, 150, 10, Color.Yellow);
            Plat(400, 550, 150, 10, Color.Yellow);
            Plat(900, 150, 150, 10, Color.Yellow);
            Plat(500, 400, 150, 10, Color.Yellow);
            Plat(600, 250, 150, 10, Color.Yellow);
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
                }
                else if (!Hero.Bounds.IntersectsWith(i.Bounds) && i is PictureBox && i.Tag.ToString() == "Room" && !Jump && u == 0)
                {
                    o++;
                    if (o == this.Controls.Count)
                    {
                        gravity = 5;
                    }
                }
                else if (Hero.Bounds.IntersectsWith(fin1))
                {
                    label1.Visible = true;
                }
                
            }
            if (Hero.Location.Y > 700)
            {
                Hero.Location = new Point(26, 550);
            }
        }
    }
}
