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
            if(comboBox1.SelectedIndex != -1)
            {
                rec.grade = comboBox1.SelectedIndex + 1;
                this.Close();
            }
            else
            {
                label1.Text = "1～5を選択してください。";
            }
            
        }
    }
}
