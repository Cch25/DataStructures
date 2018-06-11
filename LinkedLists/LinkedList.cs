using System;

namespace LinkedLists
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private int _size;
        private Node<T> _rootNode;

        // O(1) constant time complexity, update the references
        public void InsertBegin(T data)
        {
            ++_size;
            if (_rootNode == null)
                _rootNode = new Node<T>(data);
            else
            {
                var newNode = new Node<T>(data);
                newNode.NextNode = _rootNode;
                _rootNode = newNode;
            }
        }
        // O(N) inserting at the end
        public void InsertAfter(T data)
        {
            ++_size;
            if (_rootNode == null)
                _rootNode = new Node<T>(data);
            else
            {
                var node = _rootNode;
                while (true)
                {
                    if (node.NextNode != null)
                    {
                        node = node.NextNode;
                        continue;
                    }
                    var newNode = new Node<T>(data);
                    node.NextNode = newNode;
                    break;
                }
            }
        }
        public void TraverseList()
        {
            if (_rootNode == null)
                return;
            var node = _rootNode;
            while (node != null)
            {

                Console.Write(node.Data + " ");
                node = node.NextNode;
            }
        }

        public void Remove(T data)
        {
            --_size;
            if (_rootNode == null) return;
            if (_rootNode.Data.Equals(data))
            {
                _rootNode = _rootNode.NextNode;
                return;
            }
            var previousNode = _rootNode;
            var actualNode = _rootNode.NextNode;
            while (actualNode != null)
            {
                if (actualNode.Data.Equals(data))
                {
                    previousNode.NextNode = actualNode.NextNode;
                    return;
                }

                previousNode = actualNode;
                actualNode = actualNode.NextNode;
            }
        }

        public int Size()
        {
            return _size;
        }
    }
}
