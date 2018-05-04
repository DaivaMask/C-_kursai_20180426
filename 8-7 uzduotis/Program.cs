using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk viena skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("antra skaiciu");
            var b = Convert.ToInt32(Console.ReadLine());
            var atsakymas = 0;

            for (int i = 1; i <= b; i++)
            {
                atsakymas += a;
                
            }
            Console.WriteLine(atsakymas);
        }
    }
}
