using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek yra klaseje mokiniu?");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kiek konspekte yra lapu?");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("visai klasei reikes {0} popieriaus lapu", m*n );
        }
    }
}
