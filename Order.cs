using System.Collections.Generic;
using System;

namespace Multifabriken
{
    public class Order
    {
        public List<Product> Products { get; set; }

        public bool Confimed { get; set; } = false;

        public decimal TotalPrice() 
        {
            decimal total = 0;

            foreach (var product in Products)
            {
                total += product.Price;
            }

            return total;
        }

        public int NumOfProducts()
        {
            return Products.Count;
        }
    }
}