namespace Multifabriken
{
    public class Pipe
    {
        private string material;
        private int length;
        private int diameter;

        public string Material
        {
            get 
            {
                return material;
            }
            set 
            {
                material = value;
            }
        }
        public int Length 
        {
            get 
            {
                return length;
            }
            set 
            {
                length = value;
            }
        }

        public Pipe(string material, int length, int diameter) 
        {
            this.material = material;
            this.length = length;
            this.diameter = diameter;
        }
    }
}