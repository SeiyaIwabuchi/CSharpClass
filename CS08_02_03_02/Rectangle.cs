using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace CS08_02_03_02
{
    class Rectangle : Figure
    {
        Point p; int Width; int Height;

        public void setP(Point p) { 
            this.p = p;
            Random rn = new Random();
            this.Width = 10 + rn.Next(20);
            this.Height = 10 + rn.Next(20);
        }
        public Point getP() { return p; }
        public int getWidth() { return Width; }
        public int getHeight() { return Height; }
    }
}