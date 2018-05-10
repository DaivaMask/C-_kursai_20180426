using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___1_pvz
{
    class Automobilis
    {   //rekomendacija kaip rasyti:
        //publiv AbcAbc - pascal case
        //private _abcAbc - canel case

        public int GimimoMetai;
        public string Spalva;
        public string Marke;
        public string VIN;
        public string ValstybinisNumeris;
        //public List<int> asd;

        //konstruktorius ctor >tab - leidzia suvesti paprasciau duomenis; kvieciamas kai kuriamas objektas

        public Automobilis() //konstruktorius be parametru
        {

        }

        //abcAbc - metodu parametrai - camel case
        public Automobilis(int gimimoMetai, string spalva, string marke, string vin, string valstybinisNumeris) //jeigu is karto norima sudeti
        {
            GimimoMetai = gimimoMetai;
            Spalva = spalva;
            Marke = marke;
            VIN = vin;
            ValstybinisNumeris = valstybinisNumeris;
        }



        //isvedimas
        public void Isvedimas()
        {
            Console.WriteLine("automobilis {0}, spalva {1}, pagamintas {2} m ir jo numeris yra {3} ", Marke, Spalva, GimimoMetai, ValstybinisNumeris);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis(); //objektas; gali buti var auto =...
            auto.GimimoMetai = 2005;
            auto.Spalva = "juoda";
            Console.WriteLine(auto.Spalva);
            Console.WriteLine(auto.GimimoMetai);

            //arba
            var auto2 = new Automobilis()
            {
                GimimoMetai = 2005,
                Spalva = "juoda",
                Marke = "bmw" // kablelis , nebutinas
            };
            Console.WriteLine(auto2.Marke);
            Console.WriteLine(auto2.GimimoMetai);
            Console.WriteLine(auto2.Spalva);

            //arba
            var auto3 = new Automobilis(2005, "melyna", "audi", "WPFKkffsd2365", "HHG265");

            //var auto4 = new Automobilis(spalva:"balta");

            auto.Isvedimas();
            auto2.Isvedimas();
            auto3.Isvedimas();


        }
    }
}

