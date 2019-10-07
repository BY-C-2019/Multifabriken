using System;
using System.Collections.Generic;

using menu;

using Milk;
using Pipes;
using Cars;
using Candy;

using Order;
using Products;

namespace multifabriken
{
    class Program
    {
        public static List<milk> milkList = new List<milk>();
        public static List<pipes> pipeList = new List<pipes>();
        public static List<cars> carList = new List<cars>();
        public static List<candy> candyList = new List<candy>();
        public static void SortThroughList() // Metod som lägger in listorna i en gemensam lista "orderList"
        {
            milkList.Clear();
            pipeList.Clear();
            carList.Clear();
            candyList.Clear();

            foreach (var p in order.orderList)
            {
                var p2 = p as milk;
                var p3 = p as cars;
                var p4 = p as pipes;
                var p5 = p as candy;


                if (p2 != null)
                {
                    milkList.Add(p2);
                }
                else if (p3 != null)
                {
                    carList.Add(p3);
                }
                else if (p4 != null)
                {
                    pipeList.Add(p4);
                }
                else if (p5 != null)
                {
                    candyList.Add(p5);
                }
            }

        }
        public static void PrintItemsInList() // Listar våra produkter
        {
            Console.WriteLine("Havremjölk:");
            for (int i = 0; i < milkList.Count; i++)
            {
                Console.WriteLine("\tFetthalt: {0}", milkList[i].fat);
                Console.WriteLine("\tPacketering: {0}", milkList[i].package);
                Console.WriteLine();
            }

            Console.WriteLine("Bilar:");
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine("\tBilmodell: {0}", carList[i].carmodel);
                Console.WriteLine("\tFärg: {0}", carList[i].carcolour);
                Console.WriteLine("\tLyxpaket: {0}", carList[i].luxpackage);
                Console.WriteLine();

            }

            Console.WriteLine("Godis:");
            for (int i = 0; i < candyList.Count; i++)
            {
                Console.WriteLine("\tSmak: {0}", candyList[i].taste);
                Console.WriteLine("\tMängd: {0}", candyList[i].amount);
                Console.WriteLine();

            }

            Console.WriteLine("Rör:");
            for (int i = 0; i < pipeList.Count; i++)
            {
                Console.WriteLine("\tMaterial: {0}", pipeList[i].material);
                Console.WriteLine("\tLängd: {0}", pipeList[i].length);
                Console.WriteLine("\tDiameter: {0}", pipeList[i].diameter);
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            int fatContent = 0;
            int packageSize = 0;
            string input;
            do
            {
                string menuHeader = "Välkommen till MULTIFABRIKEN";
                string[] menuContent = new string[] { "Lägg till en vara", "Lista varor", "Avsluta" };

                var menu = new Menu(menuContent);
                menu = menu.GetMenu(menu, menuHeader); // Skriver ut vår meny för användaren

                switch (menu.SelectedIndex)
                {
                    case 0:
                        // Lägg till vara
                        menuHeader = "Lägg till en vara";
                        menuContent = new string[] { "Havremjölk", "Godis", "Bil", "Rör", "Avsluta" };

                        menu = new Menu(menuContent);
                        menu = menu.GetMenu(menu, menuHeader);

                        switch (menu.SelectedIndex)
                        {
                            case 0:
                                Console.Clear();
                                // Mjölk
                                while (fatContent < 2 || fatContent > 11)
                                {
                                    Console.WriteLine("Vilken fettprocent? Minst 2%, max 11%");
                                    input = Console.ReadLine();
                                    fatContent = Convert.ToInt32(input);
                                    if (fatContent < 2 || fatContent > 11)
                                    {
                                        Console.WriteLine("Minst 2% och max 11% fett.");
                                    }
                                }
                                Console.WriteLine("");
                                while (packageSize < 1 || packageSize > 3)
                                {
                                    Console.WriteLine("Vilken förpackning vill du ha?");
                                    for (int i = 0; i < products.packageList.Count; i++)
                                    {
                                        Console.WriteLine("[{0}] {1}", i + 1, products.packageList[i]);
                                    }
                                    input = Console.ReadLine();

                                    packageSize = Convert.ToInt32(input);
                                    if (packageSize < 1 || packageSize > 3)
                                    {
                                        Console.WriteLine("Ogiltligt val, välj med knapparna 1-3");
                                    }
                                }



                                packageSize--;

                                milk milk = new milk(fatContent, packageSize);

                                order.orderList.Add(milk);
                                Products.products.antal++;

                                break;

                            case 1:
                                // Godis
                                Console.Clear();

                                Console.WriteLine("Vilken godissort vill du ha?");
                                for (int i = 0; i < products.godisLista.Count; i++)
                                {
                                    Console.WriteLine("[{0}] {1}", i + 1, products.godisLista[i]);
                                }

                                input = Console.ReadLine();
                                int SelectedIndex = Convert.ToInt32(input);
                                SelectedIndex--;

                                Console.WriteLine("Hur mycket vill du ha av {0} i kg", order.godisLista[SelectedIndex]);
                                input = Console.ReadLine();
                                int candyAmount = Convert.ToInt32(input);

                                candy candy = new candy(SelectedIndex, candyAmount);

                                order.orderList.Add(candy);
                                Products.products.antal++;

                                break;

                            case 2:
                                // Bil
                                Console.Clear();

                                Console.WriteLine("Vilken modell vill du ha?");
                                for (int i = 0; i < products.bilLista.Count; i++)
                                {
                                    Console.WriteLine("[{0}] {1}", i + 1, products.bilLista[i]);
                                }

                                input = Console.ReadLine();
                                int selectedIndex = Convert.ToInt32(input);
                                selectedIndex--;

                                Console.WriteLine("Vilken färg vill du ha på bilen?");
                                string carColour = Console.ReadLine();

                                //------------------------From Stackoverflow------------------------//
                                char[] a = carColour.ToCharArray();
                                a[0] = char.ToUpper(a[0]);
                                carColour = new string(a);
                                //------------------------------------------------------------------//

                                Console.WriteLine("Vill du ha de sniceiga lyxpaketet?");
                                Console.WriteLine("[J/N]");

                                input = Console.ReadLine();

                                char[] b = input.ToCharArray();
                                b[0] = char.ToUpper(b[0]);
                                input = new string(b);

                                bool lux = false;

                                if (input[0] == 'J')
                                {
                                    lux = true;


                                }
                                else if (input[0] == 'N')
                                {
                                    Console.WriteLine("Du valde fel! Du får betala ett lyxpaket ändå");
                                    Console.ReadKey();
                                    lux = true;

                                }
                                cars cars = new cars(selectedIndex, carColour, lux);

                                order.orderList.Add(cars);
                                Products.products.antal++;

                                break;

                            case 3:
                                // Rör

                                Console.Clear();
                                Console.WriteLine("Vilket material vill du ha?");
                                for (int i = 0; i < products.myPipes.Count; i++)
                                {
                                    Console.WriteLine("[{0}] {1}", i + 1, products.myPipes[i]);
                                }

                                input = Console.ReadLine();
                                selectedIndex = Convert.ToInt32(input);
                                selectedIndex--;

                                Console.WriteLine("Vilken längd i millimeter vill du ha?");
                                input = Console.ReadLine();
                                int selectedLength = Convert.ToInt32(input);


                                Console.WriteLine("Vilken diameter i millimeter  vill du ha?");
                                input = Console.ReadLine();
                                int selectedDiameter = Convert.ToInt32(input);

                                pipes pipes = new pipes(selectedLength, selectedDiameter, selectedIndex);


                                order.orderList.Add(pipes);
                                Products.products.antal++;
                                break;
                        }

                        break;


                    case 1:
                        // Lista varor
                        Console.Clear();
                        Console.WriteLine("Du har beställt {0} st produkter", order.antal);
                        Console.WriteLine();
                        SortThroughList();
                        PrintItemsInList();
                        Console.ReadKey();

                        break;


                    case 2:
                        // Avsluta
                        SortThroughList();
                        PrintItemsInList();
                        return;

                }
            } while (true);
        }
    }
}
