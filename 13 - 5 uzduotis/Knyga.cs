using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___5_uzduotis
{
    public class Knyga
    {
       public string Autorius { get; set; }
        public string Pavadinimas { get; set; }
        public int PuslapiuSkaicius { get; set; }
        public double Kaina { get; set; }

        public Knyga (string autorius, string pavadinimas, int puslapiuSkaicius, double kaina)
        {
            Autorius = autorius;
            Pavadinimas = pavadinimas;
            PuslapiuSkaicius = puslapiuSkaicius;
            Kaina = kaina;
        }

        public Knyga (string eilute)
        {
            var duomenys = eilute.Split(';');
            Autorius = duomenys[0];
            Pavadinimas = duomenys[1];
            PuslapiuSkaicius = Convert.ToInt32(duomenys[2]);
            Kaina = Convert.ToDouble(duomenys[3]);
        }

        public Knyga()
        {

        }

    }
}
