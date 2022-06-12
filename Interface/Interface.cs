using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IPrzywitanie
    {
        public string Przywitanie();
    }
    public class PanSpodSklepu:IPrzywitanie
    {
        public string Przywitanie()
        {
            return "Kierowniku!";
        }
    }
}
