using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    class MyLinkedList
    {
        Node head;
        Node tail ;
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
        public void RemoveLast() {
            if (Count != 0) {
                if (Count == 1)
                    head = tail = null;
                else {
                    Node temp = head;
                    while (temp.Next != tail) {
                        temp.Next = temp;
                    }
                    temp.Next = null;
                    tail = temp;
                }
                Count--;
            }
        }
        public void RemoveFront()
        {
            if (Count != 0)
            {
                if (Count == 1)
                    head = tail = null;
                else
                {
                    head = head.Next;
                }
                Count--;
            }
        }
        public int RemoveByValue(int value)
        {
            int i = 1;
            if (Count != 0)
            {
                if (Count == 1 && head.Value == value)
                    head = tail = null;
                else
                {
                    Node temp = head;   
                    while (temp.Next != null)
                    {
                        if (temp.Next.Value == value) {
                            temp.Next = temp.Next.Next;
                            break;
                        }
                        temp = temp.Next;
                        i++;
                    }
                }
                Count--;
            }
            return i;
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
