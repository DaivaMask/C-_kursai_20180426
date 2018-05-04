using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzdutis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk du skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a>b || a==0)
            {
                Console.WriteLine("pirmas didesnis uz antra ARBA lygus 0");
            }
            if (b>a || b ==5)
            {
                Console.WriteLine("antras didesnis uz pirma ARBA lygus 5");
            }
            if (a>b && a==20)
            {
                Console.WriteLine("pirmas didesnis uz antra IR lygus 20");
            }
            if (b>a && b<100)
            {
                Console.WriteLine("antras didesnis uz pirma IR mazesnis uz 100");
            }
        }
    }
}
