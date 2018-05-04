using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_0_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] pazymiai = new int[6];
            //pazymiai[0] = 6;
            //pazymiai[1] = 10;
            //pazymiai[2] = 9;
            //pazymiai[3] = 8;
            //Console.WriteLine("pazymiu kiekis: " + pazymiai.Length);

            //string[] auto = new string[10];
            //auto[0] = "audi";
            //auto[1] = "bmw";
            //auto[2] = "opel";
            //Console.WriteLine("pirmas - " + auto.First());
            //Console.WriteLine("paskutinis - " + auto.Last ());


            //double[] kaina =  { 3.23, 6.66, 2.33, 9.63, 5.64 };
            //Console.WriteLine(kaina[2]);
            //----------------------------------------------------------------------------

            /*
             Console.WriteLine("kiek vardu suvesi?");
            int kiek = Convert.ToInt32(Console.ReadLine ());

            string[] vardai = new string[kiek];

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("ivesk varda: ");
                vardai[i] = Console.ReadLine(); 
            }

            foreach (var vardas in vardai)
            {
                Console.Write(vardas + " ");
            }
            Console.WriteLine();
            */

            //----------------------------------------------------------------------------

            //int[] skaiciai = new int[] { 2, 3, 1, 4, 1 };

            //var suma = 0;
            //foreach (var skaicius in skaiciai)
            //{
            //    suma += skaicius;

            //}
            //Console.WriteLine(suma);

            //----------------------------------------------------------------------------
            //tas pats

            int[] skaiciai = new int[] { 2, 3, 1, 4, -2 };
            var suma = skaiciai.Sum();
            Console.WriteLine(suma);

            //----------------------------------------------------------------------------

            //min 

            int[] skaiciaii = new int[] { 2, 3, 1, 4, -2 };
            var min = skaiciaii[0];
            foreach (var skaicius in skaiciaii)
            {
                if (skaicius < min)
                {
                    min = skaicius; 
                }
            }
            Console.WriteLine("maziausias skaicius - " + min);
            //----------------------------------------------------------------------------
            //max
            int[] skaiciaiii = new int[] { 2, 3, 1, 4, -2 };
            var max = skaiciaiii[0];
            foreach (var skaicius in skaiciaiii)
            {
                if (skaicius > max)
                {
                    max = skaicius;
                }
            }
            Console.WriteLine("didziausias skaicius - " + max);

            ////

            ///////
            //ir dar karta//
            //ir dar vienas komenaras

        }
    }
}
