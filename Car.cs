using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Car
    {
        // Tillgängliga val
        string[] availableCarModels = {"Volvo", "Toyota", "Ferrari"};
        string[] availableCarColors = {"Svart", "Vit", "Silver", "Röd"};
        string[] availableLuxuryOption = {"Ja", "Nej"};

        // Beställ ny bil variabler
        int     quantity    = 0;
        string  carModel    = "";
        string  carColor    = "";
        string  luxaryModel = "";

        public bool BuyMenu()
        {
            // Välj följande egenskaper för bil
            ChooseCarOption("modell", ref carModel, availableCarModels);
            ChooseCarOption("färg", ref carColor, availableCarColors);
            ChooseCarOption("lyxmodell", ref luxaryModel, availableLuxuryOption);

            // Kontrollera att man vill lägga till beställning
            Console.WriteLine("Är du nöjd med följade spec på bil?");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  {0} : [Färg] {1} : [Lyxmodell] {2}", carModel, carColor, luxaryModel);
            Console.WriteLine("------------------------------------");

            while (true) 
            {
                Console.Write("JA/NEJ: ");
                string input = Console.ReadLine().ToUpper();
                if (input != "")
                {
                    // Om man vill lägga beställning
                    if (input[0] == 'J')
                    {
                        // Välj hur många man vill beställa
                        Console.WriteLine("Hur många vill du köpa?");
                        while (true) 
                        {
                            // Försök konvertera inmatning och spara till quantity. Fortsätt försöka tills det lyckas.
                            Console.Write(" : ");
                            try {
                                quantity = Convert.ToInt32(Console.ReadLine());
                                return true;
                            }
                            catch {
                            }
                        }
                    }
                    // Om man inte vill lägga beställning, återgå till meny
                    else if (input[0] == 'N')
                    {
                        Console.WriteLine("Återgår till start...");
                        return false;
                    }
                }
            }
        }

        void ChooseCarOption(string valAv, ref string option, string[] availableOptions )
        {
            // Lista val
            Console.WriteLine("Val av {0}:", valAv);
            
            for (int i = 0; i < availableOptions.Length; i++)
            {
                Console.WriteLine("[{0}] {1}", i+1, availableOptions[i]);
            }

            while (true) 
            {
                try {
                    // Försök konvertera indata till int. Om det misslyckas försök igen
                    int input = Convert.ToInt32(Console.ReadLine()) -1;

                    // Om indatan är utanför arrayens index, kasta fel och försök igen
                    if (input < 0 || input >= availableOptions.Length) {
                        throw new Exception();
                    }

                    // Tilldela önskad modell från availablemodels
                    option = availableOptions[input];
                    Console.Clear();
                    Console.WriteLine("Du valde: {0}\n", option);
                    return;
                }
                catch {
                    Console.WriteLine("Värde ej accepterat");
                }
            }
        }

        public void AddToCart(List<string> listToAddProduct)
        {
            listToAddProduct.Add(quantity + "st " + carModel + " : [Färg] "+ carColor + " : [Lyxmodell] " + luxaryModel);
        }
    }
}
