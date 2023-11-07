using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Methods
{
    public class Node
    {
        public Node? linked_node;
        public int value { get; }
        public type_node type { get; }
        public Node()
        {
            type = type_node.start;
            linked_node = null;
            value = 0;
        }
        public Node(int x, Node parent)
        {
            type = type_node.usual;
            this.linked_node = parent;
            value = x;
        }

        public Node (int x)
        {
            value = x;
        }

    }
}
