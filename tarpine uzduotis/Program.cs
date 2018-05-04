using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek gali iskepti kepalu vienas darbuotojas per valanda?");
            var kepalash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kiek yra darbuotoju?");
            var darb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vieno kepalo savikaina");
            var savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vieno kepalo pardavimo kaina");
            var kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kiek kepalu uzsakyta?");
            var uzsak = Convert.ToInt32(Console.ReadLine());

            var dh = 8;

            var visikepalai = (kepalash * dh) * darb;
            Console.WriteLine("per viena darbo diena iskepta {0} kepalu", visikepalai);

            var sav = visikepalai * savikaina;
            var pelnas = kaina * visikepalai - sav; 
            Console.WriteLine("visa savikaina yra " + sav + " pajamos pardavus " + kaina * visikepalai);
            Console.WriteLine("pelno dalis " + pelnas);
            
            if (visikepalai >= uzsak)
            {
                Console.WriteLine("visi uzsakymai ivykdyti");
              	
            }
            else
            {
                Console.WriteLine("uzsakymai neivykdyti. Nespeta iskepti {0} kepalu.", uzsak-visikepalai);
            }

            

        }
    }
}
