using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithmsAndDataStructures1
{
    class MyQueue<T>: System.Collections.Generic.IEnumerable<T>
    {
        MyLinkedList<T> list = new MyLinkedList<T>();
        public void Enqueue(T value) {
            list.AddNodeInLast(new Node<T>(value));
        }
        public T Dequeue()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("The queue is empty");
            T value = list.head.Value;
            list.RemoveFront();
            return value;
        }
        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("The queue is empty");
            T value = list.head.Value;
            return value;
        }
        public void Clear() {
            list.Clear();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
