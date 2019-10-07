using System;

namespace Multifabriken
{
    public class Rör
    {
        private int choiceDiameter = 0;
        private int choiceLängd = 0;
        private int choiceMatrial = 0;
        
        
        
        public void ValAvRör()
       {       
            Kvitto kvitto = new Kvitto();
            Produkter rör = new Produkter();  
            Console.Clear();          
            Console.WriteLine("Här kan du göra beställning av rör.");
            Console.WriteLine("Du kommer få välja diameter, längd och matrial.");
            Console.Write("Skriv in diametern i centimeter: ");
            choiceDiameter = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("Du valde " + choiceDiameter + " cm i diameter.");            
            
            Console.Write("Välj längd (centimeter) på röret: ");
            choiceLängd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du valde " + choiceLängd + " cm i längd");

            Console.WriteLine("Välj matrial på röret:");
            Console.WriteLine("[1] Betong");
            Console.WriteLine("[2] Stål");
            Console.WriteLine("[3] Plast");
            string valRör;
            choiceMatrial = int.Parse(Console.ReadLine());
            switch (choiceMatrial)
            {
            case 1: 
                Console.Clear();
                Console.WriteLine("Du valde betong");
                valRör = "Röret: " + choiceDiameter + " cm diameter, " + choiceLängd + " cm i längd." + " Matrial: betong."; 
                kvitto.Reciept(valRör);
                rör.Order();
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde stål");
                valRör = "Röret: " + choiceDiameter + " cm diameter, " + choiceLängd + " cm i längd." + " Matrial: stål.";
                kvitto.Reciept(valRör);
                rör.Order();
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde plast");
                valRör = "Röret: " + choiceDiameter + " cm diameter, " + choiceLängd + " cm i längd." + " Matrial: plast.";
                kvitto.Reciept(valRör);
                rör.Order();
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }
        }
    }
}