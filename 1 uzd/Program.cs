using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            //var skaicius = 0;
            var suma = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("suma " + suma);


        }

        
    }
}

