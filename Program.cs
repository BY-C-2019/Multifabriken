using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        // skapa listor och variabler som ska kunna nås överallt
        public static List<Car> ListOfCars = new List<Car>();
        public static List<Godis> ListOfGodis = new List<Godis>();
        public static List<Pipes> ListOfPipes = new List<Pipes>();
        public static List<Oatmilk> ListOfMilk = new List<Oatmilk>();
        static string input;
        static void Main(string[] args)
        {
            // huvudmeny
            while (true)
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("");
                Console.WriteLine("[1] Köp bil");
                Console.WriteLine("[2] Köp rör");
                Console.WriteLine("[3] Köp godis");
                Console.WriteLine("[4] Köp havremjölk");
                Console.WriteLine("[5] Skriv ut inköpslista");
                Console.WriteLine("[6] Avsluta");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // skapa instans
                        Car myCar = new Car();
                        // kör metod
                        Car.AddCar();
                        // lägg till i listan
                        ListOfCars.Add(myCar);
                        break;

                    case "2":
                        // skapa instans
                        Pipes mypipes = new Pipes();
                        // kör metod
                        Pipes.AddPipe();
                        // lägg till i listan
                        ListOfPipes.Add(mypipes);
                        break;

                    case "3":
                        // skapa instans
                        // Oatmilk myMilk = new Oatmilk();
                        // kör metod
                        // Oatmilk.AddMilk();
                        // lägg till i listan
                        // ListOfMilk.Add(myMilk);
                        // break;

                    case "4":
                        // skapa instans
                        Oatmilk myMilk = new Oatmilk();
                        // kör metod
                        Oatmilk.AddMilk();
                        // lägg till i listan
                        ListOfMilk.Add(myMilk);
                        break;

                    // skriv ut listorna
                    case "5":
                        Print.PrintStuff();
                        break;

                    // avsluta
                    case "6":
                        Console.WriteLine("Hej då!");
                        Print.PrintStuff();
                        return;

                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;
                }
            }
        }
    }
}