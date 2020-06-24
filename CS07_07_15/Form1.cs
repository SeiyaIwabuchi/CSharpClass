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
            for (int i = 0;i<dummy.Length;i++) dataGridView1.Rows.Add(i.ToString(),dummy[i].name, "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.WriteLine( dataGridView1.SelectedRows.GetType());
                foreach(DataGridViewRow sr in dataGridView1.SelectedRows)
                {
                    new Form2(dummy[int.Parse((string)sr.Cells[0].Value)]).ShowDialog();
                }
            }
            else
            {
                try
                {
                    //new Form3(dummy[listBox1.SelectedIndex]).ShowDialog();
                }catch(IndexOutOfRangeException)
                {
                    MessageBox.Show("リストボックスから名前を選択してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            dateReload();
        }
        void dateReload()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dummy.Length; i++) dataGridView1.Rows.Add(i.ToString(), dummy[i].name, dummy[i].attend!=-1?dummy[i].attend.ToString():"", dummy[i].grade != -1 ? dummy[i].grade.ToString() : "");
        }
    }
}
