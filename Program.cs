using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCart = new List<string>();

            Console.WriteLine("Hej och välkommen till Multifabriken AB! \n(nummer + enter)");
            Console.WriteLine("\n[1]Produkter \n[2]Kundvagn \n[3]Avsluta");
            int input = Convert.ToInt32(Console.ReadLine());
            string[] products =  {"Bil", "Godis", "Rör", "Havremjölk"};

            switch(input)
                        {
                        
                        case 1:
                                Console.WriteLine("Vilken produkt vill du lägga till i din kundvagn?");

                                foreach (string thing in products)
                                {
                                    Console.WriteLine(thing);
                                }
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
                        case 2:
                                Console.WriteLine("Kundvagn: ");
                                foreach (var product in myCart)
                                                    {
                                                        Console.WriteLine("\n \t" + product);
                                                    }
                                break;
                        case 3:
                                
                        }    
        }
    }
}
