using System;

namespace Multifabriken
{
    class Program
    {

        //Metod för att välja modell på bilen
        static string carModel()
        {
            Console.WriteLine("Vilken bilmodell vill du ha?");
            Console.WriteLine("1. Volvo");
            Console.WriteLine("2. Saab");
            Console.WriteLine("3. Ford");
            string modelChoise = Console.ReadLine(); //try catch
            return modelChoise;
        }

        //Metod för att välja färg på bilen 
        static string carColor()
        {
            Console.WriteLine("Vilken färg ska bilen ha? Mata in dinfärgkod: ");
            string colorChoise = Console.ReadLine();
            return colorChoise;
        }

        static string carInterior()
        {
            Console.WriteLine("Välj din inredning:");
            Console.WriteLine("1. Lyx");
            Console.WriteLine("2. Standard");
            string interiorChoise = Console.ReadLine();
            
            return interiorChoise;
        }

        static string godisMeny(){
            Console.WriteLine("Vilken typ av godis vill du ha?");
            Console.WriteLine("1. Hallon");
            Console.WriteLine("2. Lakris");
            Console.WriteLine("3. Jordgubb");
            Console.WriteLine("4. Päron");
            string flavourChoise = Console.ReadLine();//try catch / switch?
            return flavourChoise;
        }
        static int mangd(){
            Console.WriteLine("Hur mycket?");
            // int ammount = convert;
            return 1;
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
                        mangd();
                        break;
                    case "2"://Havremjölk

                        break;
                    case "3"://Rör

                        break;
                    case "4"://Bilar
                        carModel();
                        carColor();
                        carInterior();
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

