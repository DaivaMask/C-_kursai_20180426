﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_point_koordiinates
{
    public interface IPoint
    {
        int x { get; }
        int y { get; }
        void Draw();
    }

    class Taskas : IPoint
    {
        public int x { get; }
        public int y { get; }

        public void Draw()
        {
            Console.WriteLine("brezia apskritima");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
