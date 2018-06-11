namespace Stacks
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Size();
    }
}
