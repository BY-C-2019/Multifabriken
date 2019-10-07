using System;

namespace Multifabriken
{
    public class Bil
    {
        private int choiceModell = 0;
        private int choiceFärg = 0;
        private int choiceInredning = 0;
        string ValAvModell;
        string ValAvFärg;
        string ValAvInredning;
        string BilTillKvitto;
        
        public void ValAvBil()
       {
            Kvitto kvitto = new Kvitto();
            Produkter bil = new Produkter();
            
            Console.Clear();
            Console.WriteLine("Här kan du göra beställning av en bil.");
            Console.WriteLine("Du kommer få välja modell, färg och inrednign.");
            Console.WriteLine("Välj av följande modeller:");
            Console.WriteLine("[1] Volvo");
            Console.WriteLine("[2] SAAB");
            Console.WriteLine("[3] BMW");
            choiceModell = int.Parse(Console.ReadLine());
            
            switch (choiceModell)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde en Volvo");
                ValAvModell = "Modell: Volvo."; 
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde en SAAB");
                ValAvModell = "Modell: SAAB.";
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde en BMW");
                ValAvModell = "Modell: BMW.";
                break;
                
                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }

            Console.WriteLine("Välj av följande färger:");
            Console.WriteLine("[1] Röd");
            Console.WriteLine("[2] Blå");
            Console.WriteLine("[3] Grön");
            choiceFärg = int.Parse(Console.ReadLine());
            
            switch (choiceFärg)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde röd färg"); 
                ValAvFärg = "Färg: Röd.";
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde blå färg");
                ValAvFärg = "Färg: Blå.";
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde en grön färg");
                ValAvFärg = "Färg: Grön.";
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }
            Console.WriteLine("Välj av följande inredningspaket:");
            Console.WriteLine("[1] Lyx");
            Console.WriteLine("[2] Mellan");
            Console.WriteLine("[3] Budget");
            Console.WriteLine("[4] Återgå till beställningsmenyn.");
            choiceInredning = int.Parse(Console.ReadLine());
            
            switch (choiceInredning)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde Lyxpaketet");
                ValAvInredning = "Inredning: Lyxpaket.";
                BilTillKvitto = ValAvModell + " " + ValAvFärg + " " + ValAvInredning;
                kvitto.Reciept(BilTillKvitto);
                bil.Order();
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde Mellanpaketet");
                ValAvInredning = "Inredning: Mellanpaketet.";
                BilTillKvitto = ValAvModell + " " + ValAvFärg + " " + ValAvInredning;
                kvitto.Reciept(BilTillKvitto);
                bil.Order();
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde Budgetpaketet");
                ValAvInredning = "Inredning: Budgetpaketet.";
                BilTillKvitto = ValAvModell + " " + ValAvFärg + " " + ValAvInredning;
                kvitto.Reciept(BilTillKvitto);
                bil.Order();
                break;
                
                case 4:
                Console.Clear();
                Console.WriteLine("Återgå till beställningsmenyn.");
                break;
                
                case 5:
                Console.Clear();
                Console.WriteLine("Återgår till huvudmenyn.");
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }
        }
    }
}