namespace BinarySeachTrees
{
    public interface IBinarySearchTree<T>
    {
        void Traversal();
        void Insert(T data);
        void Delete(T data);
        T GetMaxValue();
        T GetMinValue();
    }
}
