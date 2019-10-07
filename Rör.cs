using System;

namespace Multifabriken
{
    public class Rör
    {
        private int choiceDiameter = 0;
        private int choiceLängd = 0;
        private int choiceMatrial = 0;
        
        public Rör()
        {
            Console.WriteLine("Här kan du göra beställning av rör.");
            Console.WriteLine("Du kommer få välja diameter, längd och matrial.");
        }
        public void ValAvRör()
       {
            Console.Write("Skriv in diametern i centimeter: ");
            choiceDiameter = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("Du valde " + choiceDiameter + " cm i diametern.");            
            
            Console.Write("Välj längd (centimeter) på röret: ");
            choiceLängd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du valde " + choiceLängd + " cm i längd");

            Console.WriteLine("Välj matrial på röret:");
            Console.WriteLine("[1] Betong");
            Console.WriteLine("[2] Stål");
            Console.WriteLine("[3] Plast");
            Console.WriteLine("[4] Välj om diemensioner.");
            Console.WriteLine("[5] Gå tillbaka till huvudmenyn");
            choiceMatrial = int.Parse(Console.ReadLine());
            switch (choiceMatrial)
            {
            case 1: 
                Console.Clear();
                Console.WriteLine("Du valde betong"); 
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde stål");
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde plast");
                break;
                
                case 4:
                Console.Clear();
                Console.WriteLine("Du valde att byta diemensioner");
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