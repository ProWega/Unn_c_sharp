using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Methods
{
    public enum type_node { start, usual }
    unsafe public struct StartNode
    {

    }
    
    



    public class Stack
    {
        int stack_current_size;
        public Node top;
        public bool logText = true;
        public Stack(int start_element)
        {
            Node start_node = new Node();
            top = new Node(start_element, start_node);
        }
        public Stack()
        {
            top = new Node();
        }
        public void Push(int x)
        {
            stack_current_size++;
            Node old_top = this.top;
            Node newTop = new Node(x, old_top);
            top = newTop;
            Node parent = old_top.linked_node;
            if (logText) Console.WriteLine($"ok");
            /*
            Node p = *top.parent;
            Console.WriteLine("p.value");
            Console.WriteLine(p.value);
            Console.WriteLine("parent value");
            Console.WriteLine(p.value);
            */
        }
        public int Pop()
        {
           if (this.top.type != type_node.start)
            {
                if (logText) Console.WriteLine($"{this.top.value}");
                Node parent = this.top.linked_node;
                this.top = parent;
                this.stack_current_size--;
                //Console.WriteLine($"Новое значение {this.top.value}");
                return 1;
            }
            else
            {
                if (logText) Console.Error.WriteLine("Невозможно удалить элемент из пустого стека");
                return 0;
            }          
        }
        public void Back()
        {
            if (top.type != type_node.start)
            {
                if (logText) Console.WriteLine(top.value);
            }
            else
            {
                if (logText) Console.WriteLine("Пустой стек");
            }
        }
        public void Size()
        {
            if (logText) Console.WriteLine(stack_current_size);
        }
        public int GetSize()
        {
            return stack_current_size;
        }
        public void Clear()
        {
            //while (top.type != type_node.start)
            //{
            //    Pop();
            //}
            this.top = new Node();
            this.stack_current_size = 0;
            if (logText) Console.WriteLine("ok");
        }
        public void Exit()
        {
            Console.WriteLine("Buy");
            System.Environment.Exit(0);
        }
    }
}

