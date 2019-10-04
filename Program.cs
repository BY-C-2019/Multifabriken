using System;
using System.Collections;
using System.Collections.Generic;
using Milk;
using Pipes;
using Cars;
using Order;
using Candy;

namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            order.orderList.Add(new milk(7,2));

            foreach(var p in order.orderList){
                var p2 = p as milk;

                Console.WriteLine(p2.fat);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
