using System;

namespace Multifabriken
{
    public class Godis
    {
        // Skapar en instans av klassen Kvitto
        Kvitto kvitto = new Kvitto();
        // Läser av vilken typ av godis som väljs i switch case
        private int choiceCandy = 0;

        // Läser av hur många kg av sorten godis som väljs
        private int qtyOfTaste = 0;
        //GetSet som håller reda på inmatning.
        public int QtyOfTaste
        {
            get { return qtyOfTaste; }

            set { if (qtyOfTaste > 10)
                    {
                        value = 10;
                    } 
                    else if (qtyOfTaste < 0)
                    {
                        value = 1;
                    }
                    else
                    {
                        qtyOfTaste = value;
                    }
                }
        }
        
        //Konstruktor
        public Godis()
        {
            Console.WriteLine("Här kan du göra beställning av godis\n");    
        }
        //variabel som lägger till varor i kvitto
       private string printToReciept = "";

       //SwitchCase meny
       public void ValAvGodis()
       {
           Produkter produkter = new Produkter();
           
                Console.WriteLine("Välj av följande sorter:");
                Console.WriteLine("[1] Hallon");
                Console.WriteLine("[2] Lakrits");
                Console.WriteLine("[3] Päron");
                Console.WriteLine("[4] Jordgubb");
                Console.WriteLine("[5] Gå tillbaka till beställningsmenyn");
                choiceCandy = int.Parse(Console.ReadLine());

                System.Console.WriteLine(qtyOfTaste);

                switch (choiceCandy)
                {
                    case 1: 
                        Console.Clear();
                        Console.WriteLine("Du valde hallon! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                        Console.WriteLine("Den största förpackningen innehåller 10Kg godis.");
                        QtyOfTaste = int.Parse(Console.ReadLine());
                        printToReciept = qtyOfTaste + " kg hallongodis.";
                        produkter.Order();
                    
                    break;
                    
                    case 2: 
                        Console.Clear();
                        Console.WriteLine("Du valde Lakrits! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                        Console.WriteLine("Den största förpackningen innehåller 10Kg godis.");
                        QtyOfTaste = int.Parse(Console.ReadLine());
                        printToReciept = qtyOfTaste + " kg lakritsgodis.";
                        kvitto.Reciept(printToReciept);
                        produkter.Order();

                    break;

                    case 3: 
                        Console.Clear();
                        Console.WriteLine("Du valde Päron! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                        Console.WriteLine("Den största förpackningen innehåller 10Kg godis.");
                        QtyOfTaste = int.Parse(Console.ReadLine());
                        printToReciept = qtyOfTaste + " kg pärongodis.";
                        kvitto.Reciept(printToReciept);
                        produkter.Order();

                    
                    break;

                    case 4: 
                        Console.Clear();
                        Console.WriteLine("Du valde Jordgubb! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                        Console.WriteLine("Den största förpackningen innehåller 10Kg godis.");
                        QtyOfTaste = int.Parse(Console.ReadLine());
                        printToReciept = qtyOfTaste + " kg jordgubbsgodis.";
                        kvitto.Reciept(printToReciept);
                        produkter.Order();
                    
                    break;

                    case 5: 
                        Console.Clear();
                        produkter.Order();

                    break;
                                

                    default:
                        Console.WriteLine("Felaktig inmatning");
                    break;
                
                }
   
       }
    }
}