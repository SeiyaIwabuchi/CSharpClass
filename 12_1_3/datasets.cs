using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_3
{
    class 担任
    {
        public string クラス;
        public string 担任名;
    }

    class 学生
    {
        public string クラス;
        public int 番号;
        public string 学生名;
        public int 出席率;
    }
    class datasets
    {
        public static 担任[] 担任表 = {
            new 担任(){ クラス="TE2A",担任名="後藤みき"},
            new 担任(){クラス="TE3A", 担任名="藤本まき"},
            new 担任(){クラス="TE4A", 担任名="辻あさみ"},
            new 担任(){クラス="TE5A", 担任名="雲丹ありさ" }
        };
        public static 学生[] 学生表 = {
            new 学生(){クラス="TE2A", 番号=1, 学生名="紺野こうた", 出席率=80},
            new 学生(){クラス="TE2A", 番号=2, 学生名="小川のぶ", 出席率=90},
            new 学生(){クラス="TE3A", 番号=1, 学生名="道重ゆう", 出席率=50},
            new 学生(){クラス="TE3A", 番号=2, 学生名="新垣たく", 出席率=70},
            new 学生(){クラス="TE4A", 番号=1, 学生名="田中さとみ", 出席率=80},
            new 学生(){クラス="TE4A", 番号=2, 学生名="髙橋あい", 出席率=100}
        };
    }
}
