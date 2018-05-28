using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2
{
    class PhotoFiltras
    {
        public string Name { get; set; }
        public void GrayScale()
        {
            Console.WriteLine("Pridedam GrayScale Filtra");
        }

        public void Sepia()
        {
            Console.WriteLine("Pridedam Sepia Filtra");

        }

        public PhotoFiltras()
        {

        }
    }
}
