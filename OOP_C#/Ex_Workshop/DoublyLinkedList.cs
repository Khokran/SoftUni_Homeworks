using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class DoublyLinkedList
    {
        private class LinkNode
        {
            public LinkNode(int value)
            {
                this.Value = value;
            }
            public int Value { get; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviusNode { get; set; }
        }
        private LinkNode head;
        private LinkNode tail;
        public int Count { get; private set; }
        public void AddFirst(int value)
        {
            LinkNode newHead = new LinkNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviusNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int value)
        {
            LinkNode newTail = new LinkNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviusNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }
        public int RemoveFirst()
        {
            CheckIfEmptyThrowException();
            int firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviusNode = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            CheckIfEmptyThrowException();
            int lastElement = this.tail.Value;
            this.tail = this.tail.PreviusNode;
            if (this.tail ==null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }
            this.Count--;
            return 0;
        }
        private Exception InvalidOperationException(string message)
        {
            throw new NotImplementedException();
        }

        public void Print(Action<int> action)
        {
            LinkNode currNode = this.head;

            while (currNode != null)
            {
                action(currNode.Value);

                currNode = currNode.NextNode;
            }
        }
        private void CheckIfEmptyThrowException()
        {
            if (this.Count == 0)
            {
                throw InvalidOperationException(message: "DoublyLinkedList is empty!");
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            var currNode = this.head;
            int counter = 0;
            while (currNode!=null)
            {
                array[counter++] = currNode.Value;
                currNode = currNode.NextNode;
            }
            return array;
        }
    }
}