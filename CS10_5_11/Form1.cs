using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10_5_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            tableLayoutPanel1.SetColumnSpan(richTextBox1, 2);
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            try
            {
                using (StreamReader sr = new StreamReader("text.txt"))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }catch(FileNotFoundException e)
            {
                //ファイルがないなら何もしない。
            }
        }
        private void search()
        {
            try
            {
                Regex rx = new Regex(textBox1.Text);
                Match m = null;
                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Black;
                for (m = rx.Match(richTextBox1.Text); m.Success; m = m.NextMatch())
                {
                    richTextBox1.Select(m.Index, m.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }catch(ArgumentException e)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                sw.Write(richTextBox1.Text);
            }
        }
    }
}