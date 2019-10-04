using System;

namespace Multifabriken
{
    class Car
    {

        // privata variabler
        private static string model = "";
        private static string color = "";
        private static bool luxury = true;

        //konstruktorer
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Luxury
        {
            get { return luxury; }
            set { luxury = value; }
        }

        // metod som tar in värden ifrån användaren
        public static void AddCar()
        {
            string input;

            Console.WriteLine("Välj modell:");
            Console.WriteLine("[1] 240");
            Console.WriteLine("[2] 740");
            Console.WriteLine("[3] 940");
            input = Console.ReadLine();

            if (input == "1")
            {
                model = "240";
            }
            else if (input == "2")
            {
                model = "740";
            }
            else
            {
                model = "940";
            }

            Console.WriteLine("Välj färg:");
            Console.WriteLine("[1] Röd");
            Console.WriteLine("[2] Grön");
            Console.WriteLine("[3] Blå");
            input = Console.ReadLine();

            if (input == "1")
            {
                color = "Röd";
            }
            else if (input == "2")
            {
                color = "Grön";
            }
            else
            {
                color = "Blå";
            }

            Console.WriteLine("Vill du ta bort lyxutrustningen?");
            Console.WriteLine("[1] Nej");
            Console.WriteLine("[2] Ja");
            input = Console.ReadLine();

            if (input == "2")
            {
                luxury = false;
            }
        }
    }
}