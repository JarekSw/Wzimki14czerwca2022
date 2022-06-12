using System;
using System.Collections;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PanSpodSklepu panSpodSklepu = new PanSpodSklepu();
            Console.WriteLine(panSpodSklepu.Przywitanie());

            Console.WriteLine("\n IComparable");
            Odcinek a = new Odcinek(3);
            Odcinek b = new Odcinek(2);
            Odcinek c = new Odcinek(7);
            Odcinek d = new Odcinek(8);

            Odcinek[] tab1 = { a, b, c, d };
            Array.Sort(tab1);
            foreach (var item in tab1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n IComparer");
            Słowo słowo1 = new Słowo("a");
            Słowo słowo2 = new Słowo("bb");
            Słowo słowo3 = new Słowo("ccc");
            Słowo słowo4 = new Słowo("dddd");

            Słowo[] tablicaSłów = { słowo2, słowo1, słowo4, słowo3 };

            IComparer comparer = new Słowo();
            Array.Sort(tablicaSłów, comparer);
            foreach (var item in tablicaSłów)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIComparer2");

            Punkt punkt1 = new Punkt(1, 34);
            Punkt punkt2 = new Punkt(4, 3);
            Punkt punkt3 = new Punkt(3, 4);
            Punkt punkt4 = new Punkt(31, 6);

            Punkt[] punkty = {punkt1,punkt2, punkt3, punkt4 };

            IComparer poX = new PorownajPoX();
            Array.Sort(punkty, poX);

            Console.WriteLine("Po X");
            foreach (var item in punkty)
            {
                Console.WriteLine(item);
            }

            IComparer poY = new PorownajPoY();

            Array.Sort(punkty, poY);

            Console.WriteLine("\nPo Y");
            foreach (var item in punkty)
            {
                Console.WriteLine(item);
            }

        }
    }
}
