using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk rezio pradzia");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ivesk rezio pabaiga");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    Console.WriteLine(i + " " + "kvadratu " + (i*i));
                }
            }




        }
    }
}
