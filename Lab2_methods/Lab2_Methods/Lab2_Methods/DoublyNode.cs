using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Methods
{
    public class DoublyNode<T> where T : IComparable<T>
    {
        public DoublyNode(T data)
        {
            this.Data = data;
        }
        public DoublyNode()
        {
            
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
}
