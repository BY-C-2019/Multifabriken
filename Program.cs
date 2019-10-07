using System;

namespace Multifabriken
{
    public class Program
    {
        
             static void Main(string[] args)
             {
                 try{
                 Produkter produkter = new Produkter();
                 produkter.Huvudmeny(); 
                 }catch (Exception e){
                     System.Console.WriteLine(e);
                 }
             }
            
            
         }
    
}
