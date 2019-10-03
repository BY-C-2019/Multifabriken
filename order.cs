using System;
using Products;
using Milk;


namespace Order 
{
    class order
    {
        public List<products> order = new List<products>();

        static void add()
        {
            order.add(new Milk(7,2));
        }

        static void display()
        {
       
            Console.WriteLine(order[0]);
        }
    }
}