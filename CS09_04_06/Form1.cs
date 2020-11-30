using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09_04_06
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        private DataGridView dg;
        public Form1()
        {
            InitializeComponent();

            ds = this.dataSet1;
            dg = this.dataGridView1;

            ds.ReadXml(@"..\..\Sample.xml");
            dg.DataSource = ds.Tables[0];
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            this.Width = dataGridView1.Width + dataGridView1.RowHeadersWidth;
        }
    }
}
