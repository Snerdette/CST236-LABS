using System;
using System.Globalization;

namespace MyCollections
{
    public class QueueEmptyException : Exception
    {
        public QueueEmptyException() : base("Queue empty!") { }
    }

    public class QueueUp<T>
    {
        private class Node
        {
            public T item;
            public Node next;
        }

        private Node head;
        private Node tail;
        private int count;
        private Node next;

        // instantiates an empty queue
        public QueueUp()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // returns the number of items in the queue
        public int Count { get { return count; } }

        // inserts an item at the tail
        public void Insert(T item)
        {
            Node newNode = new Node() { item = item, next = null };
            // If:Empty Queue, inserting first Node.
            if (count ==0)
            {
                head = newNode;
            }
            else // Else: Not Empty Queue, add to end.
            {
                tail.next = newNode;    
            }
            tail = newNode;
            count++;
        }

        // removes an item from the head
        // throws QueueEmptyException
        public T Remove()
        {
            if (count == 0)
                throw new QueueEmptyException();

            T item = head.item;
            head = head.next;
            count--;

            // If we removed the last item.
            if (count == 0)
                tail = null;

            return item;
        }

        // returns the item at the head, without removing it
        // throws QueueEmptyException
        public T Peek()
        {
            if (count == 0)
                throw new QueueEmptyException();

            return head.item;
        }
    }
}

