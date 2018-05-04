using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ivesk skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius % 9 != 0)
            {
                Console.Write("ivesk skaiciu: ");
                skaicius = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("ivestas skaicius dalinasi is 9");

            }

            Console.WriteLine("ivestas skaicius dalinasi is 9");

        }
    }
}
