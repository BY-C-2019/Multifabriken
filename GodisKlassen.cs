using System.Collections.Generic;
using System;
using Products;

namespace Candy
{

    class candy : products
    {  

            public string taste = "";
            public int amount = 0;
            public candy(int candyIndex, int candyAmount)
            {
                taste = godisLista[candyIndex];
                amount = candyAmount;
            }
    }
}
