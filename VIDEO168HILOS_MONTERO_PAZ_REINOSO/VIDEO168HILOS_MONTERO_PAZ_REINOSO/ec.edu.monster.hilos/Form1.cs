using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Collections;

namespace VIDEO168HILOS_MONTERO_PAZ_REINOSO
{
    public struct ThreadData
    {
        public int BallX, BallY;
        public int BallVx, BallVy;
    }
    public partial class Form1 : Form
    {
        ArrayList threadBalls = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private const int BallWidth = 50;
        private const int BallHeight = 50;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        private void btnAddBall_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(1);
            ThreadData td = new ThreadData
            {
                BallX = rnd.Next(pictureBox1.Left + 50, pictureBox1.Right + 50),
                BallY = rnd.Next(pictureBox1.Top + 50, pictureBox1.Bottom - 50),
                BallVx = 1,
                BallVy = 1
            };
            var t = new Thread(MoveBall);
            t.Start(td);
            threadBalls.Add(t);
            this.Refresh();
        }

        public void MoveBall(object o)
        {
            Graphics dc = this.CreateGraphics();
            Random r = new Random();
            SolidBrush solidBrush = new SolidBrush(
                Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            ThreadData d = (ThreadData)o;
            for(int i=1; i <= 3000; i++)
            {
                d.BallX += d.BallVx;
                if (d.BallX < 0)
                {
                    d.BallVx = -d.BallVx;
                }
                else if (d.BallX + BallWidth > pictureBox1.Width)
                {
                    d.BallVx = -d.BallVx;
                }
                d.BallY += d.BallVy;
                if (d.BallY < 0)
                {
                    d.BallVy = -d.BallVy;
                }
                else if (d.BallY + BallHeight > pictureBox1.Height)
                {
                    d.BallVy = -d.BallVy;
                }      
                dc.SmoothingMode = SmoothingMode.HighQuality;
                dc.DrawEllipse(Pens.Black, d.BallX, d.BallY, BallWidth, BallHeight);
                dc.FillEllipse(solidBrush, d.BallX, d.BallY, BallWidth, BallHeight);
                this.Invalidate();
            }
        }


        private void btnRemoveBall_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
