using System.Collections.Generic;
using System;

namespace Multifabriken
{
    public class Order
    {
        private List<Product> _products;

        public bool IsOrderCompleted { get; set; } = false;
        public int GetTotalNumberOfProducts { get { return _products.Count; }}
        public decimal GetTotalPrice { 
            get {
                decimal total = 0;
                foreach (Product p in _products) {
                    total += p.Price;
                }
                return total;
            }
        } 

        public Order() {
            _products = new List<Product>();
        }

        public void PrintCart() {
            int i = 1;
            foreach (Product p in _products) {
                Console.WriteLine("{0}: {1} för {2}kr", i, p.Name, p.Price);
            }
            Console.WriteLine("Totalt {0} varor för sammanlagt {1}kr", GetTotalNumberOfProducts ,GetTotalPrice);
        }
    }
}