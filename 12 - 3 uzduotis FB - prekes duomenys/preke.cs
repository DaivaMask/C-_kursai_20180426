using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___3_uzduotis_FB___prekes_duomenys
{
    class preke
    {
        public string Pavadinimas;
        public double Kaina;
        public double Savikaina;
        public int Kiekis;
       


        public preke(string pavadinimas, double kaina, double savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
        }

        //isvedimas
        public void Isvedimas()
        {
            Console.WriteLine("Prekė " + Pavadinimas + ", jos kaina " + Kaina + ", savikaina - " + Savikaina + ", kiekis - " + Kiekis);

            Console.WriteLine("pelnas: " + Pelnas());

            

        }

        //prekes pelnas (kaina - savikaina)
        public double Pelnas()
        {
            
            var kn = (Kaina - Savikaina) * Kiekis;
            return kn;      //galima buvo rasyti: return (Kaina - Savikaina) * Kiekis;

        }

        //prekes likutis maziau nei 5
        public bool Maziau5()
        {
            
            if (Kiekis <= 5)
            {
                return true;
            }
            return false;
        }
    }
}
