using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 25;
            Console.WriteLine("- " + skaicius + " " + skaicius + " " + skaicius );
            Console.WriteLine(" {0} {0} {0} {0}" , skaicius);
        }
    }
}
