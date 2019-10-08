using System;
using Products;


namespace Milk
{
    class milk : products
    {
        public milk(int fatContent, int packageType)
        {
            // Fetthalt kan vara mellan 2 och 11    
            if(11 < fatContent || fatContent < 2) 
            {
                throw new ArgumentOutOfRangeException();
            }
            
            fat = fatContent;            
            package = packageList[packageType];
        }
        public int fat{get; set;} = 2; 

        // Olika typer av förpackningar
        public string package = "";
    }

}

