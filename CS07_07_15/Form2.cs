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
    public partial class Form2 : Form
    {
        private Record rec;
        public Form2()
        {
            InitializeComponent();
        }
        internal Form2(Record r)
        {
            InitializeComponent();
            rec = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double attend = double.Parse(textBox1.Text);
                if (0 <= attend && attend <= 100)
                {
                    if (attend * 10 % 1 == 0)
                    {
                        rec.attend =attend;
                        this.Close();
                    }
                    else
                    {
                        label1.Text = "小数第一位まで入力して下さい。";
                        label1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label1.Text = "0~100の範囲で入力して下さい。";
                    label1.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {
                label1.Text = "数値を入力して下さい。";
                label1.ForeColor = Color.Red;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double attend = double.Parse(((TextBox)sender).Text);
                    if(0 <= attend && attend <= 100)
                    {
                        if (attend * 10 % 1 == 0) {
                            label1.Text = Math.Round(attend, 1).ToString() + "%ですね。";
                            label1.ForeColor = Color.Black;
                        }
                        else
                        {
                            label1.Text = "小数第一位まで入力して下さい。";
                            label1.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        label1.Text = "0から100の範囲で入力して下さい。";
                        label1.ForeColor = Color.Red;
                    }
                }
                catch (FormatException)
                {
                    label1.Text = "数値を入力して下さい。";
                    label1.ForeColor = Color.Red;
                }

            }
        }
    }
}
