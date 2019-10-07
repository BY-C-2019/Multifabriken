using System;
namespace Multifabriken
{
    public class Rör
    {
        public Rör(string material, double diameter, double length)
        {
            Material = material;
            Diameter = diameter;
            Length = length;
        }
        //metod för längd på rör
        public static double pipeLength()
        {
            Console.WriteLine("Mata in önskad längd (cm): ");
            double inmatning = Convert.ToDouble(Console.ReadLine());
            return inmatning;
        }
        //metod för diameter på rör
        static double pipeDiameter()
        {
            Console.WriteLine("Mata in önskad diameter (cm): ");
            double inmatning = Convert.ToDouble(Console.ReadLine());
            return inmatning;
        }

        //Metod för material på rör
        static string pipeMaterial()
        {
            //Fixa try catch
            Console.WriteLine("Vilket material vill du ha?");
            Console.WriteLine("1. Plast");
            Console.WriteLine("2. Betong");
            Console.WriteLine("3. Stål");
            string inmatning = Console.ReadLine();
            return inmatning;
        }
        //Konstruktor

        //Properties
        public string Material;
        public double Diameter;
        public double Length;
    }
}