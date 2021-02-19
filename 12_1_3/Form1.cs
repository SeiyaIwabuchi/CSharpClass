using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IEnumerable qry =
                from sensei in datasets.担任表
                join seito in datasets.学生表
                on sensei.クラス equals seito.クラス into ss
                from comb in ss
                where comb.出席率 <= (textBox1.Text != ""?int.Parse(textBox1.Text):0)
                orderby comb.クラス, comb.番号 ascending
                select new { comb.クラス, comb.番号, comb.学生名, comb.出席率, sensei.担任名 };
            foreach (var col in qry)
            {
                Console.WriteLine(col);
                listBox1.Items.Add(col);
            }
        }
    }
}