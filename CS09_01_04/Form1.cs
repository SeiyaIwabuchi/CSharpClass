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

namespace CS09_01_04
{
    public partial class Form1 : Form
    {
        private List<Ball> ballList;
        private Cart ct;
        private Image im,bim;
        private bool isOver;
        private bool isIn;
        private int score;
        private Stopwatch stopwatch;
        private Random random;
        private int dxy = 1;
        private int dropedCount = 0;
        private long oldAddTime = 0;
        Timer tm;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            random = new Random();
            ballList = new List<Ball>();
            label1.BackColor = Color.FromArgb(0,51,204,255);
            label2.BackColor = Color.FromArgb(0, 51, 204, 255);
            label3.BackColor = Color.FromArgb(0, 51, 204, 255);
            label1.Text = "";
            label2.Text = "";
            im = Image.FromFile("..\\..\\sky.bmp");
            label3.Text = "3";
            this.ClientSize = new Size(600, 300);


            isOver = false;
            isIn = false;

            ballList.Add(new Ball());

            Point blp = new Point(0, 0);
            bim = Image.FromFile("..\\..\\apple.png");

            ballList[0].Point = blp;
            ballList[0].Image = bim;
            ballList[0].dx = 4;
            ballList[0].dy = 4;

            ct = new Cart();

            Point ctp = new Point(this.ClientSize.Width / 2, this.ClientSize.Height - 80);
            Image cim = Image.FromFile("..\\..\\cart.png");

            ct.Point = ctp;
            ct.Image = cim;

            tm = timer1;
            tm.Interval = (int)((1f/30f)*1000f);
            tm.Start();
        }
        public void fm_Paint(Object sender, PaintEventArgs e)
        {
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            
            if (stopwatch.ElapsedMilliseconds > 3000)
            {
                label3.Text = "";
                if (stopwatch.ElapsedMilliseconds - oldAddTime > 10*1000)
                {
                    ballList.Add(new Ball());
                    Point tp = new Point(random.Next(this.ClientSize.Width), random.Next(this.ClientSize.Height / 2));
                    ballList.Last().Point = tp;
                    ballList.Last().Image = bim;
                    ballList.Last().dx = dxy * 4;
                    ballList.Last().dy = dxy * 4;
                    dxy *= -1;
                    oldAddTime = stopwatch.ElapsedMilliseconds;
                }
                Graphics g = e.Graphics;

                g.DrawImage(im, 0, 0, im.Width, im.Height);
                foreach (Ball bl in ballList)
                {
                    Point blp = bl.Point;
                    Image bim = bl.Image;

                    g.DrawImage(bl.Image, blp.X, blp.Y, bim.Width, bim.Height);
                }
                Point ctp = ct.Point;
                Image cim = ct.Image;
                g.DrawImage(ct.Image, ctp.X, ctp.Y, cim.Width, cim.Height);

                if (isOver == true)
                {
                    Font f = new Font("SansSerif", 30);
                    SizeF s = g.MeasureString("Game Over\n" + label1.Text, f);

                    float cx = (this.ClientSize.Width - s.Width) / 2;
                    float cy = (this.ClientSize.Height - s.Height) / 2;

                    g.DrawString("Game Over\n" + label1.Text, f, new SolidBrush(Color.Blue), cx, cy);
                }
            }
            else
            {
                label3.Text = (3- (stopwatch.ElapsedMilliseconds / 1000)).ToString();
            }
        }
        public void tm_Tick(Object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > 3000)
            {
                foreach (Ball bl in ballList)
                {
                    Point blp = bl.Point;
                    Point ctp = ct.Point;

                    Image bim = bl.Image;
                    Image cim = ct.Image;

                    if (blp.X < 0 || blp.X > this.ClientSize.Width - bim.Width) bl.dx = -bl.dx;
                    if (blp.Y < 0) bl.dy = -bl.dy;
                    if ((isIn == false) && (blp.X > ctp.X - bim.Width && blp.X < ctp.X + cim.Width)
                                            && (blp.Y > ctp.Y - bim.Height && blp.Y < ctp.Y - bim.Height / 2))
                    {
                        isIn = true;
                        bl.dy = -bl.dy;
                    }
                    if (blp.Y < ctp.Y - bim.Height)
                    {
                        isIn = false;
                    }
                    if (blp.Y > this.ClientSize.Height && !bl.droped)
                    {
                        dropedCount++;
                        bl.droped = true;
                    }
                    if (dropedCount == 3)
                    {
                        isOver = true;
                        Timer t = (Timer)sender;
                        t.Stop();
                    }
                    if (isIn) score++;
                    label1.Text = "SCORE:" + score.ToString();
                    label2.Text = "DROPPED:" + dropedCount.ToString();
                    blp.X = blp.X + bl.dx;
                    blp.Y = blp.Y + bl.dy; 

                    bl.Point = blp;
                    Console.WriteLine(dropedCount);
                }
                ballList.RemoveAll(bt => bt.droped);
            }
            this.Invalidate();
        }

        public void fm_KeyDown(Object sender, KeyEventArgs e)
        {
            Point ctp = ct.Point;
            Image cim = ct.Image;

            if (e.KeyCode == Keys.Right)
            {
                ctp.X = ctp.X + 4;
                if (ctp.X > this.ClientSize.Width - cim.Width)
                    ctp.X = this.ClientSize.Width - cim.Width;
            }
            else if (e.KeyCode == Keys.Left)
            {
                ctp.X = ctp.X - 4;
                if (ctp.X < 0)
                    ctp.X = 0;
            }
            ct.Point = ctp;
            this.Invalidate();
        }
    }
    class Ball
    {
        public Image Image;
        public Point Point;
        public int dx, dy;
        public bool droped = false;
    }
    class Cart
    {
        public Image Image;
        public Point Point;
    }
}
