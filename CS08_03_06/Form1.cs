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

        private List<Ball> ls;
        public Form1()
        {
            InitializeComponent();
            ls = new List<Ball>();

            Random rn = new Random();

            for(int i = 0;i < 30; i++)
            {
                Ball bl = new Ball();
                int[] xy = {rn.Next(this.Width),rn.Next(this.Height)};
                int[] rgb = {rn.Next(256), rn.Next(256), rn.Next(256)};

                Point p = new Point(xy[0],xy[1]);
                Color c = Color.FromArgb(rgb[0], rgb[1], rgb[2]);

                bl.point = p;
                bl.color = c;

                ls.Add(bl);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Ball bl in ls)
            {
                Point p = bl.point;
                Color c = bl.color;
                SolidBrush br = new SolidBrush(c);

                g.FillEllipse(br, p.X, p.Y, 10, 10);
            }
        }
    }
    class Ball
    {
        public Color color;
        public Point point;
    }
}
