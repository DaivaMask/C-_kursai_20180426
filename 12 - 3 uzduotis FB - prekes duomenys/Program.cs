using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___3_uzduotis_FB___prekes_duomenys
{
    class Program
    {
        static void Main(string[] args)
        {

            var parduotuve = new Parduotuve("Maxima", "Savanoriu 321", 63.3,
                new List < preke >
                { new preke ("duona", 2.1, 1.4, 10),
                new preke ("pienas", 0.90, 0.50, 6),
                new preke ("cukrus", 1, 0.3, 5)
            });

            parduotuve.Isvedimas();
            

        }
    }
}
