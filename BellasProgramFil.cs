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
                                orderListCar.Add(MenuOptionCars());
                                //order.AddToOrderList(MenuOptionCars());
                                break;

                            case "2":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa godis metod**");
                                orderListCandy.Add(MenuOptionCandy());
                                //order.OrderList.Add(MenuOptionCandy());
                                break;

                            case "3":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa rör metod**");
                                orderListPipe.Add(MenuOptionPipes());
                                break;

                            case "4":
                                Console.Clear();
                                System.Console.WriteLine("**Anropa havre metod");
                                orderListOatmeal.Add(MenuOptionOatmeal());
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
                                //if (selection == 1) { DeleteProduct(order.OrderList); }
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
                        foreach (Car car in orderListCar) 
                        {
                            Console.WriteLine("[Beställt] - Bil: {0} || Färg: {1} || Inredning: {2}",car.TypeCar,car.ColorCar,car.InteriorCar);
                            
                        }
                        foreach (Candy candy in orderListCandy) 
                        {
                            Console.WriteLine("[Beställt] - Godissort: {0} || Mängd(g): {1}",candy.TypeCandy,candy.AmountCandy);
                        }
                        foreach(Pipe pipe in orderListPipe)
                        {
                            System.Console.WriteLine("[Beställt] - Rör: Material: {0} || Längd(cm): {1} || Diameter(mm): {2}",pipe.Material,pipe.Length,pipe.Diameter);
                        }
                        foreach(Oatmeal oatmeal in orderListOatmeal)
                        {
                            System.Console.WriteLine("[Beställt] - Havremjölk: Fetthalt(%): {0} || Mängd(L): {1}", oatmeal.Fat, oatmeal.Amount);
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
                bool loop = true;
                string inputInterior = "";

                //Bilval
                Console.Clear();
                Car.Cartype().ForEach(System.Console.WriteLine);// genväg för att skriva ut en foreachloop
                Console.WriteLine("\nAnge vilken typ av bil: ");
                type = Console.ReadLine();
                type= type.ToUpper();

                //färgval
                Console.Clear();
                Car.Carcolor().ForEach(System.Console.WriteLine); // genväg för att skriva ut en foreachloop
                Console.WriteLine("\nAnge vilken färg du vill ha på bilen: ");
                color = Console.ReadLine();

                //En loop som ser till att användaren väljer ett av de valen som finns
                while (loop == true)
                {
                    Console.WriteLine("Vill du ha [S]tandard inredning eller [L]yx-inredning?");
                    inputInterior = Console.ReadLine();
                    inputInterior = inputInterior.ToUpper();


                    if (inputInterior == "S")
                    {
                        loop = false;
                        inputInterior = "Standard";
                    }
                    else if (inputInterior == "L")
                    {
                        loop = false;
                        inputInterior = "Lyx";
                    }
                    else
                    {
                        System.Console.WriteLine("Fel inmantning");
                    }
                }
                // SKriver ut vad man har lagt till i sin beställning.
                System.Console.WriteLine($"Du har lagt till en {type} av färgen {color} och inredningspaketet du valde var: {inputInterior} \n");
                Car car = new Car(type, color, inputInterior);
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
                        
                        //Val av smak
                        Console.Clear();
                        Candy.ListofFlavs().ForEach(System.Console.WriteLine);// genväg för att skriva ut en foreachloop
                        Console.Write("Ange vilken smak på godiset: ");
                        flavour = Console.ReadLine();
                        
                        //Loop för att se till att användaren beställer rätt mängd godis.
                        Console.Write("Ange mängd du vill köpa (minst 1000g): ");
                        while(loop==false)
                        {
                        try
                        {
                        weight = Convert.ToInt32(Console.ReadLine());
                        if (weight > 999)
                        {
                        loop = true;
                        }

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
                    bool loopLength=true; // osäker på om man behöver en bool för varje loop -GW
                    bool loopDiameter=true;// eller om man kan får till det så att samma bool gäller i båda valen? -GW

                    Console.Clear();
                    Pipe.ListofTypes().ForEach(System.Console.WriteLine);// genväg för att skriva ut en foreachloop

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

                    System.Console.WriteLine($"Du har lagt till ett rör av {material} av längden {length}cm och den har diametern {diameter}mm \n");
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
                        Console.WriteLine();
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
