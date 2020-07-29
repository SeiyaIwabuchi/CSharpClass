using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_02_03_01
{
    public partial class Form1 : Form
    {
        private Bitmap bm1, bm2;
        //ColorMatrixオブジェクトの作成
        //グレースケールに変換するための行列を指定する
        private System.Drawing.Imaging.ColorMatrix cm;

        private int i=0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap newImg = new Bitmap(bm1.Width, bm1.Height);
            Graphics g = Graphics.FromImage(newImg);
            float[][] cma = new float[][]{
                    new float[]{0.299f, 0.299f, 0.299f, 0 ,0},
                new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}
                };
            foreach (float[] t in cma){
                Console.Write("[");
                foreach (float v in t) Console.Write(v + ",");
                Console.WriteLine("]");
            }
            Console.WriteLine();
            cm = new System.Drawing.Imaging.ColorMatrix(cma);
            i = ++i % 6;
            //ImageAttributesオブジェクトの作成
            System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
            g.DrawImage(bm1, new Rectangle(0, 0, bm1.Width, bm1.Height), 0, 0, bm1.Width, bm1.Height, GraphicsUnit.Pixel, ia);
            ia.SetColorMatrix(cm);
            pictureBox1.Image = newImg;
            //g.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
            bm1 = new Bitmap("../../tea.jpg");
            bm2 = new Bitmap("../../tea.jpg");
            pictureBox1.Image = bm1;
            //bm1のGraphicsオブジェクトを取得
        }

    }
}
