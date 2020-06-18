using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_06_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("本当に購入しますか？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                dr = MessageBox.Show("本当に本当に購入しますか？", "再確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("ご購入ありがとうございました。", "購入", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
