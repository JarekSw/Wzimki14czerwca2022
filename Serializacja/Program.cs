using System;

namespace Serializacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Adam", "Nowak", 32424324, 5300);
            Console.WriteLine(o1);
            Osoba.Serializacja(o1, "osoba1.dat");

            Osoba o2 = Osoba.DeSerializacja("osoba1.dat");
            Console.WriteLine(o2);
        }
    }
}
