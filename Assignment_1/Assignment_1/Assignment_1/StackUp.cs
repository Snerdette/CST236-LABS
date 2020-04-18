using System;

namespace MyCollections
{
    public class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack empty!") { }
    }

    public class StackUp<T>
    {
        private class Node
        {
            public T item;
            public Node next;
        }

        private Node head;
        private int count;

        public StackUp()
        {
            head = null;
            count = 0;
        }

        public int Count { get { return count; } }

        public void Push(T item)
        {
            head = new Node() { item = item, next = head };
            count++;
        }

        public T Pop()
        {
            if (head == null)
                throw new StackEmptyException();
            T item = head.item;
            head = head.next;
            count--;
            return item;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new StackEmptyException();
            }
            return head.item;
        }
    }
}

