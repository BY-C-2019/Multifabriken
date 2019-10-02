namespace Multifabriken
{
    class Godis
    {
        private int vikt;
        private string smak = "";

        public int Vikt
        {
            get 
            {
                return vikt;
            }
            set
            {
                vikt = value;
            }
        }
        public string Smak
        {
            get
            {
                return smak;
            }
            set
            {
                smak = value;
            }
        }
    }
}