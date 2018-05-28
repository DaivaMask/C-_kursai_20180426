using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzduotis
{
    class Klase : Mokykla
    {
        public List<string> Vardai { get; set; }
        public int[] Vidurkiai { get; set; }

        public Klase(List<string> Vardai, int []  Vidurkiai,int KlasesSkaicius, char KlasesRaide, int MokiniuSkaicius, DateTime MoksluPradzia) 
            : base(KlasesSkaicius, KlasesRaide, MokiniuSkaicius, MoksluPradzia)
        {
            this.Vardai = Vardai;
            this.Vidurkiai = Vidurkiai;
        }

        public Klase()
        {

        }

    }
}

