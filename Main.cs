using System;

namespace Multifabriken
{
    class Program
    {
            //Bool för att köra while-loopen(menyn)
            public static bool menyRun=true;
            //En bool för varje produkt som är för att veta vad som ska skrivas ut i kassan
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
            while(menyRun)
            {
                //Rensar bort allt innan man kommer till menyn
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Tryck på enter för att komma till menyn");
                Console.WriteLine("------------------------------------------");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("[1]Lägg till vara");
                Console.WriteLine("[2]Gå till kassan");
                Console.WriteLine("[3]Avsluta");
                //Try och catch finns vid varje inmatning så att det inte går att skriva fel
                try{
                char answer=Convert.ToChar(Console.ReadLine());
                
                //Meny för att lägga till saker. Hämtar sedan data från metoder nedan
                if(answer=='1'){
                    Console.Clear();
                    Console.WriteLine("[1]Bil");
                    Console.WriteLine("[2]Godis");
                    Console.WriteLine("[3]Rör");
                    Console.WriteLine("[4]Havemjölk");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Välj vara eller tryck [Q] för att komma tillbaka till menyn.");
                    char answerProdukt=Convert.ToChar(Console.ReadLine());

                    if(answerProdukt=='1'){
                        Console.Clear();
                        Car();
                    } else if (answerProdukt=='2'){
                        Console.Clear();
                        CandyList();
                    } else if(answerProdukt=='3'){
                        Console.Clear();
                        Pipes();
                    } else if (answerProdukt=='4'){
                        Console.Clear();
                        OatMilk();
                    } else if(answerProdukt=='q'||answerProdukt=='Q'){
                        
                    }

                } else if(answer=='2'){
                    Console.Clear();
                    Cart();
                }else if(answer=='3'){
                    break;
                }else{
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Felinmatning! Ange 1-3 med siffror.");
                    Console.WriteLine("---------------------------------------");
                }
                }catch{
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Felinmatning! Ange 1-3 med siffror.");
                    Console.WriteLine("---------------------------------------");
                }
            }
        } 
        //Metod för godis
        public static void CandyList()
        {
            Console.WriteLine("Våra olika godissorter!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1]Choklad");
            Console.WriteLine("[2]Lakrits");
            Console.WriteLine("[3]Surt");
            Console.WriteLine("[4]Salt");
            Console.WriteLine("[5]Blandat");
            Console.WriteLine("---------------------------");
            Console.Write("Välj godissort:");
            try{
            char candy=Convert.ToChar(Console.ReadLine());
            
            //Skickar inmatningen till klassen Candy
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
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange 1-5 med siffror!");
                Console.WriteLine("---------------------------------------");
                return; //Har en return vid varje catch så att man inte får skriva vidare i metoden
            }
            Console.Write("Välj antal kg du vill ha:");
            double weight=Convert.ToDouble(Console.ReadLine());
            try{
            myCandy.Weight=weight;
            }catch{
                Console.WriteLine("Du måste ange med siffror!");
            }
            //Gör boolen till true så att den kommer skrivas ut i orderlistan
            //Skriver den längst ner så den bara blir true om man går igenom alla steg.
            //Så den inte sparas som true om någon skriver fel så catchen slår in.
            candyItem=true;
        }
        public static void Pipes()
        {
            Console.WriteLine("Våra material på rör!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1]Plast");
            Console.WriteLine("[2]Stål");
            Console.WriteLine("[3]Betong");
            Console.WriteLine("---------------------------");
            Console.Write("Ange vilket material du vill ha på rören:");
            try{
            char material=Convert.ToChar(Console.ReadLine());
            
            if(material=='1'){
                myPipe.Material="Plast";
            } else if(material=='2'){
                myPipe.Material="Stål";
            } else if(material=='3'){
                myPipe.Material="Betong";
            } else {
                Console.WriteLine("Felinmatning!\nAnge en siffra mellan 1-3.");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Felinmatning!\nAnge en siffra mellan 1-3.");
                Console.WriteLine("---------------------------------------");
                return;
            }

            Console.Write("Ange längd i meter:");
            double lenght=Convert.ToDouble(Console.ReadLine());
            try{
            myPipe.Lenght=lenght;
            }catch{
                Console.WriteLine("Du måste ange med siffror!");
                return;
            }

            Console.Write("Ange diameter du vill ha på rören (cm):");
            double diameter=Convert.ToDouble(Console.ReadLine());
            try{
            myPipe.Diameter=diameter;
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange med siffror!");
                Console.WriteLine("---------------------------------------");
                return;
            }
            pipeItem=true;
        }
        public static void Car()
        {
            Console.WriteLine("Våra olika märken");
            Console.WriteLine("[1] Volvo");
            Console.WriteLine("[2]BMW");
            Console.WriteLine("[3]Audi");
            try{
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
            else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange en siffra mellan 1-3!");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange 1-3 med siffror!");
                Console.WriteLine("---------------------------------------");
                return;
            }
            
            Console.WriteLine("Våra olika färger: ");
            Console.WriteLine("[1]Svart");
            Console.WriteLine("[2]Vit");
            Console.WriteLine("[3]Blå");
            try{
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
            else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange en siffra mellan 1-3!");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange 1-3 med siffror!");
                Console.WriteLine("---------------------------------------");
                return;
            }
            Console.WriteLine("Vill du lägga till lyxinredning? j/n");
            char carInterior = Convert.ToChar(Console.ReadLine());
            try{
            if(carInterior == 'j' || carInterior == 'J')
            {
                myCar.LyxInredning = "Ja";
            }
            else if (carInterior == 'N' || carInterior == 'n')
            {
                myCar.LyxInredning = "Nej";
            }else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange J eller N!");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange J eller N!");
                Console.WriteLine("---------------------------------------");
                return;
            }
            carItem = true;
        }
        public static void OatMilk()
        {
            Console.WriteLine("Våra fetthalter");
            Console.WriteLine("[1]2%");
            Console.WriteLine("[2]6%");
            Console.WriteLine("[3]11%");
            try{
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
            }else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste en siffra mellan 1-3!");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange 1-3 med siffror!");
                Console.WriteLine("---------------------------------------");
                return;
            }

            Console.WriteLine("Hur många liter vill du beställa?");
            Console.WriteLine("[1]0.5 liter");
            Console.WriteLine("[2]1 liter");
            Console.WriteLine("[3]2 liter");
            try{
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
            }else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange en siffra mellan 1-3!");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Du måste ange 1-3 med siffror!");
                Console.WriteLine("---------------------------------------");
                return;
            }
            oatMilkItem=true;
        }
        public static void Cart()
        {
            Console.Clear();
            Console.WriteLine("Din orderlista:");

            //Olika if som skriver ut info om produkten om den har lagts till(då boolen blir true)
            if(candyItem==true){
                myCandy.InfoCandy();
            }
            if(pipeItem==true){
                myPipe.InfoPipe();
            }
            if(carItem==true){
                myCar.InfoCar();
            }
            if(oatMilkItem==true){
                myOatMilk.OatMilkInfo();
            }
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("[1]Ta bort något från orderlistan");
            Console.WriteLine("[2]Lägg till något i orderlistan");
            Console.WriteLine("[3]Skicka beställning");
            try{
            char answer=Convert.ToChar(Console.ReadLine());
            
            if(answer=='1'){
                Console.Clear();
                Console.WriteLine("Välj vilken kategori du vill ta bort något ifrån:");
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
                
                //Hämtar en metod från produktens klass som sedan låter användaren ta bort en index
                if(input=='1'){
                    myCandy.ItemCandy();
                } else if(input=='2'){
                    myPipe.ItemPipe();
                } else if(input=='3'){
                    myCar.ItemCar();
                } else if (input=='4'){
                    myOatMilk.OatMilkItem();
                } else if(input=='q'||input=='Q'){ 

                } else {
                    Console.WriteLine("Felinmatning! \nDu måste ange en siffra mellan 1-4.");
                }
            
            
            } else if(answer=='2'){
                //Återvänder till menyn
                return;
            } else if(answer=='3'){
                //Avslutar hela programmet
                menyRun=false;
            } else{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Felinmatning! \nDu måste ange en siffra mellan 1-3.");
                Console.WriteLine("---------------------------------------");
            }
            }catch{
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Felinmatning! \nDu måste ange en siffra mellan 1-3.");
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
