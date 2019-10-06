using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meny variabler
            string[]        menuOptions = { "Lägg till produkter", "Visa/ändra kundvagn", "Avsluta programmet" };

            List<string>    myCart = new List<string>();
            string[]        currentProducts =  {"Bil", "Godis", "Rör", "Havremjölk", "Tillbaka"};

            // Program loop
            while (true) 
            {
                // Skriv ut meny och alternativ
                Console.Clear();
                Console.WriteLine("Hej och välkommen till Multifabriken AB!");
                Console.WriteLine("----------------------------------------");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    // i+1 för enklare användar presentation
                    Console.WriteLine("[{0}] {1}", i+1, menuOptions[i]);
                }

                Console.Write(": ");
                string input = Console.ReadLine();

                // Om någon inmatnings gjorts
                if (input != "")
                {
                    switch(input[0])
                    {
                        // Lista tillgängliga produktval för användaren att välja
                        case '1':
                        Console.Clear();
                        MenuOption_AddToCart(myCart, currentProducts);
                        break;
                    
                        // Lista/modifiera kundvagn
                        case '2':
                        Console.Clear();
                        MenuOption_ShowCart(myCart);
                        break;
                        
                        // Avsluta programmet med att skriva ut kundvagn
                        case '3':
                        Console.Clear();
                        Console.WriteLine("Din kundvagn vid avslut:");
                        Console.WriteLine("-------------------------------------");
                        PrintProductsInCart(myCart, false);
                        Console.WriteLine("-------------------------------------");
                        
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
        }

        // Om ingen variabel skickas in till metoden för variabeln 'i', sätt i = 0
        static void PrintProductsInCart(List<string> cartToPrint, bool useIndex, int printedIndex = 0)
        {
            // Om kundvagnen är tom, skriv ut meddelande och gå tillbaka till menyn
            if (cartToPrint.Count == 0) {
                Console.WriteLine("Din kundvagn är tom.");
                return;
            }

            // Om kundvagnen ska printas med indexering
            if (useIndex == true)
            {
                for (int i = 0; i < cartToPrint.Count; i++) {
                    Console.WriteLine("[{0}] - {1}", i+printedIndex, cartToPrint[i]);
                }
            }
            // Om endast kundvagnen ska printas ut
            else if (useIndex == false) 
            {
                foreach (var product in cartToPrint) {
                    Console.WriteLine(" - " + product);
                }
            }
        }

        static void MenuOption_AddToCart(List<string> cartToAddProduct, string[] productList)
        {
            Console.WriteLine("Vilken produkt vill du lägga till i din kundvagn?");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine("[{0}] {1}", i+1, productList[i]);
            }
            

            while (true) 
            {
                Console.Write(": ");
                string productInput = Console.ReadLine();
    
                if (productInput != "") 
                {
                    switch(productInput[0])
                    {
                        // Köp bil
                        case '1':
                        Console.Clear();
                        Car myCar = new Car();

                        if (myCar.BuyMenu() == true) {
                            myCar.AddToCart(cartToAddProduct);
                        }

                        return;

                        // Köp godis
                        case '2':
                        Console.Clear();
                        Candy myCandy = new Candy();
                        myCandy.CandyMenu();
                        myCandy.AddToCart(cartToAddProduct);
                        return;

                        // Köp rör
                        case '3':
                        Console.Clear();
                        Pipe myPipe = new Pipe();
                        
                        if (myPipe.OrderPipe() == true) {
                            myPipe.AddToCart(cartToAddProduct);
                        }
                        return;

                        // Köp havremjölk
                        case '4':
                        Console.Clear();
                        Oatmilk myOatmilk = new Oatmilk();

                        if (myOatmilk.OatOrder() == true) {
                            myOatmilk.AddToCart(cartToAddProduct);
                        }
                        return;

                        case '5':
                        return;

                        default:
                        Console.WriteLine("Felinmatning...");
                        break;
                    }
                }
            }
        }
                    
        static void MenuOption_ShowCart(List<string> cart)
        {
            string[] cartMenuOptions = {"Ta bort produktrad", "Tillbaka"};

            Console.WriteLine("Din nuvarande kundvagn: ");
            Console.WriteLine("------------------------");
            PrintProductsInCart(cart, false);
            Console.WriteLine("------------------------\n");
            
            for (int i = 0; i < cartMenuOptions.Length; i++) {
                Console.WriteLine("[{0}] {1}", i+1, cartMenuOptions[i]);
            }
            
            while (true) 
            {
                Console.Write(": ");
                string cartMenuInput = Console.ReadLine();

                if (cartMenuInput != "")
                {
                    switch (cartMenuInput[0])
                    {
                        // Ta bort produkt
                        case '1':

                        // Om listan är tom, återgå till huvudmenyn
                        if (cart.Count == 0) {
                            Console.WriteLine("Du har inget att ta bort...");
                            return;
                        }

                        Console.Clear();
                        Console.WriteLine("Vilken produkt vill du ta bort?");
                        Console.WriteLine("-------------------------------");
                        PrintProductsInCart(cart, true, 1);
                        while (true) {
                            try {
                                // Läs in och ta bort 1 för att kompensera för att användarvänligheten (+1)
                                Console.Write(": ");
                                int productToRemove = Convert.ToInt32(Console.ReadLine()) - 1;
                                
                                // Om index är innanför kundvagnens storlek, ta bort produkt
                                if (productToRemove >= 0 && productToRemove < cart.Count) {
                                    Console.Clear();
                                    Console.WriteLine("Raderat: " + cart[productToRemove]);
                                    cart.RemoveAt(productToRemove);
                                    
                                    Console.WriteLine("Tryck på valfri tangent för att återgå till menyn.");
                                    Console.Write(": ");
                                    Console.ReadLine();
                                    return;
                                }
                                else {
                                    throw new Exception();
                                }
                                
                            }
                            catch {
                                Console.WriteLine("Det finns inget att ta bort på detta indexet...");
                            }
                        }
                        
                        // Tillbaka till menyn
                        case '2':
                        return;

                        default:
                        break;
                    }
                }
            }
        }
    }
}
