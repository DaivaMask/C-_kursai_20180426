using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2
{
    class Photo
    {
        public delegate void PhotoFilterDelegate();

        public void ApplyFilter(PhotoFilterDelegate photoFilter) 
        {
            photoFilter();
        }
    }
}
