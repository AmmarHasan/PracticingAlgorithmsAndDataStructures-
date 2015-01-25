using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    public class Node<T>
    {
        public Node()
        {
            this.Next = null;
        }
        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.Value = value;
            this.Next = next;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
