using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzduotis
{
    class Mokykla
    {
        public int KlasesSkaicius { get; set; }
        public char KlasesRaide { get; set; }
        public int MokiniuSkaicius { get; set; }
       public DateTime MoksluPradzia { get; set; }

        public Mokykla(int KlasesSkaicius, char KlasesRaide, int MokiniuSkaicius, DateTime MoksluPradzia)
        {
            this.KlasesSkaicius = KlasesSkaicius;
            this.KlasesRaide = KlasesRaide;
            this.MokiniuSkaicius = MokiniuSkaicius;
            this.MoksluPradzia = MoksluPradzia;
        }

        public Mokykla()
        {

        }

        //kiek metu mokosi
        public int KiekMokosi (DateTime mokslai)
        {
            return (DateTime.Today.Year - mokslai.Year);
        }
    }
}
