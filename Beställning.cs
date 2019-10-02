using System;
using System.Collections.Generic;


namespace Multifabriken
{
    public class Beställning
    {
        Godis godis = new Godis();

//Lägger till en lista som sparar alla beställningar.
        List<int> addingToReciept = new List<int>();
       
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
                godis.ValAvGodis();
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

                default:
                Console.WriteLine("Felaktig inmatning");
                break;
            }    
        }

            public int Reciept(int reciept)
            {
                addingToReciept.Add(reciept);
                
                return reciept;
            }

            public void PrintReciept()
            {
                Console.WriteLine("Du har beställt: ");
                for (int i = 0; i < addingToReciept.Count; i++)
                {
                    System.Console.WriteLine(addingToReciept[i]);
                }
            }
    }
}