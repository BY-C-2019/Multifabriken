using System;

namespace Multifabriken
{
    class Program
    {

        // Egen programfil för att kunna leka med menyn utan att påverka den riktiga programfilen. 
        // Använda denna för att köra ändringarna jag har gjort.
        static void Main(string[] args)
        {
            while (true)
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
                                Methods.MenuOptionCars();
                                break;

                            case "2":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa godis metod**");
                                Methods.MenuOptionCandy();
                                break;

                            case "3":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa rör metod**");
                                Methods.MenuOptionPipes();
                                break;

                            case "4":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa havre metod");
                                Methods.MenuOptionOatmeal();
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
                        Console.Clear();
                        System.Console.WriteLine("Program avslutat");
                        return;
                }

               
                
            }
        }
    }
}
