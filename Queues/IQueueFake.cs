namespace Queues
{
    public interface IQueueFake<T>
    {
        void Enqueue(T data);
        T Dequeue();
        int Size();
        bool IsEmpty();

    }
}
