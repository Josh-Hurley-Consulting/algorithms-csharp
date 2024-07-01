using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary
{
    /// <summary>
    /// Doubly Linked List implementation, which is a limited reverse engineered version of the .NET LinkedList<T> class. Modified from:
    /// https://medium.com/geekculture/building-a-linked-list-system-from-scratch-in-c-part-1-51aa6c68ea19
    /// </summary>
    /// <typeparam name="T">Type of element stored in Nodes</typeparam>
    /// <remarks>
    /// Big O: 
    /// * Time Complexity 
    ///     - Inserting Head/First: O(1) Constant, no traversal needed so size of list isn't a factor
    ///     - Inserting Last: O(n) Linear, as number of elements grow, the runtime grows linearly 
    /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
    /// </remarks>
    public class DoublyLinkedList<T>
    {
        private Node _head;

        public Node First => _head;

        public Node Last
        {
            get
            {
                Node node = GetLastNode();
                return node;
            }
        }

        private int _count;

        public int Count
        {
            get 
            { 
                return _count;
            }

            private set
            { 
                _count = value;
            }
        }

        private Node GetLastNode()
        {
            Node node = _head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        public void AddFirst(T value)
        {
            Node newNode = new Node(value);
            Count++;

            if (_head != null)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
            }
            
            _head = newNode;
        }

        public void AddLast(T value)
        {
            Node newNode = new Node(value);
            Count++;
            
            if (_head == null)
            {
                _head = newNode;
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.Next = newNode;
            newNode.Previous = lastNode;
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Previous = null;
                Next = null;
            }
        }
    }
}
