using System;
namespace Multifabriken
{
    public class OatMilk : Product
    {
        public double Size { get; set; }

        public double FatRatio { get; set; }

        public OatMilk()
        {
            string[] fatRatioStrings = new string[]{"0.5% fetthalt","1.0% fetthalt","1.5% fetthalt","4.0% fetthalt"};
            double[] fatRatio = new double[]{0.5, 1.0, 1.5, 4.0,15,20};
            string[] sizeStrings = new string[]{"0.5 liter","1.0 liter","2.0 liter"};
            double[] sizes = new double[]{ 0.5, 1, 2};
            int fatIndex = Menu.DisplayMenu(fatRatioStrings,"");
            int sizeIndex = Menu.DisplayMenu(sizeStrings,"");
            Size = sizes[sizeIndex];
            FatRatio = fatRatio[fatIndex];
            Name = Size + " liter havremjölk med " + FatRatio + "% fetthalt";
            Price = Convert.ToDecimal(15 * Size);
        }
    }
}