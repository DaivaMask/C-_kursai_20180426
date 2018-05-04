using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //var suma = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    suma += i;
            //}
            //Console.WriteLine("suma: " + suma);

            //var lygsuma = 0;
            //for (int i = 20; i < 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        lygsuma += i;
            //    }
            //}
            //Console.WriteLine("lyginiu suma: " + lygsuma);

            //var nelygsuma = 0;
            //for (int i = 30; i < 60; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        nelygsuma += i;
            //    }
            //}
            //Console.WriteLine("nelyginiu suma: " + nelygsuma);

            //var x = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        x += i;
            //    }
            //}
            //Console.WriteLine("suma " + x);

           
            for (int i = 1; i < 20; i++)
            {
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BuzzFizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
