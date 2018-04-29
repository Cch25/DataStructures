using System.Collections;
using System.Collections.Generic;

namespace Stacks
{
    public class StackFake<T> : IFakeStack<T>, IEnumerable<T>
    {
        private int _count;
        private Node<T> _root;
        public void Push(T data)
        {
            _count++;
            if (_root == null)
                _root = new Node<T>(data);
            else
            {
                var oldRoot = _root;
                _root = new Node<T>(data);
                _root.NextNode = oldRoot;
            }
        }

        public T Pop()
        {
            if (_root == null) return default(T);
            --_count;
            var itemToPop = _root.Data;
            _root = _root.NextNode;
            return itemToPop;
        }

        public T Peek()
        {
            return _root.Data;
        }

        public bool IsEmpty()
        {
            return _root == null;
        }

        public int Size()
        {
            return _count;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var node = _root;
            while (node != null)
            {
                yield return node.Data;
                node = node.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
