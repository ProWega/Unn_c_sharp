using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class PizzaStock : IStorage<Order>
    {
        public float totalCapacity;
        public float currentTotalLoad;
        public Queue<Order> items = new Queue<Order>();
        public static float basePizzaWeight = 1;
        public PizzaStock(float totalCapacity_, float currentTotalLoad=0)
        {
            SetTotalCapacity(totalCapacity_);
            this.currentTotalLoad = currentTotalLoad;
        }
        void SetTotalCapacity(float capacity)
        {
            totalCapacity = capacity;
        }

        public void FreeUpStock()
        {
            if (items.Count > 0)
            {
                Order order = items.Dequeue();
                totalCapacity -= order.stockWeight;
            }
        }

        public bool ReserveStock(float capacity)
        {

            float newCapacity = capacity + currentTotalLoad;
            if (newCapacity > totalCapacity)
            {
                return false;
            }
            else
            {
                currentTotalLoad = newCapacity;
                return true;
            }

        }
    }
}
