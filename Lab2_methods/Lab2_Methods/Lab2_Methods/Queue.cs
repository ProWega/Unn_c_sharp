using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Methods
{
    public class Queue
    {
        int queue_current_size;
        public Node front;
        public Node last_node;
        public Queue(int start_element)
        {
            last_node = new Node();
            front = new Node(start_element);
            last_node.linked_node = front;
        }
        public Queue()
        {
            last_node = new Node();
        }

        public void Push(int x)
        {
            if (front == null)
            {
                front = new Node(x);
                last_node.linked_node = front;
            }
            queue_current_size++;
            Node new_node = new Node(x);
            last_node.linked_node.linked_node = new_node;
            last_node.linked_node = new_node;
            Console.WriteLine("ok");
        }

        public void Front()
        {
            Console.WriteLine(front.value);
        }
        public void Pop()
        {
            if (front == null)
            {
                Console.WriteLine("Пустая очередь");
            }
            else
            {
                Console.WriteLine(front.value);
                front = front.linked_node;
                queue_current_size--;
            }
        }

        public void Size()
        {
            Console.WriteLine(queue_current_size);
        }
        public void Clear()
        {
            queue_current_size = 0;
            front = null;
            last_node = new Node();
            Console.WriteLine("ok");
        }
        public void Exit()
        {
            Console.WriteLine("Buy");
            System.Environment.Exit(0);
        }
    }
}
