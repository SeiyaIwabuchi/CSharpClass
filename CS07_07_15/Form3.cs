using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_15
{
    public partial class Form3 : Form
    {
        private Record rec;
        internal Form3()
        {
            InitializeComponent();
        }
        internal Form3(Record r)
        {
            InitializeComponent();
            rec = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "1" || textBox1.Text == "2" || textBox1.Text == "3" || textBox1.Text == "4" || textBox1.Text == "5")
                {
                    rec.grade = int.Parse(textBox1.Text);
                    this.Close();
                }
                else
                {
                    label1.Text = "成績が間違っています。";
                }
            }
            catch (FormatException)
            {
                label1.Text = "成績が間違っています。";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((TextBox)sender).Text == "1" || ((TextBox)sender).Text == "2" || ((TextBox)sender).Text == "3" || ((TextBox)sender).Text == "4" || ((TextBox)sender).Text == "5")
                {
                    label1.Text = ((TextBox)sender).Text + "ですね。";
                }
                else
                {
                    label1.Text = "成績が間違っています。";
                }
            }
        }
    }
}
