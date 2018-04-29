namespace LinkedLists
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T data)
        {
            Data = data;
            NextNode = null;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
