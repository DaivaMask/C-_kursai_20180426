using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            var vartotojo_vardas = programa.vartotojoVardas();
            programa.pasisveikinti(vartotojo_vardas);

        }

        public void pasisveikinti(string vardas)
        {
            Console.WriteLine("o labas, " + vardas);
        }

        public string vartotojoVardas()
        {
            Console.WriteLine("ivesk varda: ");
            var vardas = Console.ReadLine();
            return vardas;
        }

    }
}
