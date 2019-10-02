using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            List<Godis> myGodises = new List<Godis>();
            List<Pipes> myPipes = new List<Pipes>();
            List<Oatmilk> myMilks = new List<Oatmilk>();

            while (true)
            {
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("[1] Köp bil");
                Console.WriteLine("[2] Köp Rör");
                Console.WriteLine("[3] Köp godis");
                Console.WriteLine("[4] Köp havremjölk");
                Console.WriteLine("[5] Skriv ut inköpslista");
                Console.WriteLine("[6] Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Car myCar = new Car();

                        Console.WriteLine("Välj modell:");
                        Console.WriteLine("[1] 240");
                        Console.WriteLine("[2] 740");
                        Console.WriteLine("[3] 940");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myCar.Model = "240";
                        }
                        else if (input == "2")
                        {
                            myCar.Model = "740";
                        }
                        else
                        {
                            myCar.Model = "940";
                        }

                        Console.WriteLine("Välj färg:");
                        Console.WriteLine("[1] Röd");
                        Console.WriteLine("[2] Grön");
                        Console.WriteLine("[3] Blå");
                        input = Console.ReadLine();

                        myCar.Color = Console.ReadLine();

                        Console.WriteLine("Välj färg:");
                        Console.WriteLine("[1] Röd");

                        myCars.Add(myCar);
                        break;


                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;
                }
            }
        }
    }
}
