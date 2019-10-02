using System;

namespace Multifabriken
{
    class Program
    {
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

                    } else if(answerProdukt=='3'){

                    } else if (answerProdukt=='4'){

                    } else if(answerProdukt=='q'||answerProdukt=='Q'){
                        
                    }


                } else if(answer=='2'){

                }else if(answer=='3'){
                    break;
                }
            }
        }
    }
}
