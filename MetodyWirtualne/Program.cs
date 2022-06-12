using System;

namespace MetodyWirtualne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze=new Zwierze();
            Zwierze pies=new Pies();

            Console.WriteLine(zwierze.DajGlos());
            Console.WriteLine(pies.DajGlos());

        }
    }
}
