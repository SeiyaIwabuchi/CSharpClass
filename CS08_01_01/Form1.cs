using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_01_01
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap img;
        Bitmap canvas;
        public Form1()
        {
            InitializeComponent();
            //this.pictureBox1.Image = Image.FromFile(@"..\..\car.bmp");
            //描画先とするImageオブジェクトを作成する
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            g = Graphics.FromImage(canvas);
            //描画する画像のBitmapオブジェクトを作成
            img = new Bitmap(@"..\..\car.bmp");
            //g.DrawImage(img,new PointF((canvas.Width/2) - (img.Width / 2), (canvas.Height / 2) - (img.Height / 2)));
            //pictureBox1.Image = canvas;
            //setPositon();
            rotation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //setPositon();
        }

        private void setPositon()
        {
            this.pictureBox1.Image = pictureBox1.Image;
            this.pictureBox1.Size = this.pictureBox1.Image.Size;
            pictureBox1.Location = new Point((this.Size.Width / 2) - (pictureBox1.Size.Width / 2) - 10, (this.Size.Height / 2) - (pictureBox1.Size.Height / 2) - button1.Size.Height - 10);
            Console.WriteLine(this.pictureBox1.Size);
        }
        
        private async void rotation()
        {
            //ラジアン単位に変換
            for (; ; )
            {
                for (int i = 0; i < 360; i++)
                {
                    await Task.Delay(1);
                    double d = i / (180 / Math.PI);
                    //中心位置を求める
                    float centX = img.Width / 2;
                    float centY = img.Height / 2;
                    //斜辺長を求める
                    float r = (float)Math.Sqrt( (Math.Pow(centX,2)) + (Math.Pow(centY,2)) );
                    //画像右上の座標
                    float rightTopX = centX - (r * (float)Math.Cos(d)) ;
                    float rightTopY = centY + (r * (float)Math.Sin(d));
                    //画像左上の座標
                    float leftTopX = centX - (r * (float)Math.Cos(d));
                    float leftTopY = centY - (r * (float)Math.Sin(d));
                    //画像左下の座標
                    float leftBottomX = centX - (r * (float)Math.Cos(d));
                    float leftBottomY = centY + (r * (float)Math.Sin(d));
                    //PointF配列を作成
                    PointF[] destinationPoints = {
                    new PointF(leftTopX, leftTopY),
                    new PointF(rightTopX, rightTopY),
                    new PointF(leftBottomX, leftBottomY)
                    };
                    foreach (PointF p in destinationPoints){
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();
                    //g.Clear(this.BackColor);
                    g.DrawImage(img, destinationPoints);
                    pictureBox1.Image = canvas ;
                    //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    //setPositon();
                }
            }
        }
    }
}
