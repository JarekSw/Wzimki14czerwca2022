using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Wezel
    {
        public Object o;
        public Wezel dziecko;
        public Wezel(Object o)
        {
            this.o = o;
        }
        public override string ToString()
        {
            return o.ToString();
        }
    }
    internal class Kolejka
    {
        Wezel glowa=null;

        public void DodajDoKolejki(Object o)
        {
            Wezel wezel = new Wezel(o);
            Wezel tmp = glowa;
            if(glowa==null)
            {
                tmp = wezel;
                return;
            } 
            else
            {
                tmp = tmp.dziecko;
            }
        }
        public Object Zdejmij()
        {
            
            Object o = glowa.o;
            glowa=glowa.dziecko;
            return o;
        }
    }
}
