using System;

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

        

    }
}