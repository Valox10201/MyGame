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
        List<Rectangle> platforms = new List<Rectangle>();
        public void Plat(int x, int y)
        {
            PictureBox plat = new PictureBox();
            plat.Location = new Point(x, y);
            plat.Width = 150;
            plat.Height = 20;
            plat.BackColor = Color.Yellow;
            plat.Tag = "Room";
            this.Controls.Add(plat);
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
                gravity = -7;
                Pause(400);
                gravity = 0;
                Pause(100);
                gravity = 5;
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

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox Ground = new PictureBox();
            Ground.Width = 1250;
            Ground.Height = 25;
            Ground.BackColor = Color.Green;
            Ground.Location = new Point(0, 650);
            Ground.Tag = "Room";
            this.Controls.Add(Ground);
            Plat(200, 600);
            Plat(400, 600);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {

                if (Hero.Bounds.IntersectsWith(i.Bounds) && Jump == false && i.Tag.ToString() == "Room" && i is PictureBox)
                {
                    gravityTime.Stop();
                }
                else if (!Hero.Bounds.IntersectsWith(i.Bounds) && Jump == false && i.Tag.ToString() == "Room" && i is PictureBox)
                {
                    gravityTime.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
