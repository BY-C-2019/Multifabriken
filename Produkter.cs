using System;
using System.Collections.Generic;


namespace Multifabriken
{
    public class Produkter
    {

      private int order = 0;
        public void Order()
        {
            Console.Clear();
            System.Console.WriteLine("[1] Beställa godis");
            System.Console.WriteLine("[2] Beställa rör");
            System.Console.WriteLine("[3] Beställa bil");
            System.Console.WriteLine("[4] Beställa Havremjölk");
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

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }    
        }

           
    }
}
