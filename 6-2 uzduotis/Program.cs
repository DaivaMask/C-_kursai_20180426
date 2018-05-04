using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk tris skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            var v = (double)(a + b + c) / 3;
            Console.WriteLine("pazymiu vidurkis yra " + v);

            if (v >= 8 && v <= 10)
            {
                Console.WriteLine("vidurkis lygus 8, 9 arba 10");
            }
          if (v >= 5 && v < 8)

            {
                Console.WriteLine("vidurkis lygus 5, 6 arba 7");
            }
            if (v <5)
            {
                Console.WriteLine("vidurkis mazesnis nei 5");
            }
        }
    }
}
