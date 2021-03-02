using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDB
{
    public partial class Form1 : Form
    {
        Gakusei gakusei = new Gakusei();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "100";
            label1.Text = "";
            try
            {
                foreach (Gakusei g in gakusei.getAll())
                {
                    if (g.Gshusseki > int.Parse(textBox1.Text)) continue;
                    listBox1.Items.Add(String.Format("{0}{1}{2}\t{3}\t{4} %", g.Gakkacode, g.Gakunen, g.Gclass, g.Gname, g.Gshusseki));
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Error: Failed from the DataBase. " + ex.Message;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                foreach (Gakusei g in gakusei.getAll())
                {
                    if (g.Gshusseki > int.Parse(textBox1.Text)) continue;
                    listBox1.Items.Add(String.Format("{0}{1}{2}\t{3}\t{4} %", g.Gakkacode, g.Gakunen, g.Gclass, g.Gname, g.Gshusseki));
                }
            }
            catch (FormatException fe)
            {
                label1.Text = fe.Message;
                return;
            }
            catch (Exception ex)
            {
                label1.Text = "Error: Failed from the DataBase. " + ex.Message;
                return;
            }
        }
    }
}