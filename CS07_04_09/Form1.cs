using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_04_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] str = {"乗用車","トラック","オープンカー","タクシー","スポーツカー","ミニカー","自転車","三輪車","バイク","飛行機","ヘリコプター","ロケット"};
            foreach(string s in str)
            {
                listBox1.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tmp = (ListBox)sender;
            label1.Text = tmp.Text + "を選びました。";
        }
    }
}
