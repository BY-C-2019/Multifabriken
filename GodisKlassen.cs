using System.Collections.Generic;
using System;

namespace Candy
{

    public class candy : products
    {  
            private List<string> godisLista = new List<string>(){"Hallon", "Päron", "Lakris", "Jordgubbar"};

            public string taste = "";


            public candy(int candyIndex)
            {
                taste = godisLista[candyIndex];
                
            }
       
    }

}
