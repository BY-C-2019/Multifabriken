using System;
using System.Collections.Generic;


namespace Multifabriken
{
    public class Produkter
    {

      private int order = 0;
        
        
        
        public void Huvudmeny(){
             Console.Clear();
             Console.WriteLine("Välkommen till Multifabriken, ta en titt på vår meny:\n");
             System.Console.WriteLine("[1] Beställa produkter");
             System.Console.WriteLine("[2] Se beställda produkter");
             System.Console.WriteLine("[3] Avsluta");
             int input = int.Parse(Console.ReadLine());

             switch(input)
             {
                 case 1: 
                // Beställa produkter
                 Console.Clear();
                 Produkter beställning = new Produkter();
                 beställning.Order();
                 break;

                 case 2:
                 //Historik
                 Console.Clear();
                 Kvitto kvitto = new Kvitto();
                 kvitto.PrintReciept();
                 
                 break;

                 case 3: 
                 return;

                 default:

                 System.Console.WriteLine("Felaktig inmatning.");

                 break;

             }
            }
        
        
        public void Order()
        {
            Console.Clear();
            System.Console.WriteLine("[1] Beställa godis");
            System.Console.WriteLine("[2] Beställa rör");
            System.Console.WriteLine("[3] Beställa bil");
            System.Console.WriteLine("[4] Beställa Havremjölk");
            System.Console.WriteLine("[5] Återgå till huvudmeny.");
            order = int.Parse(Console.ReadLine());

            switch (order)
            {
                case 1: 
                Console.Clear();
                Godis godis = new Godis();
                godis.ValAvGodis();
                break;

                case 2: 
                Console.Clear();
                Rör rör = new Rör();
                rör.ValAvRör();
                break;

                case 3: 
                Console.Clear();
                Bil bil = new Bil();
                bil.ValAvBil();
                break;

                case 4: 
                Console.Clear();
                Havremjölk havremjölk = new Havremjölk();
                havremjölk.Havremilk();
                break;

                case 5: 
                Console.Clear();
                Huvudmeny();
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }    
        }

           
    }
}
