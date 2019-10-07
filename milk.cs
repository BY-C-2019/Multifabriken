using System;
using System.Collections.Generic;
using Products;


namespace Milk
{
    class milk : products
    {
        public milk(int fatContent, int packageType)
        {
            if(11 < fatContent || fatContent < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            fat = fatContent;            
            package = packageList[packageType];
        }
        // Fetthalt kan vara mellan 2 och 11
        public int fat{get; set;} = 2; 
        // Olika typer av förpackningar

        public string package = "";
    }

}

