using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS11_4_4
{
    public partial class form1 : Form
    {
        public static string HOST = "localhost";
        public static int PORT = 10000;
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tc = default(TcpClient);
            StreamReader sr = default(StreamReader);
            try
            {
                using (tc = new TcpClient(HOST, PORT))
                {
                    using (sr = new StreamReader(tc.GetStream()))
                    {
                        String str = sr.ReadLine();
                        textBox1.Text += str + "\r\n";
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.Focus();
                        textBox1.ScrollToCaret();
                    }
                }
            }catch(SocketException ex)
            {
                textBox1.Text = ex.Message;
                textBox1.Text += ex.Source;
                textBox1.Text += ex.StackTrace;
                if (tc != null) tc.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
