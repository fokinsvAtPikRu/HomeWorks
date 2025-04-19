using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEducation
{
    internal class Node<T>
    {
        internal T Value { get; set; }
        internal Node<T> NextItem { get; set; }
        internal Node(T value, Node<T> nextItem)
        {
            Value = value;
            NextItem = nextItem;
        }
    }
    internal class MyQueue<T> : IEnumerable<T>
    {
        #region

        internal Node<T> head;
        private Node<T> tail;
        public bool IsEmpty => head == null;
        public void Enqueue(T element)
        {
            if (head == null)
            {
                head = new Node<T>(element, null);
            }
            else
            {
                var current = head;
                while (current.NextItem != null)
                     current = current.NextItem; 
                current.NextItem = new Node<T>(element,null);                
            }
        }
        public T Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");
            T result = head.Value;
            head = head.NextItem;
            tail = tail != null ? tail.NextItem : null;
            return result;
            #endregion
        }
        // IEnumerator с yield return
        //public IEnumerator<T> GetEnumerator()
        //{
        //    var current = head;
        //    while (current != null)
        //    {
        //        yield return current.Value;
        //        current = current.NextItem;
        //    }
        //}

        // реализация Enumerator<T>
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public class QueueEnumerator<T> : IEnumerator<T>
        {
            MyQueue<T> queue;
            Node<T> item;
            public QueueEnumerator(MyQueue<T> queue)
            {
                this.queue = queue;
                item = null;
            }

            public T Current => item.Value;
            public bool MoveNext()
            {
                if (item == null)
                    item = queue.head;
                else
                    item = item.NextItem;
                return item != null;
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }
            public void Reset() { }
        }
    }
}
    

