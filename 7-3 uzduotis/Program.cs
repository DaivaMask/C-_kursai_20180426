using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirink gerima: 1-vanduo, 2 - kava, 3 - arbata, 4 - kakava");
            var s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    Console.WriteLine("pasirinktas vanduo");

                    break;
                case 2:
                    Console.WriteLine("pasirinkta kava");
                    break;
                case 3:
                    Console.WriteLine("pasirinkta arbata");
                    break;
                case 4:
                    Console.WriteLine("pasirinkta kakava");
                    break;
            }
        }
    }
}
