using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_04_07
{
    public partial class Form1 : Form
    {
        private Ball bl;
        private int dx, dy;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.ClientSize = new Size(250,100);
            bl = new Ball();

            Point p = new Point(0,0);
            Color c = Color.Blue;

            bl.Point = p;
            bl.Color = c;

            dx = 2;
            dy = 2;

            Timer tm = timer1;
            tm.Interval = 100;
            tm.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = bl.Point;

            if (p.X < 0 || p.X > this.ClientSize.Width - 20) dx = random.Next(1, 10) * (Math.Abs(dx)) * -1;
            if (p.Y < 0 || p.Y > this.ClientSize.Height - 20) dy = random.Next(1, 10) * (Math.Abs(dy)) * -1;

            p.X = p.X + dx;
            p.Y = p.Y + dy;

            bl.Point = p;
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point p = bl.Point;
            Color c = bl.Color;
            SolidBrush br = new SolidBrush(c);
            try
            {
                g.FillEllipse(br, p.X, p.Y, 10, 10);
            }
            catch(OverflowException oe)
            {
                p = new Point(0, 0);
                g.FillEllipse(br, p.X, p.Y, 10, 10);
                Console.WriteLine(oe);
            }
            
        }
    }
    class Ball
    {
        public Color Color;
        public Point Point;
    }
}
