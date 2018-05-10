using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_pvz
{
    class suo  //virsuj project > add class
    {
        public int Amzius;
        public string Veisle;
        public string Vardas;

        public suo(string vardas, string veisle, int amzius)
        {
            Vardas = vardas;
            Veisle = veisle;
            Amzius = amzius;
        }


        //ivedimas
        public suo() //kuriamas tuscias suns objektas ir suvesim duomenis
        {
            Console.WriteLine("ivesk suns amziu: ");
            Amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ivesk veisle: ");
            Veisle = Console.ReadLine();
            Console.WriteLine("ivesk varda: ");
            Vardas = Console.ReadLine();

        }

        public void Isvedimas()
        {
            Console.WriteLine("Suns vardas {0}, jis yra {1} ir jam {2} m.", Vardas, Veisle, Amzius);
        }
    }
}
