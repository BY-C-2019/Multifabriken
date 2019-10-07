using System;

namespace Multifabriken
{
    public class Bil
    {
        private int choiceModell = 0;
        private int choiceFärg = 0;
        private int choiceInredning = 0;
        
        public Bil()
        {
            Console.WriteLine("Här kan du göra beställning av en bil.");
            Console.WriteLine("Du kommer få välja modell, färg och inrednign.");
        }
        public void ValAvBil()
       {
            Console.WriteLine("Välj av följande modeller:");
            Console.WriteLine("[1] Volvo");
            Console.WriteLine("[2] SAAB");
            Console.WriteLine("[3] BMW");
            Console.WriteLine("[4] Gå tillbaka till huvudmenyn");
            choiceModell = int.Parse(Console.ReadLine());
            // choiceToCustomerModell = int.Parse(Console.ReadLine());
            switch (choiceModell)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde en Volvo"); 
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde en SAAB");
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde en BMW");
                break;
                
                case 4:
                Console.Clear();
                break;
                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }
       
                        
            Console.WriteLine("Välj av följande färger:");
            Console.WriteLine("[1] Röd");
            Console.WriteLine("[2] Blå");
            Console.WriteLine("[3] Grön");
            Console.WriteLine("[4] Byt modell");
            Console.WriteLine("[5] Gå tillbaka till huvudmenyn");
            choiceFärg = int.Parse(Console.ReadLine());
            // choiceToCustomerModell = int.Parse(Console.ReadLine());
            switch (choiceFärg)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde röd färg"); 
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde en blå färg");
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde en grön färg");
                break;
                
                case 4:
                Console.Clear();
                Console.WriteLine("Du valde att byta modell");
                break;
                
                case 5:
                Console.Clear();
                Console.WriteLine("Återgår till huvudmenyn.");
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }
            
          
            
            Console.WriteLine("Välj av följande inredningspaket:");
            Console.WriteLine("[1] Lyx");
            Console.WriteLine("[2] Mellan");
            Console.WriteLine("[3] Budget");
            Console.WriteLine("[4] Byt Färg");
            Console.WriteLine("[5] Gå tillbaka till huvudmenyn");
            choiceInredning = int.Parse(Console.ReadLine());
            // choiceToCustomerModell = int.Parse(Console.ReadLine());
            switch (choiceInredning)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde Lyxpaketet"); 
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde Mellanpaketet");
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde Budgetpaketet");
                break;
                
                case 4:
                Console.Clear();
                Console.WriteLine("Du valde att byta färg");
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