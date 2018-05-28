using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_uzduotis
{
    class Imone
    {
        public string Pavadinimas { get; set; }
        public string Adresas { get; set; }
        public int Biudzetas { get; set; }
        public Imone(string Pavadinimas, string Adresas, int Biudzetas)
        {
            this.Pavadinimas = Pavadinimas;
            this.Adresas = Adresas;
            this.Biudzetas = Biudzetas;
        }

    }


    class Program
    {
        public delegate bool Tikrinimas(int pinigai);

        static bool Tusinukai (int pinigai)
        {
            if (pinigai < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Zenkliukai (int pinigai)
        {
            if (pinigai >= 100 && pinigai <= 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Puodukai(int pinigai)
        {
            if (pinigai > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



            static void Main(string[] args)
        {
        }
    }
}
