using System;

namespace BinarySeachTrees
{
    public class Node<T> : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node()
        {
        }

        public int CompareTo(T other)
        {
            if (Data is IComparable d && d.CompareTo(other) < 0)
                return 1;
            if (Data is IComparable dd && dd.CompareTo(other) > 0)
                return -1;
            return 0;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
