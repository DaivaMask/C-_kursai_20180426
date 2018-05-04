using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 25;
            int pirmas = sk / 10;
            var antras = (double) sk % 10  ;
            Console.WriteLine(pirmas + antras );
            Console.WriteLine(pirmas * antras);
        }
    }
}
