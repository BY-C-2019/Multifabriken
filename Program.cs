using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runMenu = true;
            Order order = new Order();

            while (runMenu)
            {

                System.Console.WriteLine("[1] Skapa beställning:");
                System.Console.WriteLine("[2] Ändra beställning:");
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
                                System.Console.WriteLine("**Anropa bil metod**");
                                order.OrderList.Add(MenuOptionCars());
                                break;

                            case "2":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa godis metod**");
                                order.OrderList.Add(MenuOptionCandy());
                                break;

                            case "3":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa rör metod**");
                                order.OrderList.Add(MenuOptionPipes());
                                break;

                            case "4":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa havre metod");
                                order.OrderList.Add(MenuOptionOatmeal());
                                break;
                        }
                        break;


                    case "2":
                        int selection = 0;
                        while (selection == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("[1] Ta bort produkt: ");
                            Console.WriteLine("[2] Ändra produkt: ");
                            Console.Write("\nSkriv in val: ");
                            try
                            {
                                selection = Convert.ToInt32(Console.ReadLine());
                                if (selection == 1) { DeleteProduct(order.OrderList); }
                                if (selection == 2) { ChangeProduct(); }
                                else 
                                {
                                    throw new FormatException();
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Skriv in en siffra. 1 eller 2.");
                                Console.ReadLine();
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Okeeej. Skriv in en siffra mellan 1 eller 2.");
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ett oväntat fel inträffade: " + e);
                            }
                        }
                        break;

                    case "3":
                        Console.Clear();
                        System.Console.WriteLine("Tryck på valfri tangent för att skicka offert...");
                        Console.ReadKey();
                        System.Console.WriteLine("Offert inskickad.");
                        break;

                    case "4":
                        runMenu = false;
                        Console.Clear();
                        foreach (Car car in order.OrderList)
                        {
                            Console.WriteLine(car.TypeCar);
                            Console.WriteLine(car.ColorCar);
                            Console.WriteLine(car.InteriorCar);
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
                Car car = new Car(color, type, interior);
                return car;
            }
        }
        //Menyval ang. Godis
        static public Candy MenuOptionCandy()
                {
                    {
                        string flavour = "";
                        int weight = 0;
                        bool loop=false;

                        Console.Write("Ange vilken typ av godis: ");
                        flavour = Console.ReadLine();

                        while(loop==false| weight >=1000)
                        {
                        Console.Write("Ange mängd du vill köpa (minst 1000g): ");
                        try
                        {
                        weight = Convert.ToInt32(Console.ReadLine());
                        loop=true;
                        }
                        catch
                        {
                            System.Console.WriteLine("Ange endast nummer, minst 1000g.");
                            loop=false;
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
                    
                    string material="";;
                    int length=0;
                    int diameter=0;
                    bool loopLength=true; // osäker på om man behöver en bool för varje loop 
                    bool loopDiameter=true;// eller om man kan får till det så att samma bool gäller i båda valen?

                    Console.Write("Välj material: ");
                    material = Console.ReadLine();
                    while(loopLength==true)
                    {
                    Console.Write("Välj längd, ange i centimeter: ");
                    try
                    {
                        length = Convert.ToInt32(Console.ReadLine());
                        loopLength= false;
                    }
                    catch
                    {
                        System.Console.WriteLine("Ange hela centimeter, Ange endast siffror.");
                        loopLength=true;
                    }
                    }

                    while(loopDiameter ==true)
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
                        loopDiameter= true;
                    }
                    }

                    System.Console.WriteLine($"Du har lagt till ett rör av {material} av längden {length} och den har diametern {diameter} \n");
                    Pipe pipe = new Pipe(material, length, diameter);
                    return pipe;
                }

                //Menyval gällande Havremjölk
                static public Oatmeal MenuOptionOatmeal()
                {
                    int fat=0;
                    int amount=0;
                    bool loopFat = true;
                    bool loopAmount= true;

                    while(loopFat==true)
                    {
                    Console.Write("Välj fetthalt; 2-11%: ");
                    try
                    {
                        fat = Convert.ToInt32(Console.ReadLine());
                        if (fat >=2 & fat <=11)
                        {
                        loopFat= false;
                        }
                        else
                        {
                        System.Console.WriteLine("Ange endast siffror mellan 2 och 11.");
                        }
                    }
                    catch
                    {
                        System.Console.WriteLine("Ange endast siffror mellan 2 och 11.");
                        loopFat=true;
                    }
                    }
                    
                     while(loopAmount==true)
                    {
                    Console.Write("Välj mängd, ange endast hela liter: ");
                    try
                    {
                        amount = Convert.ToInt32(Console.ReadLine());
                        loopAmount= false;
                    }
                    catch
                    {
                        System.Console.WriteLine("Ange hela liter, Ange endast siffror.");
                        loopAmount=true;
                    }
                    }

                    System.Console.WriteLine($"Du har lagt till {amount} liter Havremjölk med fetthalten {fat}% \n");
                    Oatmeal oatmeal = new Oatmeal(fat, amount);
                    return oatmeal;
                }

                static public void DeleteProduct(List<object> order) 
                {
                    Console.WriteLine("Vilken produkt vill du ta bort?");
                    Console.WriteLine("Gör ett sifferval: ");
                    foreach (List<object> item in order) 
                    {

                    }
                    Console.ReadLine();

                }

                static public void ChangeProduct() 
                {
                    Console.WriteLine("It werks.");
                    Console.ReadLine();
                }
    }
}
