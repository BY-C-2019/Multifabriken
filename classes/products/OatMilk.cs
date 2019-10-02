using System;
namespace Multifabriken
{
    public class OatMilk : Product
    {
        public double Size { get; set; }

        public double FatRatio { get; set; }

        public OatMilk()
        {
            string[] fatRatioStrings = new string[]{"0.5% fetthalt","1.0% fetthalt","1.5% fetthalt","4.0% fetthalt","11.0% fetthalt"};
            double[] fatRatio = new double[]{0.5, 1.0, 1.5, 4.0, 11.0};
            FatRatio = fatRatio[Menu.DisplayMenu(fatRatioStrings,"Välj fetthalt:")];
            Name = "Havremjölk";
            Size = Menu.MenuForAmount("Hur många liter önskas? ", 30, false);
            Price = Convert.ToDecimal(15 * Size);
        }

        public override string ToString()
        {
            return $"{Name}, {Size} liter, Fetthalt {FatRatio}%. Pris: {Price} kr";
        }
    }
}