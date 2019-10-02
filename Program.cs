using System;

namespace Multifabriken
{
    class Program
    {
        public static OatMilk myOatMilk = new OatMilk();
        public static Car myCar = new Car();

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("[1]Lägg till vara");
                Console.WriteLine("[2]Gå till kassan");
                Console.WriteLine("[3]Avsluta");
                char answer=Convert.ToChar(Console.ReadLine());

                if(answer=='1'){
                    Console.WriteLine("[1]Bil");
                    Console.WriteLine("[2]Godis");
                    Console.WriteLine("[3]Rör");
                    Console.WriteLine("[4]Havemjölk");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Välj vara eller tryck [Q] för att komma tillbaka till menyn.");
                    char answerProdukt=Convert.ToChar(Console.ReadLine());

                    if(answerProdukt=='1'){
                        Car();
                    } else if (answerProdukt=='2'){

                    } else if(answerProdukt=='3'){

                    } else if (answerProdukt=='4'){
                        OatMilk();
                    } else if(answerProdukt=='q'||answerProdukt=='Q'){
                        
                    }

                } else if(answer=='2'){

                }else if(answer=='3'){
                    break;
                }
            
            }
        }
        public static void Car()
        {
            //carItem = true;
            Console.WriteLine("Våra olika märken");
            Console.WriteLine("[1] Volvo");
            Console.WriteLine("[2]BMW");
            Console.WriteLine("[3]Audi");
            char carModel=Convert.ToChar(Console.ReadLine());
            if(carModel == '1')
            {
                myCar.Model = "Volvo";
            }
            else if(carModel == '2')
            {
                myCar.Model = "BMW";
            }
            else if(carModel == '3')
            {
                myCar.Model = "Audi";
            }
            
            Console.WriteLine("Våra olika färger: ");
            Console.WriteLine("[1]Svart");
            Console.WriteLine("[2]Vit");
            Console.WriteLine("[3]Blå");
            char carColor=Convert.ToChar(Console.ReadLine());
            if(carColor == '1')
            {
                myCar.Color = "Svart";
            }
            else if(carColor == '2')
            {
                myCar.Color = "Vit";
            }
            else if(carColor == '3')
            {
                myCar.Color = "Blå";
            }
            Console.WriteLine("Vill du lägga till lyxinredning? j/n");
            char carInterior = Convert.ToChar(Console.ReadLine());
            if(carInterior == 'j' || carInterior == 'J')
            {
                myCar.LyxInredning = "Ja";
            }
            else if (carInterior == 'n' || carInterior == 'N')
            {
                myCar.LyxInredning = "Nej";
            }
        }
        public static void OatMilk()
        {
            Console.WriteLine("Våra fetthalter");
            Console.WriteLine("[1]2%");
            Console.WriteLine("[2]6%");
            Console.WriteLine("[3]11%");
            char oatMilkFat = Convert.ToChar(Console.ReadLine());
            if(oatMilkFat == '1')
            {
                myOatMilk.Fat = 2;
            }
            else if(oatMilkFat == '2')
            {
                myOatMilk.Fat = 6;
            }
            else if(oatMilkFat == '3')
            {
                myOatMilk.Fat = 11;
            }
            Console.WriteLine("Hur många liter vill du beställa?");
            Console.WriteLine("[1]0.5 liter");
            Console.WriteLine("[2]1 liter");
            Console.WriteLine("[3]2 liter");
            char oatMilkLitres = Convert.ToChar(Console.ReadLine());
            if(oatMilkLitres == '1')
            {
                myOatMilk.Litres = 0.5;
            }
            else if(oatMilkLitres == '2')
            {
                myOatMilk.Litres = 1;
            }
            else if(oatMilkLitres == '3')
            {
                myOatMilk.Litres = 2;
            }
        }
    }
}
