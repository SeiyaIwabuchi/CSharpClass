using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_02_03
{
    public partial class Form1 : Form
    {
        private Bitmap bm1, bm2;
        private int i;
        //ColorMatrixオブジェクトの作成
        //グレースケールに変換するための行列を指定する
        private System.Drawing.Imaging.ColorMatrix cm =
            new System.Drawing.Imaging.ColorMatrix(
                new float[][]{
                    new float[]{0.299f, 0.299f, 0.299f, 0 ,0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
        //ImageAttributesオブジェクトの作成
        private System.Drawing.Imaging.ImageAttributes ia =
        new System.Drawing.Imaging.ImageAttributes();

        //bm1のGraphicsオブジェクトを取得
        private Graphics g;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            g.DrawImage(bm2,new Rectangle(0,0,bm1.Width,bm1.Height), 0, 0, bm1.Width, bm1.Height, GraphicsUnit.Pixel, ia);
            pictureBox1.Image = bm2;
        }

        public Form1()
        {
            InitializeComponent();
            bm1 = new Bitmap("../../tea.jpg");
            bm2 = new Bitmap("../../tea.jpg");
            pictureBox1.Image = bm1;
            ia.SetColorMatrix(cm);
            //bm1のGraphicsオブジェクトを取得
            g = Graphics.FromImage(bm2);
    }
        
    }
}
