using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___3_uzduotis_FB___prekes_duomenys
{
    class Parduotuve
    {
        public string Pavadinimas;
        public string Adresas;
        public double Plotas;
        public List<preke> Preke;

        public Parduotuve(string pavadinimas, string adresas, double plotas, List<preke> preke)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Plotas = plotas;
            Preke = preke;
        }

        //isvedimas
        public void Isvedimas()
        {
            Console.WriteLine("Parduotuve: " + Pavadinimas + ", kurios adresas " + Adresas);

            foreach (var prek in Preke)
            {
                prek.Isvedimas();
            }


        }
    }
}
