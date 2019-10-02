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
                            myCar.Model = "Blå";
                        }

                        Console.WriteLine("Vill du ta bort lyxutrustningen?");
                        Console.WriteLine("[1] Nej");
                        Console.WriteLine("[2] Ja");
                        input = Console.ReadLine();

                        if (input == "2")
                        {
                            myCar.Luxury = false;
                        }

                        ListOfCars.Add(myCar);
                        break;

                    // rörmeny
                    case "2":

                        // instans skapas
                        Pipes myPipe = new Pipes();

                        Console.WriteLine("Välj rör:");
                        Console.WriteLine("[1] Stål 9mm");
                        Console.WriteLine("[2] Stål 5.56mm");
                        Console.WriteLine("[3] Plast 9mm");
                        Console.WriteLine("[4] Plast 5.56");
                        Console.WriteLine("[5] Betong 9mm");
                        Console.WriteLine("[6] Betong 5.56mm");
                        Console.WriteLine("[7] Gå tillbaka");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                myPipe.Material = "Stål 9mm";
                                Console.WriteLine("Okej du valde Stål 9mm hur många meter vill du ha?");
                                string meter = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter + " meter Stål 9mm rör ");
                                break;

                            case "2":
                                Console.WriteLine("Okej du valde Stål 5.56mm hur många meter vill du ha?");
                                string meter2 = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter2 + " meter Stål 5.56mm rör ");
                                break;

                            case "3":
                                Console.WriteLine("Okej du valde Plast 9mm hur många meter vill du ha?");
                                string meter3 = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter3 + " meter Plast 9mm rör ");
                                break;

                            case "4":
                                Console.WriteLine("Okej du valde Plast 5.56 hur många meter vill du ha?");
                                string meter4 = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter4 + " meter Plast 5.56mm rör ");
                                break;

                            case "5":
                                Console.WriteLine("Okej du valde Betong 9mm hur många meter vill du ha?");
                                string meter5 = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter5 + " meter Betong 9mm rör ");
                                break;

                            case "6":
                                Console.WriteLine("Okej du valde Betong 5.56mm hur många meter vill du ha?");
                                string meter6 = Console.ReadLine();
                                Console.WriteLine("Okej du beställde " + meter6 + " meter Betong 5.56mm rör ");
                                break;

                            case "7":
                                break;
                        }

                        ListOfPipes.Add(myPipe);

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
