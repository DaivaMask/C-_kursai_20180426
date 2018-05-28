using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_uzduotis
{
    public class Asmuo
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public Asmuo (string Vardas, string Pavarde)
        {
            this.Vardas = Vardas;
            this. Pavarde = Pavarde;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Asmuo> asmenys = new List<Asmuo>(); 
            Dictionary<Asmuo, int> telKnyga = new Dictionary<Asmuo, int>();

            string[] vardai = {"Jonas", "Antanas", "Stase", "Ieva,", "Barbora" };
            string[] pavardes = {"Jonaitis", "Antanaitis", "Paslaptis", "Kerpe", "Ziede" };
            int[] numeriai = {123123, 159159, 654987, 753649, 85858522};
            Random rng = new Random();

            foreach (var item in asmenys)
            {
                telKnyga.Add(item, numeriai[rng.Next (numeriai.Count())]);
                Console.WriteLine(" " + telKnyga);
            }

        }
    }
}
