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
        private CheckBox[] rb = new CheckBox[4];
        private Image cim;
        private Image[] mim = new Image[4];
        private MyCard pb1,pb2;
        private Label lb;
        private MyList chkHist;
        public Form1()
        {
            InitializeComponent();
            Program.cont = false;
            chkHist = new MyList();
            tlp = tableLayoutPanel1;
            int ii = 0;
            rb[ii++] = checkBox1;
            rb[ii++] = checkBox2;
            rb[ii++] = checkBox3;
            rb[ii++] = checkBox4;
            for (int i = 0; i < rb.Length; i++)
            {
                mim[i] = Image.FromFile("..\\..\\mark" + i + ".bmp");
                rb[i].Image = mim[i];
                rb[i].Text = "";
            }

            cim = Image.FromFile("..\\..\\card.bmp");
            pb1 = pictureBox1;
            pb1.Image = cim;
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            pb1.Anchor = AnchorStyles.Right;
            pb2 = (MyCard)pictureBox2;
            pb2.Image = cim;
            pb2.SizeMode = PictureBoxSizeMode.AutoSize;
            pb2.Anchor = AnchorStyles.Right;

            //lb = new Label();
            lb = label1;
            lb.Font = new Font("SansSerif", 50, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Anchor = AnchorStyles.None;
            lb.Parent = tlp;

            //tlp.SetColumnSpan(pb1, 2);
            tlp.SetColumnSpan(lb, 2);

            Random rn = new Random();
            pb1.num = rn.Next(4);
            pb2.num = rn.Next(4);
            while (pb2.num == pb1.num) pb2.num = rn.Next(4);

            //pb.Click += new EventHandler(pb_Click);
        }

        public void pb_Click(Object sender, EventArgs e)
        {
            MyCard tp = (MyCard)sender;
            if (tp.isOpen == false)
            {
                tp.isOpen = true;
                tp.Image = mim[tp.num];
            }
            judgement();
            /*else
            {
                tp.isOpen = false;
                lb.Text = "";
                tp.Image = cim;

                Random rn = new Random();
                tp.num = rn.Next(4);
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int checkedIndex = 0;
            for (int i = 0;i < rb.Length;i++)
            {
                if(rb[i] == (CheckBox)sender)
                {
                    if(((CheckBox)sender).Checked)  chkHist.Add(i);
                    checkedIndex = i;
                    break;
                }
            }
            if(chkHist.Count >= 3 && rb[chkHist[0]].Checked)
            {
                rb[chkHist[0]].Checked = false;
                chkHist.RemoveAt(0);
            }
            Console.WriteLine(((CheckBox)sender).Checked);
            if(chkHist.Count <= 2 && !((CheckBox)sender).Checked)
            {
                chkHist.RemoveAll(t => t == checkedIndex);
            }
            Console.WriteLine(chkHist.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.cont = true;
            this.Dispose();
        }

        void judgement()
        {
            if (pb1.isOpen && pb2.isOpen)
            {
                if (rb[pb1.num].Checked && rb[pb2.num].Checked)
                {
                    lb.ForeColor = Color.DeepPink;
                    lb.Text = "Hit";
                }
                else if ((!rb[pb1.num].Checked && rb[pb2.num].Checked) || (rb[pb1.num].Checked && !rb[pb2.num].Checked))
                {
                    lb.ForeColor = Color.DeepPink;
                    lb.Text = "Small Hit";
                }
                else
                {
                    lb.ForeColor = Color.DeepPink;
                    lb.Text = "Miss";
                }
            }
        }
    }

    class MyCard : PictureBox
    {
        public bool isOpen = false;
        public int num = 0;
    }
    class MyList : List<int>
    {
        public override string ToString()
        {
            String s = "[";
            for(int i = 0; i < this.Count; i++)
            {
                s += this[i];
                if(this.Count-1 > i)
                {
                    s += ",";
                }
            }
            s += "]";
            return s;
        }
    }
}
