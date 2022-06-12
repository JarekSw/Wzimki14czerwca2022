using System;

namespace Delegaty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etapy etapy = new Etapy(Ochrona.OtwarcieDrzwi);
            etapy += Ochrona.Kradzież;
            etapy += Ochrona.Interwencja;

            etapy();

            Console.WriteLine("\n");
            Sortowanie sortowanie = new Sortowanie();
            string[] tab = { "aasd","bdssssc","se","fes","poldd" };

            sortowanie.tab = tab;
            sortowanie.Sort(MetodySortwoania.PorownajNapisyAlfabetycznie);
            Console.WriteLine("Alfabetycznie:");
            foreach (var item in sortowanie.tab)
            {
                Console.WriteLine(item);
            }
            sortowanie.Sort(MetodySortwoania.PorownajNapisyPoDlugosci);
            Console.WriteLine("\nWedług dłougości:");
            foreach (var item in sortowanie.tab)
            {
                Console.WriteLine(item);
            }
        }
    }
}
