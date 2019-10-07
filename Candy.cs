using System;
using System.Collections.Generic;
namespace Multifabriken
{
    class Candy
    {
       private string typeCandy;
       public string TypeCandy
       {
           get { return typeCandy; }
           set { typeCandy = value; }
       }

       private int amountCandy;
       public int AmountCandy
       {
           get { return amountCandy; }
           set { amountCandy = value; }
       }
       
       
       
       public Candy (string inputTypeCandy,int inputAmountCandy)
       {
           this.typeCandy=inputTypeCandy;
           this.amountCandy=inputAmountCandy;
       }

        //Lista med smakerna som är tillgängliga
        public static List <string> ListofFlavs()
        {
                        List<string> menuFlavCandy= new List<string>
                        {
                        "Typ 1",  
                        "Typ 2",
                        "Typ 3",
                        "Typ 4"

                        };
                        return menuFlavCandy;
        }

    }
}