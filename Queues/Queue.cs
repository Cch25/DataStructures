namespace Queues
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> _firstNode;
        private Node<T> _lastNode;
        private int _size;
        public void Enqueue(T data)
        {
            ++_size;
            var oldLastNode = _lastNode;
            _lastNode = new Node<T>(data);
            if (IsEmpty())
                _firstNode = _lastNode;
            else
                oldLastNode.NextNode = _lastNode;
        }

        public T Dequeue()
        {
            if (_firstNode == null) return default(T);
            var itemToDequeue = _firstNode.Data;
            _firstNode = _firstNode.NextNode;
            if (IsEmpty())
            {
                _lastNode = null;
            }
            return itemToDequeue;
        }

        public int Size()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _firstNode == null;
        }
    }
}
