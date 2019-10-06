using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Pipe
    {
        private string materialType;
        private int diameter;
        private int length;
        private int input;
        bool loop = false;
        string[] availableTypes = { "Plast", "Betong", "Stål" };

        //Metod som ska anropas från Main
        //Till för tydlighet så inte all kod ligger i samma metod
        public bool OrderPipe()
        {
            ChoosePipeType();
            ChooseDiameter();
            ChooseLength();

            do
            {
                loop = false;

                try
                {
                    Console.WriteLine("Typ: " + materialType);
                    Console.WriteLine("Diameter: " + diameter + " millimeter");
                    Console.WriteLine("Längd: " + length + " meter");
                    Console.Write("Vill du lägga till i kundvagn? Ja/Nej: ");
                    string addToCartInput = Console.ReadLine();
                    addToCartInput = addToCartInput.ToUpper();

                    //Returnerar true/false till Main ifall ordern ska läggas till i kundvagnen
                    if (addToCartInput[0] == 'J')
                    {
                        Console.WriteLine("Din rörorder har lagts till i din kundvagn!");
                        Console.ReadLine();
                        return true;
                    }
                    else if (addToCartInput[0] == 'N')
                    {
                        Console.WriteLine("Du valde att inte lägga till något i kundvagen.");
                        Console.ReadLine();
                        return false;
                    }
                    else
                    {
                        loop = true;
                        Console.WriteLine("Programmet accepterar bara Ja eller Nej som svar");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    loop = true;
                    Console.WriteLine("Programmet accepterar bara Ja eller Nej som svar");
                    Console.ReadLine();
                }
            }
            while (loop);

            return false;

        }
        //Låter kunden välja typ av rör
        public void ChoosePipeType()
        {
            do
            {
                loop = false;

                try
                {
                    Console.WriteLine("Rörtyper som finns att beställa: ");
                    for (int i = 0; i < availableTypes.Length; i++)
                    {
                        Console.WriteLine("[" + i + "] " + availableTypes[i]);
                    }

                    Console.Write("Välj typ: ");
                    int pipeTypeWanted = Convert.ToInt32(Console.ReadLine());

                    switch (pipeTypeWanted)
                    {
                        case 0:
                            materialType = availableTypes[pipeTypeWanted];
                            break;
                        case 1:
                            materialType = availableTypes[pipeTypeWanted];
                            break;
                        case 2:
                            materialType = availableTypes[pipeTypeWanted];
                            break;
                        default:
                            loop = true;
                            Console.WriteLine("Gör ett val mellan 0-2");
                            Console.ReadLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Endast heltal!");
                    Console.ReadLine();
                    loop = true;
                }
            }
            while (loop);

            Console.WriteLine("Du har valt rör av typen " + materialType + ".");
            Console.ReadLine();
        }
        //När kunden valt rörtyp får hen välja diametern på röret
        public void ChooseDiameter()
        {
            do
            {
                loop = false;

                try
                {
                    Console.Write("Vilken diameter i millimeter ska " + materialType + "röret ha? ");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input > 1)
                    {
                        diameter = input;
                    }

                    else if (input < 2)
                    {
                        loop = true;
                        Console.WriteLine("Diametern måste vara minst 2mm");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Felaktig inmatning. Endast siffror och det måste vara hela millimeter.");
                    Console.ReadLine();
                    loop = true;
                }
            }
            while (loop);
        }
        //Efter att rörtyp och diameter valts väljer kunden hur många meter rör hen vill beställa
        public void ChooseLength()
        {
            do
            {
                loop = false;

                try
                {
                    Console.WriteLine("Hur många meter rör vill du beställa?");
                    input = Convert.ToInt32(Console.ReadLine());
                    if(input >= 1)
                    {
                        length = input;
                    }
                    else if (input < 1)
                    {
                        loop = true;
                        Console.WriteLine("Du måste beställa minst en meter.");
                    }
                }
                catch
                {
                    loop = true;
                    Console.WriteLine("Endast siffror och hela meter!");
                    Console.ReadLine();
                }
            }
            while (loop);

            Console.ReadLine();
        }
        //Metod för att addera string med beställning till lista
        public void AddToCart(List<string> pipeToAddToList)
        {
            pipeToAddToList.Add("Typ av rör: " + materialType + ". Diameter : " + diameter + "mm. Längd: " + length + " meter.");
        }
    }
}
