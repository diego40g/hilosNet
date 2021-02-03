using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Collections;

namespace VIDEO170HILOS_MONTERO_PAZ_REINOSO
{
    public struct ThreadData
    {
        public int BallX, BallY;
        public int BallVx, BallVy;
        public int R, G, B;
    }
    public partial class Form1 : Form
    {
        ArrayList threadBalls1 = new ArrayList();
        ArrayList threadBalls2 = new ArrayList();
        ArrayList threadBalls3 = new ArrayList();
        Thread hilo1;
        Thread hilo2;
        Thread hilo3;
        public Form1()
        {
            InitializeComponent();
        }
        private const int BallWidth = 50;
        private const int BallHeight = 50;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void MoveBall(object o)
        {
            Graphics dc = this.CreateGraphics();
            Random r = new Random();

            ThreadData d = (ThreadData)o;
            SolidBrush solidBrush = new SolidBrush(
               Color.FromArgb(d.R, d.G, d.B));
            while (true)
            {
                d.BallX += d.BallVx;
                if (d.BallX < 0)
                {
                    d.BallVx = -d.BallVx;
                }
                else
                {
                    if (d.BallX + BallWidth > pictureBox1.Width)
                    {
                        d.BallVx = -d.BallVx;
                    }
                    d.BallY += d.BallVy;
                    if (d.BallY < 0)
                    {
                        d.BallVy = -d.BallVy;
                    }
                    else
                    {
                        if (d.BallY + BallHeight > pictureBox1.Height)
                        {
                            d.BallVy = -d.BallVy;
                        }
                        dc.SmoothingMode = SmoothingMode.HighQuality;
                        //dc.DrawEllipse(Pens.Black, d.BallX, d.BallY, BallWidth, BallHeight);
                        dc.FillEllipse(solidBrush, d.BallX, d.BallY, BallWidth, BallHeight);
                        this.Invalidate();
                    }
                }
            }
        }
        private void btnAddBall_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(1);
            ThreadData td = new ThreadData
            {
                BallX = rnd.Next(pictureBox1.Left + 50, pictureBox1.Right + 50),
                BallY = rnd.Next(pictureBox1.Top + 50, pictureBox1.Bottom - 50),
                BallVx = 1,
                BallVy = 1,
                R = 0,
                G = 255,
                B = 255
            };
            hilo1 = new Thread(MoveBall);
            hilo1.Start(td);
            threadBalls1.Add(hilo1);
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            if (threadBalls1.Count > 0)
            {
                Thread td = (Thread)threadBalls1[threadBalls1.Count - 1];
                td.Abort();
                threadBalls1.RemoveAt(threadBalls1.Count - 1);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            label2.Text = threadBalls1.Count.ToString();
            label4.Text = threadBalls2.Count.ToString();
            label6.Text = threadBalls3.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBall2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(1);
            ThreadData td = new ThreadData
            {
                BallX = rnd.Next(pictureBox1.Left + 50, pictureBox1.Right + 50),
                BallY = rnd.Next(pictureBox1.Top + 50, pictureBox1.Bottom - 50),
                BallVx = 1,
                BallVy = 1,
                R = 255,
                G = 0,
                B = 255
            };
            hilo2 = new Thread(MoveBall);
            hilo2.Start(td);
            threadBalls2.Add(hilo2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBall3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(1);
            ThreadData td = new ThreadData
            {
                BallX = rnd.Next(pictureBox1.Left + 50, pictureBox1.Right + 50),
                BallY = rnd.Next(pictureBox1.Top + 50, pictureBox1.Bottom - 50),
                BallVx = 1,
                BallVy = 1,
                R = 255,
                G = 255,
                B = 0
            };
            hilo3 = new Thread(MoveBall);
            hilo3.Start(td);
            threadBalls3.Add(hilo3);
        }

        private void btnStopAll2_Click(object sender, EventArgs e)
        {
            if (threadBalls2.Count > 0)
            {
                Thread td = (Thread)threadBalls2[threadBalls2.Count - 1];
                td.Abort();
                threadBalls2.RemoveAt(threadBalls2.Count - 1);
            }
        }

        private void btnStopAll3_Click(object sender, EventArgs e)
        {
            if (threadBalls3.Count > 0)
            {
                Thread td = (Thread)threadBalls3[threadBalls3.Count - 1];
                td.Abort();
                threadBalls3.RemoveAt(threadBalls3.Count - 1);
            }
        }
    }
}
