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

        private static void InOrderTraversal(Node<T> node)
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

        private static void InsertNode(T data, Node<T> node)
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

        private static Node<T> Delete(Node<T> node, T data)
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

        private static Node<T> GetPredecessor(Node<T> nodeLeftNode)
        {
            return nodeLeftNode.RightNode != null ? GetPredecessor(nodeLeftNode.RightNode) : nodeLeftNode;
        }

        public T GetMaxValue()
        {
            return _root == null ? default(T) : GetMax(_root);
        }

        private static T GetMax(Node<T> node)
        {
            return node.RightNode != null ? GetMax(node.RightNode) : node.Data;
        }

        public T GetMinValue()
        {
            return _root == null ? default(T) : GetMinValue(_root);
        }

        private static T GetMinValue(Node<T> node)
        {
            return node.LeftNode != null ? GetMinValue(node.LeftNode) : node.Data;
        }
    }
}
