using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_16
{
    public partial class Form2 : Form
    {
        private string[] argumentValues;
        public string ReturnValue;
        public Form2(params string[] arg)
        {
            this.argumentValues = arg;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = argumentValues[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = textBox2.Text;
            this.Close();
        }
        static public string ShowMiniForm(string s)
        {
            Form2 f = new Form2(s);
            f.ShowDialog();
            string reciveText = f.ReturnValue;
            f.Dispose();

            return reciveText;
        }
    }
}
