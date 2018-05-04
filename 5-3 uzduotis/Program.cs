using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk teigiama skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a<0)
            {
                Console.WriteLine(a + " yra neigiamas,as tave aprekiu");
            }
            if (a>0)
            {
                Console.WriteLine(a + " yra teigiamas - sveikinu :)");
            }
            if (a %2 == 0)
            {
                Console.WriteLine(a + " yra lyginis");
            }
            if (a%4 == 0)
            {
                Console.WriteLine(a + " dalinasi is 4");
            }
            if (a>10)
            {
                Console.WriteLine(a + " dalinasi is 10");
            }
        }
    }
}
