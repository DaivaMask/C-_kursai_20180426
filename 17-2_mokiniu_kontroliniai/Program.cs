using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_mokiniu_kontroliniai
{
    //siaip pvz : skirtingi tipai liste
    class SkirtingiTipai <T,K, A> where T:IEnumerable<int>  //T privalo buti int (uzdedam apribojimus)
        where A: Program
        {
       public List<T> vienasTipas { get; set; }
        public List<K> AntrasTipas { get; set; }
        public List<A> TreciasTipas { get; set; }

        //naudojimas zemiau po visu kodu

    }



    //skaitymas is failo
    //stulpelyje mokinys, eiluteje pazymiai

    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader reader = new System.IO.StreamReader("vidurkiai.txt");
            List<List<int>> sarasas = new List<List<int>>();  //sarasas sarase; kaip gridas
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                List<int> tempData = new List<int>();
                foreach (var item in data)
                {
                    tempData.Add(int.Parse(item));
                }
                sarasas.Add(tempData);
            }

            //mokiniu vidurkis
            foreach (var item in sarasas)
            {
                Console.WriteLine("mokinio vidurkis yra {0:0.00}", item.Average());  //:0.00 suapvalins du skaicius po kableliu
            }

            //kontroliniu (stulepliu) vidurkis
            var laikinaKopija = sarasas.ToArray();   //padarys stulepliu masyva
            for (int i = 0; i < laikinaKopija[0].Count; i++)
            {
                int suma = 0;
                int divider = 0;
                for (int j = 0; j < laikinaKopija.Length; j++)
                {
                    if (laikinaKopija[j].Count > j)
                        suma += laikinaKopija[j].ElementAt(i);
                    else
                        divider = j;
                    if (laikinaKopija.Length - 1 >= j)
                    {
                        divider = laikinaKopija.Length;
                    }
                }

                Console.WriteLine("kontroliniu vidurkis yra {0:0.00}", ((double)suma / divider));
            }

            //mokiniu vidurkiai mazejancia tvarka
            List<List<int>> surikiuotaInformacija = new List<List<int>>();         //surikiuota informacija
            while (sarasas.Count != 0)
            {
                double max = double.MinValue;
                List<int> maxMember = new List<int>(); //issisaugoti max skaicius
                foreach (var item in sarasas)
                {
                    if (max < item.Average())
                    {
                        max = item.Average();
                        maxMember = item;
                    }
                }
                surikiuotaInformacija.Add(maxMember);
                sarasas.Remove(maxMember);
            }
            foreach (var item in surikiuotaInformacija)
            {
                Console.WriteLine("mokinio vidurkis {0:0.00}", item.Average());
            }


            //naujos klases listas
           //gerai, kai be apribojimu: List<SkirtingiTipai<int, string, char>> kazkas = new List<SkirtingiTipai<int, string, char>>();

            List<SkirtingiTipai<IEnumerable<int>, string, Program>> kazkas = new List<SkirtingiTipai<IEnumerable<int>, string, Program>>();

        }
    }
}
