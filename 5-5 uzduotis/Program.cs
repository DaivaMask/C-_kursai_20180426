﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk tris skaicius ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("pirmas didesnis uz antra");
            }
            else if (b > c)
            {
                Console.WriteLine("antras didesnis uz trecia");
            }
            else if (c > a)
            {
                Console.WriteLine("trecias didesnis uz pirma");
            }
            else if (a==b)
            {
                Console.WriteLine("pirmas ir antras lygus");
            }
        }
    }
}
