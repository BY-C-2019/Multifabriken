using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meny variabler
            string[]        menuOptions = { "Produkter", "Kundvagn", "Avsluta" };

            List<string>    myCart = new List<string>();
            string[]        currentProducts =  {"Bil", "Godis", "Rör", "Havremjölk"};

            // Program loop
            while (true) 
            {
                // Skriv ut meny och alternativ
                Console.WriteLine("Hej och välkommen till Multifabriken AB!");
                Console.WriteLine("----------------------------------------");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine("[{0}] {1}", i+1, menuOptions[i]);
                }
                string input = Console.ReadLine();

                switch(input[0])
                {
                    case '1':
                    // Lista tillgängliga produktval för användaren att välja
                    Console.WriteLine("Vilken produkt vill du lägga till i din kundvagn?");
                    foreach (string product in currentProducts)
                    {
                        Console.WriteLine(product);
                    }
                    // Läs in användarens val och välj produkt
                    int input2 = Convert.ToInt32(Console.ReadLine());

                        switch(input2)
                        {
                            //tillfälligt för test
                            case 1:
                                Candy myCandy = new Candy();
                                myCandy.CandyMenu();
                                myCandy.AddToCart(myCart);
                                
                                    foreach (var product in myCart)
                                        {
                                            Console.WriteLine(product);
                                        }
                                break;
                    }
                    break;
                
                    // Lista kundvagn
                    case '2':
                    Console.WriteLine("Din nuvarande kundvagn: ");
                    PrintProductsInCart(myCart);
                    break;
                    
                    // Avsluta programmet
                    case '3':
                    Console.WriteLine("Du hann inte checka ut din kundvagn:");
                    // Skriv ut kundvagnen
                    PrintProductsInCart(myCart);
                    
                    // Avsluta programmet med return
                    Console.WriteLine("Programmet avslutas...");
                    return;

                    // Felinmatningar
                    default:
                    Console.WriteLine("Felinmatning...");
                    break;
                }
            }
        }

        static void PrintProductsInCart(List<string> cartToPrint)
        {
            foreach (var product in cartToPrint)
            {
                Console.WriteLine("\n \t" + product);
            }
        }
    }
}
