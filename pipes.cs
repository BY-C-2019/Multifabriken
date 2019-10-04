using System;

namespace Multifabriken
{
    class Pipes
    {
        //privata vaiabler
        private static string diameter = "0";
        private static string material = "";
        private static string längd = "0";
        //konstruktorer
        public string Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Längd
        {
            get { return längd; }
            set { längd = value; }
        }
        // metod som tar in värden ifrån användaren
        public static void AddPipe()

        {
            {
                string input;

                Console.WriteLine("Välj diameter:");
                Console.WriteLine("[1] 9mm");
                Console.WriteLine("[2] 5.56mm");
                Console.WriteLine("[3] 15mm");
                input = Console.ReadLine();

                if (input == "1")
                {
                    diameter = "9mm";
                }
                else if (input == "2")
                {
                    diameter = "5.56mm";
                }
                else
                {
                    diameter = "15mm";
                }

                Console.WriteLine("Välj material:");
                Console.WriteLine("[1] Betong");
                Console.WriteLine("[2] Stål");
                Console.WriteLine("[3] Plast");
                input = Console.ReadLine();

                if (input == "1")
                {
                  material = "Betong";
                }
                else if (input == "2")
                {
                    material = "Stål";
                }
                 else
                {
                 material = "Plast";
                }

                Console.WriteLine("Vad vill du ha för längd?");
                Console.WriteLine("[1] 1m");
                Console.WriteLine("[2] 15m");
                Console.WriteLine("[3] 100m");
                input = Console.ReadLine();

               if (input == "1")
                {
                  längd = "1m";
                }
                else if (input == "2")
                {
                    längd = "15m";
                }
                 else
                {
                 längd = "100m";
                }
            }
        }

    }
}
