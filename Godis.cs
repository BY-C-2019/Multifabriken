namespace Multifabriken
{
    class Godis
    {
        private string vikt = "";
        private string smak = "";

        public string Vikt
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