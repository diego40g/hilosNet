using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Collections;

namespace VIDEO169HILOS_MONTERO_PAZ_REINOSO
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
            //this.Refresh();
        }
       
        public void MoveBall(object o)
        {
            Graphics dc = this.CreateGraphics();
            Random r = new Random();
            SolidBrush solidBrush = new SolidBrush(
                Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            ThreadData d = (ThreadData)o;
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
                        dc.DrawEllipse(Pens.Black, d.BallX, d.BallY, BallWidth, BallHeight);
                        dc.FillEllipse(solidBrush, d.BallX, d.BallY, BallWidth, BallHeight);
                        this.Invalidate();
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            label2.Text = threadBalls.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (threadBalls.Count > 0)
            {
                Thread td = (Thread)threadBalls[threadBalls.Count - 1];
                Thread.Sleep(100);
                td.Abort();
                threadBalls.RemoveAt(threadBalls.Count - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
