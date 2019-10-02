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

        public int AddProduct { 
            set {
                switch (value) {
                    // 0: Car
                    // 1: Candy
                    // 2: Pipe
                    // 3: OatMilk
                    case 0:
                        _products.Add(new Car());
                        break;
                    case 1:
                        _products.Add(new Candy());
                        break;
                    case 2:
                        _products.Add(new Pipe());
                        break;
                    case 3:
                        _products.Add(new OatMilk());
                        break;
                }
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