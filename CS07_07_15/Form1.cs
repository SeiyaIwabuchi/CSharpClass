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
            for (int i = 0; i < dummy.Length; i++) dataGridView1.Rows.Add(
                i.ToString(), dummy[i].name, 
                dummy[i].attend != -1 ? dummy[i].attend.ToString() : "", 
                dummy[i].grade != -1 ? dummy[i].grade.ToString() : ""
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record trec = dummy[0];
            foreach (DataGridViewRow sr in dataGridView1.SelectedRows)
            {
                trec = dummy[int.Parse((string)sr.Cells[0].Value)];
            }
            if (radioButton1.Checked)
            {
                new Form2(trec).ShowDialog();
            }
            else
            {
                new Form3(trec).ShowDialog();
            }
            dataReload();
        }
        //DataGridViewの表示更新
        void dataReload()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dummy.Length; i++) dataGridView1.Rows.Add(i.ToString(), dummy[i].name, dummy[i].attend!=-1?dummy[i].attend.ToString():"", dummy[i].grade != -1 ? dummy[i].grade.ToString() : "");
        }
    }
}
