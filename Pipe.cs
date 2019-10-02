using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Pipe
    {
        private string materialType;
        private int diameter;
        private int length;
        bool loop = true;
        string[] availableTypes = { "Plast", "Betong", "Stål" };

        //Metod som ska anropas från Main
        //Enbart till för tydlighet så inte all kod ligger i samma metod
        public bool OrderPipe()
        {
            ChoosePipeType();
            ChooseDiameter();
            ChooseLength();

            while (loop)
            {
                Console.WriteLine("Typ: " + materialType);
                Console.WriteLine("Diameter: " + diameter + " millimeter");
                Console.WriteLine("Längd: " + length + " meter");
                Console.Write("Vill du lägga till i kundvagn? Ja/Nej: ");
                string WannaAddToCart = Console.ReadLine();
                WannaAddToCart = WannaAddToCart.ToUpper();

                //Returnerar true/false till Main ifall ordern ska läggas till i kundvagnen
                if (WannaAddToCart == "JA")
                {
                    loop = false;
                    Console.WriteLine("Din rörorder har lagts till i din kundvagn!");
                    return true;
                }
                else if (WannaAddToCart == "NEJ")
                {
                    loop = false;
                    Console.WriteLine("Du valde att inte lägga till något i kundvagen.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Endast Ja eller Nej");
                }
            }
            return false;

        }
        //Låter kunden välja typ av rör
        public void ChoosePipeType()
        {
            Console.WriteLine("Rörtyper som finns att beställa: ");
            for (int i = 0; i < availableTypes.Length; i++)
            {
                Console.WriteLine("[" + (i) + "] " + availableTypes[i]);
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
            }
            Console.WriteLine("Du har valt rör av typen " + materialType + ".");
            Console.ReadLine();
        }
        //När kunden valt rörtyp får hen välja diametern på röret
        public void ChooseDiameter()
        {
            Console.Write("Vilken diameter i millimeter ska " + materialType + "röret ha? ");
            diameter = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        //Efter att rörtyp och diameter valts väljer kunden hur många meter rör hen vill beställa
        public void ChooseLength()
        {
            Console.WriteLine("Hur många meter rör vill du beställa?");
            length = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        //Metod för att addera string med beställning till lista
        public void AddToCart(List<string> pipeToAddToList)
        {
            pipeToAddToList.Add("Typ: " + materialType + ". Diameter : " + diameter + "mm. Längd: " + length + " meter.");
        }
    }
}
