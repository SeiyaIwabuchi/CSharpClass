using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_02_03_02
{
    public partial class Form1 : Form
    {
        private List<Figure> ls;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            ls = new List<Figure>();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw(e);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {   // 処理は設定していません         

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ドローはペンを、フィルはブラシを使う             Pen dp = new Pen(Color.Black, 1); 

            //Bitmap img = (Bitmap)Image.FromFile("C:¥¥ビットマップを指定する");
            //TextureBrush txb = new TextureBrush(img);
            Pen dp = new Pen(Color.Black);
            Brush db = new SolidBrush(Color.Black);

            foreach (Figure f in ls) { 
                if (f is Rectangle) { 
                    Rectangle r = (Rectangle)f;
                    g.FillRectangle(db, r.getP().X, r.getP().Y, r.getWidth(), r.getHeight());
                } else {
                    Triangle t = (Triangle)f;
                    g.FillPolygon(db, t.getP());
                } 
            }
        }

        private void draw(MouseEventArgs e)
        {
            if (count % 2 == 0)
            {
                Triangle tr = new Triangle(); Point p = new Point(); p.X = e.X; p.Y = e.Y; tr.setP(p);

                ls.Add(tr); this.Invalidate();
            }
            else
            {
                Rectangle rct = new Rectangle(); Point p = new Point(); p.X = e.X; p.Y = e.Y; rct.setP(p);

                ls.Add(rct); this.Invalidate();
            }
            count++;
        }
    }
}