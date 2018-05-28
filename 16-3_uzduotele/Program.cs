using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3_uzduotele
{
    public interface IZmones
    {
        int ID { get; }
        string Name { get; }

        void PrintOutData();
    }


    public class ZmogusConsole : IZmones
    {

        public int ID { get; }
        public string Name { get; }


        [STAThread]
        public void PrintOutData()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); //iskvies langa, kurioj galesim parinkti vieta failo saugojimui
            string path = null;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path + "\\out.txt", true); //true - rasys zemyn, ne ant virsaus (pildysis failas)
            writer.WriteLine("Vartotojo ID: " + ID);
            writer.WriteLine("Vartotojo vardas: " + Name);
            writer.Flush(); //issivalo atminti
        }

        public ZmogusConsole(int ID, string Name)  //konstruktorius
        {
            this.ID = ID;
            this.Name = Name;
        }
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Koks ID ir vardas (ivesti per tarpa)");
            string[] data = Console.ReadLine().Split(' ');

            ZmogusConsole zmogus = new ZmogusConsole(int.Parse(data[0]), data[1]); //parse = convert.toInt
            zmogus.PrintOutData();



        }
    }
}
