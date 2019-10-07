using System;
using System.Collections.Generic;

namespace Multifabriken
{
    public class Order
    {
        private List<object> orderList;
        public List<object> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        public List<object> GetOrderList()
        {
            return orderList;
        }
        public void AddToOrderList(object item) 
        {
            List<object> orderList = new List<object>();
            orderList.Add(item);
        }
        public void ShowOrderList() 
        {
            foreach (object item in orderList) {
                Console.WriteLine(item);
            }
        }

        public Order()
        {
            
        }

    }
}