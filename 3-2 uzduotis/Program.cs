using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 2;
            var kvadratu = skaicius * skaicius;
            var treciu_laipsniu = Math.Pow(skaicius, 3);
            Console.WriteLine(" Skaicius {0}"  ,skaicius);
            Console.WriteLine("kvadratu {0} ", kvadratu);
            Console.WriteLine("treciu {0}", treciu_laipsniu);

            Console.WriteLine(Math.Pow(skaicius, 3));
           
        }
    }
}
