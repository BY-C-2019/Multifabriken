using System;

namespace Multifabriken
{
    class Program
    {
        static string godisMeny(){
            Console.WriteLine("");
            string choise = Console.ReadLine();
            return choise;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till multifabriken!");
            while (true)
            {
                Console.WriteLine("Vad vill du beställa?");
                Console.WriteLine("1. Godis");
                Console.WriteLine("2. Havremjölk");
                Console.WriteLine("3. Rör");
                Console.WriteLine("4. Bilar");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1"://Godis
                        godisMeny();
                        break;
                    case "2"://Havremjölk

                        break;
                    case "3"://Rör

                        break;
                    case "4"://Bilar

                        break;
                    case "5"://Skriv ut beställning

                        break;//Avsluta programmet
                    case "6":

                        return;
                    default:
                        Console.WriteLine("Skriv ditt val endast med siffervärde");
                        break;
                }
            }
        }
    }
}
