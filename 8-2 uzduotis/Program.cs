using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i += 2)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            for (int i = 1; i < 20; i += 2)
            {
                Console.Write("[" + i + "] ");
            }
            Console.WriteLine();



            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
