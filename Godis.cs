using System;

namespace Multifabriken
{
    public class Godis
    {
        // Läser av vilken typ av godis som väljs
        private int choiceCandy = 0;

        // Läser av hur många av sorten godis som väljs
        private int qtyOfTaste = 0;

        private int oldQtyOfTaste = 0;
        public Godis()
        {
            Console.WriteLine("Här kan du göra beställning av godis");
           
        }
       
       public void ValAvGodis()
       {
            Console.WriteLine("Välj av följande sorter:");
            Console.WriteLine("[1] Hallon");
            Console.WriteLine("[2] Lakrits");
            Console.WriteLine("[3] Päron");
            Console.WriteLine("[4] Jordgubb");
            Console.WriteLine("[5] Gå tillbaka till huvudmenyn");
            choiceCandy = int.Parse(Console.ReadLine());

             switch (choiceCandy)
            {
                case 1: 
                Console.Clear();
                Console.WriteLine("Du valde hallon! Hur många kilo (avrundat till heltal) godis vill du ha av denna smak?");
                qtyOfTaste = int.Parse(Console.ReadLine());
                break;
                
                case 2: 
                Console.Clear();
                godis.ValAvGodis();
                break;

                case 3: 
                Console.Clear();
                godis.ValAvGodis();
                break;

                case 4: 
                Console.Clear();
                godis.ValAvGodis();
                break;

                case 5: 
                Console.Clear();
                godis.ValAvGodis();
                break;

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }



            
       }
    }
}