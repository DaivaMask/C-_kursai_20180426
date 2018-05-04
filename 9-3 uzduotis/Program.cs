using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pazymiai = {3, 6, 9, 10, 4, 2};
            int pazymys = pazymiai[0];

            foreach (var paz in pazymiai)
            {
                if (paz > pazymys)
                {
                    pazymys = paz;
                }
            }
            Console.WriteLine("geriausias pazymys" + pazymys);

        }
    }
}
