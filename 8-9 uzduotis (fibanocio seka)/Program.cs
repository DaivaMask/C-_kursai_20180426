using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9_uzduotis__fibanocio_seka_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek isvesti fibanocio sekos skaiciu?: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var a = 0;
            var b = 1;
            var c = a + b;

            Console.Write(a + " " + b + " " +b + " ");
            for (int i = 2; i < x; i++)
            {
                c += i;
                Console.Write(c+ " ");
            }
        }
    }
}
