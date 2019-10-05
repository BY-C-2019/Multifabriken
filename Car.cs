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

            bool checkInput = false;

            // kör loop så länge inte någon av de förväntade alternativen matas in
            while (!checkInput)
            {
                Console.WriteLine("Välj modell:");
                Console.WriteLine("[1] Volvo 240");
                Console.WriteLine("[2] Volvo 740");
                Console.WriteLine("[3] Volvo 940");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        model = "Volvo 240";
                        // avsluta loopen
                        checkInput = true;
                        break;

                    case "2":
                        model = "Volvo 740";
                        checkInput = true;
                        break;

                    case "3":
                        model = "Volvo 940";
                        checkInput = true;
                        break;

                    default:
                        // täcker alla val förutom de förväntade men avbryter inte loopen
                        Console.WriteLine("Fel val!");
                        break;
                }
            }

            checkInput = false;
            while (!checkInput)
            {
                Console.WriteLine("Välj färg:");
                Console.WriteLine("[1] Röd");
                Console.WriteLine("[2] Grön");
                Console.WriteLine("[3] Blå");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        color = "Röd";
                        checkInput = true;
                        break;

                    case "2":
                        color = "Grön";
                        checkInput = true;
                        break;

                    case "3":
                        color = "Blå";
                        checkInput = true;
                        break;

                    default:
                        Console.WriteLine("Fel val!");
                        break;
                }
            }

            checkInput = false;
            while (!checkInput)
            {
                Console.WriteLine("Vill du ta bort lyxutrustningen?");
                Console.WriteLine("[1] Nej");
                Console.WriteLine("[2] Ja");
                input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        luxury = true;
                        checkInput = true;
                        break;

                    case "2":
                        luxury = false;
                        checkInput = true;
                        break;

                    default:
                        Console.WriteLine("Fel val!");
                        break;
                }
            }
        }
    }
}