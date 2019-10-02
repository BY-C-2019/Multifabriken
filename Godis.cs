using System;

namespace Multifabriken
{
    public class Godis
    {
        
        // Läser av vilken typ av godis som väljs
        private int choiceCandy = 0;

        // Läser av hur många av sorten godis som väljs
        private int qtyOfTaste = 0;

        //Håller koll på hur många kilo godis som är beställt
        private int oldQtyOfTaste = 0;
        public Godis()
        {
            Console.WriteLine("Här kan du göra beställning av godis");
           
        }
       
       public void ValAvGodis()
       {
           do{
            Console.WriteLine("Välj av följande sorter:");
            Console.WriteLine("[1] Hallon");
            Console.WriteLine("[2] Lakrits");
            Console.WriteLine("[3] Päron");
            Console.WriteLine("[4] Jordgubb");
            Console.WriteLine("[5] Gå tillbaka till huvudmenyn");
            choiceCandy = int.Parse(Console.ReadLine());

            System.Console.WriteLine(qtyOfTaste);

             switch (choiceCandy)
            {
                case 1: 
                Console.Clear();
                System.Console.WriteLine(oldQtyOfTaste);
                Console.WriteLine("Du valde hallon! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                qtyOfTaste = int.Parse(Console.ReadLine());
                oldQtyOfTaste = oldQtyOfTaste + qtyOfTaste;
                break;
                
                case 2: 
                Console.Clear();
                Console.WriteLine("Du valde Lakrits! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                qtyOfTaste = int.Parse(Console.ReadLine());
                qtyOfTaste = qtyOfTaste + qtyOfTaste;
                
                break;

                case 3: 
                Console.Clear();
                Console.WriteLine("Du valde Päron! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                qtyOfTaste = int.Parse(Console.ReadLine());
                qtyOfTaste = qtyOfTaste + qtyOfTaste;
                
                break;

                case 4: 
                Console.Clear();
                Console.WriteLine("Du valde Jordgubb! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                qtyOfTaste = int.Parse(Console.ReadLine());
                qtyOfTaste = qtyOfTaste + qtyOfTaste;
                
                break;

                case 5: 
                Console.Clear();
                
                break;
                            

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            
            }
            } while (choiceCandy !=5 || oldQtyOfTaste <= 10);


            
       }
    }
}