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

                    } else if (answerProdukt=='2'){
                        CandyList();
                    } else if(answerProdukt=='3'){
                        Pipes();
                    } else if (answerProdukt=='4'){

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
