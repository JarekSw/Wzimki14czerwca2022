using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyWirtualne
{
    public class Zwierze
    {
        public virtual string DajGlos()
        {
            return "Glos zwierzecia";
        }
    }
    public class Pies:Zwierze
    {
        public override string DajGlos()
        {
            return base.DajGlos()+": szczekam";
        }
    }

    class Ryba:Zwierze
    {
        public sealed override string DajGlos()
        {
            return "ryby głosu nie mają";
        }
    }

    class Dorsz:Ryba
    {
        //public override string DajGlos()
        //{
        //    return "Hej jestem rybą";
        //}
    }

    
}
