using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsitiktinis = new Random();
            var atsitiktinissk = atsitiktinis.Next(10);
            Console.WriteLine("ivesk skaiciu nuo 0 iki 10: ");
            var skaicius = Convert.ToInt32( Console.ReadLine());
            while (skaicius != atsitiktinissk)
            {
                Console.WriteLine("bandyk atspeti slapta skaiciu nuo 0 iki 10: ");
                skaicius = Convert.ToInt32(Console.ReadLine());
                if (skaicius == atsitiktinissk)
                {
                    Console.WriteLine("atspejei");
                }
            }
        }
    }
}
