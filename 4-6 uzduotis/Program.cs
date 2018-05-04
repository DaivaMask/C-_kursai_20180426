
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk tris skaicius: ");
            var sk1 = Convert.ToDouble(Console.ReadLine());
            var sk2 = Convert.ToDouble(Console.ReadLine());
            var sk3 = Convert.ToDouble(Console.ReadLine());

            var vd = Math.Round(((sk1 + sk2 + sk3) / 3), 1);
            Console.WriteLine("ivestu skaiciu {0}, {1}, {2} vidurkis yra {3} ", sk1, sk2, sk3, vd);
        }
    }
}
