namespace LinkedLists
{
    public interface IFakeList<in T>
    {
        void InsertBegin(T data);
        void InsertAfter(T data);
        void TraverseList();
        void Remove(T data);
        int Size();
    }
}
