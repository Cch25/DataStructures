namespace Stacks
{
    public interface IFakeStack<T>
    {
        void Push(T data);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Size();
    }
}
