using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite varda: ");
            var vardas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("iveskite amziu: ");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tavo vardas {0}, o tavo amzius {1} m." , vardas,amzius);
           
        }
    }
}
