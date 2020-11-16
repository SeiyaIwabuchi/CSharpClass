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

namespace CS10_03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender == button1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "バイナリファイル|*";
                char[] ch = new char[2];
                String tb1Text = "", tb2Text = "";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryReader br = new BinaryReader(new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)))
                    {
                        long size = br.BaseStream.Length;
                        while (size > 0)
                        {
                            byte bt = br.ReadByte();
                            tb1Text += bt.ToString("x");
                            if ((bt >= 0x41 && bt <= 0x5a) || (bt >= 0x61 && bt <= 0x7a)) tb2Text += Convert.ToChar(bt).ToString();
                            else tb2Text += " ";
                            size -= 1;
                        }
                    }
                    textBox1.Text = tb1Text;
                    textBox2.Text = tb2Text;
                }
            }
            else if(sender == button2)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "バイナリファイル|*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write).Close();
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(sfd.FileName, FileMode.Truncate, FileAccess.Write)))
                    {
                        bw.Seek(0, SeekOrigin.Begin);
                        for(int i = 0; i < textBox1.Text.Length / 2; i++)
                        {
                            string str = textBox1.Text.Substring(i * 2, 2);
                            char[] ch = str.ToCharArray();
                            if (Uri.IsHexDigit(ch[0]) && Uri.IsHexDigit(ch[1]))
                            {
                                bw.Write(Convert.ToByte(str, 16));
                            }
                        }
                    }
                }
            }
        }
    }
}
