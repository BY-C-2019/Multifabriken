using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa listor
            List<Car> ListOfCars = new List<Car>();
            List<Godis> ListOfGodis = new List<Godis>();
            List<Pipes> ListOfPipes = new List<Pipes>();
            List<Oatmilk> ListOfMilk = new List<Oatmilk>();

            // huvudmeny
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
                    // bilmeny
                    case "1":
                        // instans skapas
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

                        if (input == "1")
                        {
                            myCar.Color = "Röd";
                        }
                        else if (input == "2")
                        {
                            myCar.Color = "Grön";
                        }
                        else
                        {
                            myCar.Color = "Blå";
                        }
                        break;

                    // rörmeny
                    case "2":

                        // instans skapas
                        Pipes myPipes = new Pipes();

                        Console.WriteLine("Välj material:");
                        Console.WriteLine("[1] Stål");
                        Console.WriteLine("[2] Plast");
                        Console.WriteLine("[3] Betong");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myPipes.Material = "Stål";
                        }
                        else if (input == "2")
                        {
                            myPipes.Material = "Plast";
                        }
                        else
                        {
                            myPipes.Material = "Betong";
                        }

                        Console.WriteLine("Välj Diameter:");
                        Console.WriteLine("[1] 9mm");
                        Console.WriteLine("[2] 5.56");
                        Console.WriteLine("[3] 30mm");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myPipes.Diameter = "9mm";
                        }
                        else if (input == "2")
                        {
                            myPipes.Diameter = "5.56mm";
                        }
                        else
                        {
                            myPipes.Diameter = "30mm";
                        }

                        Console.WriteLine("Hur många meter vill du ha?");
                        Console.WriteLine("[1] 15m");
                        Console.WriteLine("[2] 1m");
                        Console.WriteLine("[3] 100m");
                        input = Console.ReadLine();
                       
                        if (input == "1")
                        {
                            myPipes.Längd = "15m";
                        }
                        else if (input == "2")
                        {
                            myPipes.Längd = "1m";
                        }
                        else
                        {
                            myPipes.Längd = "100m";
                        }

                        ListOfPipes.Add(myPipes);

                        foreach (var item in ListOfPipes)
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case "3":
                        break;
                    // mjölkmeny
                    case "4":
                        // instans skapas
                        Oatmilk myMilk = new Oatmilk();

                        Console.WriteLine("Välj mängd:");
                        Console.WriteLine("[1] 0,5 liter");
                        Console.WriteLine("[2] 1 liter");
                        Console.WriteLine("[3] 2 liter");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myMilk.Volume = "0,5 liter";
                        }
                        else if (input == "2")
                        {
                            myMilk.Volume = "1 liter";
                        }
                        else
                        {
                            myMilk.Volume = "2 liter";
                        }

                        Console.WriteLine("Välj fetthalt:");
                        Console.WriteLine("[1] 0,5%");
                        Console.WriteLine("[2] 1,5%");
                        Console.WriteLine("[3] 3%");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            myMilk.Fat = "0,5%";
                        }
                        else if (input == "2")
                        {
                            myMilk.Fat = "1,5%";
                        }
                        else
                        {
                            myMilk.Fat = "3%";
                        }

                        ListOfMilk.Add(myMilk);

                        break;
                        
                    // skriv ut listorna
                    case "5":
                        Console.WriteLine("Inköpslistan:");
                        Console.WriteLine("");

                        foreach (var item in ListOfCars)
                        {
                            Console.WriteLine(item.Model);
                            Console.WriteLine(item.Color);
                            Console.WriteLine(item.Luxury);
                            Console.WriteLine("");
                        }

                        foreach (var item in ListOfPipes)
                        {
                            Console.WriteLine(item.Material);
                            Console.WriteLine(item.Diameter);
                            Console.WriteLine(item.Längd);
                            Console.WriteLine("");
                        }

                        foreach (var item in ListOfGodis)
                        {
                            Console.WriteLine(item.Smak);
                            Console.WriteLine(item.Vikt);
                            Console.WriteLine("");
                        }

                        foreach (var item in ListOfMilk)
                        {
                            Console.WriteLine(item.Volume);
                            Console.WriteLine(item.Fat);
                            Console.WriteLine("");
                        }

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