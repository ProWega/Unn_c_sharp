using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Methods
{
    public class Deque<T> where T : IComparable<T>
    {
        public int size = 0;
        DoublyNode<T> head;
        public DoublyNode<T> tail;

        public Deque()
        {
            head = new DoublyNode<T>();
            tail = new DoublyNode<T>();
        }
        public Deque(T element)
        {
            DoublyNode<T> node = new DoublyNode<T>(element);
            head = node;
            tail = node;
            size = 1;
        }

        public void AddLast(T element)
        {
            DoublyNode<T> node = new DoublyNode<T>(element);  
            if (size == 0)
            {
                head = node;
            }
            Console.WriteLine(node.Data);
            tail.Next = node;
            node.Previous = tail;
            tail = node;
            size++;

        }
        public void RemoveLast()
        {
            size--;
            tail = tail.Previous;
            tail.Next = null;
        }
        public void AddFirst(T element)
        {
            
            
            DoublyNode<T> node = new DoublyNode<T>(element);
            if (size == 0)
            {
                tail = node;
            }
            head.Previous = node;
            node.Next = head;
            head = node;
            size++;
        }
        public void RemoveFirst()
        {
            size--;
            head = head.Next;
            head.Previous = null;
        }
        public void Remove(T element)
        {
            DoublyNode<T> currentNode = head; 
            for (int i = 0; i < size+1; i++)
            {
                //Console.WriteLine($"Check {currentNode.Data}");
                //Console.WriteLine($"Data: {currentNode.Data}");
                //Console.WriteLine($"ComareTo() = {currentNode.Data.CompareTo(element)}");
                if (currentNode.Data.CompareTo(element) == 0)
                {
                    
                    if (currentNode.Previous != null && currentNode.Next != null)
                    {
                        //Console.WriteLine("Not first");
                        currentNode.Previous.Next = currentNode.Next;
                        currentNode.Next.Previous = currentNode.Previous;
                    }
                    else 
                    {
                        if (currentNode.Previous == null)
                        {
                            head = currentNode.Next;
                            head.Previous = null;
                        }
                        if (currentNode.Next == null)
                        {
                            tail = currentNode.Previous;
                            tail.Next = null;
                        }
                    } 
                    size--;
                    //Console.WriteLine(currentNode.Data);
                }
                currentNode = currentNode.Next;
            }
        }
        public void Print()
        {
            DoublyNode<T> currentNode = head;
            Console.Write("Deque: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{currentNode.Data} ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
        public void Find(T element)
        {
            DoublyNode<T> currentNode = head;
            for (int i = 0; i < size; i++)
            {
                //Console.WriteLine($"Check {currentNode.Data}");
                //Console.WriteLine($"Data: {currentNode.Data}");
                //Console.WriteLine($"ComareTo() = {currentNode.Data.CompareTo(element)}");
                if (currentNode.Data.CompareTo(element) == 0)
                {
                    Console.WriteLine($"Элемет {element} найден на позиции {i}");
                }
                currentNode = currentNode.Next;
            }
        }
    }
}
