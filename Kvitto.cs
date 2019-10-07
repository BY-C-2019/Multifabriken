using System;
using System.Collections.Generic;

namespace Multifabriken
{
public class Kvitto
{
    //Lägger till en lista som sparar alla beställningar.
        List<string> addingToReciept = new List<string>();

        //Sträng som sparar undan värdete av reciept i addingtoreciept-listan
        private string kvitto;

        //Metod där varor läggs till i listan
        public string Reciept(string reciept)
            {
                reciept = Console.ReadLine();

                for(int i = 0; i < addingToReciept.Count; i++)
                {
                addingToReciept.Add(reciept);
                }     

                return reciept;
            }
            //Metod som skriver ut listan
            public void PrintReciept()
            {
                Console.Clear();
                Console.WriteLine("Du har beställt: ");
                Console.WriteLine("------------------");
                System.Console.WriteLine(addingToReciept.Count);
                for (int i = 0; i < addingToReciept.Count; i++)
                {                   
                    Console.WriteLine(addingToReciept[i]);
                }
               
            Console.WriteLine(kvitto);
            }
}
}