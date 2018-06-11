namespace Queues
{
    public interface IQueue<T>
    {
        void Enqueue(T data);
        T Dequeue();
        int Size();
        bool IsEmpty();

    }
}
