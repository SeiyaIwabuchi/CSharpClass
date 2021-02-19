using System;
using System.Collections;
using System.Linq;

namespace CS12_1_1
{
    class car
    {
        public int 番号;
        public string 名前;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            car[] 車表 = 
            {
                new car() {番号=2,名前="乗用車"},
                new car() {番号=3,名前="オープンカー"},
                new car() {番号=4,名前="トラック"}
            };
            IEnumerable qry = from K in 車表
                              where K.番号 <= 3
                              orderby K.番号 descending
                             select new { K.名前, K.番号 };
            foreach(var tmp in qry)
            {
                Console.WriteLine(tmp);
            }
        }
    }
}
