using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace CS08_02_03_02
{
    class Triangle : Figure
    {
        private Point[] pa;

        public void setP(Point p) {
            pa = new Point[3];
            Random rn = new Random();
            pa[0] = p; pa[1].X = p.X + 10 + rn.Next(15);
            pa[1].Y = p.Y + 10 - rn.Next(20);
            pa[2].X = (p.X + pa[1].X) / 2; pa[2].Y = p.Y + 10 + rn.Next(5);
        }
        public Point[] getP() { return pa; }
    }
}