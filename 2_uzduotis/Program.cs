using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_uzduotis
{
    public interface IGyvunas
    {
        string Vardas { get; set; }
        string Rusis { get; set; }
        string apibudinimas();
    }

    class Suo : IGyvunas
    {
       public  string Vardas { get; set; }
       public  string Rusis { get; set; }
       public  string apibudinimas()
        {
            string eilute = "Kaime pririštas prie grandinės ir nutrūksta norėdamas pagauti katiną";
            string eilutee = Vardas + ' ' + Rusis + ' ' + eilute;
            return eilutee;
         }

        public Suo(string Vardas, string Rusis)
        {
            this.Vardas = Vardas;
            this.Rusis = Rusis;
        }
    }

    class Seskas : IGyvunas
    {
        public string Vardas { get; set; }
        public string Rusis { get; set; }
        public string apibudinimas()
        {
            string eilute = "Šeškas labai greit laksto.. tik spėk gaudyt, geriau pavadėlį nusipirkti";
            string eilutee = Vardas + ' ' + Rusis + ' ' + eilute;
            return eilutee;
        }

        public Seskas(string Vardas, string Rusis)
        {
            this.Vardas = Vardas;
            this.Rusis = Rusis;
        }

    }

    class Briedis : IGyvunas
    {

        public string Vardas { get; set; }
        public string Rusis { get; set; }
        public string apibudinimas()
        {
            string eilute = "Briedis užaugina ir numeta laaaaaaabai didelius ragus";
            string eilutee = Vardas + ' ' + Rusis + ' ' + eilute;
            return eilutee;
        }

        public Briedis(string Vardas, string Rusis)
        {
            this.Vardas = Vardas;
            this.Rusis = Rusis;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Suo s = new Suo ("šuo Pifas", "lenciūginis");
            Console.WriteLine(s.apibudinimas());
            Seskas ss = new Seskas("Mika", "pasirodo plėšrūnas");
            Console.WriteLine(ss.apibudinimas());
            Briedis b = new Briedis("vardas nežinomas", "žinduolis");
            Console.WriteLine(b.apibudinimas());
        }
    }
}
