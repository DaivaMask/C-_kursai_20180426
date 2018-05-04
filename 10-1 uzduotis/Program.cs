using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> sarasas = new List<int>();
            var skaiciai = new Random();
            var dydis = skaiciai.Next(1, 101);

            for (int i = 1; i < dydis; i++)
            {
                var skaicius = skaiciai.Next(1, 101);
                sarasas.Add(skaicius);

            }

            var min = sarasas[0];
            foreach (var skaicius in sarasas)
            {
                if (skaicius < min)
                {
                    min = skaicius;
                }
            }
            Console.WriteLine("maziausias: " + min);

            var max = sarasas[0];
            foreach (var skaicius in sarasas)
            {
                if (skaicius > max)
                {
                    max = skaicius;
                }
            }
            Console.WriteLine("didziausias: " + max);

            Console.WriteLine("vidurkis: " + sarasas.Average());


            //var kiek = 0;
            //foreach (var skaicius in sarasas)
            //{
            //    if (skaicius < vidurkis)
            //    {
            //        kiek++;
            //    }
            //}
            //Console.WriteLine("kiek mazesni uz vidurki: " + sarasas.Count());







        }
    }
}
