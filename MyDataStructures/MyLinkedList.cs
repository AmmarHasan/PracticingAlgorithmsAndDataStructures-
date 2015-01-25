using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    public class MyLinkedList<T>:System.Collections.Generic.ICollection<T>
    {
        public Node<T> head{get;private set;}
        public Node<T> tail{get;private set;}
        public int Count{ get; private set;}
        public void AddNodeFromFront(Node<T> node){
            Node<T> temp = head;
            head = node;
            head.Next = temp;
            Count++;
            if (Count == 1) {
                tail = head;
            }
        }
        public void AddNodeInLast(Node<T> node)
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
            Node<T> temp = head;
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
                    Node<T> temp = head;
                    while (temp.Next != tail) {
                        temp = temp.Next;
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
        public int RemoveAllOccurancesByValue(T value)
        {
            int i = 0;
            if (Count != 0)
            {
                if (Count == 1 && head.Value.Equals(value))
                    head = tail = null;
                else
                {
                    Node<T> temp = head;   
                    while (temp.Next != null)
                    {
                        if (temp.Next.Value.Equals(value)) {
                            temp.Next = temp.Next.Next;
                            Count--;
                        }
                        temp = temp.Next;
                        i++;
                    }
                }
                Count--;
            }
            return i;
        }
        public bool RemoveFirstOccurancesByValue(T value)
        {
            if (Count != 0)
            {
                if (Count == 1 && head.Value.Equals(value))
                    head = tail = null;
                else
                {
                    Node<T> temp = head;
                    while (temp.Next != null)
                    {
                        if (temp.Next.Value.Equals(value))
                        {
                            temp.Next = temp.Next.Next;
                            Count--;
                            return true;
                        }
                        temp = temp.Next;
                    }
                }
            }
            return false;
        }


        #region ICollection
        public void Add(T item)
        {
            AddNodeFromFront(new Node<T>(item));
        }
        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> temp = head;
            while (temp != null) {
                if (temp.Value.Equals(item))
                    return true;
                temp=temp.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> temp = head;
            while (temp != null) {
                array[arrayIndex++] = temp.Value;
                temp = temp.Next;
            }
        }

        int ICollection<T>.Count
        {
            get { return Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return RemoveFirstOccurancesByValue(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = head;
            while (temp != null) {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        } 
        #endregion

      
    }
}
