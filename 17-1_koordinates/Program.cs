﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_koordinates
{
    class Point
    {
        public int x { get; }
        public int y { get; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            List<Point> taskai = new List<Point>();
            Random rng = new Random();
            for (int i = 0; i < rng.Next(); i++)
            {
                taskai.Add(new Point(rng.Next(-10, 10), rng.Next(-10, 10)));
            }

            int xc = 5;  //xcentras
            int yc = 6;
            int r = 10;

            foreach (var item in taskai)
            {
                if (r> (Math.Sqrt(Math.Pow(item.x-xc,2) + Math.Pow(item.y - yc, 2))))  //formule d= kvadratine_saknis( (x2 - x1)kvadratu + (y2 - y1)kvadratu )
                {
                    Console.WriteLine("Taskas {0} {1} yra apskritime", item.x, item.y);
                }


            }
        }
    }
}
