using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Beställning beställning = new Beställning();

            Console.Clear();
            Console.WriteLine("Välkommen till Multifabriken, ta en titt på vår meny:\n");
            System.Console.WriteLine("[1] Beställa produkter");
            System.Console.WriteLine("[2] Se beställda produkter");
            System.Console.WriteLine("[3] Avsluta");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1: 
                Console.Clear();
                beställning.Order();
                // Beställa produkter
                break;

                case 2: 
                //Historik
                break;

                case 3: 
                return;

                default:

                System.Console.WriteLine("Felaktig inmatning.");

                break;

            }

        }
    }
}
