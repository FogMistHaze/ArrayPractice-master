using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        int vx3 = rand.Next(-20, 21);
        int vy3= rand.Next(-20, 21);
        int vx4 = rand.Next(-20, 21);
        int vy4 = rand.Next(-20, 21);
        int score = 100;

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label3.Left = rand.Next(ClientSize.Width - label1.Width);
            label3.Top = rand.Next(ClientSize.Height - label1.Height);

            label4.Left = rand.Next(ClientSize.Width - label1.Width);
            label4.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score--;
            scoreLabel.Text = $"Score {score:000}";

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            Point fpos = PointToClient(MousePosition);

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;
            }

            label3.Left += vx3;
            label3.Top += vy3;

            if (label3.Left < 0)
            {
                vx3 = Math.Abs(vx);
            }
            if (label3.Top < 0)
            {
                vy3 = Math.Abs(vy);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy);
            }

            if ((fpos.X >= label3.Left)
                && (fpos.X < label3.Right)
                && (fpos.Y >= label3.Top)
                && (fpos.Y < label3.Bottom))
            {
                timer1.Enabled = false;
            }

            label4.Left += vx4;
            label4.Top += vy4;

            if (label4.Left < 0)
            {
                vx4 = Math.Abs(vx);
            }
            if (label4.Top < 0)
            {
                vy4 = Math.Abs(vy);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx4 = -Math.Abs(vx);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy4 = -Math.Abs(vy);
            }

            if ((fpos.X >= label4.Left)
                && (fpos.X < label4.Right)
                && (fpos.Y >= label4.Top)
                && (fpos.Y < label4.Bottom))
            {
                timer1.Enabled = false;
            }
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}