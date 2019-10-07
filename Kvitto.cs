using System;
using System.Collections.Generic;

namespace Multifabriken
{
public class Kvitto
{
    //Lägger till en lista som sparar alla beställningar.
        List<string> addingToReciept = new List<string>();
     public string Reciept(string reciept)
            {
                
                addingToReciept.Add(reciept);
                
                return reciept;
            }

            public void PrintReciept()
            {
                Console.Clear();
                Console.WriteLine("Du har beställt: ");
                Console.WriteLine("------------------");
                for (int i = 0; i < addingToReciept.Count; i++)
                {
                    System.Console.WriteLine(addingToReciept[i]);
                }
            }
}
}