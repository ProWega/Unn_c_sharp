using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class CookDirector
    {
        int orderCountrer = 0;
        public Queue<Order> orders = new Queue<Order>();
        public List<Order> ordersCookingList = new List<Order>();
        public List<Order> ordersReady = new List<Order>();
        public List<Order> ordersDelivering = new List<Order>();
        public List<Order> ordersDeliveredArchive = new List<Order>();

        public PizzaStock Stock;
        
        void AcceptOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Order {order.Id} зарегистрирован");
        }
        public void RegisterNewOrder()
        {
            Order order = new Order(++orderCountrer, PizzaStock.basePizzaWeight);
            AcceptOrder(order);
        }
        public void RegisterNewOrder(float stockWeight)
        {
            Order order = new Order(++orderCountrer, stockWeight);
            AcceptOrder(order);

        }

    }
}
