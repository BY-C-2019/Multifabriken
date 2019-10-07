using System;
namespace Multifabriken
{
public class Godis
    {
         //Metod för att välja godistyp
        public  static int candyMenu(){
            Console.WriteLine("Vilken typ av godis vill du ha?");
            Console.WriteLine("1. Hallon");
            Console.WriteLine("2. Lakris");
            Console.WriteLine("3. Jordgubb");
            Console.WriteLine("4. Päron");
            string flavourChoise = Console.ReadLine();//try catch / switch?
            int flavour = 0;
            try{
                flavour = Convert.ToInt32(flavourChoise);
            }catch{
                Console.WriteLine("Ange endast siffervärde på menyval");
            }
            return flavour;
        }
        //Konstruktor
        public Godis (int flavour, double weight)
        {
            Smak = flavour;
            Vikt = weight;
        }

        //Properties
        public int Smak;
        public double Vikt;
    }
}