using System;

namespace Multifabriken
{
    class Oatmilk
    {
        private static string volume = "";
        private static string fat = "";

        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public string Fat
        {
            get { return fat; }
            set { fat = value; }
        }

        public static void AddMilk()
        {
            {
                string input;

                bool checkInput = false;

                // kör loop så länge inte någon av de förväntade alternativen matas in
                while (!checkInput)
                {
                    Console.WriteLine("Välj mängd:");
                    Console.WriteLine("[1] 0,5 liter");
                    Console.WriteLine("[2] 1,5 liter");
                    Console.WriteLine("[3] 3 liter");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            volume = "0,5 liter";
                            // avsluta loopen
                            checkInput = true;
                            break;

                        case "2":
                            volume = "1,5 liter";
                            checkInput = true;
                            break;

                        case "3":
                            volume = "3 liter";
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
                    Console.WriteLine("Välj fetthalt:");
                    Console.WriteLine("[1] 0,5%");
                    Console.WriteLine("[2] 1,5%");
                    Console.WriteLine("[3] 3%");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            fat = "0,5%";
                            checkInput = true;
                            break;

                        case "2":
                            fat = "1,5%";
                            checkInput = true;
                            break;

                        case "3":
                            fat = "3%";
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
}