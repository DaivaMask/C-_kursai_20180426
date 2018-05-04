using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ivesk zodi arba exit: ");
            var zodis = Convert.ToString(Console.ReadLine());
            string zd = zodis + " ";

            string pabaiga = "exit";
            while (pabaiga == "exit")
            {
                Console.Write("ivesk zodi arba exit: ");
                pabaiga = Convert.ToString(Console.ReadLine());
                //zd += (zd != "exit") c + " " ;
                //Console.WriteLine();

            }
            Console.WriteLine(zd + " ");
        }
    }
}
