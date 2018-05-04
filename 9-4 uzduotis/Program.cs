using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //int bakas = 70;
            

            int[] kelione = { 120, 55, 160, 45 };
            int km = kelione[0];

            foreach (var kelio in kelione)
            {
                if (kelio < km)
                {
                    km = kelio;
                }
            }
            Console.WriteLine("trumpiausia kelione: " + km);


            foreach (var kelio in kelione)
            {
                if (kelio > km)
                {
                    km = kelio;
                }
            }
            Console.WriteLine("ilgiausia kelione: " + km);


            var litru_simtui = 8;

            var visa_kelione = 0;
            for (int i = 0; i < kelione.Length; i++)
            {
                visa_kelione  += kelione[i];
            }
            Console.WriteLine("is viso km: " + visa_kelione);

            

            Console.WriteLine("sunaudojo {0} litru", visa_kelione/litru_simtui);
        }
    }
}
