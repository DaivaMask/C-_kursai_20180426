using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___4_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var kompas = new kompiuteris();
            //kompas.DiskoTalpa = 5;  //negalima, nes private
            Console.WriteLine(kompas.DiskoTalpa);

            var kompas2 = new kompiuteris("asdfasd", "adfa", 5);

            var kompas3 = new kompiuteris();
            kompas3.Ivedimas();
            

        }
    }
}
