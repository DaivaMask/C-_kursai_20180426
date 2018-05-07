using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek vesi pazymiu?");
            var kiekis = Convert.ToInt32(Console.ReadLine());

            List<int> pazymiai = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                pazymiai.Add(2);
                Console.WriteLine();
                pazymiai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
