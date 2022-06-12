using System;

namespace Klasy_abstrakcyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figury kwadrat = new Kwadrat(3);
            Console.WriteLine(kwadrat.Pole());
        }
    }
}
