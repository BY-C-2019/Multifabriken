using System.Collections.Generic;
using System;
using System.Linq;

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
            Console.Clear();
            if (_products.Count <= 0) {
                Console.WriteLine("Din kundvagn är tom!\nKlicka på valfri knapp för att gå vidare.");
                Console.ReadKey();
            }
            else {
                int i = 1;
                Console.WriteLine("Din kundkorg!\n");
                foreach (Product p in _products) {
                    Console.WriteLine(p.ToString());
                    i++;
                }
                System.Console.WriteLine("------------------------------------------------------");
                if(GetTotalNumberOfProducts > 1)
                {
                    Console.Write("Totalt {0} varor.",GetTotalNumberOfProducts);          
                }
                else
                {
                    Console.Write("Totalt {0} vara.",GetTotalNumberOfProducts);
                }
                string total = String.Format("Totalsumma: {0} kr", GetTotalPrice);
                System.Console.WriteLine(String.Format("{0,40}", total));
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\nFör att ta bort en rad tryck på [R]. För att gå vidare tryck på annan knapp");
                Console.ResetColor();
                var input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.R)
                {
                    if(Menu.YesOrNo("Vill du verkligen ta bort en vara ur varukorgen?"))
                    {
                        string[] query =    (from s in _products
                                            select s.ToString()).ToArray();
                                            
                        _products.RemoveAt(Menu.DisplayMenu(query, "Välj vara att ta bort:"));
                        System.Console.WriteLine("Varan borttagen");
                    }
                }
            }
        }

        public void ConfirmOrder() {
            PrintCart();
            IsOrderCompleted = Menu.YesOrNo("Är detta okej?");
        }
    }
}