using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_16_2
{
    public partial class Form2 : Form
    {
        private string[] arguments;
        public Form2(params string[] arg)
        {
            arguments = arg;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            char[] cArr = arguments[0].ToCharArray();
            bool numOnly = true, textOnly = true, isEmpty = true;
            foreach (char c in cArr)
            {
                isEmpty = false;
                char[] tmpCharArray = {c};
                if (int.TryParse(new String(tmpCharArray), out int trash) == false)
                {
                    numOnly = false;
                }
                else
                {
                    textOnly = false;
                }
            }
            checkBox1.Checked = numOnly && !isEmpty;
            checkBox2.Checked = textOnly && !isEmpty;
            checkBox3.Checked = !numOnly && !textOnly && !isEmpty;
        }
        public static void ShowForm(string s)
        {
            Form2 f = new Form2(s);
            f.ShowDialog();
            f.Dispose();
        }
    }
}
