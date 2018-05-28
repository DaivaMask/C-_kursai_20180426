using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_uzduotele
{
    class Program
    {
        //public delegate void AmziausGrupesNustatymas(string Vardas, int Amzius);

        
        static void Main(string[] args)
        {

            Action<string, int> sarasasMetodu = TikrinaArVaikas;
            sarasasMetodu += TikrinaArSenolis;
            sarasasMetodu += TikrinaArSuauges;

            List<Zmogus> asmenys = new List<Zmogus>
            {
                new Zmogus ("Danguole", 54),
            new Zmogus("Jonas", 76),
            new Zmogus("Rokas", 3),
            new Zmogus("Svieta", 32),
            new Zmogus("Janina", 19),
            new Zmogus("inga", 17)
            };

            foreach (var item in asmenys)
            {
                item.AmziausGrupesNustatymas(sarasasMetodu);
            }

        }

        static void TikrinaArVaikas(string Vardas, int Amzius)
        {
            if (Amzius < 18)
            {
                Console.WriteLine("{0} yra vaikas", Vardas);
            }
        }

        static void TikrinaArSenolis(string Vardas, int Amzius)
        {
            if (Amzius >= 65)
            {
                Console.WriteLine("{0} yra senolis", Vardas);
            }
        }
        static void TikrinaArSuauges(string Vardas, int Amzius)
        {
            if (Amzius >= 18 && Amzius < 65)
            {
                Console.WriteLine("{0} yra suauges", Vardas);
            }
        }


    }



}
