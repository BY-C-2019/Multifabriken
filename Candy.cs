using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Candy
    {
        string[] CandyChoises = {"Hallon", "Lakrits", "Päron", "Jordgubbe"};
        string ChosenCandy = "Inte godis";
        int CandyAmount = 0;

        public void CandyMenu()
        {
            bool getingType = true;
            bool getingAmount = true;
            int InputCandy = 5;
           
            //Här väljer man godistyp
            while(getingType == true)
            {
                Console.WriteLine("Vilket godis vill du ha? \n \n[1]Hallon \n[2]Lakrits \n[3]Päron \n[4]Jordgubbe");
                try
                {

                    InputCandy = Convert.ToInt32(Console.ReadLine());

                        switch(InputCandy)
                        {
                            case 1:
                                    ChosenCandy = CandyChoises[0];
                                    getingType = false;
                                    break;
                            case 2:
                                    ChosenCandy = CandyChoises[1];
                                    getingType = false;
                                    break;
                            case 3:
                                    ChosenCandy = CandyChoises[2];
                                    getingType = false;
                                    break;
                            case 4:
                                    ChosenCandy = CandyChoises[3];
                                    getingType = false;
                                    break;
                        }
                        
                }
                catch
                    {
                        Console.WriteLine("Du kan endast välja mellan sorterna Hallon, Lakrits, Päron, Jordgubbe\n");
                    }
            }
            //Här anges mängden kg av de valda godiset
            while(getingAmount == true)
            {
                Console.WriteLine("Hur många kg " + ChosenCandy + " vill du ha?");
                try{
                CandyAmount = Convert.ToInt32(Console.ReadLine());

                if(CandyAmount >= 1)
                    {
                        getingAmount = false;
                    }
                }
                catch{
                    Console.WriteLine("Du kan endast köpa hela kg!");
                }
            }
        }
        //I denna funktion läggs valet av godis och mängden godis ihop till en string som går att sedan lägga in i listan myCart i Program.cs 
        public void AddToCart(List<string> listToAddProduct)
        {
         listToAddProduct.Add(CandyAmount + " kg "+ ChosenCandy);  
        }
    }
}
