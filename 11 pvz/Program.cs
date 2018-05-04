using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //cia rasosi kodas
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti();

            programa.Atsisveikinti();

            Pasisveikinti2();

            //arba
            Program.Pasisveikinti2(); //jeigu butu is kitos klases (virsuj class Program)
        }

        //cia rasosi metodai


    public static void Pasisveikinti2()
       {
        Console.WriteLine("labas is static metodo");
        }
     



    //metodas pasisveikinimui
    public void Pasisveikinti()
    {
        Console.WriteLine("laba diena");
    }

    public void Atsisveikinti()
    {
        Console.WriteLine("viso gero!");
    }
}
}
