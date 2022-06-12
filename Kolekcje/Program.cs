using System;
using System.Collections;

namespace Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("jeden");
            queue.Enqueue("dwa");
            queue.Enqueue("trzy");
            queue.Enqueue("cztery");

            Console.WriteLine("Kolejka: ");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            

            Stack stack = new Stack();
            stack.Push("jeden");
            stack.Push("dwa");
            stack.Push("trzy");
            stack.Push("cztery");

            Console.WriteLine("\nStos: ");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Kolejka kolejka = new Kolejka();
            kolejka.DodajDoKolejki("pierwszy");
            kolejka.DodajDoKolejki("drugi");
            kolejka.DodajDoKolejki("trzeci");
            kolejka.DodajDoKolejki("czwarty");

            Console.WriteLine("\nKolejka zaimplemetnowana");
            Console.WriteLine(kolejka.Zdejmij());
            Console.WriteLine(kolejka.Zdejmij());
            Console.WriteLine(kolejka.Zdejmij());
            Console.WriteLine(kolejka.Zdejmij());
           
        }
    }
}
