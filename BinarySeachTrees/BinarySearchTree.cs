using System;

namespace BinarySeachTrees
{
    public class BinarySearchTree<T> : IBinarySearchTree<T>
    {
        private Node<T> _root { get; set; }
        public void Traversal(TraverseType tt)
        {
            if (tt == TraverseType.InOrder)
            {
                if (_root != null)
                    InOrderTraversal(_root);
            }
            else if (tt == TraverseType.Reverse)
            {
                if (_root != null)
                    ReverseTraversal(_root);
            }
        }

        private void InOrderTraversal(Node<T> node)
        {
            if (node.LeftNode != null)
                InOrderTraversal(node.LeftNode);
            Console.Write($"{node.Data} - ");
            if (node.RightNode != null)
                InOrderTraversal(node.RightNode);
        }

        private void ReverseTraversal(Node<T> node)
        {
            if (node.RightNode != null)
                InOrderTraversal(node.RightNode);
            Console.Write($"{node.Data} - ");
            if (node.LeftNode != null)
                InOrderTraversal(node.LeftNode);
        }

        public void Insert(T data)
        {
            if (_root == null)
                _root = new Node<T>(data);
            else
                InsertNode(_root, data);
        }

        private void InsertNode(Node<T> node, T data)
        {
            if (node.CompareTo(data) < 0)
            {
                if (node.LeftNode != null)
                {
                    InsertNode(node.LeftNode, data);
                }
                else
                {
                    node.LeftNode = new Node<T>(data);
                }

            }
            else if (node.CompareTo(data) > 0)
            {
                if (node.RightNode != null)
                {
                    InsertNode(node.RightNode, data);
                }
                else
                {
                    node.RightNode = new Node<T>(data);
                }
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
                node.LeftNode = Delete(node.LeftNode, data);
            else if (node.CompareTo(data) > 0)
                node.RightNode = Delete(node.RightNode, data);
            else
            {
                if (node.LeftNode == null && node.RightNode == null)
                {
                    Console.WriteLine("Landed on a node without leafs");
                    return null;
                }
                else if (node.LeftNode == null)
                {
                    Console.WriteLine("Node with a right leaf");
                    node = null;
                    return node.RightNode;
                }
                else if (node.RightNode == null)
                {
                    Console.WriteLine("Node with a left leaf");
                    node = null;
                    return node.LeftNode;
                }
                else
                {
                    Console.WriteLine("Landed on a node with two leafs");
                    var temp = GetPredecessor(node.LeftNode);
                    node.Data = temp.Data;
                    node.LeftNode = Delete(node.LeftNode, temp.Data);
                }
            }
            return node;
        }

        private Node<T> GetPredecessor(Node<T> leftNode)
        {
            if (leftNode.RightNode != null)
                return GetPredecessor(leftNode.RightNode);
            Console.WriteLine($"Predecessor: {leftNode.Data}");
            return leftNode;
        }

        public T GetMaxValue()
        {
            var data = default(T);
            if (_root != null)
                data = GetMax(_root);
            return data;
        }

        private T GetMax(Node<T> node)
        {
            if (node.RightNode != null)
                return GetMax(node.RightNode);
            return node.Data;
        }

        public T GetMinValue()
        {
            var data = default(T);
            if (_root != null)
            {
                data = GetMin(_root);
            }
            return data;
        }

        private T GetMin(Node<T> node)
        {
            if (node.LeftNode != null)
            {
                return GetMin(node.LeftNode);
            }

            return node.Data;
        }
    }
}
