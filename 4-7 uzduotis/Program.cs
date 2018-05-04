using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk laipsnius pagal Celsiju: ");
            var c = Convert.ToDouble(Console.ReadLine());
            var k = c + 273.15;
            Console.WriteLine("ivesti laipsniai pagal Kelvina yra {0}",k);

            //9/5 + 32 = 68 °F
            var f = (c * (9 / 5)) + 32;

        }
    }
}
