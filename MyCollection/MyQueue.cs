using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEducation
{
    internal class MyQueue<T> : IEnumerable<T>
    {
        private class Node
        {
            internal T Value { get; set; }
            internal Node NextItem { get; set; }
            internal Node(T value, Node nextItem)
            {
                Value = value;
                NextItem = nextItem;
            }
        }
        private Node head;
        private Node tail;
        public bool IsEmpty => head == null;
        public void Enqueue(T element)
        {
            if (head == null)
            {
                head = new Node(element, null);
            }
            else
            {
                tail = head;
                head = new Node((T)element, tail);
            }
        }
        public T Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");
            T result = head.Value;
            head = head.NextItem;
            if (tail != null)
                tail=tail.NextItem;
            if (head == null)
                tail = null;
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current!=null)
            {
                yield return current.Value;
                current = current.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
