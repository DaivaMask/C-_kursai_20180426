using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_uzduotis_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ivesk teigiama skaiciu:");
            //var skaicius = Convert.ToInt32(Console.ReadLine());
            //while (skaicius > 0)
            //{
            //    Console.WriteLine(skaicius);
            //    skaicius--;
            //}

            //2 uzduotis


            Console.WriteLine("ivesk neigiama skaiciu:");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius <= 0)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }


        }
    }
}
