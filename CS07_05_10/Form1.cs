using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_05_10
{
    public partial class Form1 : Form
    {
        //private ToolStripMenuItem[] mi = new ToolStripMenuItem[10+3];
        public Form1()
        {
            InitializeComponent();
            /*mi[0] = new ToolStripMenuItem("メイン1");
            mi[1] = new ToolStripMenuItem("メイン2");
            mi[2] = new ToolStripMenuItem("サブ1") ;
            mi[3] = new ToolStripMenuItem("サブ2") ;
            mi[4] = new ToolStripMenuItem("乗用車");
            mi[5] = new ToolStripMenuItem("トラック");
            mi[6] = new ToolStripMenuItem("オープンカー");
            mi[7] = new ToolStripMenuItem ("タクシー"); 
            mi[8] = new ToolStripMenuItem("スポーツカー");
            mi[9] = new ToolStripMenuItem("ミニカー");
            mi[10] = new ToolStripMenuItem("メイン3");
            mi[11] = new ToolStripMenuItem("パトカー");
            mi[12] = new ToolStripMenuItem("消防車");

            mi[0].DropDownItems.Add(mi[4]);
            mi[0].DropDownItems.Add(mi[5]);

            mi[1].DropDownItems.Add(mi[2]);
            mi[1].DropDownItems.Add(new ToolStripSeparator());
            mi[1].DropDown.Items.Add(mi[3]);
            mi[2].DropDownItems.Add(mi[6]);
            mi[2].DropDownItems.Add(mi[7]); 
            mi[3].DropDownItems.Add(mi[8]);
            mi[3].DropDownItems.Add(mi[9]);
            mi[10].DropDownItems.Add(mi[11]);
            mi[10].DropDownItems.Add(mi[12]);

            menuStrip1.Items.Add(mi[0]);
            menuStrip1.Items.Add(mi[1]);
            menuStrip1.Items.Add(mi[10]);
            
            for (int i = 4; i < mi.Length; i++) mi[i].Click += new EventHandler(mi_click);
            */
        }

        public void mi_click(Object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            if (mi.DropDownItems.Count == 0)
            {
                if (mi.OwnerItem.Text == "メイン3")
                {
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                    label1.Text = mi.Text + "ですね。";
                }
                else
                {
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label1.Text = mi.Text + "ですね。";
                }
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
