using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_16_1
{
    public partial class Form2 : Form
    {
        private string[] arguments;
        public string returnValue;
        public Form2(params string[] arg)
        {
            arguments = arg;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = arguments[0];
            richTextBox1.Text = arguments[1];
        }
        static public string ShowConfirmationForm(bool[] temp,string comment)
        {
            string[] tempStr = { "37.5℃未満", "37.5℃以上", "未測定" };
            int tempSelected = -1;
            for(int i=0;i<temp.Length;i++)
            {
                if (temp[i]) tempSelected = i;
            }
            Form2 f = new Form2(tempStr[tempSelected],comment);
            f.ShowDialog();
            f.Dispose();
            return "送信しました。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
