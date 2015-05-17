using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> b = new BinaryTree<int>();
            b.Add(2);
            b.Add(1);
            b.Add(3);
            b.Add(5);
            b.Add(4);
            DoublyNode<int> node3=b.Find(3);
            DoublyNode<int> node5 = b.Find(5);
            Console.Read();
        }
    }
}
