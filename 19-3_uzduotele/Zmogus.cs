using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_uzduotele
{
    class Zmogus
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }

        public void AmziausGrupesNustatymas(Action <string, int> grupesNustatymoAction)
        {
            grupesNustatymoAction(Vardas, Amzius);
        }

        public Zmogus (string Vardas, int Amzius)
        {
            this.Vardas = Vardas;
            this.Amzius = Amzius;
        }

    }
}
