using System;

namespace Multifabriken
{
    class Print
    {
        public static void PrintStuff()
        {
            Console.WriteLine("Inköpslistan innehåller följande:");
            Console.WriteLine("");
            foreach (var item in Program.ListOfCars)
            {
                Console.WriteLine("Bilmodell: " + item.Model);
                Console.WriteLine("Färg: " + item.Color);
                if (item.Luxury == true)
                {
                    Console.WriteLine("med lyxutrustning");
                }
                Console.WriteLine("");

            }
            foreach (var item in Program.ListOfGodis)
            {
                Console.WriteLine("Godispåse");
                Console.WriteLine("Vikt: " + item.Vikt);
                Console.WriteLine("Smak: " + item.Smak);
                Console.WriteLine("");
            }

            foreach (var item in Program.ListOfPipes)
            {
                Console.WriteLine("Rör");
                Console.WriteLine("Material: " + item.Material);
                Console.WriteLine("Längd: " + item.Längd);
                Console.WriteLine("Diameter: " + item.Diameter);
                Console.WriteLine("");
            }

            foreach (var item in Program.ListOfMilk)
            {
                Console.WriteLine("Havremjölk");
                Console.WriteLine("Mängd: " + item.Volume);
                Console.WriteLine("Fetthalt: " + item.Fat);
                Console.WriteLine("");
            }
        }
    }
}