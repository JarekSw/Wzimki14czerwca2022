using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    delegate void Etapy();
    internal class Ochrona
    {
        public static void OtwarcieDrzwi()
        {
            Console.WriteLine("Otworzono drzwi");
        }
        public static void Kradzież()
        {
            Console.WriteLine("Skradzonio przedmiot");
        }
        public static void Interwencja()
        {
            Console.WriteLine("Obezwładniono");
        }
    }
}
