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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] temps = {radioButton1.Checked, radioButton2.Checked, radioButton3.Checked };
            MessageBox.Show( Form2.ShowConfirmationForm(temps,richTextBox1.Text));
        }
    }
}
