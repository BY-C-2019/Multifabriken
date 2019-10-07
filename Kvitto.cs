using System;
using System.Collections.Generic;

namespace Multifabriken
{
public class Kvitto
{
    //Lägger till en lista som sparar alla beställningar.
        
        private string kvitto;
            
        List<string> addingToReciept = new List<string>();
            
        
            public string Reciept(string reciept)
            {
                
                kvitto = reciept;
                addingToReciept.Add(kvitto);
                System.Console.WriteLine(addingToReciept.Count);
                return kvitto;
            }
            
            public void PrintReciept()
            {
                Console.Clear();
                Console.WriteLine("Du har beställt: ");
                Console.WriteLine("------------------");
                Console.WriteLine(addingToReciept.Count);
                //for (int i = 0; i < addingToReciept.Count; i++)
                //{
                //    System.Console.WriteLine(addingToReciept[i]);
                //}
            }
}
}