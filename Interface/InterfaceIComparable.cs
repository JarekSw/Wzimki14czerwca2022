using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Odcinek:IComparable
    {
        int dl;
        
        public Odcinek (int dlugosc)
        {
            dl = dlugosc;
        }
        public int CompareTo(object o)
        {
            Odcinek odcinek = (Odcinek)o;
            if (odcinek.dl > dl)
                return -1;
            if (odcinek.dl < dl)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return dl+"";
        }
    }
}
