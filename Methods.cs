using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    class Methods

    {
        //Menyvalen som gäller produkten bil
        static public Methods MenuOptionCars()
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
                Methods car = new Methods();
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

                public static void DeleteProduct() 
                {
                    Console.WriteLine("Vilken produkt vill du ta bort?");
                    Console.WriteLine("Gör ett sifferval: ");
                    Console.ReadLine();

                }

                public static void ChangeProduct() 
                {
                    Console.WriteLine("It werks.");
                    Console.ReadLine();
                }

    }
}
