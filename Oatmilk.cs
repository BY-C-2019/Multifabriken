using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Oatmilk
    {
        static int fatRate;
        static double volume;
        static void ChooseFat()
        {
            int minFat = 2; // Minsta möjliga % på fetthalt
            int maxFat = 11; // Högsta möjliga % på fetthalt
            bool fatRateOk = false;
            while (fatRateOk == false)
            {
                Console.WriteLine("Vilken fetthalt skulle du vilja ha?");
                Console.Write("Välj mellan {0} och {1}: ",minFat, maxFat);
                try
                {
                    fatRate = Convert.ToInt32(Console.ReadLine());
                    if (fatRate < minFat || fatRate > maxFat) // Om inmatningen är under eller över det tilllåtna
                    {
                        Console.WriteLine("Felaktig fetthalt!");
                    }
                    else
                    {
                        fatRateOk = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktigt inmatning!");
                }
            }       
        }
        static void ChooseVolume()
        {
            double minVol = 0.5; // Minsta möjliga volym
            bool volumeOk = false;
            while (volumeOk == false)
            {
                Console.WriteLine("Hur många liter vill ni ha: ");
                try
                {
                    volume = Convert.ToDouble(Console.ReadLine());
                    if (volume < minVol) // Om volymen är mindre än minsta tilllåtna
                    {
                    Console.Write("Tyvärr säljer vi inte så små volymer. Minsta möjliga volym är {0} liter", minVol);
                    }
                    else
                    {
                        volumeOk = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktig inmatning");
                }
            }
        }
        public bool OatOrder()
        {
            ChooseFat();
            ChooseVolume();
            Console.WriteLine("Du valde {0}% fetthalt och {1} liter.", fatRate, volume);
            Console.WriteLine("Är du säker på dina val? J/N");
            string input = Console.ReadLine().ToUpper();
            if (input == "J")
            {
                return true;         
            }
            else
            {
                return false;
            }
            
        }
        public void AddToCart(List<string> listToAddProduct)
        {
            listToAddProduct.Add("Havremjölk. fetthalt: " + fatRate + "% antal liter: " + volume);
        }
    }
}
