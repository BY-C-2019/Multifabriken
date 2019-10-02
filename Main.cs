using System;

namespace Multifabriken
{
    class Program
    {
            public static bool candyItem=false;
            public static bool pipeItem=false;
            public static bool carItem=false;
            public static bool oatMilkItem=false;

            public static Candy myCandy=new Candy();
            public static Pipes myPipe=new Pipes();
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
                        CandyList();
                    } else if(answerProdukt=='3'){
                        Pipes();
                    } else if (answerProdukt=='4'){
                        OatMilk();
                    } else if(answerProdukt=='q'||answerProdukt=='Q'){
                        
                    }


                } else if(answer=='2'){
                    Cart();
                }else if(answer=='3'){
                    break;
                }
            }
        } 
        public static void CandyList()
        {
            candyItem=true;

            Console.WriteLine("Våra olika godissorter!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1]Choklad");
            Console.WriteLine("[2]Lakrits");
            Console.WriteLine("[3]Surt");
            Console.WriteLine("[4]Salt");
            Console.WriteLine("[5]Blandat");
            Console.WriteLine("---------------------------");
            Console.Write("Välj godissort:");
            char candy=Convert.ToChar(Console.ReadLine());
            
            if(candy=='1'){
            myCandy.CandyVarieties="Choklad";
            } else if(candy=='2'){
            myCandy.CandyVarieties="Lakrits";
            } else if(candy=='3'){
            myCandy.CandyVarieties="Surt godis";
            } else if(candy=='4'){
            myCandy.CandyVarieties="Salt godis";
            } else if(candy=='5'){
            myCandy.CandyVarieties="Blandat";
            } else {
                Console.WriteLine("Felinmatning!\nAnge en siffra mellan 1-5.");
            }
            Console.Write("Välj antal kg du vill ha:");
            double weight=Convert.ToDouble(Console.ReadLine());
            myCandy.Weight=weight;

        }
        public static void Pipes()
        {
            pipeItem=true;

            Console.WriteLine("Våra material på rör!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1]Plast");
            Console.WriteLine("[2]Stål");
            Console.WriteLine("[3]Betong");
            Console.WriteLine("---------------------------");
            Console.Write("Ange vilket material du vill ha på rören");
            char material=Convert.ToChar(Console.ReadLine());
            
            if(material=='1'){
                myPipe.Material="Plast";
            } else if(material=='2'){
                myPipe.Material="Stål";
            } else if(material==3){
                myPipe.Material="Betong";
            } else {
                Console.WriteLine("Felinmatning!\nAnge en siffra mellan 1-3.");
            }

            Console.Write("Ange längd i meter:");
            double lenght=Convert.ToDouble(Console.ReadLine());
            myPipe.Lenght=lenght;

            Console.Write("Ange diameter du vill ha på rören:");
            double diameter=Convert.ToDouble(Console.ReadLine());
            myPipe.Diameter=diameter;


        }
        public static void Car()
        {
            carItem = true;
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
            oatMilkItem=true;
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
        public static void Cart()
        {
            Console.WriteLine("Din orderlista:");

            if(candyItem==true){
                myCandy.InfoCandy();
            }
            if(pipeItem==true){
                myPipe.InfoPipe();
            }
            if(candyItem==true){
                //myCar.InfoCar();
            }
            if(oatMilkItem==true){
                //myOatMilk.InfoOatMilk();
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("[1]Ta bort något från orderlistan");
            Console.WriteLine("[2]Lägg till något i orderlistan");
            Console.WriteLine("[3]Skicka beställning");
            char answer=Convert.ToChar(Console.ReadLine());

            if(answer=='1'){
                Console.Write("Välj vilken kategori du vill ta bort något ifrån:");
                if(candyItem==true){
                    Console.WriteLine("[1]Godis");
                }
                if(pipeItem==true){
                    Console.WriteLine("[2]Rör");
                }
                if(carItem==true){
                    Console.WriteLine("[3]Bil");
                }
                if(oatMilkItem==true){
                    Console.WriteLine("[4]Havemjölk");
                }
                Console.WriteLine("Tryck på [Q] för att återvända till menyn.");
                char input=Convert.ToChar(Console.ReadLine());

                if(input=='1'){
                    myCandy.ItemCandy();
                } else if(input=='2'){
                    myPipe.ItemPipe();
                } else if(input=='3'){

                } else if (input=='4'){

                } else if(input=='q'||input=='Q'){ 

                } else {
                    Console.WriteLine("Felinmatning! \nDu måste ange en siffra mellan 1-4.");
                }
            } else if(answer=='2'){
            
            } else if(answer=='3'){
                return;
            } else{
                Console.WriteLine("Felinmatning! \nDu måste ange en siffra mellan 1-3.");
            }


        }
    }
}
