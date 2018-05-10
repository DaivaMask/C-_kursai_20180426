using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_pvz
{
    class prieglauda
    {
        public string Pavadinimas;
        public string Adresas;
        public List<suo> Sunys;
        //arba taip: public List<suo> Sunys = new List<suo>();


        public prieglauda(string pavadinimas, string adresas)  //neturi saraso, rinksis pagal vedamus duomenis kuri naudoti
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = new List<suo>();    //sarasas turi buti paruostas naudoti, jis turi veikti
        }

        public prieglauda(string pavadinimas, string adresas, List<suo> sunys) //su sarasu
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Sunys = sunys;
        }

        //prideti sunis
        public void Checkin()
        {
            Console.WriteLine("kiek sunu prisicheckins: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(i + 1 + "suns duomenys: ");
                Sunys.Add(new suo()); //sunys prideti (naujas suo)
            }
        }


        //priglaudos isvedimas
        public void Isvedimas()
        {
            //isvedami prieglaudos duomenys
            Console.WriteLine("Prieglauda '{0}' randasi {1} ", Pavadinimas, Adresas);

            foreach (var suoo in Sunys)
            {
                suoo.Isvedimas();
            }

            Console.WriteLine("vyriausias suo: ");
            VyriausiasSuo().Isvedimas();  //objektas.ovjekto isvedimas is suns klases

            Console.WriteLine("sunu amzius: " + vidurkis());
        }

        //vyriausias suo
        public suo VyriausiasSuo()
        {
            var vyriausias = Sunys.First();

            foreach (var suo in Sunys)
            {
                //suo.Amzius naudoti palyginimui
                if (suo.Amzius > vyriausias.Amzius)
                {
                    vyriausias = suo;
                }
            }

            return vyriausias;
        }

        //amziaus vidurkis
        public double vidurkis()
        {
            var suma = 0;

            foreach (var vid in Sunys)
            {
                suma += vid.Amzius;
            }

            return (double)suma / Sunys.Count;


        }



    }
}
