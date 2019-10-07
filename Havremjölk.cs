using System;

namespace Multifabriken
{
    public class Havremjölk
    {
        //skapar en instans av klassen kvitto
        Kvitto kvitto = new Kvitto();
        //Beställning beställningTvå = new Beställning();
        private double sizeOfHavremjölk = 0;

        private double fetthaltOfHavremjölk = 0;
        
        public void Havremilk()
        {
        Console.WriteLine("Välj vilken volym du vill ha på din havremjölk (i liter): ");
        sizeOfHavremjölk = double.Parse(Console.ReadLine());
        Console.WriteLine("Vilken fetthalt vill du ha på din havremjölk?");
        fetthaltOfHavremjölk = double.Parse(Console.ReadLine());

        string val = "Havremjölk " + sizeOfHavremjölk + " liter och en fetthalt: " + fetthaltOfHavremjölk + " procent.";
        
        kvitto.Reciept(val);
        }
       
    }
}