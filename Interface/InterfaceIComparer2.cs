using System;
using System.Collections;

namespace Interface
{
    internal class Punkt
    {
        public int x;
        public int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return x+" "+y; 
        }
    }
    public class PorownajPoX : IComparer
    {
        public int Compare(object z, object t)
        {
            Punkt a= (Punkt)z;
            Punkt b= (Punkt)t;

            if (a.x > b.x)
                return 1;
            if (a.x < b.x)
                return -1;
            return 0;
        }
    }
    public class PorownajPoY : IComparer
    {
        public int Compare(object z, object t)
        {
            Punkt a = (Punkt)z;
            Punkt b = (Punkt)t;

            if (a.y > b.y)
                return 1;
            if (a.y < b.y)
                return -1;
            return 0;
        }
    }
}
