using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CS11._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry ih = Dns.GetHostEntry(textBox1.Text);
                IPAddress ia = ih.AddressList[0];
                ipStrToInt(ia.ToString());
                hostLabel.Text = ih.HostName;
                IPLabel.Text = ia.ToString();
                if(ipStrToInt("1.0.0.0") <= ipStrToInt(ia.ToString()) && ipStrToInt(ia.ToString()) <= ipStrToInt("126.255.255.255"))
                {
                    classLabel.Text = "A";
                }
                else if (ipStrToInt("128.0.0.0") <= ipStrToInt(ia.ToString()) && ipStrToInt(ia.ToString()) <= ipStrToInt("191.255.255.255"))
                {
                    classLabel.Text = "B";
                }
                else if (ipStrToInt("192.0.0.0") <= ipStrToInt(ia.ToString()) && ipStrToInt(ia.ToString()) <= ipStrToInt("223.255.255.255"))
                {
                    classLabel.Text = "C";
                }
                else
                {
                    classLabel.Text = "不明";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                hostLabel.Text = "";
                IPLabel.Text = "";
                classLabel.Text = "";
                MessageBox.Show("エラーが発生しました。\n" + ex.Message);
            }
            
        }
        private ulong ipStrToInt(String ipstr)
        {
            ulong ipulong = 0;
            for(int i=0; i<4; i++)
            {
                ipulong += (ulong)(int.Parse(ipstr.Split('.')[i]) << (8*(3-i)));
            }
            return ipulong;
        }
    }
}
