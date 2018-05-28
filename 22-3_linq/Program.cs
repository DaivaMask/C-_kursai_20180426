using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3_linq
{
    class Zmogus
    {
        public int Ugis { get; set; }
        public double Svoris { get; set; }
        public string Vardas { get; set; }

        public Zmogus(int Ugis, double Svoris, string Vardas)
        {
            this.Ugis = Ugis;
            this.Svoris = Svoris;
            this.Vardas = Vardas;
        }

        public double KMIskaiciavimas()
        {
            return (Svoris / Math.Pow((double)Ugis/100,2));  //svoris (kg) padalintas is ugio metrais  kvadratu
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Zmogus> zmones = new List<Zmogus>()
            {
                new Zmogus (180, 105, "Rokas"),
                new Zmogus(173, 65, "Ugne"),
                new Zmogus (168, 89, "Povilas"),
                new Zmogus(210, 105, "Jonas"),
                new Zmogus (173, 68, "Rasa"),
                new Zmogus (189, 98, "Justas")
             };

            //maziau populiarus
            IEnumerable<Zmogus> KMIdaugiau25 =    //zmogus skaip su lamda, kaip x'as
                from zmogus in zmones
                where zmogus.KMIskaiciavimas() > 25
                select zmogus;


            //IEnumerable<Zmogus> PVZ =
            //    from zmon in zmones
            //   join ...


            //labiau populiarus parasymas
            IEnumerable<Zmogus> KMIGeras = zmones.
                Where(x => x.KMIskaiciavimas() > 20 && x.KMIskaiciavimas() < 25).
                OrderBy(x => x.Vardas);

            foreach (var item in KMIdaugiau25)
            {
                Console.WriteLine(item.Vardas);
            }
            Console.WriteLine("------------------------------");
            foreach (var item in KMIGeras)
            {
                Console.WriteLine("KMI geras: " + item.Vardas);
            }
        }
    }
}
