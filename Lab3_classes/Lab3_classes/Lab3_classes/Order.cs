using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    public class Order
    {
        public int Id { get; set; }
        public float stockWeight;
        public IOrderInfo info;
        public Order(int Id, float stockWeight)
        {
            this.Id = Id;
            this.stockWeight = stockWeight; 
        }
    }
}
