using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runMenu = true;
            List<object> orderList  = new List<object>();

            while (runMenu)
            {

                System.Console.WriteLine("[1] Skapa beställning:");
                System.Console.WriteLine("[2] Ändra beställning:");
                System.Console.WriteLine("[3] Skicka offert.");
                System.Console.WriteLine("[4] Avsluta.");
                System.Console.Write("Välj: ");

                string meny = Console.ReadLine();
                string menyProducts = "";

                switch (meny)
                {
                    
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("[1] Bil");
                        System.Console.WriteLine("[2] Godis");
                        System.Console.WriteLine("[3] Rör");
                        System.Console.WriteLine("[4] Havremjölk");
                        System.Console.Write("Välj produkt: ");

                        menyProducts = Console.ReadLine();
                        switch (menyProducts)
                        {
                            case "1":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa bil metod**");
                                orderList.Add(MenuOptionCars());
                                break;

                            case "2":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa godis metod**");
                                orderList.Add(MenuOptionCandy());
                                break;

                            case "3":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa rör metod**");
                                orderList.Add(MenuOptionPipes());
                                break;

                            case "4":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa havre metod");
                                orderList.Add(MenuOptionOatmeal());
                                break;
                        }
                        break;


                    case "2":
                        Console.Clear();
                        System.Console.Write("Ta bort produkt: ");
                        menyProducts = Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        System.Console.WriteLine("Tryck på valfri tangent för att skicka offert...");
                        Console.ReadKey();
                        System.Console.WriteLine("Offert inskickad.");
                        break;

                    case "4":
                        runMenu = false;
                        Console.Clear();
                        foreach (Car car in orderList) 
                        {
                            Console.WriteLine(car.TypeCar);
                            Console.WriteLine(car.ColorCar);
                            Console.WriteLine(car.InteriorCar);
                        }
                        Console.ReadLine();
                        System.Console.WriteLine("Program avslutat");
                        return;
                }


                Car MenuOptionCars()
                {
                    {
                        string Type = "";
                        string Color = "";
                        bool interior = false;

                        Console.WriteLine("Ange vilken typ av bil: ");
                        Type = Console.ReadLine();
                        Console.WriteLine("Ange vilken färg du vil ha på bilen: ");
                        Color = Console.ReadLine();
                        Console.WriteLine("Vill du ha [S]tandard inredning eller [L]yx-inredning?");
                        string inputInterior = Console.ReadLine();

                        if (inputInterior == "S")
                        {
                            interior = false;
                        }
                        else if (inputInterior == "L")
                        {
                            interior = true;
                        }


                        Car car = new Car(Type, Color, interior);
                        return car;
                    }

                }

                Candy MenuOptionCandy()
                {
                    {
                        string Type = "";
                        int Weight = 0;

                        Console.WriteLine("Ange vilken typ av godis: ");
                        Type = Console.ReadLine();
                        Console.WriteLine("Ange vilken färg du vil ha på bilen: ");
                        Weight = Convert.ToInt32(Console.ReadLine());

                        Candy candy = new Candy(Type, Weight);
                        return candy;
                    }

                }

                Pipe MenuOptionPipes()
                {
                    string material;
                    int length;
                    int diameter;

                    Console.WriteLine("Välj material");
                    material = Console.ReadLine();
                    Console.WriteLine("Välj längd");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Välj diMTER");
                    diameter = Convert.ToInt32(Console.ReadLine());

                    Pipe pipe = new Pipe(material, length, diameter);
                    return pipe;
                }

                Oatmeal MenuOptionOatmeal()
                {
                    int fat;
                    int amount;

                    Console.WriteLine("Välj Fett");
                    fat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Välj mängd");
                    amount = Convert.ToInt32(Console.ReadLine());

                    Oatmeal oatmeal = new Oatmeal(fat, amount);
                    return oatmeal;
                }
            }
        }
    }
}
