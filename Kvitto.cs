using System;
using System.Collections.Generic;

namespace Multifabriken
{
public class Kvitto
{
    //Lägger till en lista som sparar alla beställningar. 
        List<string> addingToReciept = new List<string>();

        //Sträng som sparar undan värdete av reciept i addingtoreciept-listan
        //private string kvitto;

        //Metod där varor läggs till i listan
        public void Reciept(string reciept)
            {
                
                addingToReciept.Add(reciept);
                for(int i = 0; i < addingToReciept.Count; i++)
                {
                   System.Console.WriteLine(addingToReciept[i]);
                }

            }

            
            //Metod som skriver ut listan
            public void PrintReciept()
            {
                //System.Console.WriteLine(kvitto);
                Console.WriteLine("Du har beställt: ");
                Console.WriteLine("------------------");
               // System.Console.WriteLine(addingToReciept.Count);
                //for (int i = 0; i < addingToReciept.Count; i++)
                //{                   
                  //  Console.WriteLine(addingToReciept[i]);
                //}
               foreach(string name in addingToReciept)
               {
                   System.Console.WriteLine(addingToReciept);
               }

            //Console.WriteLine(kvitto);
            }
}
}