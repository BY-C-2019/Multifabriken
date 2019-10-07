using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runMenu = true;
            List<Car> orderListCar = new List<Car>();
            List<Candy> orderListCandy = new List<Candy>();
            List<Pipe> orderListPipe = new List<Pipe>();
            List<Oatmeal> orderListOatmeal = new List<Oatmeal>();
            
            //räknar antal orderrader.
            int counter = 1;

            while (runMenu)
            {
                Console.Clear();
                System.Console.WriteLine("[1] Skapa beställning:");
                //System.Console.WriteLine("[2] Ändra beställning:"); // Arbete pågår. Ursäkta röran, vi bygger om.
                System.Console.WriteLine("[3] Skicka offert.");
                System.Console.WriteLine("[4] Avsluta.");
                System.Console.Write("Välj: ");

                string meny = Console.ReadLine();
                string menyProducts = "";

                switch (meny)
                {

                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("[1] Bil");
                        System.Console.WriteLine("[2] Godis");
                        System.Console.WriteLine("[3] Rör");
                        System.Console.WriteLine("[4] Havremjölk");
                        System.Console.Write("Välj produkt: ");

                        menyProducts = Console.ReadLine();
                        switch (menyProducts)
                        {
                            case "1":
                                Console.Clear();
                                orderListCar.Add(MenuOptionCars());
                                break;

                            case "2":
                                Console.Clear();
                                orderListCandy.Add(MenuOptionCandy());
                                break;

                            case "3":
                                Console.Clear();
                                orderListPipe.Add(MenuOptionPipes());
                                break;

                            case "4":
                                Console.Clear();
                                orderListOatmeal.Add(MenuOptionOatmeal());
                                break;
                        }
                        break;

                    /*  Arbete pågår. Ursäkta röran, vi bygger om.
                    case "2":
                        int selection = 0;
                        bool selectionLoop = true;
                        while (selectionLoop)
                        {
                            Console.Clear();
                            Console.WriteLine("[1] Ta bort produkt");
                            Console.WriteLine("[2] Ändra produkt");
                            Console.WriteLine("[3] Återgå");
                            Console.Write("\nSkriv in val: ");
                            try
                            {
                                selection = Convert.ToInt32(Console.ReadLine());
                                if (selection == 1)
                                {
                                    //DeleteProduct(orderListCar, orderListCandy, orderListPipe, orderListOatmeal);
                                    int userCategoryChoice = 0;
                                    bool runCategoryMenu = true;
                                    while (runCategoryMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Vilken kategori?");
                                        Console.WriteLine("[1] Bilar");
                                        Console.WriteLine("[2] Godis");
                                        Console.WriteLine("[3] Rör]");
                                        Console.WriteLine("[4] Havremjölk");
                                        Console.WriteLine("[5] Klar/Återgå");
                                        Console.WriteLine("\nGör ett sifferval: ");

                                        userCategoryChoice = Convert.ToInt32(Console.ReadLine());
                                        switch (userCategoryChoice)
                                        {
                                            case 1:
                                                //DeleteProduct();
                                            break;
                                            case 2:
                                            break;
                                            case 3:
                                            break;
                                            case 4:
                                            break;
                                            case 5:
                                                runCategoryMenu = false;
                                            break;

                                            default:
                                            Console.WriteLine("Gör ett val mellan 1 & 5. Tryck nu enter.");
                                            Console.ReadLine();
                                            break;
                                        }
                                    }
                                }
                                if (selection == 2) { ChangeProduct(); }
                                if (selection == 3)
                                {
                                    selectionLoop = false;
                                }
                                else
                                {
                                    throw new FormatException();
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Skriv in en siffra. 1, 2 eller 3.");
                                Console.ReadLine();
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Okeeej. Skriv in en siffra mellan 1 & 3.");
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ett oväntat fel inträffade: " + e);
                            }
                        }
                        break;
                    */

                    case "3":
                        Console.Clear();
                        System.Console.WriteLine("Offert inskickad.");
                        System.Console.WriteLine("Tryck på valfri tangent för att komma tillbaka till huvudmeny...");
                        Console.ReadKey();
                        break;

                    case "4":
                        runMenu = false;
                        Console.Clear();
                        foreach (Car car in orderListCar)
                        {
                            Console.WriteLine("[Beställt, rad {0}] - Bil: {1} || Färg: {2} || Inredning(True = Lyx | False = Standard): {3}",counter++,car.TypeCar, car.ColorCar, car.InteriorCar);
                        }
                        foreach (Candy candy in orderListCandy)
                        {
                            Console.WriteLine("[Beställt, rad {0}] - Godissort: {1} || Mängd(g): {2}",counter++,candy.TypeCandy, candy.AmountCandy);
                        }
                        foreach (Pipe pipe in orderListPipe)
                        {
                            System.Console.WriteLine("[Beställt, rad {0}] - Rörmaterial: {1} || Längd(cm): {2} || Diameter(mm): {3}",counter++,pipe.Material, pipe.Length, pipe.Diameter);
                        }
                        foreach (Oatmeal oatmeal in orderListOatmeal)
                        {
                            System.Console.WriteLine("[Beställt, rad {0}] - Havremjölkens fetthalt(%): {1} || Mängd(L): {2}",counter++,oatmeal.Fat, oatmeal.Amount);
                        }
                        Console.ReadLine();
                        System.Console.WriteLine("Program avslutat");
                        return;
                }
            }
        }

        //Menyvalen som gäller produkten bil
        static public Car MenuOptionCars()
        {
            {
                string type = "";
                string color = "";
                bool interior = false;
                bool loop = true;
                string inputInterior = "";

                Console.WriteLine("Ange vilken typ av bil: ");
                type = Console.ReadLine();
                Console.WriteLine("Ange vilken färg du vill ha på bilen: ");
                color = Console.ReadLine();

                //En loop som ser till att användaren väljer ett av de valen som finns
                while (loop == true)
                {
                    Console.WriteLine("Vill du ha [S]tandard inredning eller [L]yx-inredning?");
                    inputInterior = Console.ReadLine();
                    inputInterior = inputInterior.ToUpper();


                    if (inputInterior == "S")
                    {
                        interior = false;
                        loop = false;
                        inputInterior = "Standard-Inredning";
                    }
                    else if (inputInterior == "L")
                    {
                        interior = true;
                        loop = false;
                        inputInterior = "Lyx-Inredning";
                    }
                    else
                    {
                        System.Console.WriteLine("Fel inmantning");
                    }
                }
                // SKriver ut vad man har lagt till i sin beställning.
                System.Console.WriteLine($"Du har lagt till en {type} av färgen {color} och den har {inputInterior} \n");
                Car car = new Car(type, color, interior);
                return car;
            }
        }
        //Menyval ang. Godis
        static public Candy MenuOptionCandy()
        {
            {
                string flavour = "";
                int weight = 0;
                bool loop = false;

                Console.Write("Ange vilken typ av godis: ");
                flavour = Console.ReadLine();

                while (loop == false | weight >= 1000)
                {
                    Console.Write("Ange mängd du vill köpa (minst 1000g): ");
                    try
                    {
                        weight = Convert.ToInt32(Console.ReadLine());
                        loop = true;
                        //break;
                    }
                    catch
                    {
                        System.Console.WriteLine("Ange endast nummer, minst 1000g.");
                        loop = false;
                    }
                }
                System.Console.WriteLine($"Du har lagt till {weight} gram godis av smaken {flavour}.\n");
                Candy candy = new Candy(flavour, weight);
                return candy;
            }

        }

        //Menyval ang. Rör
        static public Pipe MenuOptionPipes()
        {

            string material = ""; ;
            int length = 0;
            int diameter = 0;
            bool loopLength = true; // osäker på om man behöver en bool för varje loop 
            bool loopDiameter = true;// eller om man kan får till det så att samma bool gäller i båda valen?

            Console.Write("Välj material: ");
            material = Console.ReadLine();
            while (loopLength == true)
            {
                Console.Write("Välj längd, ange i centimeter: ");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    loopLength = false;
                }
                catch
                {
                    System.Console.WriteLine("Ange hela centimeter, Ange endast siffror.");
                    loopLength = true;
                }
            }

            while (loopDiameter == true)
            {
                Console.Write("Välj diameter, ange i millimeter: ");
                try
                {
                    diameter = Convert.ToInt32(Console.ReadLine());
                    loopDiameter = false;
                }
                catch
                {
                    System.Console.WriteLine("Ange endast siffror.");
                    loopDiameter = true;
                }
            }

            System.Console.WriteLine($"Du har lagt till ett rör av {material} av längden {length} och den har diametern {diameter} \n");
            Pipe pipe = new Pipe(material, length, diameter);
            return pipe;
        }

        //Menyval gällande Havremjölk
        static public Oatmeal MenuOptionOatmeal()
        {
            int fat = 0;
            int amount = 0;
            bool loopFat = true;
            bool loopAmount = true;

            while (loopFat == true)
            {
                Console.Write("Välj fetthalt; 2-11%: ");
                try
                {
                    fat = Convert.ToInt32(Console.ReadLine());
                    if (fat >= 2 & fat <= 11)
                    {
                        loopFat = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Ange endast siffror mellan 2 och 11.");
                    }
                }
                catch
                {
                    System.Console.WriteLine("Ange endast siffror mellan 2 och 11.");
                    loopFat = true;
                }
            }

            while (loopAmount == true)
            {
                Console.Write("Välj mängd, ange endast hela liter: ");
                try
                {
                    amount = Convert.ToInt32(Console.ReadLine());
                    loopAmount = false;
                }
                catch
                {
                    System.Console.WriteLine("Ange hela liter, Ange endast siffror.");
                    loopAmount = true;
                }
            }

            System.Console.WriteLine($"Du har lagt till {amount} liter Havremjölk med fetthalten {fat}% \n");
            Oatmeal oatmeal = new Oatmeal(fat, amount);
            return oatmeal;
        }
        // Ta inte bort än!!!
        // static public List<Car> DeleteProduct(List<Car> car, List<Candy> candy, List<Pipe> pipe, List<Oatmeal> oatmeal)
        // {
        //     int userCategoryChoice = 0;
        //     while (userCategoryChoice == 0)
        //     {
        //         Console.Clear();
        //         Console.WriteLine("Vilken kategori?");
        //         Console.WriteLine("[1] Bilar");
        //         Console.WriteLine("[2] Godis");
        //         Console.WriteLine("[3] Rör]");
        //         Console.WriteLine("[4] Havremjölk");
        //         Console.WriteLine("[5] Klar/Återgå");
        //         Console.WriteLine("\nGör ett sifferval: ");

        //         try
        //         {
        //             userCategoryChoice = Convert.ToInt32(Console.ReadLine());
        //             if (userCategoryChoice == 1)
        //             {
        //                 int index = 0;
        //                 int userCarChoice;
        //                 Console.Clear();
        //                 Console.WriteLine("\nBilar:");
        //                 foreach (Car item in car)
        //                 {
        //                     Console.WriteLine($"Nummer:[{index}] Typ:{item.TypeCar} Färg:{item.ColorCar}");
        //                     index++;
        //                 }
        //                 Console.WriteLine("Välj bilens nummer: ");
        //                 userCarChoice = Convert.ToInt32(Console.ReadLine());
        //                 car.RemoveAt(userCarChoice);
        //                 userCategoryChoice = 0;
        //             }
        //             if (userCategoryChoice == 2)
        //             {
        //                 Console.WriteLine("\nGodis:");
        //                 foreach (Candy item in candy)
        //                 {
        //                     Console.WriteLine($"{item.TypeCandy} {item.AmountCandy}");
        //                 }
        //             }
        //             if (userCategoryChoice == 3)
        //             {
        //                 Console.WriteLine("\nRör:");
        //                 foreach (Pipe item in pipe)
        //                 {
        //                     Console.WriteLine($"{item.Material} {item.Length}");
        //                 }
        //             }
        //             if (userCategoryChoice == 4)
        //             {
        //                 Console.WriteLine("\nHavremjölk:");
        //                 foreach (Oatmeal item in oatmeal)
        //                 {
        //                     Console.WriteLine($"{item.Amount} {item.Fat}");
        //                 }
        //             }
        //             if (userCategoryChoice == 5)
        //             {
        //                 break;
        //             }
        //         }
        //         catch (FormatException)
        //         {
        //             Console.WriteLine("Välj ett nummer mellan 1 och 4.");
        //             Console.ReadLine();
        //         }
        //         catch (OverflowException)
        //         {
        //             Console.WriteLine("Riiight. Välj ett nummer mellan 1 och 4.");
        //             Console.ReadLine();
        //         }
        //         catch (Exception masterFail)
        //         {
        //             Console.WriteLine("Ett oväntat fel inträffade: " + masterFail);
        //             Console.ReadLine();
        //         }
        //     }
        // }

        static public void ChangeProduct()
        {
            Console.WriteLine("It werks.");
            Console.ReadLine();
        }
    }
}
