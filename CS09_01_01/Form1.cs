using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09_01_01
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlp;
        private RadioButton[] rb = new RadioButton[4];
        private Image cim;
        private Image[] mim = new Image[4];
        private PictureBox pb;
        private Label lb;
        private int num;
        private bool isOpen;
        public Form1()
        {
            InitializeComponent();
            tlp = tableLayoutPanel1;
            int ii = 0;
            rb[ii++] = radioButton1;
            rb[ii++] = radioButton2;
            rb[ii++] = radioButton3;
            rb[ii++] = radioButton4;
            for (int i = 0; i < rb.Length; i++)
            {
                mim[i] = Image.FromFile("..\\..\\mark" + i + ".bmp");
                rb[i].Image = mim[i];
            }

            cim = Image.FromFile("..\\..\\card.bmp");
            pb = pictureBox1;
            pb.Image = cim;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Anchor = AnchorStyles.Right;
            pb.Parent = tlp;

            //lb = new Label();
            lb = label1;
            lb.Font = new Font("SansSerif", 50, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Anchor = AnchorStyles.None;
            lb.Parent = tlp;

            tlp.SetColumnSpan(pb, 2);
            tlp.SetColumnSpan(lb, 2);

            isOpen = false;
            Random rn = new Random();
            num = rn.Next(4);

            //pb.Click += new EventHandler(pb_Click);
        }

        public void pb_Click(Object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                pb.Image = mim[num];

                if (rb[num].Checked == true)
                {
                    lb.ForeColor = Color.DeepPink;
                    lb.Text = "HIT!";
                }
                else
                {
                    lb.ForeColor = Color.SlateBlue;
                    lb.Text = "MISS!";
                }
            }
            else
            {
                isOpen = false;
                lb.Text = "";
                pb.Image = cim;

                Random rn = new Random();
                num = rn.Next(4);
            }
        }
    }
}
