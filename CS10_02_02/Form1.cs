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

namespace CS10_02_02
{
    public partial class Form1 : Form
    {
        private TextBox tb;
        private Button bt1, bt2;
        public Form1()
        {
            InitializeComponent();
            tb = textBox1;
            bt1 = button1;
            bt2 = button2;
            tb.Width = this.Width;
            tb.Height = this.Height - 100;
        }
        public void bt_Click(Object sender, EventArgs e)
        {
            if (sender == bt1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "テキストファイル|*.txt|カンマ区切りテキスト(*.csv)|*.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ReadCsv(ofd);
                }
            }
            else if (sender == bt2)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "テキストファイル|*.txt|カンマ区切りテキスト(*.csv)|*.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    string[] sr = tb.Text.Replace("\r","").Split('\n');
                    string saveText = "";
                    for(int i = 0; i < sr.Length; i++)
                    {
                        if (i == sr.Length - 1) saveText += sr[i];
                        else if (i < sr.Length - 1)
                        {
                            if (sr[i] == "") continue;
                            else if (sr[i + 1] != "") saveText += sr[i] + ",";
                            else saveText += sr[i] + "\r\n";
                        }
                    }
                    sw.WriteLine(saveText);
                    Console.WriteLine(saveText);
                    sw.Close();
                }
            }
        }
        void ReadCsv(OpenFileDialog ofd)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.UTF8))
                {
                    tb.Text = "";
                    while (!sr.EndOfStream){
                        string line = sr.ReadLine();
                        string[] columns = line.Split(',');
                        foreach(string s in columns)
                        {
                            tb.Text += s + "\r\n";
                        }
                        tb.Text += "\r\n";
                    }
                }
            }catch(System.Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
        }
    }
}
