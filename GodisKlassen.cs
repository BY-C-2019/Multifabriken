using System.Collections.Generic;
using System;
using Products;

namespace Candy
{

    class candy : products
    {  
            private List<string> godisLista = new List<string>(){"Hallon", "Päron", "Lakris", "Jordgubbar"};

            public string taste = "";


            public candy(int candyIndex)
            {
                taste = godisLista[candyIndex];
                
            }
    }
}
