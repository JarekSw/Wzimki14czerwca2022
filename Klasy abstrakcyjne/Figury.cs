using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_abstrakcyjne
{
    public abstract class Figury
    {
        public abstract Double Pole();
    }
    public class Kwadrat:Figury
    {
        int bok;
        public Kwadrat(int bok)
        {
            this.bok = bok;
        }
        public override double Pole()
        {
            return bok * bok;
        }
    }
}
