using System;

namespace Multifabriken
{
    class Print
    {
        public static void PrintStuff()
        {
            foreach (var item in Program.ListOfCars)
            {
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.Luxury);
            }
            foreach (var item in Program.ListOfGodis)
            {
                Console.WriteLine(item.Vikt);
                Console.WriteLine(item.Smak);
            }
            foreach (var item in Program.ListOfPipes)
            {
                Console.WriteLine(item.Material);
                Console.WriteLine(item.Längd);
                Console.WriteLine(item.Diameter);
            }
            foreach (var item in Program.ListOfMilk)
            {
                Console.WriteLine(item.Volume);
                Console.WriteLine(item.Fat);
            }
        }
    }
}