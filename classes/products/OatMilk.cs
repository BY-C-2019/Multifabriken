using System;
namespace Multifabriken
{
    public class OatMilk : Product
    {
        public double Size { get; set; }

        public double FatRatio { get; set; }

        OatMilk() : base()
        {
            string[] fatRatio = new string[]{"0.5","1.0","1.5","4"};
            string[] size = new string[]{"0.5","1","2"};
            FatRatio = Convert.ToDouble(Menu.DisplayMenu(fatRatio,""));
            Size = Convert.ToDouble(Menu.DisplayMenu(size,""));

        }
    }
}