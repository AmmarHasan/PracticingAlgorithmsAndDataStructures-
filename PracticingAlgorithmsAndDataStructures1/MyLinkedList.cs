using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    class MyLinkedList
    {
        Node head=new Node();
        Node tail = new Node();
        public static ulong Count=0;


        public void AddNodeFromFront(Node node){
            Node temp = head;
            head = node;
            head.Next = temp;
            Count++;
            if (Count == 1) {
                tail = head;
            }
        }
        public void AddNodeInLast(Node node)
        {
            tail.Next = node;
            tail = node;   
            Count++;
            if (Count == 1)
            {
                head= tail;
            }
        }
        public void PrintList() {
            Node temp = head;
            while (temp != null) {
                Console.WriteLine(""+temp.Value);
                temp = temp.Next;
            }
        }

        
        public class Node {
            public Node()
            {
                this.Next = null;
            }
            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
            }
            public Node(int value,Node next) {
                this.Value = value;
                this.Next = next;
            }
           
            public int Value { get; set; }
            public Node Next { get; set; }
        }
    }
}
