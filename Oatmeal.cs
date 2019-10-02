namespace Multifabriken 
{
    public class Oatmeal 
    {
        private int fat;
        private int amount;

        public int Fat 
        {
            get 
            {
                return fat;
            }
            set 
            {
                fat = value;
            }
        }
        public float Amount 
        {
            get 
            {
                return amount;
            }
            set 
            {
                amount = value;
            }
        }
        public Oatmeal(int inputFat, int amount)  
        {
            this.fat = inputFat;
            this.amount = inputFat;
        }
    }
}