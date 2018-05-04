using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk tris sveikus skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("1.1 pirmas ir antras skaiciai lygus");
            }
            if (b == c)
            {
                Console.WriteLine("1.2 antras ir trecias lygus");
            }

            if (a > b)
            {
                Console.WriteLine("1.3 pirmas didesnis uz antra");
            }

            if (b > (c * 2))
            {
                Console.WriteLine("1.4 antras didesnis uz dviguba trecia");

            }

            if ((a % 2) == 0)
            {
                Console.WriteLine("1.5 pirmas yra lyginis");

            }
            if ((b % 2) != 0)
            {
                Console.WriteLine("1.6 antras yra nelyginis");
            }
            if (c>0)
            {
                Console.WriteLine("1.7 trecias yra teigiamas");

            }
            if (c<0)
            {
                Console.WriteLine("1.8 trecias yra neigiamas");

            }
        }
    }
}
