using System;
using System.Collections.Generic;

namespace Multifabriken
{
public class Kvitto
{
    //Lägger till en lista som sparar alla beställningar.
        List<string> addingToReciept = new List<string>();
        private string kvitto = "";
     public string Reciept(string reciept)
            {
                reciept = kvitto;
                addingToReciept.Add(kvitto);
                
                return kvitto;
            }

            public void PrintReciept()
            {
                Console.Clear();
                Console.WriteLine("Du har beställt: ");
                Console.WriteLine("------------------");
                for (int i = 0; i < addingToReciept.Count; i++)
                {
                    System.Console.WriteLine(kvitto[i]);
                }
            }
}
}