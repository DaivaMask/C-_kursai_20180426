using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("koki kompiuteri turi: 1 - stacionarus, 2 - nesiojamas, 3 - plansete");
            var k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Console.WriteLine("su stacionariu sedek namuose");
                
                    break;
                case 2:
                    Console.WriteLine("su nesiojamu gali iseiti");
                    break;
                case 3:
                    Console.WriteLine("su plansete gali skirsti");
                    break;
                default:
                    Console.WriteLine("toks variantas nerastas");
                    break;
            }

        }
    }
}
