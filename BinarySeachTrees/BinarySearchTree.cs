using System;

namespace BinarySeachTrees
{
    public class BinarySearchTree<T> : IBinarySearchTree<T>
    {
        private Node<T> _root;

        public void Traversal()
        {
            if (_root != null)
                InOrderTraversal(_root);
        }

        private void InOrderTraversal(Node<T> node)
        {
            if (node.LeftNode != null)
                InOrderTraversal(node.LeftNode);
            Console.Write($"{node.Data} -");
            if (node.RightNode != null)
                InOrderTraversal(node.RightNode);
        }

        public void Insert(T data)
        {
            if (_root == null)
                _root = new Node<T>(data);
            else
            {
                InsertNode(data, _root);
            }
        }

        private void InsertNode(T data, Node<T> node)
        {
            if (node.CompareTo(data) < 0)
            {
                if (node.LeftNode != null)
                    InsertNode(data, node.LeftNode);
                else
                    node.LeftNode = new Node<T>(data);
            }
            else if (node.CompareTo(data) > 0)
            {
                if (node.RightNode != null)
                    InsertNode(data, node.RightNode);
                else
                    node.RightNode = new Node<T>(data);
            }


        }

        public void Delete(T data)
        {
            if (_root != null)
                Delete(_root, data);
        }

        private Node<T> Delete(Node<T> node, T data)
        {
            if (node == null) return null;
            if (node.CompareTo(data) < 0)
            {
                node.LeftNode = Delete(node.LeftNode, data);
            }
            else if (node.CompareTo(data) > 0)
            {
                node.RightNode = Delete(node.RightNode, data);
            }
            else
            {
                //we found the node
                if (node.LeftNode == null && node.RightNode == null)
                {
                    Console.WriteLine("Node with no leafs");
                    return null;
                }

                if (node.LeftNode == null)
                {
                    Console.WriteLine("Removing the right child");
                    var tempNode = node.RightNode;
                    return tempNode;
                }
                if (node.RightNode == null)
                {
                    Console.WriteLine("Removing the left child");
                    var tempNode = node.LeftNode;
                    return tempNode;
                }

                Console.WriteLine("Removing node with two children");
                var temp = GetPredecessor(node.LeftNode);
                node.Data = temp.Data;
                node.LeftNode = Delete(node.LeftNode, temp.Data);

            }
            return node;
        }

        private Node<T> GetPredecessor(Node<T> nodeLeftNode)
        {
            if (nodeLeftNode.RightNode != null)
                return GetPredecessor(nodeLeftNode.RightNode);
            return nodeLeftNode;
        }

        public T GetMaxValue()
        {
            if (_root == null)
            {
                return default(T);
            }
            return GetMax(_root);
        }

        private T GetMax(Node<T> node)
        {
            if (node.RightNode != null)
                return GetMax(node.RightNode);
            return node.Data;
        }

        public T GetMinValue()
        {
            if (_root == null)
                return default(T);
            return GetMinValue(_root);
        }

        private T GetMinValue(Node<T> node)
        {
            if (node.LeftNode != null)
                return GetMinValue(node.LeftNode);
            return node.Data;
        }
    }
}
