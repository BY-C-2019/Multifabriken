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
        
    }
    // public Order(List<object> order) 
    // {
    //     this.orderList = order;
    // }
}