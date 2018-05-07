using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //eurovizijos balai
            // susikurti 2 balu sarasus
            //metodai: - duomenu suvedimas konsoles pagalba
            //- balu sumos skaiciavimui
            //    -maziausias balas
            //    -didziausias balas
            // - balu vidurkis
            // - aukstesniu uz vidurki elementu kiekis
            //    -isvedimas
            //    -palyginti, kuriame sarase yra didziausias balu vidurkis
            //    -surasti, kuriame sarase yra maziausias balas

            Program programa = new Program();
            var balai2016 = programa.ivedimas(); //new Dictionary<string, int>() //pilnas sarasas su visais duomenim
            var balai2017 = programa.ivedimas();

            programa.isvedimas(balai2016);
            programa.isvedimas(balai2017);

            programa.Palyginimas(balai2016, balai2017); //palyginimo isvedimas
            programa.aukst_vidurki(balai2016, balai2017);
        }
    
     

        //aukstesni uz vidurki
        public void aukst_vidurki(Dictionary<string, int> balai1, Dictionary<string, int> balai2)
        {
            var aukst1 = vidurkis(balai1);
            var kiek = 0;

            for (int i = 0; i < balai1.Count; i++)
            {
                if (balai1.ElementAt(i).Value >= aukst1)
                {
                    Console.WriteLine("aukstesni uz vidurki 2016m: " + aukst1);
                }
            }

            var aukst2 = vidurkis(balai2);
            for (int i = 0; i < balai2.Count; i++)
            {
                if (balai2.ElementAt(i).Value >= aukst2)
                {
                    Console.WriteLine("aukstesni uz vidurki 2017m: " + aukst2);
                }
            }


        }

        //vidurkis
        public double vidurkis(Dictionary<string, int> balai)
        {
            //naudos sumos metoda

            var sum = suma(balai);
            //balai.count //kiekis
            var kiek = balai.Count;

            return (double)sum / kiek;

        }

        //palyginimas
        public void Palyginimas(Dictionary<string, int> balai1,
            Dictionary<string, int> balai2)
        {
            var vidurkis1 = vidurkis(balai1);
            var vidurkis2 = vidurkis(balai2);

            //cia if salyga ir isvesti ka norim

            if (vidurkis1 > vidurkis2)
            {
                Console.WriteLine("vidurkis didesnis 2016m " + vidurkis1);
            }
            else if (vidurkis1 < vidurkis2)
            {
                Console.WriteLine("vidurkis didesnis 2017 m" + vidurkis2);
            }
        }




        //maziausio radimas
        public int maziausias(Dictionary<string, int> balai)
        {
            var indeksas = 0;
            var maziausias = balai.ElementAt(0).Value; //balas[0].reiksme

            for (int i = 0; i < balai.Count; i++)
            {
                if (balai.ElementAt(i).Value <= maziausias)
                {
                    indeksas = i;
                    maziausias = balai.ElementAt(i).Value;
                }
            }

            return indeksas;

        }


        //didziausias

        public int didziausias(Dictionary<string, int> balai)
        {
            var indeksas = 0;
            var didziausias = balai.ElementAt(0).Value; //balas[0].reiksme

            for (int i = 0; i < balai.Count; i++)
            {
                if (balai.ElementAt(i).Value >= didziausias)
                {
                    indeksas = i;
                    didziausias = balai.ElementAt(i).Value;
                }
            }

            return indeksas;

        }

        public void isvedimas(Dictionary<string, int> balai) //kairej pusej (stringa) bus Key, kas desinej (int) bus Value
        {
            foreach (var balas in balai)
            {
                Console.WriteLine(balas.Key + ": " + balas.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("balu suma: " + suma(balai));
            Console.WriteLine();
            Console.WriteLine("maziausias: " + balai.ElementAt(maziausias(balai)));
            Console.WriteLine();
            Console.WriteLine("didziausias: " + balai.ElementAt(didziausias(balai)));
            Console.WriteLine();
            Console.WriteLine("vidurkis: " + vidurkis(balai));
            Console.WriteLine();
        }

        public Dictionary<string, int> ivedimas() // public void ivedimas(Dictionary<string, int> balai)
        {
            var balai = new Dictionary<string, int>();
            //paklausti kiek duomenu suvesti vartotojui
            //gauti atsakyma is vartotojo
            //sukti cikla tiek kartu kiek pasirinko suvesti duomenu

            Console.WriteLine("kiek duomenu suvesi?");
            var b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                Console.Write("salies pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("balai: ");
                var gautiBalai = Convert.ToInt32(Console.ReadLine());

                balai.Add(pavadinimas, gautiBalai);
            }

            return balai;
        }
        //balu sumos radimas
        public int suma(Dictionary<string, int> balai)
        {
            var suma = 0; //prie kazko turesim prisideti gauta suma
            foreach (var balas in balai)
            {
                suma += balas.Value; //int dalis is dictionary saraso
            }

            return suma;
        }



    }
}
