using System;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("[1] Köp bil");
                Console.WriteLine("[2] Köp Rör");
                Console.WriteLine("[3] Köp godis");
                Console.WriteLine("[4] Köp havremjölk");
                Console.WriteLine("[5] Skriv ut inköpslista");
                Console.WriteLine("[6] Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Välj modell:");
                            Console.WriteLine("[1] 240");
                            Console.WriteLine("[2] 740");
                            Console.WriteLine("[3] 940");
                            Console.WriteLine("[4] Gå tillbaka");
                            input = Console.ReadLine();

                            switch (input)
                            {
                                case "1":

                                    break;

                                case "2":

                                    break;

                                case "3":

                                    break;

                                case "4":
                                    return;

                                default:
                                    Console.WriteLine("Fel val, försök igen");
                                    break;
                            }
                        }


                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;
                }
            }
        }
    }
}
