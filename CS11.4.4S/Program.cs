using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace CS11._4._4S
{
    class Program
    {
        public static string HOST = "localhost";
        public static int PORT = 10000;
        static void Main(string[] args)
        {
            IPHostEntry ih = Dns.GetHostEntry(HOST);
            TcpListener tl = new TcpListener(ih.AddressList[0], PORT);
            tl.Start();

            Console.WriteLine("待機します。");
            while (true)
            {
                using (TcpClient tc = tl.AcceptTcpClient())
                {
                    using (StreamWriter sw = new StreamWriter(tc.GetStream()))
                    {
                        sw.WriteLine("こちらはサーバーです。" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                    }
                }
            }
        }
    }
}
