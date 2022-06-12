using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    delegate bool KtoryMniejszy(object a,object b);
    static class MetodySortwoania
    {
        public static bool PorownajNapisyAlfabetycznie(object a,object b)
        {
            string x=Convert.ToString(a);
            string y=Convert.ToString(b);

            int result = x.CompareTo(y);
            if (result > 0)
                return true;
            else
                return false;
        }
        public static bool PorownajNapisyPoDlugosci(object a, object b)
        {
            string x = Convert.ToString(a);
            string y = Convert.ToString(b);
            if (x.Length > y.Length)
                return true;
            else
                return false;
        }
    }

    internal class Sortowanie
    {
        public object[] tab;
        public void Sort(KtoryMniejszy p)
        {
            for (int k = 0; k < tab.Length - 1; k++)
                for (int i = 0; i < tab.Length - 1 - k; i++)
                    if (p(tab[i], tab[i + 1]))
                    {
                        object tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
        }
    }
}
