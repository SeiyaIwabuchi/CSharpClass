using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_03_06
{
    public partial class Form1 : Form
    {

        private List<Tri> ls;
        public Form1()
        {
            InitializeComponent();
            ls = new List<Tri>();

            Random rn = new Random();

            for(int i = 0;i < 100; i++)
            {
                //Ball bl = new Ball();
                Tri tr = new Tri();
                int[] xy = {rn.Next(this.Width),rn.Next(this.Height)};
                int[] rgb = {rn.Next(256), rn.Next(256), rn.Next(256), rn.Next(256) };

                //Point p = new Point(xy[0],xy[1]);
                Point a = new Point(xy[0],xy[1]);
                Point b = new Point(xy[0], xy[1]+10);
                Point c = new Point(xy[0]+5, xy[1]+5);
                Color col = Color.FromArgb(rgb[0], rgb[1], rgb[2],rgb[3]);
                tr.a = a;
                tr.b = b;
                tr.c = c;
                tr.color = col;
                Console.WriteLine(col);
                //bl.point = p;
                //bl.color = c;

                ls.Add(tr);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Tri t in ls)
            {
                SolidBrush br = new SolidBrush(t.color);
                Point[] p = new Point[3];
                int i = 0;
                p[i++] = t.a;
                p[i++] = t.b;
                p[i++] = t.c;
                g.FillPolygon(br, p);
            }
        }
    }
    class Ball
    {
        public Color color;
        public Point point;
    }
    class Tri
    {
        public Color color;
        public Point a, b, c;
    }
}
