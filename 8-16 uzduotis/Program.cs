using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;
            do
            {
                Console.WriteLine("1 - suo, 2 - kate,  3 - vista");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas < 1 || pasirinkimas > 3)
                {
                    Console.WriteLine("blogas pasirinkimas");
                }
                //else if (pasirinkimas == 1)
                //{
                //    Console.WriteLine("pasirinkimas " + 1);
                //}
                //else if (pasirinkimas == 2)
                //{
                //    Console.WriteLine("pasirinkimas " + 2);
                //}
                //else if (pasirinkimas == 3)
                //{
                //    Console.WriteLine("pasirinkimas " + 3);
                //}
            } while (pasirinkimas >= 1 || pasirinkimas <= 3);
            Console.WriteLine("pasirinkimas " + pasirinkimas);
        }
    }
}
