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
        private Graphics g;
        private Bitmap img;
        private Bitmap canvas;
        private bool tg = true;
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
            ((Button)button1).Text = tg ? "止める！" : "回す！";
            rotation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            tg = !tg;
            ((Button)sender).Text = tg ? "止める！" : "回す！";
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
                for (int i = 0; i < 360;)
                {
                    await Task.Delay(1);
                    //中心位置を求める
                    float centX = img.Width / 2;
                    float centY = img.Height / 2;
                    //斜辺長を求める
                    float r = (float)Math.Sqrt( (Math.Pow(centX,2)) + (Math.Pow(centY,2)) );
                    //float X = (r * (float)Math.Cos(d));
                    //float Y = (r* (float)Math.Sin(d));
                    //画像右上の座標
                    float rightTopX = (r * (float)Math.Cos(getRadFromDeg(i -26.56505F))) + centX;
                    float rightTopY = (r * (float)Math.Sin(getRadFromDeg(i - 26.56505F))) + centX;
                    //画像左上の座標
                    float leftBottomX = (r * (float)Math.Cos(getRadFromDeg(i + 180 - 26.56505F))) + centX;
                    float leftBottomY = (r * (float)Math.Sin(getRadFromDeg(i + 180 - 26.56505F))) + centX;
                    //画像左下の座標
                    float leftTopX = (r * (float)Math.Cos(getRadFromDeg(i + 26.56505F + 180))) + centX;
                    float leftTopY = (r * (float)Math.Sin(getRadFromDeg(i + 26.56505F + 180))) + centX;
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
                    if (tg)
                    {
                        g.Clear(this.BackColor);
                        g.DrawImage(img, destinationPoints);
                        pictureBox1.Image = canvas;
                        toolStripStatusLabel1.Text = i.ToString() + "°";
                        i++;
                    }
                    //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    //setPositon();
                }
            }
        }
        private float getRadFromDeg(float deg)
        {
            return (float)(deg / (180 / Math.PI));
        }
    }
}
