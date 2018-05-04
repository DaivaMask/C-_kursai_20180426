using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            var suma = a + b;
            var skirtumas = a - b;
            var sandauga = a * b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", a, b, sandauga);
            //math.Pow (2, 3) pakels 2 treciuoju laipsniu
        }
    }
}
