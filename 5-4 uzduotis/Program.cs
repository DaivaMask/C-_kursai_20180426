using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk penkis savo pazymius");
            var p1 = Convert.ToInt32(Console.ReadLine());
            var p2 = Convert.ToInt32(Console.ReadLine());
            var p3 = Convert.ToInt32(Console.ReadLine());
            var p4 = Convert.ToInt32(Console.ReadLine());
            var p5 = Convert.ToInt32(Console.ReadLine());

            var v = (double)(p1 + p2 + p3 + p4 + p5) / 5;
            Console.WriteLine("pazymiu vidurkis yra {0}", v);
            if (v >= 5)
            {
                Console.WriteLine("valio, pazymiu vidurkis didesnis uz 5");
            }

        }
    }
}
