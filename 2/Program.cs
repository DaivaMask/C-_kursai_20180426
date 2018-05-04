using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 3; //ilgis
            var p = 5; //plotis
            var pl = i * p;
            Console.Write("kambario ilgis " + i);
            Console.WriteLine(", plotis " + p + ", plotas - " + pl);
            Console.WriteLine("kokia plyteliu kvadrato kaina?");
            var kaina = Convert.ToDouble(Console.ReadLine());
            var eur = pl* kaina;
            //Console.WriteLine(Math.Round(eur, 2));
            Console.WriteLine("kambario grindims reikes {0} eur", eur + eur*0.05);
            //Console.WriteLine(Math.Round(2.366, 2));
            //kaip jeigu kaina su kableliu?
            
        }
    }
}
