using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite simboli: ");
            var s = Convert.ToChar (Console.Read());
            
            Console.WriteLine("{0}{0}{0}", s);
            Console.WriteLine("{0}{0}{0}", s);
            Console.WriteLine("{0}{0}{0}", s);


        }
    }
}
