using System;
using System.Collections;

namespace Interface
{

    internal class Słowo:IComparer
    {
        public string tekst;
        public Słowo() { }
        public Słowo(string tekst)
        {
            this.tekst = tekst;
        }

        int IComparer.Compare(Object x,Object y)
        {
            Słowo słowo1 = (Słowo)x;
            Słowo słowo2 = (Słowo)y;

            return słowo1.tekst.Length - słowo2.tekst.Length;
        }
        public override string ToString()
        {
            return tekst;
        }
    }
}
