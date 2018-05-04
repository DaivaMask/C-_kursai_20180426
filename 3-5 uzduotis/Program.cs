using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 5;
            var s = 0;
            Console.WriteLine("5 * 0 = " + sk*s);
            Console.WriteLine("5 * 1 = " + sk * ++s);
            Console.WriteLine("5 * 2 = "  + sk * ++s);
            Console.WriteLine("5 * 3 = " + sk * ++s);
            Console.WriteLine("5 * 4 = "  +sk * ++s);
            Console.WriteLine("5 * 5 = " +sk * ++s);
            Console.WriteLine("5 * 6 = " + sk * ++s);

            Console.WriteLine("5 * 7 = " + sk * 7);
            Console.WriteLine("5 * 8 = " + sk * 8);
            Console.WriteLine("5 * 9 = " + sk * 9);
            Console.WriteLine("5 * 10 = " + sk * 10);

        }
    }
}
