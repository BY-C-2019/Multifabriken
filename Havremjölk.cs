using System;

namespace Multifabriken
{
    public class Havremjölk
    {
        //skapar en instans av klassen kvitto
        Kvitto kvitto = new Kvitto();
        
        
        //variabel för storlek på paketet
        private double sizeOfHavremjölk = 0;

        // variabel för fetthalt
        private double fetthaltOfHavremjölk = 0;
        
        //Metod där beställningen av havremjölk sker
        public void Havremilk()
        {
        Console.WriteLine("Välj vilken volym du vill ha på din havremjölk (i liter): ");
        sizeOfHavremjölk = double.Parse(Console.ReadLine());
        Console.WriteLine("Vilken fetthalt vill du ha på din havremjölk?");
        fetthaltOfHavremjölk = double.Parse(Console.ReadLine());

        string val = "Havremjölk " + sizeOfHavremjölk + " liter och en fetthalt: " + fetthaltOfHavremjölk + " procent.";
        
        Produkter produkter = new Produkter();
        //Lägger till valet i en lista
        kvitto.Reciept(val);    
        //Skapar en instans av produkter, så att programmet återgår till ordermenyn
        produkter.Order();
        }
        
    }
}