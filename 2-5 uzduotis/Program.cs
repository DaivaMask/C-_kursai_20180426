using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zv = '*';
            Console.WriteLine("****");
            Console.WriteLine("" + zv + " " + " " + zv);
            Console.WriteLine("{0}{0}{0}{0}" , zv);
        }
    }
}
