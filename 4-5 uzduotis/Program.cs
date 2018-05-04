using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite sveikaji skaiciu: ");
            var sk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * 1 = {1} ", sk, (sk*1));
            Console.WriteLine("{0} * 2 = {1} ", sk, (sk * 2));
            Console.WriteLine("{0} * 3 = {1} ", sk, (sk * 3));
            Console.WriteLine("{0} * 4 = {1} ", sk, (sk * 4));
            Console.WriteLine("{0} * 5 = {1} ", sk, (sk * 5));

        }
    }
}
