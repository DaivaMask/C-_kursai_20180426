using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk tris skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a>b || a>c )
            {
                Console.WriteLine("didesnis skaicius yra {0}",a);
                
            }
            else if (b>c || b>a)
            {
                Console.WriteLine("didesnis skaicius yra {0}", b);
            }
            else Console.WriteLine("didesnis skaicius yra {0}",c);
        }
    }
}
