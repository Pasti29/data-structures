using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDotNet.DataStructures
{
    public class LinkedList
    {
        internal class Node
        {
            public int value;
            public Node? next;

            public Node(int val)
            {
                value = val;
                next = null;
            }
        }

        private Node? _head;
        private Node? _tail;

        public LinkedList()
        {
            _head = null;
            _tail = null;
        }

        public void PushFront(int val)
        {
            Node newNode = new(val);
            newNode.next = _head;
            if (_head == null)
                _tail = newNode;
            _head = newNode;
        }

        public void PushBack(int val)
        {
            Node newNode = new(val);
            if (_tail != null)
                _tail.next = newNode;
            else
                _head = newNode;
            _tail = newNode;
        }

        public void PopFront()
        {
            if (_head == null)
                return;
            _head = _head.next;
        }

        public void PopBack()
        {
            if (_head == null)
                return;
            Node node = _head;
            Node newTail = node;
            while (node.next != null)
            {
                newTail = node;
                node = node.next;
            }
            _tail = newTail;
            _tail.next = null;
        }

        public int ShowFront()
        {
            if (_head == null)
                throw new InvalidOperationException("Can't show first node because linked list is empty!");
            return _head.value;
        }

        public int ShowBack()
        {
            if (_tail == null)
                throw new InvalidOperationException("Can't show last node because linked list is empty!");
            return _tail.value;
        }

        public void Print()
        {
            Node? node = _head;
            while (node != null)
            {
                Console.Write($"{node.value} -> ");
                node = node.next;
            }
            Console.WriteLine("null");
        }
    }
}
