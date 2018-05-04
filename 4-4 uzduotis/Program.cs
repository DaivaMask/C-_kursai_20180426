using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());

            var suma = sk1 + sk2 + sk3;
            Console.WriteLine("skaiciu suma yra " + suma);
            Console.WriteLine("{0} + {1} + {2} = {3} ",sk1, sk2, sk3, suma);

            var skirtumas = sk1 - sk2 - sk3;
            Console.WriteLine("skaiciu skirtumas yra " + skirtumas);
            Console.WriteLine("{0} - {1} - {2} = {3} ", sk1, sk2, sk3, skirtumas);

        }
    }
}
