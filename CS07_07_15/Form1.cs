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
    public partial class Form1 : Form
    {
        private Record[] dummy = { new Record("岩渕誠也",-1,-1), new Record("岩渕道明", -1, -1), new Record("岩渕レイ子", -1, -1) };
        public Form1()
        {
            InitializeComponent();
            foreach(Record r in dummy)
            {
                listBox1.Items.Add(r.name) ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                new Form2(dummy[listBox1.SelectedIndex]).ShowDialog();
            }
            else
            {
                try
                {
                    new Form3(dummy[listBox1.SelectedIndex]).ShowDialog();
                }catch(IndexOutOfRangeException)
                {
                    MessageBox.Show("リストボックスから名前を選択してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
