using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) && Jump == false)
            {
                pictureBox2.Top += 2;
            }
        }

        private void leftTime_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 5;
        }

        private void rightTime_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 5;
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
    }
}
