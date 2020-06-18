using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tmp = (TextBox)sender;
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "" && textBox2.Text != "") label1.Text = textBox1.Text + "と" + textBox2.Text + "を選択しました。";
                else if (textBox1.Text != "" && textBox2.Text == "") label1.Text = textBox1.Text + "を選択しました。";
                else if (textBox1.Text == "" && textBox2.Text != "") label1.Text = textBox2.Text + "を選択しました。";
                else if (textBox1.Text == "" && textBox2.Text == "") label1.Text = "いらっしゃいませ。";
            }
        }
    }
}
